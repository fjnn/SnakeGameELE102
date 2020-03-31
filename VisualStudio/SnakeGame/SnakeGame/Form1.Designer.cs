namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelGameOver = new System.Windows.Forms.Label();
            this.ButtonBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(355, 426);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Score.Location = new System.Drawing.Point(421, 67);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(80, 25);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score:";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelScore.Location = new System.Drawing.Point(547, 67);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(19, 25);
            this.LabelScore.TabIndex = 2;
            this.LabelScore.Text = " ";
            // 
            // LabelGameOver
            // 
            this.LabelGameOver.AutoSize = true;
            this.LabelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelGameOver.Location = new System.Drawing.Point(46, 45);
            this.LabelGameOver.Name = "LabelGameOver";
            this.LabelGameOver.Size = new System.Drawing.Size(70, 25);
            this.LabelGameOver.TabIndex = 3;
            this.LabelGameOver.Text = "label1";
            this.LabelGameOver.Visible = false;
            // 
            // ButtonBox
            // 
            this.ButtonBox.Location = new System.Drawing.Point(662, 402);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.Size = new System.Drawing.Size(100, 20);
            this.ButtonBox.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(552, 386);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(90, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(552, 415);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(90, 23);
            this.DisconnectButton.TabIndex = 6;
            this.DisconnectButton.Text = "DISCONNECT";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(422, 397);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(84, 24);
            this.ConnectionStatusLabel.TabIndex = 7;
            this.ConnectionStatusLabel.Text = "STATUS";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(552, 357);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(90, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.LabelGameOver);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label LabelGameOver;
        private System.Windows.Forms.TextBox ButtonBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Button StartButton;
    }
}

