namespace Arduino_Serial
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
            this.ledButton = new System.Windows.Forms.Button();
            this.potButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ledButton
            // 
            this.ledButton.Location = new System.Drawing.Point(74, 12);
            this.ledButton.Name = "ledButton";
            this.ledButton.Size = new System.Drawing.Size(75, 23);
            this.ledButton.TabIndex = 0;
            this.ledButton.Text = "Toggle LED";
            this.ledButton.UseVisualStyleBackColor = true;
            this.ledButton.Click += new System.EventHandler(this.ledButton_Click);
            // 
            // potButton
            // 
            this.potButton.Location = new System.Drawing.Point(51, 67);
            this.potButton.Name = "potButton";
            this.potButton.Size = new System.Drawing.Size(118, 23);
            this.potButton.TabIndex = 1;
            this.potButton.Text = "Read Potentiometer";
            this.potButton.UseVisualStyleBackColor = true;
            this.potButton.Click += new System.EventHandler(this.potButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 154);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.potButton);
            this.Controls.Add(this.ledButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ledButton;
        private System.Windows.Forms.Button potButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

