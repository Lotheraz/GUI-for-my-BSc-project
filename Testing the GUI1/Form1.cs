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
        private Dictionary<string, Action> stepActions;
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the serial port when the form is closing.
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        

        // Defines the event handler method
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the available data from the serial port
            string temperature = serialPort.ReadLine();

            // Update the temperature label on the form
            UpdateTemperaturelabelTemperature2(temperature);
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
            dropDownMenu1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            dropDownMenu2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // Close
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            serialPort.Open();

            // Initialize the dictionary with actions for each step.
            // Right now, they all show a message, but you could replace them with actual method calls.
            stepActions = new Dictionary<string, Action>();
            for (int i = 1; i <= 22; i++)
            {
                string stepName = $"Step{i}";
                stepActions[stepName] = () => MessageBox.Show($"Running your selected program: {stepName}");
            }

        }



        // Public method to safely update the temperature label on the form
        public void UpdateTemperaturelabelTemperature2(string temperature)
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
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("11");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Similar to button1_Click, but this time to turn off the step motor
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("12");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Similar to button1_Click, but this time to turn on magnet nr 1
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn on the magnet
                serialPort.WriteLine("13");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn of the magnet
                serialPort.WriteLine("mag1OFF");
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

        /*private void button4_Click(object sender, EventArgs e)
        {
            // This is the button assigned to run the actual setting/program that is selected from the dropdown menu

            if (dropDownMenu2.SelectedItem == null)
            {   // Different messages that will show in a messagebox depending on the dropdown menu item
                MessageBox.Show("You did not select a step, please select a step");
            }
            else
            {
                string selectedItem = dropDownMenu2.SelectedItem.ToString();
                if (selectedItem == "Step1")
                {
                    MessageBox.Show("Running your selected program: Step1");
                }
                else if (selectedItem == "Step2")
                {
                    MessageBox.Show("Running your selected program: Step2");
                }
                else if (selectedItem == "Step3")
                {
                    MessageBox.Show("Running your selected program: Step3");
                }
                else if (selectedItem == "Step4")
                {
                    MessageBox.Show("Running your selected program: Step4");
                }
            }
        }*/

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine(); // Read the incoming data.
            UpdateGuiLabel(indata); // Update the GUI with the received data.
        }

        // This method safely updates the label text with the received data.
        private void UpdateGuiLabel(string data)
        {
            if (labelTemperature2.InvokeRequired)
            {
                // Use BeginInvoke to avoid potential deadlock in some edge cases
                labelTemperature2.BeginInvoke(new MethodInvoker(delegate { labelTemperature2.Text = data; }));
            }
            else
            {
                labelTemperature2.Text = data;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This is the button assigned to run the actual setting/program that is selected from the dropdown menu
            if (dropDownMenu2.SelectedItem == null)
            {
                // Different messages that will show in a messagebox depending on the dropdown menu item
                MessageBox.Show("You did not select a step, please select a step");
            }
            else
            {
                string selectedItem = dropDownMenu2.SelectedItem.ToString();
                if (stepActions.TryGetValue(selectedItem, out var action))
                {
                    action.Invoke();
                }
                else
                {
                    MessageBox.Show("Unknown step selected.");
                }
            }
        }
        /* private void button3_Click_1(object sender, EventArgs e)
         {
             // This is the button assigned to run the actual setting/program that is selected from the dropdown menu

             if (dropDownMenu1.SelectedItem == null)
             {   // Different messages that will show in a messagebox depending on the dropdown menu item
                 MessageBox.Show("You did not select a step, please select a step");
             }
             else
             {
                 string selectedItem = dropDownMenu1.SelectedItem.ToString();
                 if (selectedItem == "Step1")
                 {
                     MessageBox.Show("Running your selected program: Step1");
                 }
                 else if (selectedItem == "Step2")
                 {
                     MessageBox.Show("Running your selected program: Step2");
                 }
                 else if (selectedItem == "Step3")
                 {
                     MessageBox.Show("Running your selected program: Step3");
                 }
                 else if (selectedItem == "Step4")
                 {
                     MessageBox.Show("Running your selected program: Step4");
                 }
             }
         }*/

        private void button3_Click_1(object sender, EventArgs e)
        {
            // This is the button assigned to run the actual setting/program that is selected from the dropdown menu
            if (dropDownMenu1.SelectedItem == null)
            {
                // Different messages that will show in a messagebox depending on the dropdown menu item
                MessageBox.Show("You did not select a step, please select a step");
            }
            else
            {
                string selectedItem = dropDownMenu1.SelectedItem.ToString();
                if (stepActions.TryGetValue(selectedItem, out var action))
                {
                    action.Invoke();
                }
                else
                {
                    MessageBox.Show("Unknown step selected.");
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
            selectedProgram1.Text = dropDownMenu1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Giving the dropdown menu a label that corresponds with the selected value and displaying it
            selectedProgram2.Text = dropDownMenu2.Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate the dropdown menu with items
            dropDownMenu1.Items.Add("Step1");
            dropDownMenu1.Items.Add("Step2");
            dropDownMenu1.Items.Add("Step3");
            dropDownMenu1.Items.Add("Step4");
            dropDownMenu1.Items.Add("Step5");
            dropDownMenu1.Items.Add("Step6");
            dropDownMenu1.Items.Add("Step7");
            dropDownMenu1.Items.Add("Step8");
            dropDownMenu1.Items.Add("Step9");
            dropDownMenu1.Items.Add("Step10");
            dropDownMenu1.Items.Add("Step11");
            dropDownMenu1.Items.Add("Step12");
            dropDownMenu1.Items.Add("Step13");
            dropDownMenu1.Items.Add("Step14");
            dropDownMenu1.Items.Add("Step15");
            dropDownMenu1.Items.Add("Step16");
            dropDownMenu1.Items.Add("Step17");
            dropDownMenu1.Items.Add("Step18");
            dropDownMenu1.Items.Add("Step19");
            dropDownMenu1.Items.Add("Step20");
            dropDownMenu1.Items.Add("Step21");
            dropDownMenu1.Items.Add("Step22");

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
                // serialPort.Open();
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
                    formInstance.UpdateTemperaturelabelTemperature2(data.Trim()); 
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
        


    }
   

}
