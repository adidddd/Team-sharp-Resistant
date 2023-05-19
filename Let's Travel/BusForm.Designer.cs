namespace Project
{
    partial class BusForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.BusIdtextBox = new System.Windows.Forms.TextBox();
            this.CompanyNametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FromcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deptTimeBox = new System.Windows.Forms.DateTimePicker();
            this.arrivalTimeBox = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(580, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 48;
            this.button1.Text = "Add Bus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BusIdtextBox
            // 
            this.BusIdtextBox.Location = new System.Drawing.Point(682, 32);
            this.BusIdtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusIdtextBox.Name = "BusIdtextBox";
            this.BusIdtextBox.Size = new System.Drawing.Size(187, 22);
            this.BusIdtextBox.TabIndex = 43;
            // 
            // CompanyNametextBox
            // 
            this.CompanyNametextBox.Location = new System.Drawing.Point(281, 31);
            this.CompanyNametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyNametextBox.Name = "CompanyNametextBox";
            this.CompanyNametextBox.Size = new System.Drawing.Size(187, 22);
            this.CompanyNametextBox.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Company Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 62;
            this.label9.Text = "Bus Id:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(139, 306);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(829, 196);
            this.listBox1.TabIndex = 77;
            // 
            // TocomboBox
            // 
            this.TocomboBox.FormattingEnabled = true;
            this.TocomboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Barisal",
            "Bandarban",
            "Rangamati",
            "Chattogram"});
            this.TocomboBox.Location = new System.Drawing.Point(681, 77);
            this.TocomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TocomboBox.Name = "TocomboBox";
            this.TocomboBox.Size = new System.Drawing.Size(187, 24);
            this.TocomboBox.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "To:";
            // 
            // FromcomboBox
            // 
            this.FromcomboBox.FormattingEnabled = true;
            this.FromcomboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Barisal",
            "Bandarban",
            "Rangamati",
            "Chattogram"});
            this.FromcomboBox.Location = new System.Drawing.Point(281, 77);
            this.FromcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromcomboBox.Name = "FromcomboBox";
            this.FromcomboBox.Size = new System.Drawing.Size(187, 24);
            this.FromcomboBox.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Arrival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Departure";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // deptTimeBox
            // 
            this.deptTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deptTimeBox.Location = new System.Drawing.Point(281, 128);
            this.deptTimeBox.Name = "deptTimeBox";
            this.deptTimeBox.Size = new System.Drawing.Size(200, 22);
            this.deptTimeBox.TabIndex = 95;
            // 
            // arrivalTimeBox
            // 
            this.arrivalTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTimeBox.Location = new System.Drawing.Point(694, 128);
            this.arrivalTimeBox.Name = "arrivalTimeBox";
            this.arrivalTimeBox.Size = new System.Drawing.Size(200, 22);
            this.arrivalTimeBox.TabIndex = 96;
            this.arrivalTimeBox.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(410, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 97;
            this.button2.Text = "Add Route";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Price:";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(681, 183);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(187, 22);
            this.PricetextBox.TabIndex = 98;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.arrivalTimeBox);
            this.Controls.Add(this.deptTimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TocomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BusIdtextBox);
            this.Controls.Add(this.CompanyNametextBox);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusForm";
            this.Text = "BusForm";
            this.Load += new System.EventHandler(this.BusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BusIdtextBox;
        private System.Windows.Forms.TextBox CompanyNametextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox TocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FromcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deptTimeBox;
        private System.Windows.Forms.DateTimePicker arrivalTimeBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PricetextBox;
    }
}