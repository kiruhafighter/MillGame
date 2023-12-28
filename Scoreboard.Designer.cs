namespace MillGame
{
    partial class Scoreboard
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
            this.scoreGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreGridView
            // 
            this.scoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreGridView.Location = new System.Drawing.Point(12, 12);
            this.scoreGridView.Name = "scoreGridView";
            this.scoreGridView.RowHeadersWidth = 51;
            this.scoreGridView.RowTemplate.Height = 29;
            this.scoreGridView.Size = new System.Drawing.Size(543, 566);
            this.scoreGridView.TabIndex = 0;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 579);
            this.Controls.Add(this.scoreGridView);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView scoreGridView;
    }
}