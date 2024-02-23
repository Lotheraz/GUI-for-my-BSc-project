using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Testing_the_GUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\sult_\OneDrive\Desktop\Fordetect Calibrator Files\Configurations";

            // Call the function to open the file
            OpenFile(filePath);
        }

        // Function to open a file
        private static void OpenFile(string filePath)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = "notepad.exe", // Explicitly specify Notepad as the executable
                    Arguments = filePath, // Pass the file path as an argument
                    
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


