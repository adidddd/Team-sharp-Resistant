namespace Project
{
    partial class User_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            this.AddMoneybutton = new System.Windows.Forms.Button();
            this.TrainTicketbutton = new System.Windows.Forms.Button();
            this.BusTicketbutton = new System.Windows.Forms.Button();
            this.BookHotelbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMoneybutton
            // 
            this.AddMoneybutton.BackColor = System.Drawing.SystemColors.Info;
            this.AddMoneybutton.Location = new System.Drawing.Point(18, 136);
            this.AddMoneybutton.Name = "AddMoneybutton";
            this.AddMoneybutton.Size = new System.Drawing.Size(166, 31);
            this.AddMoneybutton.TabIndex = 0;
            this.AddMoneybutton.Text = "Add Money";
            this.AddMoneybutton.UseVisualStyleBackColor = false;
            this.AddMoneybutton.Click += new System.EventHandler(this.AddMoneybutton_Click);
            // 
            // TrainTicketbutton
            // 
            this.TrainTicketbutton.BackColor = System.Drawing.SystemColors.Info;
            this.TrainTicketbutton.Location = new System.Drawing.Point(15, 325);
            this.TrainTicketbutton.Name = "TrainTicketbutton";
            this.TrainTicketbutton.Size = new System.Drawing.Size(166, 31);
            this.TrainTicketbutton.TabIndex = 1;
            this.TrainTicketbutton.Text = "Train Ticket";
            this.TrainTicketbutton.UseVisualStyleBackColor = false;
            this.TrainTicketbutton.Click += new System.EventHandler(this.TrainTicketbutton_Click);
            // 
            // BusTicketbutton
            // 
            this.BusTicketbutton.BackColor = System.Drawing.SystemColors.Info;
            this.BusTicketbutton.Location = new System.Drawing.Point(18, 261);
            this.BusTicketbutton.Name = "BusTicketbutton";
            this.BusTicketbutton.Size = new System.Drawing.Size(166, 31);
            this.BusTicketbutton.TabIndex = 2;
            this.BusTicketbutton.Text = "Bus Ticket";
            this.BusTicketbutton.UseVisualStyleBackColor = false;
            this.BusTicketbutton.Click += new System.EventHandler(this.BusTicketbutton_Click);
            // 
            // BookHotelbutton
            // 
            this.BookHotelbutton.BackColor = System.Drawing.SystemColors.Info;
            this.BookHotelbutton.Location = new System.Drawing.Point(18, 195);
            this.BookHotelbutton.Name = "BookHotelbutton";
            this.BookHotelbutton.Size = new System.Drawing.Size(166, 31);
            this.BookHotelbutton.TabIndex = 3;
            this.BookHotelbutton.Text = "Book Hotel";
            this.BookHotelbutton.UseVisualStyleBackColor = false;
            this.BookHotelbutton.Click += new System.EventHandler(this.BookHotelbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.AddMoneybutton);
            this.panel1.Controls.Add(this.BookHotelbutton);
            this.panel1.Controls.Add(this.BusTicketbutton);
            this.panel1.Controls.Add(this.TrainTicketbutton);
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 523);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(464, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 523);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 523);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usernname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User_Dashboard";
            this.Text = "User_Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMoneybutton;
        private System.Windows.Forms.Button TrainTicketbutton;
        private System.Windows.Forms.Button BusTicketbutton;
        private System.Windows.Forms.Button BookHotelbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}