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
            this.AddMoneybutton = new System.Windows.Forms.Button();
            this.TrainTicketbutton = new System.Windows.Forms.Button();
            this.BusTicketbutton = new System.Windows.Forms.Button();
            this.BookHotelbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddMoneybutton
            // 
            this.AddMoneybutton.Location = new System.Drawing.Point(113, 198);
            this.AddMoneybutton.Name = "AddMoneybutton";
            this.AddMoneybutton.Size = new System.Drawing.Size(166, 31);
            this.AddMoneybutton.TabIndex = 0;
            this.AddMoneybutton.Text = "Add Money";
            this.AddMoneybutton.UseVisualStyleBackColor = true;
            this.AddMoneybutton.Click += new System.EventHandler(this.AddMoneybutton_Click);
            // 
            // TrainTicketbutton
            // 
            this.TrainTicketbutton.Location = new System.Drawing.Point(479, 264);
            this.TrainTicketbutton.Name = "TrainTicketbutton";
            this.TrainTicketbutton.Size = new System.Drawing.Size(166, 31);
            this.TrainTicketbutton.TabIndex = 1;
            this.TrainTicketbutton.Text = "Train Ticket";
            this.TrainTicketbutton.UseVisualStyleBackColor = true;
            this.TrainTicketbutton.Click += new System.EventHandler(this.TrainTicketbutton_Click);
            // 
            // BusTicketbutton
            // 
            this.BusTicketbutton.Location = new System.Drawing.Point(479, 198);
            this.BusTicketbutton.Name = "BusTicketbutton";
            this.BusTicketbutton.Size = new System.Drawing.Size(166, 31);
            this.BusTicketbutton.TabIndex = 2;
            this.BusTicketbutton.Text = "Bus Ticket";
            this.BusTicketbutton.UseVisualStyleBackColor = true;
            this.BusTicketbutton.Click += new System.EventHandler(this.BusTicketbutton_Click);
            // 
            // BookHotelbutton
            // 
            this.BookHotelbutton.Location = new System.Drawing.Point(113, 264);
            this.BookHotelbutton.Name = "BookHotelbutton";
            this.BookHotelbutton.Size = new System.Drawing.Size(166, 31);
            this.BookHotelbutton.TabIndex = 3;
            this.BookHotelbutton.Text = "Book Hotel";
            this.BookHotelbutton.UseVisualStyleBackColor = true;
            this.BookHotelbutton.Click += new System.EventHandler(this.BookHotelbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Balance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usernname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookHotelbutton);
            this.Controls.Add(this.BusTicketbutton);
            this.Controls.Add(this.TrainTicketbutton);
            this.Controls.Add(this.AddMoneybutton);
            this.Name = "User_Dashboard";
            this.Text = "User_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMoneybutton;
        private System.Windows.Forms.Button TrainTicketbutton;
        private System.Windows.Forms.Button BusTicketbutton;
        private System.Windows.Forms.Button BookHotelbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}