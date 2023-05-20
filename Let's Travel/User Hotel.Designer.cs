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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Hotel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowHotelbutton = new System.Windows.Forms.Button();
            this.DestinationcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ShowRoombutton = new System.Windows.Forms.Button();
            this.HotelNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RoomCodecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Paymentbutton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(355, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Listbox"});
            this.listBox1.Location = new System.Drawing.Point(3, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 212);
            this.listBox1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.ShowHotelbutton);
            this.panel2.Controls.Add(this.DestinationcomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(66, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 113);
            this.panel2.TabIndex = 53;
            // 
            // ShowHotelbutton
            // 
            this.ShowHotelbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowHotelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHotelbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowHotelbutton.Location = new System.Drawing.Point(132, 54);
            this.ShowHotelbutton.Name = "ShowHotelbutton";
            this.ShowHotelbutton.Size = new System.Drawing.Size(109, 38);
            this.ShowHotelbutton.TabIndex = 54;
            this.ShowHotelbutton.Text = "Show Hotels";
            this.ShowHotelbutton.UseVisualStyleBackColor = false;
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
            this.DestinationcomboBox.Location = new System.Drawing.Point(132, 9);
            this.DestinationcomboBox.Name = "DestinationcomboBox";
            this.DestinationcomboBox.Size = new System.Drawing.Size(99, 24);
            this.DestinationcomboBox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Destination:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.ShowRoombutton);
            this.panel3.Controls.Add(this.HotelNamecomboBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(66, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 157);
            this.panel3.TabIndex = 54;
            // 
            // ShowRoombutton
            // 
            this.ShowRoombutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowRoombutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRoombutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowRoombutton.Location = new System.Drawing.Point(143, 79);
            this.ShowRoombutton.Name = "ShowRoombutton";
            this.ShowRoombutton.Size = new System.Drawing.Size(113, 30);
            this.ShowRoombutton.TabIndex = 51;
            this.ShowRoombutton.Text = "Show Rooms";
            this.ShowRoombutton.UseVisualStyleBackColor = false;
            // 
            // HotelNamecomboBox
            // 
            this.HotelNamecomboBox.FormattingEnabled = true;
            this.HotelNamecomboBox.Location = new System.Drawing.Point(136, 35);
            this.HotelNamecomboBox.Name = "HotelNamecomboBox";
            this.HotelNamecomboBox.Size = new System.Drawing.Size(120, 24);
            this.HotelNamecomboBox.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Hotel Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.RoomCodecomboBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Paymentbutton);
            this.panel4.Location = new System.Drawing.Point(66, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 129);
            this.panel4.TabIndex = 55;
            // 
            // RoomCodecomboBox
            // 
            this.RoomCodecomboBox.FormattingEnabled = true;
            this.RoomCodecomboBox.Location = new System.Drawing.Point(155, 21);
            this.RoomCodecomboBox.Name = "RoomCodecomboBox";
            this.RoomCodecomboBox.Size = new System.Drawing.Size(99, 24);
            this.RoomCodecomboBox.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Room Code:";
            // 
            // Paymentbutton
            // 
            this.Paymentbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Paymentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Paymentbutton.Location = new System.Drawing.Point(92, 70);
            this.Paymentbutton.Name = "Paymentbutton";
            this.Paymentbutton.Size = new System.Drawing.Size(103, 56);
            this.Paymentbutton.TabIndex = 53;
            this.Paymentbutton.Text = "Proceed to Payment";
            this.Paymentbutton.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(-2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(903, 61);
            this.panel5.TabIndex = 56;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(-2, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(62, 622);
            this.panel6.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // User_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 690);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User_Hotel";
            this.Text = "User_Hotel";
            this.Load += new System.EventHandler(this.User_Hotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShowHotelbutton;
        private System.Windows.Forms.ComboBox DestinationcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ShowRoombutton;
        private System.Windows.Forms.ComboBox HotelNamecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox RoomCodecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Paymentbutton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}