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
            dropDownMenu = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            selectValue = new Label();
            TemperatureLabel = new Label();
            labelTemperature1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            tabPage2 = new TabPage();
            labelTemperature2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            button12 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 783);
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
            button2.Location = new Point(3, 861);
            button2.Name = "button2";
            button2.Size = new Size(141, 72);
            button2.TabIndex = 1;
            button2.Text = "Turn Off Stepmotor1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1525, 861);
            button4.Name = "button4";
            button4.Size = new Size(141, 72);
            button4.TabIndex = 3;
            button4.Text = "Run Program";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Calibrate
            // 
            Calibrate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calibrate.Location = new Point(1525, 783);
            Calibrate.Name = "Calibrate";
            Calibrate.Size = new Size(141, 72);
            Calibrate.TabIndex = 4;
            Calibrate.Text = "Calibrate configurations";
            Calibrate.UseVisualStyleBackColor = true;
            Calibrate.Click += button3_Click;
            // 
            // dropDownMenu
            // 
            dropDownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownMenu.FormattingEnabled = true;
            dropDownMenu.Items.AddRange(new object[] { "Program1", "Program2", "Program3", "Program4" });
            dropDownMenu.Location = new Point(173, 26);
            dropDownMenu.Name = "dropDownMenu";
            dropDownMenu.Size = new Size(241, 23);
            dropDownMenu.TabIndex = 5;
            dropDownMenu.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1257, 895);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 7;
            label1.Text = "Selected";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 24);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 8;
            label2.Text = "Program Selection";
            // 
            // selectValue
            // 
            selectValue.AutoSize = true;
            selectValue.BackColor = SystemColors.Highlight;
            selectValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            selectValue.Location = new Point(1381, 888);
            selectValue.Name = "selectValue";
            selectValue.Padding = new Padding(1);
            selectValue.Size = new Size(24, 32);
            selectValue.TabIndex = 9;
            selectValue.Text = "?";
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.BackColor = SystemColors.ButtonFace;
            TemperatureLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TemperatureLabel.Location = new Point(739, 879);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(165, 37);
            TemperatureLabel.TabIndex = 10;
            TemperatureLabel.Text = "Temperature";
            // 
            // labelTemperature1
            // 
            labelTemperature1.AutoSize = true;
            labelTemperature1.BackColor = SystemColors.ButtonFace;
            labelTemperature1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemperature1.ForeColor = Color.Red;
            labelTemperature1.Location = new Point(936, 879);
            labelTemperature1.Name = "labelTemperature1";
            labelTemperature1.Size = new Size(29, 37);
            labelTemperature1.TabIndex = 11;
            labelTemperature1.Text = "?";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1717, 1048);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(labelTemperature1);
            tabPage1.Controls.Add(dropDownMenu);
            tabPage1.Controls.Add(TemperatureLabel);
            tabPage1.Controls.Add(selectValue);
            tabPage1.Controls.Add(Calibrate);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1709, 1020);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Mode";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1525, 861);
            button3.Name = "button3";
            button3.Size = new Size(141, 72);
            button3.TabIndex = 13;
            button3.Text = "Run Program";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button28);
            tabPage2.Controls.Add(button29);
            tabPage2.Controls.Add(button26);
            tabPage2.Controls.Add(button27);
            tabPage2.Controls.Add(button24);
            tabPage2.Controls.Add(button25);
            tabPage2.Controls.Add(button22);
            tabPage2.Controls.Add(button23);
            tabPage2.Controls.Add(button20);
            tabPage2.Controls.Add(button21);
            tabPage2.Controls.Add(button18);
            tabPage2.Controls.Add(button19);
            tabPage2.Controls.Add(button16);
            tabPage2.Controls.Add(button17);
            tabPage2.Controls.Add(button14);
            tabPage2.Controls.Add(button15);
            tabPage2.Controls.Add(button12);
            tabPage2.Controls.Add(button13);
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(labelTemperature2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1709, 1020);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Operator Mode";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTemperature2
            // 
            labelTemperature2.AutoSize = true;
            labelTemperature2.BackColor = SystemColors.ButtonFace;
            labelTemperature2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemperature2.ForeColor = Color.Red;
            labelTemperature2.Location = new Point(936, 879);
            labelTemperature2.Name = "labelTemperature2";
            labelTemperature2.Size = new Size(29, 37);
            labelTemperature2.TabIndex = 14;
            labelTemperature2.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(1381, 888);
            label3.Name = "label3";
            label3.Padding = new Padding(1);
            label3.Size = new Size(24, 32);
            label3.TabIndex = 14;
            label3.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(739, 879);
            label6.Name = "label6";
            label6.Size = new Size(165, 37);
            label6.TabIndex = 13;
            label6.Text = "Temperature";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1257, 895);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 15;
            label4.Text = "Selected";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Program1", "Program2", "Program3", "Program4" });
            comboBox1.Location = new Point(173, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 23);
            comboBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 24);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 16;
            label5.Text = "Program Selection";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1525, 783);
            button5.Name = "button5";
            button5.Size = new Size(141, 72);
            button5.TabIndex = 13;
            button5.Text = "Calibrate configurations";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button3_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(3, 392);
            button6.Name = "button6";
            button6.Size = new Size(141, 72);
            button6.TabIndex = 18;
            button6.Text = "Turn Off Stepmotor4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(3, 471);
            button7.Name = "button7";
            button7.Size = new Size(141, 72);
            button7.TabIndex = 19;
            button7.Text = "Turn On Stepmotor3";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(3, 549);
            button8.Name = "button8";
            button8.Size = new Size(141, 72);
            button8.TabIndex = 20;
            button8.Text = "Turn Off Stepmotor3";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(3, 627);
            button9.Name = "button9";
            button9.Size = new Size(141, 72);
            button9.TabIndex = 21;
            button9.Text = "Turn On Stepmotor2";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(3, 705);
            button10.Name = "button10";
            button10.Size = new Size(141, 72);
            button10.TabIndex = 22;
            button10.Text = "Turn Off Stepmotor2";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(182, 314);
            button11.Name = "button11";
            button11.Size = new Size(141, 72);
            button11.TabIndex = 23;
            button11.Text = "Turn On Magnet 1";
            button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(3, 314);
            button13.Name = "button13";
            button13.Size = new Size(141, 72);
            button13.TabIndex = 25;
            button13.Text = "Turn On Stepmotor4";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(182, 392);
            button12.Name = "button12";
            button12.Size = new Size(141, 72);
            button12.TabIndex = 26;
            button12.Text = "Turn Off Magnet 1";
            button12.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Location = new Point(706, 392);
            button14.Name = "button14";
            button14.Size = new Size(141, 72);
            button14.TabIndex = 28;
            button14.Text = "Turn Off Magnet 4";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.Location = new Point(706, 314);
            button15.Name = "button15";
            button15.Size = new Size(141, 72);
            button15.TabIndex = 27;
            button15.Text = "Turn On Magnet 4";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Location = new Point(878, 392);
            button16.Name = "button16";
            button16.Size = new Size(141, 72);
            button16.TabIndex = 30;
            button16.Text = "Turn Off Magnet 5";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.Location = new Point(878, 314);
            button17.Name = "button17";
            button17.Size = new Size(141, 72);
            button17.TabIndex = 29;
            button17.Text = "Turn On Magnet 5";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Location = new Point(1539, 392);
            button18.Name = "button18";
            button18.Size = new Size(141, 72);
            button18.TabIndex = 32;
            button18.Text = "Turn Off Magnet 9";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button19.Location = new Point(1539, 314);
            button19.Name = "button19";
            button19.Size = new Size(141, 72);
            button19.TabIndex = 31;
            button19.Text = "Turn On Magnet 9";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button20.Location = new Point(1045, 392);
            button20.Name = "button20";
            button20.Size = new Size(141, 72);
            button20.TabIndex = 34;
            button20.Text = "Turn Off Magnet 6";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button21.Location = new Point(1045, 314);
            button21.Name = "button21";
            button21.Size = new Size(141, 72);
            button21.TabIndex = 33;
            button21.Text = "Turn On Magnet 6";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button22.Location = new Point(1368, 392);
            button22.Name = "button22";
            button22.Size = new Size(141, 72);
            button22.TabIndex = 36;
            button22.Text = "Turn Off Magnet 8";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button23.Location = new Point(1368, 314);
            button23.Name = "button23";
            button23.Size = new Size(141, 72);
            button23.TabIndex = 35;
            button23.Text = "Turn On Magnet 8";
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button24.Location = new Point(1206, 392);
            button24.Name = "button24";
            button24.Size = new Size(141, 72);
            button24.TabIndex = 38;
            button24.Text = "Turn Off Magnet 7";
            button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            button25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button25.Location = new Point(1206, 314);
            button25.Name = "button25";
            button25.Size = new Size(141, 72);
            button25.TabIndex = 37;
            button25.Text = "Turn On Magnet 7";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button26.Location = new Point(532, 392);
            button26.Name = "button26";
            button26.Size = new Size(141, 72);
            button26.TabIndex = 40;
            button26.Text = "Turn Off Magnet 3";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button27.Location = new Point(532, 314);
            button27.Name = "button27";
            button27.Size = new Size(141, 72);
            button27.TabIndex = 39;
            button27.Text = "Turn On Magnet 3";
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button28.Location = new Point(356, 392);
            button28.Name = "button28";
            button28.Size = new Size(141, 72);
            button28.TabIndex = 42;
            button28.Text = "Turn Off Magnet 2";
            button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            button29.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button29.Location = new Point(356, 314);
            button29.Name = "button29";
            button29.Size = new Size(141, 72);
            button29.TabIndex = 41;
            button29.Text = "Turn On Magnet 2";
            button29.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1708, 981);
            Controls.Add(tabControl1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "GuiTest1";
            TextChanged += comboBox1_SelectedIndexChanged;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button Calibrate;
        private OpenFileDialog openFileDialog1;
        private ComboBox dropDownMenu;
        private Label label1;
        private Label label2;
        private Label selectValue;
        private Label TemperatureLabel;
        private Label labelTemperature1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private Button button5;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Label labelTemperature2;
        private Button button13;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button28;
        private Button button29;
        private Button button26;
        private Button button27;
        private Button button24;
        private Button button25;
        private Button button22;
        private Button button23;
        private Button button20;
        private Button button21;
        private Button button18;
        private Button button19;
        private Button button16;
        private Button button17;
        private Button button14;
        private Button button15;
        private Button button12;
    }
}
