using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports; // Add this to use the SerialPort class
using System.Windows.Forms;

namespace Testing_the_GUI1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort; // Declare the SerialPort object

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort(); // Initialize the serial port
        }

        private void InitializeSerialPort()
        {
            try
            {
                serialPort = new SerialPort("COM3", 9600); // Adjust "COM3" as per your Arduino connection
                serialPort.Open(); // Open the serial port
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open serial port: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("1"); // Send "1" to turn on the LED
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("0"); // Send "0" to turn off the LED
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\sult_\OneDrive\Desktop\Fordetect Calibrator Files\Configurations";
            OpenFile(filePath); // Call the function to open the file
        }

        private static void OpenFile(string filePath)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = "notepad.exe",
                    Arguments = filePath,
                };

                Process.Start(startInfo);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("An error occurred while attempting to open the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}