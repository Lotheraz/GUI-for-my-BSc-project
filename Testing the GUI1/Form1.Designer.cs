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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            Calibrate = new Button();
            openFileDialog1 = new OpenFileDialog();
            dropDownMenu1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            selectedProgram1 = new Label();
            TemperatureLabel = new Label();
            labelTemperature1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            button36 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            button3 = new Button();
            tabPage2 = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            button37 = new Button();
            button32 = new Button();
            button35 = new Button();
            button34 = new Button();
            button30 = new Button();
            button31 = new Button();
            label3 = new Label();
            label8 = new Label();
            button28 = new Button();
            button29 = new Button();
            button26 = new Button();
            button27 = new Button();
            button24 = new Button();
            button25 = new Button();
            button22 = new Button();
            button23 = new Button();
            button20 = new Button();
            button21 = new Button();
            button18 = new Button();
            button19 = new Button();
            button16 = new Button();
            button17 = new Button();
            button14 = new Button();
            button15 = new Button();
            button12 = new Button();
            button13 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            labelTemperature2 = new Label();
            selectedProgram2 = new Label();
            label6 = new Label();
            label4 = new Label();
            dropDownMenu2 = new ComboBox();
            label5 = new Label();
            button5 = new Button();
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F);
            button1.Location = new Point(9, 248);
            button1.Name = "button1";
            button1.Size = new Size(168, 48);
            button1.TabIndex = 0;
            button1.Text = "Move Stepmotor 2 Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F);
            button2.Location = new Point(183, 248);
            button2.Name = "button2";
            button2.Size = new Size(161, 48);
            button2.TabIndex = 1;
            button2.Text = "Move Stepmotor 2 Down";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1228, 705);
            button4.Name = "button4";
            button4.Size = new Size(141, 72);
            button4.TabIndex = 3;
            button4.Text = "Run Step";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Calibrate
            // 
            Calibrate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calibrate.Location = new Point(1228, 627);
            Calibrate.Name = "Calibrate";
            Calibrate.Size = new Size(141, 72);
            Calibrate.TabIndex = 4;
            Calibrate.Text = "Calibrate configurations";
            Calibrate.UseVisualStyleBackColor = true;
            Calibrate.Click += button3_Click;
            // 
            // dropDownMenu1
            // 
            dropDownMenu1.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownMenu1.FormattingEnabled = true;
            dropDownMenu1.Items.AddRange(new object[] { "Run All Steps", "Step2", "Step3", "Step4", "Step5", "Step6", "Step7", "Step8", "Step9", "Step10", "Step11", "Step12", "Step13", "Step14", "Step15", "Step16", "Step17", "Step18", "Step19", "Step20", "Step21", "Step22", "Step23", "Step24" });
            dropDownMenu1.Location = new Point(173, 26);
            dropDownMenu1.Name = "dropDownMenu1";
            dropDownMenu1.Size = new Size(241, 34);
            dropDownMenu1.TabIndex = 5;
            dropDownMenu1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(960, 739);
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
            // selectedProgram1
            // 
            selectedProgram1.AutoSize = true;
            selectedProgram1.BackColor = Color.CornflowerBlue;
            selectedProgram1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            selectedProgram1.Location = new Point(1084, 732);
            selectedProgram1.Name = "selectedProgram1";
            selectedProgram1.Padding = new Padding(1);
            selectedProgram1.Size = new Size(24, 32);
            selectedProgram1.TabIndex = 9;
            selectedProgram1.Text = "?";
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.BackColor = Color.CornflowerBlue;
            TemperatureLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TemperatureLabel.Location = new Point(442, 723);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(165, 37);
            TemperatureLabel.TabIndex = 10;
            TemperatureLabel.Text = "Temperature";
            // 
            // labelTemperature1
            // 
            labelTemperature1.AutoSize = true;
            labelTemperature1.BackColor = Color.CornflowerBlue;
            labelTemperature1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemperature1.ForeColor = Color.Red;
            labelTemperature1.Location = new Point(639, 723);
            labelTemperature1.Name = "labelTemperature1";
            labelTemperature1.Size = new Size(0, 37);
            labelTemperature1.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold);
            tabControl1.Location = new Point(-3, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1412, 848);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(button36);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(labelTemperature1);
            tabPage1.Controls.Add(dropDownMenu1);
            tabPage1.Controls.Add(TemperatureLabel);
            tabPage1.Controls.Add(selectedProgram1);
            tabPage1.Controls.Add(Calibrate);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1404, 806);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Mode";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(937, 77);
            label9.Name = "label9";
            label9.Size = new Size(449, 30);
            label9.TabIndex = 17;
            // 
            // button36
            // 
            button36.BackColor = Color.Red;
            button36.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button36.Location = new Point(1228, 549);
            button36.Name = "button36";
            button36.Size = new Size(141, 72);
            button36.TabIndex = 16;
            button36.Text = "Abort Step Program";
            button36.UseVisualStyleBackColor = false;
            button36.Click += button36_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 757);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 32);
            dateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.CornflowerBlue;
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(1179, 26);
            label7.Name = "label7";
            label7.Size = new Size(198, 26);
            label7.TabIndex = 14;
            label7.Text = "User Mode Selected";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1228, 705);
            button3.Name = "button3";
            button3.Size = new Size(141, 72);
            button3.TabIndex = 13;
            button3.Text = "Run Program";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button37);
            tabPage2.Controls.Add(button32);
            tabPage2.Controls.Add(button35);
            tabPage2.Controls.Add(button34);
            tabPage2.Controls.Add(button30);
            tabPage2.Controls.Add(button31);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label8);
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
            tabPage2.Controls.Add(selectedProgram2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dropDownMenu2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Font = new Font("Microsoft Sans Serif", 9.75F);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1404, 806);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manager Mode";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(11, 761);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.Size = new Size(365, 29);
            dateTimePicker2.TabIndex = 55;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(937, 77);
            label10.Name = "label10";
            label10.Size = new Size(449, 30);
            label10.TabIndex = 54;
            // 
            // button37
            // 
            button37.BackColor = Color.Red;
            button37.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button37.Location = new Point(1228, 548);
            button37.Name = "button37";
            button37.Size = new Size(141, 72);
            button37.TabIndex = 53;
            button37.Text = "Abort Step Program";
            button37.UseVisualStyleBackColor = false;
            button37.Click += button37_Click;
            // 
            // button32
            // 
            button32.BackColor = Color.Yellow;
            button32.Font = new Font("Microsoft Sans Serif", 9.75F);
            button32.Location = new Point(350, 248);
            button32.Name = "button32";
            button32.Size = new Size(96, 48);
            button32.TabIndex = 52;
            button32.Text = "Reset Stepmotor 2";
            button32.UseVisualStyleBackColor = false;
            button32.Click += button32_Click;
            // 
            // button35
            // 
            button35.BackColor = Color.Yellow;
            button35.Font = new Font("Microsoft Sans Serif", 9.75F);
            button35.Location = new Point(350, 86);
            button35.Name = "button35";
            button35.Size = new Size(96, 102);
            button35.TabIndex = 51;
            button35.Text = "Reset Pump 1 and Pump 2";
            button35.UseVisualStyleBackColor = false;
            button35.Click += button35_Click;
            // 
            // button34
            // 
            button34.BackColor = Color.Yellow;
            button34.Font = new Font("Microsoft Sans Serif", 9.75F);
            button34.Location = new Point(350, 194);
            button34.Name = "button34";
            button34.Size = new Size(96, 48);
            button34.TabIndex = 50;
            button34.Text = "Reset Stepmotor 4";
            button34.UseVisualStyleBackColor = false;
            button34.Click += button34_Click;
            // 
            // button30
            // 
            button30.BackColor = Color.Red;
            button30.Font = new Font("Microsoft Sans Serif", 9.75F);
            button30.Location = new Point(590, 86);
            button30.Name = "button30";
            button30.Size = new Size(96, 48);
            button30.TabIndex = 46;
            button30.Text = "Close All Valves";
            button30.UseVisualStyleBackColor = false;
            button30.Click += button30_Click;
            // 
            // button31
            // 
            button31.BackColor = Color.Green;
            button31.Font = new Font("Microsoft Sans Serif", 9.75F);
            button31.Location = new Point(474, 86);
            button31.Name = "button31";
            button31.Size = new Size(96, 48);
            button31.TabIndex = 45;
            button31.Text = "Open All Valves";
            button31.UseVisualStyleBackColor = false;
            button31.Click += button31_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(475, 26);
            label3.Name = "label3";
            label3.Size = new Size(222, 37);
            label3.TabIndex = 44;
            label3.Text = "Valve Control";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(1147, 26);
            label8.Name = "label8";
            label8.Size = new Size(239, 24);
            label8.TabIndex = 43;
            label8.Text = "Manager Mode Selected";
            // 
            // button28
            // 
            button28.BackColor = Color.Red;
            button28.Font = new Font("Microsoft Sans Serif", 9.75F);
            button28.Location = new Point(591, 518);
            button28.Name = "button28";
            button28.Size = new Size(96, 48);
            button28.TabIndex = 42;
            button28.Text = "Turn Off Magnet 2";
            button28.UseVisualStyleBackColor = false;
            button28.Click += button28_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.Green;
            button29.Font = new Font("Microsoft Sans Serif", 9.75F);
            button29.Location = new Point(474, 518);
            button29.Name = "button29";
            button29.Size = new Size(96, 48);
            button29.TabIndex = 41;
            button29.Text = "Turn On Magnet 2";
            button29.UseVisualStyleBackColor = false;
            button29.Click += button29_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.Red;
            button26.Font = new Font("Microsoft Sans Serif", 9.75F);
            button26.Location = new Point(591, 464);
            button26.Name = "button26";
            button26.Size = new Size(96, 48);
            button26.TabIndex = 40;
            button26.Text = "Turn Off Magnet 3";
            button26.UseVisualStyleBackColor = false;
            button26.Click += button26_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.Green;
            button27.Font = new Font("Microsoft Sans Serif", 9.75F);
            button27.Location = new Point(475, 464);
            button27.Name = "button27";
            button27.Size = new Size(96, 48);
            button27.TabIndex = 39;
            button27.Text = "Turn On Magnet 3";
            button27.UseVisualStyleBackColor = false;
            button27.Click += button27_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.Red;
            button24.Font = new Font("Microsoft Sans Serif", 9.75F);
            button24.Location = new Point(591, 248);
            button24.Name = "button24";
            button24.Size = new Size(96, 48);
            button24.TabIndex = 38;
            button24.Text = "Turn Off Magnet 7";
            button24.UseVisualStyleBackColor = false;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.Green;
            button25.Font = new Font("Microsoft Sans Serif", 9.75F);
            button25.Location = new Point(474, 248);
            button25.Name = "button25";
            button25.Size = new Size(96, 48);
            button25.TabIndex = 37;
            button25.Text = "Turn On Magnet 7";
            button25.UseVisualStyleBackColor = false;
            button25.Click += button25_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Red;
            button22.Font = new Font("Microsoft Sans Serif", 9.75F);
            button22.Location = new Point(591, 194);
            button22.Name = "button22";
            button22.Size = new Size(96, 48);
            button22.TabIndex = 36;
            button22.Text = "Turn Off Magnet 8";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.Green;
            button23.Font = new Font("Microsoft Sans Serif", 9.75F);
            button23.Location = new Point(474, 194);
            button23.Name = "button23";
            button23.Size = new Size(96, 48);
            button23.TabIndex = 35;
            button23.Text = "Turn On Magnet 8";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Red;
            button20.Font = new Font("Microsoft Sans Serif", 9.75F);
            button20.Location = new Point(591, 302);
            button20.Name = "button20";
            button20.Size = new Size(96, 48);
            button20.TabIndex = 34;
            button20.Text = "Turn Off Magnet 6";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Green;
            button21.Font = new Font("Microsoft Sans Serif", 9.75F);
            button21.Location = new Point(475, 302);
            button21.Name = "button21";
            button21.Size = new Size(96, 48);
            button21.TabIndex = 33;
            button21.Text = "Turn On Magnet 6";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Red;
            button18.Font = new Font("Microsoft Sans Serif", 9.75F);
            button18.Location = new Point(591, 140);
            button18.Name = "button18";
            button18.Size = new Size(96, 48);
            button18.TabIndex = 32;
            button18.Text = "Turn Off Magnet 9";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Green;
            button19.Font = new Font("Microsoft Sans Serif", 9.75F);
            button19.Location = new Point(475, 140);
            button19.Name = "button19";
            button19.Size = new Size(96, 48);
            button19.TabIndex = 31;
            button19.Text = "Turn On Magnet 9";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Red;
            button16.Font = new Font("Microsoft Sans Serif", 9.75F);
            button16.Location = new Point(591, 356);
            button16.Name = "button16";
            button16.Size = new Size(96, 48);
            button16.TabIndex = 30;
            button16.Text = "Turn Off Magnet 5";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Green;
            button17.Font = new Font("Microsoft Sans Serif", 9.75F);
            button17.Location = new Point(475, 356);
            button17.Name = "button17";
            button17.Size = new Size(96, 48);
            button17.TabIndex = 29;
            button17.Text = "Turn On Magnet 5";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Red;
            button14.Font = new Font("Microsoft Sans Serif", 9.75F);
            button14.Location = new Point(591, 410);
            button14.Name = "button14";
            button14.Size = new Size(96, 48);
            button14.TabIndex = 28;
            button14.Text = "Turn Off Magnet 4";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Green;
            button15.Font = new Font("Microsoft Sans Serif", 9.75F);
            button15.Location = new Point(474, 410);
            button15.Name = "button15";
            button15.Size = new Size(96, 48);
            button15.TabIndex = 27;
            button15.Text = "Turn On Magnet 4";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.Font = new Font("Microsoft Sans Serif", 9.75F);
            button12.Location = new Point(591, 572);
            button12.Name = "button12";
            button12.Size = new Size(96, 48);
            button12.TabIndex = 26;
            button12.Text = "Turn Off Magnet 1";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Green;
            button13.Font = new Font("Microsoft Sans Serif", 9.75F);
            button13.Location = new Point(9, 140);
            button13.Name = "button13";
            button13.Size = new Size(168, 48);
            button13.TabIndex = 25;
            button13.Text = "Pump1 On Suck";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Green;
            button11.Font = new Font("Microsoft Sans Serif", 9.75F);
            button11.Location = new Point(475, 572);
            button11.Name = "button11";
            button11.Size = new Size(96, 48);
            button11.TabIndex = 23;
            button11.Text = "Turn On Magnet 1";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Red;
            button10.Font = new Font("Microsoft Sans Serif", 9.75F);
            button10.Location = new Point(183, 194);
            button10.Name = "button10";
            button10.Size = new Size(161, 48);
            button10.TabIndex = 22;
            button10.Text = "Move Stepmotor 4 Right";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Green;
            button9.Font = new Font("Microsoft Sans Serif", 9.75F);
            button9.Location = new Point(9, 194);
            button9.Name = "button9";
            button9.Size = new Size(168, 48);
            button9.TabIndex = 21;
            button9.Text = "Move Stepmotor 4 Left";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Microsoft Sans Serif", 9.75F);
            button8.Location = new Point(183, 86);
            button8.Name = "button8";
            button8.Size = new Size(161, 48);
            button8.TabIndex = 20;
            button8.Text = "Pump2 On Push";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Green;
            button7.Font = new Font("Microsoft Sans Serif", 9.75F);
            button7.Location = new Point(9, 86);
            button7.Name = "button7";
            button7.Size = new Size(168, 48);
            button7.TabIndex = 19;
            button7.Text = "Pump2 On Suck";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Microsoft Sans Serif", 9.75F);
            button6.Location = new Point(183, 140);
            button6.Name = "button6";
            button6.Size = new Size(161, 48);
            button6.TabIndex = 18;
            button6.Text = "Pump1 On Push";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // labelTemperature2
            // 
            labelTemperature2.AutoSize = true;
            labelTemperature2.BackColor = SystemColors.ActiveCaption;
            labelTemperature2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemperature2.ForeColor = Color.Red;
            labelTemperature2.Location = new Point(639, 723);
            labelTemperature2.Name = "labelTemperature2";
            labelTemperature2.Size = new Size(0, 37);
            labelTemperature2.TabIndex = 14;
            // 
            // selectedProgram2
            // 
            selectedProgram2.AutoSize = true;
            selectedProgram2.BackColor = SystemColors.ActiveCaption;
            selectedProgram2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            selectedProgram2.Location = new Point(1084, 732);
            selectedProgram2.Name = "selectedProgram2";
            selectedProgram2.Padding = new Padding(1);
            selectedProgram2.Size = new Size(24, 32);
            selectedProgram2.TabIndex = 14;
            selectedProgram2.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(442, 723);
            label6.Name = "label6";
            label6.Size = new Size(165, 37);
            label6.TabIndex = 13;
            label6.Text = "Temperature";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(960, 739);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 15;
            label4.Text = "Selected";
            // 
            // dropDownMenu2
            // 
            dropDownMenu2.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownMenu2.FormattingEnabled = true;
            dropDownMenu2.Items.AddRange(new object[] { "Run All Steps", "Step2", "Step3", "Step4", "Step5", "Step6", "Step7", "Step8", "Step9", "Step10", "Step11", "Step12", "Step13", "Step14", "Step15", "Step16", "Step17", "Step18", "Step19", "Step20", "Step21", "Step22", "Step23", "Step24" });
            dropDownMenu2.Location = new Point(173, 26);
            dropDownMenu2.Name = "dropDownMenu2";
            dropDownMenu2.Size = new Size(241, 24);
            dropDownMenu2.TabIndex = 17;
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
            button5.Location = new Point(1228, 627);
            button5.Name = "button5";
            button5.Size = new Size(141, 72);
            button5.TabIndex = 13;
            button5.Text = "Calibrate configurations";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1405, 837);
            Controls.Add(tabControl1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "GUI Fordetect";
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
        private ComboBox dropDownMenu1;
        private Label label1;
        private Label label2;
        private Label selectedProgram1;
        private Label TemperatureLabel;
        private Label labelTemperature1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private Button button5;
        private Label selectedProgram2;
        private Label label4;
        private Label label5;
        private ComboBox dropDownMenu2;
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
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private ColorDialog colorDialog1;
        private Label label3;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button35;
        private Button button34;
        private Button button36;
        private Button button37;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
