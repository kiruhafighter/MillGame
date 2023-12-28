namespace MillGame
{
    partial class StartMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hostButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.scoreboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new game field";
            // 
            // hostButton
            // 
            this.hostButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hostButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hostButton.FlatAppearance.BorderSize = 3;
            this.hostButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.hostButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.hostButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hostButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hostButton.Location = new System.Drawing.Point(86, 87);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(159, 46);
            this.hostButton.TabIndex = 1;
            this.hostButton.Text = "New Game";
            this.hostButton.UseVisualStyleBackColor = false;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "Or connect to existing one";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP:";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ipAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ipAddressTextBox.Location = new System.Drawing.Point(86, 255);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(208, 31);
            this.ipAddressTextBox.TabIndex = 4;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.connectButton.FlatAppearance.BorderSize = 3;
            this.connectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectButton.Location = new System.Drawing.Point(86, 303);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(159, 46);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // scoreboardButton
            // 
            this.scoreboardButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.scoreboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreboardButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scoreboardButton.FlatAppearance.BorderSize = 3;
            this.scoreboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.scoreboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.scoreboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreboardButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreboardButton.Location = new System.Drawing.Point(45, 412);
            this.scoreboardButton.Name = "scoreboardButton";
            this.scoreboardButton.Size = new System.Drawing.Size(252, 46);
            this.scoreboardButton.TabIndex = 6;
            this.scoreboardButton.Text = "Show Scoreboard";
            this.scoreboardButton.UseVisualStyleBackColor = false;
            this.scoreboardButton.Click += new System.EventHandler(this.scoreboardButton_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 489);
            this.Controls.Add(this.scoreboardButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.label1);
            this.Name = "StartMenu";
            this.Text = "Host or connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button hostButton;
        private Label label2;
        private Label label3;
        private TextBox ipAddressTextBox;
        private Button connectButton;
        private Button scoreboardButton;
    }
}