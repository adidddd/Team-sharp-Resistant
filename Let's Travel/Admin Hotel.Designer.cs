namespace Project
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HaddresstextBox = new System.Windows.Forms.TextBox();
            this.HnametextBox = new System.Windows.Forms.TextBox();
            this.DestinationcomboBox = new System.Windows.Forms.ComboBox();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Showbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RtypetextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RpricetextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.RcodetextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hotel Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hotel Category:";
            // 
            // HaddresstextBox
            // 
            this.HaddresstextBox.Location = new System.Drawing.Point(333, 178);
            this.HaddresstextBox.Name = "HaddresstextBox";
            this.HaddresstextBox.Size = new System.Drawing.Size(187, 22);
            this.HaddresstextBox.TabIndex = 12;
            // 
            // HnametextBox
            // 
            this.HnametextBox.Location = new System.Drawing.Point(333, 150);
            this.HnametextBox.Name = "HnametextBox";
            this.HnametextBox.Size = new System.Drawing.Size(187, 22);
            this.HnametextBox.TabIndex = 13;
            // 
            // DestinationcomboBox
            // 
            this.DestinationcomboBox.FormattingEnabled = true;
            this.DestinationcomboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Barisal",
            "Bandarban",
            "Rangamati",
            "Chattogram",
            "Cox\'s Bazar",
            "St. Martin",
            "Sylhet",
            "Khagrachori",
            "Khulna",
            "Rajshahi"});
            this.DestinationcomboBox.Location = new System.Drawing.Point(333, 258);
            this.DestinationcomboBox.Name = "DestinationcomboBox";
            this.DestinationcomboBox.Size = new System.Drawing.Size(187, 24);
            this.DestinationcomboBox.TabIndex = 17;
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CategorycomboBox.Location = new System.Drawing.Point(333, 224);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(187, 24);
            this.CategorycomboBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(92, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Hotel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(394, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "Remove Hotel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Showbutton.Location = new System.Drawing.Point(243, 358);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(126, 42);
            this.Showbutton.TabIndex = 24;
            this.Showbutton.Text = "Show Rooms";
            this.Showbutton.UseVisualStyleBackColor = false;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "HOTEL ROOM LIST",
            "Room Code\t\tRoom Type\t\tPrice"});
            this.listBox1.Location = new System.Drawing.Point(640, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 212);
            this.listBox1.TabIndex = 25;
            // 
            // RtypetextBox
            // 
            this.RtypetextBox.Location = new System.Drawing.Point(915, 146);
            this.RtypetextBox.Name = "RtypetextBox";
            this.RtypetextBox.Size = new System.Drawing.Size(187, 22);
            this.RtypetextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(669, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Room Type:";
            // 
            // RpricetextBox
            // 
            this.RpricetextBox.Location = new System.Drawing.Point(915, 183);
            this.RpricetextBox.Name = "RpricetextBox";
            this.RpricetextBox.Size = new System.Drawing.Size(187, 22);
            this.RpricetextBox.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(669, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Price:";
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Addbutton.Location = new System.Drawing.Point(640, 503);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(168, 42);
            this.Addbutton.TabIndex = 32;
            this.Addbutton.Text = "Add Room";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // RcodetextBox
            // 
            this.RcodetextBox.Location = new System.Drawing.Point(915, 112);
            this.RcodetextBox.Name = "RcodetextBox";
            this.RcodetextBox.Size = new System.Drawing.Size(187, 22);
            this.RcodetextBox.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(669, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Room Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 658);
            this.Controls.Add(this.RcodetextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.RpricetextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RtypetextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CategorycomboBox);
            this.Controls.Add(this.DestinationcomboBox);
            this.Controls.Add(this.HnametextBox);
            this.Controls.Add(this.HaddresstextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HaddresstextBox;
        private System.Windows.Forms.TextBox HnametextBox;
        private System.Windows.Forms.ComboBox DestinationcomboBox;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox RtypetextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RpricetextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox RcodetextBox;
        private System.Windows.Forms.Label label14;
    }
}

