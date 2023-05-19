namespace Project
{
    partial class Admin_Dashboard
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.TrainTicketbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manage Hotel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(485, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Balance";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(154, 91);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 62);
            this.button7.TabIndex = 6;
            this.button7.Text = "Manage Buses";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TrainTicketbutton
            // 
            this.TrainTicketbutton.Location = new System.Drawing.Point(154, 301);
            this.TrainTicketbutton.Name = "TrainTicketbutton";
            this.TrainTicketbutton.Size = new System.Drawing.Size(154, 58);
            this.TrainTicketbutton.TabIndex = 7;
            this.TrainTicketbutton.Text = "Manage Train";
            this.TrainTicketbutton.UseVisualStyleBackColor = true;
            this.TrainTicketbutton.Click += new System.EventHandler(this.TrainTicketbutton_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrainTicketbutton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button TrainTicketbutton;
    }
}