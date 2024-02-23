namespace Testing_the_GUI1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            Calibrate = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(51, 136);
            button1.Name = "button1";
            button1.Size = new Size(141, 72);
            button1.TabIndex = 0;
            button1.Text = "Turn On Stepmotor1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(51, 214);
            button2.Name = "button2";
            button2.Size = new Size(141, 72);
            button2.TabIndex = 1;
            button2.Text = "Turn Of Stepmotor1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(372, 145);
            button4.Name = "button4";
            button4.Size = new Size(141, 72);
            button4.TabIndex = 3;
            button4.Text = "Run Program";
            button4.UseVisualStyleBackColor = true;
            // 
            // Calibrate
            // 
            Calibrate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calibrate.Location = new Point(920, 478);
            Calibrate.Name = "Calibrate";
            Calibrate.Size = new Size(141, 72);
            Calibrate.TabIndex = 4;
            Calibrate.Text = "Calibrate configurations";
            Calibrate.UseVisualStyleBackColor = true;
            Calibrate.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1073, 562);
            Controls.Add(Calibrate);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "GuiTest1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button Calibrate;
        private OpenFileDialog openFileDialog1;
    }
}
