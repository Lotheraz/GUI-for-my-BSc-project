using System;
using System.Diagnostics;
using System.IO.Ports;
// Add this to use the SerialPort class
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

// All comments are referring to the code below the comment

namespace Testing_the_GUI1
{
    public partial class Form1 : Form
    {
        // Declare the SerialPort object
        public SerialPort serialPort;
        private TemperatureReader temperatureReader;

        

        // Defines the event handler method
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the available data from the serial port
            string temperature = serialPort.ReadLine();

            // Update the temperature label on the form
            UpdateTemperatureLabel1(temperature);
        }


        public Form1()
        {
            InitializeComponent();
            // Adjust "COM3" as per your Arduino connection
            serialPort = new SerialPort("COM3", 9600);
            // Initialize the TemperatureReader with this form instance
            temperatureReader = new TemperatureReader(this);
            // Initialize the serial port in TemperatureReader
            temperatureReader.InitializeSerialPort("COM3");
            //This makes sure we get an updated temptrature in real time
            serialPort.DataReceived += SerialPort_DataReceived;
        }



        // Public method to safely update the temperature label on the form
        public void UpdateTemperatureLabel1(string temperature)
        {
            // Check if the update of label's text needs to be done on the UI thread
            if (labelTemperature1.InvokeRequired)
            {
                // If so, use Invoke to ensure the update happens on the UI thread
                labelTemperature1.Invoke(new Action(() => labelTemperature1.Text = temperature + " °C"));
            }
            else
            {
                // If not, update the label's text directly
                labelTemperature1.Text = temperature + " °C";
            }
        }

        public void UpdateTemperatureLabel2(string temperature)
        {
            // Check if the update of label's text needs to be done on the UI thread
            if (labelTemperature2.InvokeRequired)
            {
                // If so, use Invoke to ensure the update happens on the UI thread
                labelTemperature2.Invoke(new Action(() => labelTemperature2.Text = temperature + " °C"));
            }
            else
            {
                // If not, update the label's text directly
                labelTemperature2.Text = temperature + " °C";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn on the LED
                serialPort.WriteLine("1");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Similar to button1_Click, but this time to turn off the LED
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the LED
                serialPort.WriteLine("0");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This is the file path that will be opened in Notepad
            string filePath = @"C:\Users\sult_\OneDrive\Desktop\Fordetect Calibrator Files\Configurations";
            // Call a method to open the file at the given path
            OpenFile(filePath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This is the button assigned to run the actual setting/program that is selected from the dropdown menu

            if (dropDownMenu.SelectedItem == null)
            {   // Different messages that will show in a messagebox depending on the dropdown menu item
                MessageBox.Show("You did not select a program, please select a program");
            }
            else
            {
                string selectedItem = dropDownMenu.SelectedItem.ToString();
                if (selectedItem == "Program1")
                {
                    MessageBox.Show("Running your selected program: Program1");
                }
                else if (selectedItem == "Program2")
                {
                    MessageBox.Show("Running your selected program: Program2");
                }
                else if (selectedItem == "Program3")
                {
                    MessageBox.Show("Running your selected program: Program3");
                }
                else if (selectedItem == "Program4")
                {
                    MessageBox.Show("Running your selected program: Program4");
                }
            }
        }


        private static void OpenFile(string filePath)
        {
            try
            {
                // Set up the process start information to open the file in Notepad
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    // Specifying that notepad is the program that is used for opening the file that is specified 
                    FileName = "notepad.exe",
                    // Argument here is the filepath and chaning the filepath will change the file you open
                    Arguments = filePath,
                };
                // Start the process, which will open Notepad with the file
                Process.Start(startInfo);
            }
            catch (FileNotFoundException ex)
            {
                // If the file is not found, inform the user
                MessageBox.Show("An error occurred while attempting to open the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                // If any other exception occurred, inform the user
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Giving the dropdown menu a label that corresponds with the selected value and displaying it
            selectValue.Text = dropDownMenu.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate the dropdown menu with items
            dropDownMenu.Items.Add("Program1");
            dropDownMenu.Items.Add("Program2");
            dropDownMenu.Items.Add("Program3");
            dropDownMenu.Items.Add("Program4");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    public class TemperatureReader
    {
        // Reference to the serialPort instance
        private SerialPort serialPort;
        // Reference to the Form1 instance
        private Form1 formInstance; 

        public TemperatureReader(Form1 form)
        {
            formInstance = form;
        }

        public void InitializeSerialPort(string portName)
        {
            // Initialize a new instance of the SerialPort class with the specified port name.
            serialPort = new SerialPort(portName)
            {
                // Set the baud rate for serial data transmission.
                BaudRate = 9600,
                // No parity bit is added to the data packet.
                Parity = Parity.None,
                // One stop bit is used to signal the end of a data packet.
                StopBits = StopBits.One,
                // The data is sent with 8 data bits.
                DataBits = 8,
                // No handshaking protocol is used.
                Handshake = Handshake.None,
                // The time-out value for read operations.
                ReadTimeout = 500,
                // The time-out value for write operations.
                WriteTimeout = 500
            };

            // Try to open the serial port and attach the DataReceived event handler.
            try
            {
                // Attach the event handler method for data received events.
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
                // Open the serial port for communications.
                serialPort.Open();
            }
            catch (Exception ex) // Catch any exceptions thrown during the opening of the serial port.
            {
                // Check if the form's window handle has been created to ensure thread safety when calling BeginInvoke.
                if (formInstance.IsHandleCreated)
                {
                    // If the handle is created, safely call BeginInvoke on the form's thread.
                    formInstance.BeginInvoke(new Action(() =>
                    {
                        // Display a message box with the error message.
                        MessageBox.Show($"Failed to open serial port '{portName}'. {ex.Message}");
                    }));
                }
                else
                {
                    // If the form's handle is not created, we cannot use BeginInvoke.
                    // Here you should handle the error appropriately, such as logging it or storing the error message for later display.
                    // For example, log the error message or store it in a variable to show later.
                }
            }
        }


        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read the data asynchronously
                string data = serialPort.ReadLine(); 
                formInstance.BeginInvoke(new Action(() =>
                {
                    // Invoke method to update the GUI
                    formInstance.UpdateTemperatureLabel1(data.Trim()); 
                }));
            }
            catch (TimeoutException)
            {
                // Handle the case where the read operation times out
                // Possibly retry the read operation or log the timeout
            }
            catch (IOException ex)
            {
            // Handle I/O exceptions that might occur if the serial port is suddenly disconnected, etc.
            }
            // Other specific exceptions related to the SerialPort can be caught here if needed
        }


        public void CloseSerialPort()
        {
            // At the end, checks if the serialport is open and if it is, closes it
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }
    }
}
