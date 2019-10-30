namespace Mini_to_Life
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player1 = new System.Windows.Forms.GroupBox();
            this.Player2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Player1.Location = new System.Drawing.Point(13, 13);
            this.Player1.MaximumSize = new System.Drawing.Size(650, 700);
            this.Player1.MinimumSize = new System.Drawing.Size(360, 576);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(650, 700);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            this.Player1.Text = "Player 1";
            // 
            // Player2
            // 
            this.Player2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Player2.Location = new System.Drawing.Point(688, 13);
            this.Player2.MaximumSize = new System.Drawing.Size(650, 700);
            this.Player2.MinimumSize = new System.Drawing.Size(360, 576);
            this.Player2.Name = "Player2";
            this.Player2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2.Size = new System.Drawing.Size(650, 700);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            this.Player2.Text = "Player 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(1366, 766);
            this.Name = "Form1";
            this.Text = "Mini to Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Player1;
        private System.Windows.Forms.GroupBox Player2;
    }
}

