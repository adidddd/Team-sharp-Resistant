namespace Project
{
    partial class User_Hotel
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
            this.DestinationcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HotelNamecomboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ShowRoombutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Paymentbutton = new System.Windows.Forms.Button();
            this.ShowHotelbutton = new System.Windows.Forms.Button();
            this.RoomCodecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.DestinationcomboBox.Location = new System.Drawing.Point(196, 82);
            this.DestinationcomboBox.Name = "DestinationcomboBox";
            this.DestinationcomboBox.Size = new System.Drawing.Size(187, 24);
            this.DestinationcomboBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Destination:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hotel Name:";
            // 
            // HotelNamecomboBox
            // 
            this.HotelNamecomboBox.FormattingEnabled = true;
            this.HotelNamecomboBox.Location = new System.Drawing.Point(196, 291);
            this.HotelNamecomboBox.Name = "HotelNamecomboBox";
            this.HotelNamecomboBox.Size = new System.Drawing.Size(187, 24);
            this.HotelNamecomboBox.TabIndex = 27;
            this.HotelNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.HotelNamecomboBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Listbox"});
            this.listBox1.Location = new System.Drawing.Point(516, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 244);
            this.listBox1.TabIndex = 28;
            // 
            // ShowRoombutton
            // 
            this.ShowRoombutton.Location = new System.Drawing.Point(217, 364);
            this.ShowRoombutton.Name = "ShowRoombutton";
            this.ShowRoombutton.Size = new System.Drawing.Size(155, 63);
            this.ShowRoombutton.TabIndex = 29;
            this.ShowRoombutton.Text = "Show Rooms";
            this.ShowRoombutton.UseVisualStyleBackColor = true;
            this.ShowRoombutton.Click += new System.EventHandler(this.ShowRoombutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Room Code:";
            // 
            // Paymentbutton
            // 
            this.Paymentbutton.BackColor = System.Drawing.Color.Coral;
            this.Paymentbutton.Location = new System.Drawing.Point(623, 443);
            this.Paymentbutton.Name = "Paymentbutton";
            this.Paymentbutton.Size = new System.Drawing.Size(161, 42);
            this.Paymentbutton.TabIndex = 38;
            this.Paymentbutton.Text = "Proceed to Payment";
            this.Paymentbutton.UseVisualStyleBackColor = false;
            this.Paymentbutton.Click += new System.EventHandler(this.Paymentbutton_Click);
            // 
            // ShowHotelbutton
            // 
            this.ShowHotelbutton.Location = new System.Drawing.Point(228, 140);
            this.ShowHotelbutton.Name = "ShowHotelbutton";
            this.ShowHotelbutton.Size = new System.Drawing.Size(155, 63);
            this.ShowHotelbutton.TabIndex = 41;
            this.ShowHotelbutton.Text = "Show Hotels";
            this.ShowHotelbutton.UseVisualStyleBackColor = true;
            this.ShowHotelbutton.Click += new System.EventHandler(this.ShowHotelbutton_Click);
            // 
            // RoomCodecomboBox
            // 
            this.RoomCodecomboBox.FormattingEnabled = true;
            this.RoomCodecomboBox.Location = new System.Drawing.Point(690, 397);
            this.RoomCodecomboBox.Name = "RoomCodecomboBox";
            this.RoomCodecomboBox.Size = new System.Drawing.Size(187, 24);
            this.RoomCodecomboBox.TabIndex = 42;
            this.RoomCodecomboBox.SelectedIndexChanged += new System.EventHandler(this.RoomCodecomboBox_SelectedIndexChanged);
            // 
            // User_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 558);
            this.Controls.Add(this.RoomCodecomboBox);
            this.Controls.Add(this.ShowHotelbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paymentbutton);
            this.Controls.Add(this.ShowRoombutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HotelNamecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DestinationcomboBox);
            this.Controls.Add(this.label2);
            this.Name = "User_Hotel";
            this.Text = "User_Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DestinationcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HotelNamecomboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ShowRoombutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Paymentbutton;
        private System.Windows.Forms.Button ShowHotelbutton;
        private System.Windows.Forms.ComboBox RoomCodecomboBox;
    }
}