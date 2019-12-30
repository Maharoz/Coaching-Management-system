namespace Byatikram
{
    partial class FeeCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentRollTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.AmountTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.DueTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountPaid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalDue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.ReferenceRollNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.ReferalDiscountTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalPayable = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.OtherDiscountTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(120, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Students Roll";
            // 
            // StudentRollTextBox
            // 
            this.StudentRollTextBox.BackColor = System.Drawing.Color.White;
            this.StudentRollTextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.StudentRollTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentRollTextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.StudentRollTextBox.BorderThickness = 3;
            this.StudentRollTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentRollTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StudentRollTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentRollTextBox.isPassword = false;
            this.StudentRollTextBox.Location = new System.Drawing.Point(352, 77);
            this.StudentRollTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentRollTextBox.Name = "StudentRollTextBox";
            this.StudentRollTextBox.Size = new System.Drawing.Size(292, 44);
            this.StudentRollTextBox.TabIndex = 2;
            this.StudentRollTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StudentRollTextBox.OnValueChanged += new System.EventHandler(this.StudentRollTextBox_OnValueChanged);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.BackColor = System.Drawing.Color.White;
            this.AmountTextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.AmountTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmountTextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.AmountTextBox.BorderThickness = 3;
            this.AmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AmountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmountTextBox.isPassword = false;
            this.AmountTextBox.Location = new System.Drawing.Point(352, 251);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(292, 44);
            this.AmountTextBox.TabIndex = 3;
            this.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(122, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(122, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fees for the month";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(439, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Receive";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(122, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Students Name";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.BackColor = System.Drawing.Color.White;
            this.StudentNameTextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.StudentNameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentNameTextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.StudentNameTextBox.BorderThickness = 3;
            this.StudentNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StudentNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentNameTextBox.isPassword = false;
            this.StudentNameTextBox.Location = new System.Drawing.Point(352, 130);
            this.StudentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(292, 44);
            this.StudentNameTextBox.TabIndex = 9;
            this.StudentNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(352, 195);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(136, 35);
            this.bunifuDropdown1.TabIndex = 10;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[] {
        "2019",
        "2020",
        "2021",
        "2022"};
            this.bunifuDropdown2.Location = new System.Drawing.Point(494, 195);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(150, 35);
            this.bunifuDropdown2.TabIndex = 11;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DueTextBox
            // 
            this.DueTextBox.BackColor = System.Drawing.Color.White;
            this.DueTextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.DueTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DueTextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.DueTextBox.BorderThickness = 3;
            this.DueTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DueTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DueTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DueTextBox.isPassword = false;
            this.DueTextBox.Location = new System.Drawing.Point(352, 313);
            this.DueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DueTextBox.Name = "DueTextBox";
            this.DueTextBox.Size = new System.Drawing.Size(292, 44);
            this.DueTextBox.TabIndex = 13;
            this.DueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F);
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(122, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Previous Due";
            // 
            // AmountPaid
            // 
            this.AmountPaid.BackColor = System.Drawing.Color.White;
            this.AmountPaid.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.AmountPaid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmountPaid.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.AmountPaid.BorderThickness = 3;
            this.AmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AmountPaid.isPassword = false;
            this.AmountPaid.Location = new System.Drawing.Point(352, 559);
            this.AmountPaid.Margin = new System.Windows.Forms.Padding(4);
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.Size = new System.Drawing.Size(292, 44);
            this.AmountPaid.TabIndex = 16;
            this.AmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AmountPaid.OnValueChanged += new System.EventHandler(this.DueForThisPay_OnValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F);
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(122, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Payable";
            // 
            // TotalDue
            // 
            this.TotalDue.BackColor = System.Drawing.Color.White;
            this.TotalDue.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.TotalDue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalDue.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.TotalDue.BorderThickness = 3;
            this.TotalDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalDue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalDue.isPassword = false;
            this.TotalDue.Location = new System.Drawing.Point(352, 620);
            this.TotalDue.Margin = new System.Windows.Forms.Padding(4);
            this.TotalDue.Name = "TotalDue";
            this.TotalDue.Size = new System.Drawing.Size(292, 44);
            this.TotalDue.TabIndex = 19;
            this.TotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F);
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(92, 611);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Due After This Payment";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ReferenceRollNumber
            // 
            this.ReferenceRollNumber.BackColor = System.Drawing.Color.White;
            this.ReferenceRollNumber.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.ReferenceRollNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReferenceRollNumber.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.ReferenceRollNumber.BorderThickness = 3;
            this.ReferenceRollNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReferenceRollNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ReferenceRollNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReferenceRollNumber.isPassword = false;
            this.ReferenceRollNumber.Location = new System.Drawing.Point(878, 376);
            this.ReferenceRollNumber.Margin = new System.Windows.Forms.Padding(4);
            this.ReferenceRollNumber.Name = "ReferenceRollNumber";
            this.ReferenceRollNumber.Size = new System.Drawing.Size(292, 44);
            this.ReferenceRollNumber.TabIndex = 21;
            this.ReferenceRollNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F);
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(731, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "For Roll No";
            // 
            // ReferalDiscountTextBox
            // 
            this.ReferalDiscountTextBox.BackColor = System.Drawing.Color.White;
            this.ReferalDiscountTextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.ReferalDiscountTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReferalDiscountTextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.ReferalDiscountTextBox.BorderThickness = 3;
            this.ReferalDiscountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReferalDiscountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ReferalDiscountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReferalDiscountTextBox.isPassword = false;
            this.ReferalDiscountTextBox.Location = new System.Drawing.Point(352, 376);
            this.ReferalDiscountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReferalDiscountTextBox.Name = "ReferalDiscountTextBox";
            this.ReferalDiscountTextBox.Size = new System.Drawing.Size(292, 44);
            this.ReferalDiscountTextBox.TabIndex = 23;
            this.ReferalDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReferalDiscountTextBox.OnValueChanged += new System.EventHandler(this.ReferalDiscountTextBox_OnValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 18F);
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(122, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Refrerral discount";
            // 
            // TotalPayable
            // 
            this.TotalPayable.BackColor = System.Drawing.Color.White;
            this.TotalPayable.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.TotalPayable.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalPayable.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.TotalPayable.BorderThickness = 3;
            this.TotalPayable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalPayable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TotalPayable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalPayable.isPassword = false;
            this.TotalPayable.Location = new System.Drawing.Point(352, 498);
            this.TotalPayable.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPayable.Name = "TotalPayable";
            this.TotalPayable.Size = new System.Drawing.Size(292, 44);
            this.TotalPayable.TabIndex = 25;
            this.TotalPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 18F);
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(126, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "Amount Paid";
            // 
            // OtherDiscountTextBox
            // 
            this.OtherDiscountTextBox.BackColor = System.Drawing.Color.White;
            this.OtherDiscountTextBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.OtherDiscountTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OtherDiscountTextBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.OtherDiscountTextBox.BorderThickness = 3;
            this.OtherDiscountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OtherDiscountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OtherDiscountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OtherDiscountTextBox.isPassword = false;
            this.OtherDiscountTextBox.Location = new System.Drawing.Point(352, 443);
            this.OtherDiscountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OtherDiscountTextBox.Name = "OtherDiscountTextBox";
            this.OtherDiscountTextBox.Size = new System.Drawing.Size(292, 44);
            this.OtherDiscountTextBox.TabIndex = 27;
            this.OtherDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OtherDiscountTextBox.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox4_OnValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 18F);
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(120, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 29);
            this.label13.TabIndex = 28;
            this.label13.Text = "Other discount";
            // 
            // FeeCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1225, 759);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OtherDiscountTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TotalPayable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ReferalDiscountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReferenceRollNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalDue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DueTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.StudentRollTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FeeCollection";
            this.Text = "FeeCollection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox StudentRollTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox AmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox StudentNameTextBox;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMetroTextbox DueTextBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox AmountPaid;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox TotalDue;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox ReferenceRollNumber;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox ReferalDiscountTextBox;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox TotalPayable;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMetroTextbox OtherDiscountTextBox;
        private System.Windows.Forms.Label label13;
    }
}