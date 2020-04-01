namespace Arduino_Serial_Advanced
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.baudrateComboBox = new System.Windows.Forms.ComboBox();
            this.baudrateLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toggleButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.onButton = new System.Windows.Forms.Button();
            this.led3CheckBox = new System.Windows.Forms.CheckBox();
            this.led2CheckBox = new System.Windows.Forms.CheckBox();
            this.led1CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.potreadButton = new System.Windows.Forms.Button();
            this.voltLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.baudrateComboBox);
            this.groupBox1.Controls.Add(this.baudrateLabel);
            this.groupBox1.Controls.Add(this.portLabel);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.statusLabel.Location = new System.Drawing.Point(269, 47);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 16);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Ready";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(112, 68);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // baudrateComboBox
            // 
            this.baudrateComboBox.FormattingEnabled = true;
            this.baudrateComboBox.Location = new System.Drawing.Point(112, 42);
            this.baudrateComboBox.Name = "baudrateComboBox";
            this.baudrateComboBox.Size = new System.Drawing.Size(100, 21);
            this.baudrateComboBox.TabIndex = 2;
            // 
            // baudrateLabel
            // 
            this.baudrateLabel.AutoSize = true;
            this.baudrateLabel.Location = new System.Drawing.Point(45, 45);
            this.baudrateLabel.Name = "baudrateLabel";
            this.baudrateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudrateLabel.TabIndex = 1;
            this.baudrateLabel.Text = "Baud Rate:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(66, 16);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(40, 13);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "PORT:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(112, 13);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toggleButton);
            this.groupBox2.Controls.Add(this.offButton);
            this.groupBox2.Controls.Add(this.onButton);
            this.groupBox2.Controls.Add(this.led3CheckBox);
            this.groupBox2.Controls.Add(this.led2CheckBox);
            this.groupBox2.Controls.Add(this.led1CheckBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Control";
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(207, 43);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(75, 23);
            this.toggleButton.TabIndex = 5;
            this.toggleButton.Text = "TOGGLE";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(70, 43);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(40, 23);
            this.offButton.TabIndex = 4;
            this.offButton.Text = "OFF";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(31, 43);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(33, 23);
            this.onButton.TabIndex = 3;
            this.onButton.Text = "ON";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // led3CheckBox
            // 
            this.led3CheckBox.AutoSize = true;
            this.led3CheckBox.Location = new System.Drawing.Point(281, 20);
            this.led3CheckBox.Name = "led3CheckBox";
            this.led3CheckBox.Size = new System.Drawing.Size(71, 17);
            this.led3CheckBox.TabIndex = 2;
            this.led3CheckBox.Text = "LED Blue";
            this.led3CheckBox.UseVisualStyleBackColor = true;
            // 
            // led2CheckBox
            // 
            this.led2CheckBox.AutoSize = true;
            this.led2CheckBox.Location = new System.Drawing.Point(144, 20);
            this.led2CheckBox.Name = "led2CheckBox";
            this.led2CheckBox.Size = new System.Drawing.Size(79, 17);
            this.led2CheckBox.TabIndex = 1;
            this.led2CheckBox.Text = "LED yellow";
            this.led2CheckBox.UseVisualStyleBackColor = true;
            // 
            // led1CheckBox
            // 
            this.led1CheckBox.AutoSize = true;
            this.led1CheckBox.Location = new System.Drawing.Point(7, 20);
            this.led1CheckBox.Name = "led1CheckBox";
            this.led1CheckBox.Size = new System.Drawing.Size(70, 17);
            this.led1CheckBox.TabIndex = 0;
            this.led1CheckBox.Text = "LED Red";
            this.led1CheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.voltageLabel);
            this.groupBox3.Controls.Add(this.potreadButton);
            this.groupBox3.Controls.Add(this.voltLabel);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(13, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Potentiometer Reading";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Location = new System.Drawing.Point(141, 54);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(10, 13);
            this.voltageLabel.TabIndex = 4;
            this.voltageLabel.Text = ".";
            // 
            // potreadButton
            // 
            this.potreadButton.Location = new System.Drawing.Point(291, 28);
            this.potreadButton.Name = "potreadButton";
            this.potreadButton.Size = new System.Drawing.Size(75, 23);
            this.potreadButton.TabIndex = 3;
            this.potreadButton.Text = "Read";
            this.potreadButton.UseVisualStyleBackColor = true;
            this.potreadButton.Click += new System.EventHandler(this.potreadButton_Click);
            // 
            // voltLabel
            // 
            this.voltLabel.AutoSize = true;
            this.voltLabel.Location = new System.Drawing.Point(119, 54);
            this.voltLabel.Name = "voltLabel";
            this.voltLabel.Size = new System.Drawing.Size(0, 13);
            this.voltLabel.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 19);
            this.progressBar1.Maximum = 1023;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 32);
            this.progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label baudrateLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.CheckBox led3CheckBox;
        private System.Windows.Forms.CheckBox led2CheckBox;
        private System.Windows.Forms.CheckBox led1CheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label voltLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox baudrateComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.Button potreadButton;
    }
}

