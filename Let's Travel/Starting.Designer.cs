namespace Project
{
    partial class Starting
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
            this.Userbutton = new System.Windows.Forms.Button();
            this.Adminbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Userbutton
            // 
            this.Userbutton.Location = new System.Drawing.Point(465, 148);
            this.Userbutton.Name = "Userbutton";
            this.Userbutton.Size = new System.Drawing.Size(176, 102);
            this.Userbutton.TabIndex = 0;
            this.Userbutton.Text = "User";
            this.Userbutton.UseVisualStyleBackColor = true;
            this.Userbutton.Click += new System.EventHandler(this.Userbutton_Click);
            // 
            // Adminbutton
            // 
            this.Adminbutton.Location = new System.Drawing.Point(182, 148);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(176, 102);
            this.Adminbutton.TabIndex = 1;
            this.Adminbutton.Text = "Admin";
            this.Adminbutton.UseVisualStyleBackColor = true;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // Starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adminbutton);
            this.Controls.Add(this.Userbutton);
            this.Name = "Starting";
            this.Text = "Starting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Userbutton;
        private System.Windows.Forms.Button Adminbutton;
    }
}