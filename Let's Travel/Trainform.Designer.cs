namespace Project
{
    partial class Trainform
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
            this.label5 = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.arrivalTimeBox = new System.Windows.Forms.DateTimePicker();
            this.deptTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FromcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BusIdtextBox = new System.Windows.Forms.TextBox();
            this.CompanyNametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 116;
            this.label5.Text = "Price:";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(754, 215);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(187, 22);
            this.PricetextBox.TabIndex = 115;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(483, 269);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 114;
            this.button2.Text = "Add Route";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // arrivalTimeBox
            // 
            this.arrivalTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTimeBox.Location = new System.Drawing.Point(767, 160);
            this.arrivalTimeBox.Name = "arrivalTimeBox";
            this.arrivalTimeBox.Size = new System.Drawing.Size(200, 22);
            this.arrivalTimeBox.TabIndex = 113;
            // 
            // deptTimeBox
            // 
            this.deptTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deptTimeBox.Location = new System.Drawing.Point(354, 160);
            this.deptTimeBox.Name = "deptTimeBox";
            this.deptTimeBox.Size = new System.Drawing.Size(200, 22);
            this.deptTimeBox.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(667, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 111;
            this.label3.Text = "Arrival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "Departure";
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
            this.TocomboBox.Location = new System.Drawing.Point(754, 109);
            this.TocomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TocomboBox.Name = "TocomboBox";
            this.TocomboBox.Size = new System.Drawing.Size(187, 24);
            this.TocomboBox.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 108;
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
            this.FromcomboBox.Location = new System.Drawing.Point(354, 109);
            this.FromcomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromcomboBox.Name = "FromcomboBox";
            this.FromcomboBox.Size = new System.Drawing.Size(187, 24);
            this.FromcomboBox.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "From:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(212, 338);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(829, 196);
            this.listBox1.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 104;
            this.label9.Text = "Train Id:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(653, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 103;
            this.button1.Text = "Add Train";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BusIdtextBox
            // 
            this.BusIdtextBox.Location = new System.Drawing.Point(755, 64);
            this.BusIdtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusIdtextBox.Name = "BusIdtextBox";
            this.BusIdtextBox.Size = new System.Drawing.Size(187, 22);
            this.BusIdtextBox.TabIndex = 102;
            // 
            // CompanyNametextBox
            // 
            this.CompanyNametextBox.Location = new System.Drawing.Point(354, 63);
            this.CompanyNametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyNametextBox.Name = "CompanyNametextBox";
            this.CompanyNametextBox.Size = new System.Drawing.Size(187, 22);
            this.CompanyNametextBox.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 100;
            this.label6.Text = "Company Name:";
            // 
            // Trainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 594);
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
            this.Name = "Trainform";
            this.Text = "Trainform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker arrivalTimeBox;
        private System.Windows.Forms.DateTimePicker deptTimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FromcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BusIdtextBox;
        private System.Windows.Forms.TextBox CompanyNametextBox;
        private System.Windows.Forms.Label label6;
    }
}