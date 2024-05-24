using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

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
            string data = serialPort.ReadLine();

            // Update the temperature label on the form
            ProcessReceivedData(data);
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
            //This makes sure we get an updated temperature in real time
            serialPort.DataReceived += SerialPort_DataReceived;
            dropDownMenu1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            dropDownMenu2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // Close
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            try
            {
                serialPort.Open();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while attempting to open the serial port: {ex.Message}");
            }

            // Initialize the dictionary with actions for each step.
            stepActions = new Dictionary<string, Action>();
            for (int i = 1; i <= 22; i++)
            {
                string stepName = $"Step{i}";
                stepActions[stepName] = () => MessageBox.Show($"Running your selected program: {stepName}");
            }
        }

        public void ProcessReceivedData(string data)
        {
            data = data.Trim();

            if (data.StartsWith("Temperature:"))
            {
                string temperature = data.Substring("Temperature:".Length).Trim();
                UpdateTemperatureLabels(temperature);
            }
            else
            {
                UpdateStatusLabels(data);
            }
        }

        public void UpdateTemperatureLabels(string temperature)
        {
            Action updateAction = () =>
            {
                // Assuming labelTemperature1 and labelTemperature2 are the label controls
                labelTemperature1.Text = temperature + " °C";
                labelTemperature2.Text = temperature + " °C";
            };

            // Check if the update of label's text needs to be done on the UI thread
            if (labelTemperature1.InvokeRequired || labelTemperature2.InvokeRequired)
            {
                // Use Invoke to ensure the update happens on the UI thread
                this.Invoke(updateAction);
            }
            else
            {
                // If not, update the label's text directly
                updateAction();
            }
        }

        public void UpdateStatusLabels(string message)
        {
            Action updateAction = () =>
            {
                // Assuming label9 and label10 are the label controls for status updates
                label9.Text = message;
                label10.Text = message;
            };

            // Check if the update of label's text needs to be done on the UI thread
            if (label9.InvokeRequired || label10.InvokeRequired)
            {
                // Use Invoke to ensure the update happens on the UI thread
                this.Invoke(updateAction);
            }
            else
            {
                // If not, update the label's text directly
                updateAction();
            }
        }

        private void SendCommandWithNewline(string command)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine(command);
                serialPort.WriteLine("\n"); // Ensure newline is sent after the command
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SendCommandWithNewline("MoveUp");
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("MoveUp");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SendCommandWithNewline("MoveDown");
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("MoveDown");
                serialPort.WriteLine("/n");
            }
            else
            {
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            // This is the button assigned to run the actual setting/program that is selected from the dropdown menu
            if (dropDownMenu1.SelectedItem == null)
            {
                // Inform the user that no step has been selected
                MessageBox.Show("You did not select a step, please select a step");
            }
            else
            {
                string selectedItem = dropDownMenu1.SelectedItem.ToString();
                // Check if the serial port is open before attempting to write to it
                if (serialPort != null && serialPort.IsOpen)
                {
                    if (selectedItem == "Run All Steps")
                    {
                        // Send the special variable "All" through the serial port
                        serialPort.WriteLine("1");
                        serialPort.WriteLine("/n");
                    }
                    else
                    {
                        // Extract the numeric part from the selected item, assuming the format is "StepX"
                        int stepNumber;
                        if (int.TryParse(selectedItem.Substring(4), out stepNumber))
                        {
                            // Send the step number through the serial port
                            serialPort.WriteLine(stepNumber.ToString());
                            serialPort.WriteLine("/n");
                        }
                        else
                        {
                            MessageBox.Show("Unknown step selected.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Serial port is not open.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This is the button assigned to run the actual setting/program that is selected from the dropdown menu
            if (dropDownMenu2.SelectedItem == null)
            {
                // Inform the user that no step has been selected
                MessageBox.Show("You did not select a step, please select a step");
            }
            else
            {
                string selectedItem = dropDownMenu2.SelectedItem.ToString();
                // Check if the serial port is open before attempting to write to it
                if (serialPort != null && serialPort.IsOpen)
                {
                    if (selectedItem == "Run All Steps")
                    {
                        // Send the special variable "All" through the serial port
                        serialPort.WriteLine("1");
                        serialPort.WriteLine("/n");
                    }
                    else
                    {
                        // Extract the numeric part from the selected item, assuming the format is "StepX"
                        int stepNumber;
                        if (int.TryParse(selectedItem.Substring(4), out stepNumber))
                        {
                            // Send the step number through the serial port
                            serialPort.WriteLine(stepNumber.ToString());
                            serialPort.WriteLine("/n");
                        }
                        else
                        {
                            MessageBox.Show("Unknown step selected.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Serial port is not open.");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("Pump1_On_Push");
                serialPort.WriteLine("/n");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("Pump2_On_Suck");
                serialPort.WriteLine("/n");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("Pump2_On_Push");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("MoveLeft");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("MoveRight");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("Mag1_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("Mag1_OFF");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off the step motor
                serialPort.WriteLine("Pump1_On_Suck");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag4_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag4_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag5_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag5_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag9_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn oon magnet number 9 
                serialPort.WriteLine("Mag9_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn off magnet number 6
                serialPort.WriteLine("Mag6_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn on magnet number 6
                serialPort.WriteLine("Mag6_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag8_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag8_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag7_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag7_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag3_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag3_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag2_OFF");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // Check if the serial port is open before attempting to write to it
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Mag2_ON");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn on all the magnets, in turn opening all the valves
                serialPort.WriteLine("Close_All_Valves");
                serialPort.WriteLine("/n");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send a command to the serial port to turn on all the magnets, in turn opening all the valves
                serialPort.WriteLine("Open_All_Valves");
                serialPort.WriteLine("/n");
            }
            else
            {
                // If the serial port is not open, inform the user
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("Reset_Motor1");
                    serialPort.WriteLine("/n");
                }
                else
                {
                    MessageBox.Show("Serial port is not open.");
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("Reset_Pump1");
                serialPort.WriteLine("/n");
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("Reset_Motor2");
                    serialPort.WriteLine("/n");
                }
                else
                {
                    MessageBox.Show("Serial port is not open.");
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("Reset_Pumps");
                    serialPort.WriteLine("/n");
                }
                else
                {
                    MessageBox.Show("Serial port is not open.");
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
                        formInstance.ProcessReceivedData(data.Trim());
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
}
