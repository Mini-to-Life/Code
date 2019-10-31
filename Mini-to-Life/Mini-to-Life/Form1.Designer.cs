namespace Mini_to_Life
{
    partial class MiniToLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniToLife));
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.GroupBox();
            this.Player2 = new System.Windows.Forms.GroupBox();
            this.PB_player1 = new System.Windows.Forms.PictureBox();
            this.PB_player2 = new System.Windows.Forms.PictureBox();
            this.TB_naam_player1 = new System.Windows.Forms.TextBox();
            this.TB_naam_player2 = new System.Windows.Forms.TextBox();
            this.TB_playerNaam1 = new System.Windows.Forms.TextBox();
            this.TB_playerNaam2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.Player1.SuspendLayout();
            this.Player2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player2)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_logo
            // 
            this.PB_logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_logo.Image")));
            this.PB_logo.Location = new System.Drawing.Point(576, 10);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(200, 200);
            this.PB_logo.TabIndex = 0;
            this.PB_logo.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Controls.Add(this.TB_playerNaam1);
            this.Player1.Controls.Add(this.TB_naam_player1);
            this.Player1.Controls.Add(this.PB_player1);
            this.Player1.Location = new System.Drawing.Point(13, 10);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(550, 700);
            this.Player1.TabIndex = 1;
            this.Player1.TabStop = false;
            this.Player1.Text = "Player 1";
            // 
            // Player2
            // 
            this.Player2.Controls.Add(this.TB_playerNaam2);
            this.Player2.Controls.Add(this.TB_naam_player2);
            this.Player2.Controls.Add(this.PB_player2);
            this.Player2.Location = new System.Drawing.Point(788, 17);
            this.Player2.Name = "Player2";
            this.Player2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2.Size = new System.Drawing.Size(550, 700);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            this.Player2.Text = "Player 2";
            // 
            // PB_player1
            // 
            this.PB_player1.Image = ((System.Drawing.Image)(resources.GetObject("PB_player1.Image")));
            this.PB_player1.Location = new System.Drawing.Point(6, 33);
            this.PB_player1.Name = "PB_player1";
            this.PB_player1.Size = new System.Drawing.Size(200, 300);
            this.PB_player1.TabIndex = 0;
            this.PB_player1.TabStop = false;
            // 
            // PB_player2
            // 
            this.PB_player2.Image = ((System.Drawing.Image)(resources.GetObject("PB_player2.Image")));
            this.PB_player2.Location = new System.Drawing.Point(344, 33);
            this.PB_player2.Name = "PB_player2";
            this.PB_player2.Size = new System.Drawing.Size(200, 300);
            this.PB_player2.TabIndex = 1;
            this.PB_player2.TabStop = false;
            // 
            // TB_naam_player1
            // 
            this.TB_naam_player1.Location = new System.Drawing.Point(213, 40);
            this.TB_naam_player1.Name = "TB_naam_player1";
            this.TB_naam_player1.ReadOnly = true;
            this.TB_naam_player1.Size = new System.Drawing.Size(100, 34);
            this.TB_naam_player1.TabIndex = 1;
            this.TB_naam_player1.Text = "Naam:";
            this.TB_naam_player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_naam_player2
            // 
            this.TB_naam_player2.Location = new System.Drawing.Point(238, 33);
            this.TB_naam_player2.Name = "TB_naam_player2";
            this.TB_naam_player2.ReadOnly = true;
            this.TB_naam_player2.Size = new System.Drawing.Size(100, 34);
            this.TB_naam_player2.TabIndex = 2;
            this.TB_naam_player2.Text = "Naam:";
            this.TB_naam_player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_playerNaam1
            // 
            this.TB_playerNaam1.Location = new System.Drawing.Point(320, 40);
            this.TB_playerNaam1.Name = "TB_playerNaam1";
            this.TB_playerNaam1.ReadOnly = true;
            this.TB_playerNaam1.Size = new System.Drawing.Size(224, 34);
            this.TB_playerNaam1.TabIndex = 2;
            // 
            // TB_playerNaam2
            // 
            this.TB_playerNaam2.Location = new System.Drawing.Point(8, 33);
            this.TB_playerNaam2.Name = "TB_playerNaam2";
            this.TB_playerNaam2.ReadOnly = true;
            this.TB_playerNaam2.Size = new System.Drawing.Size(224, 34);
            this.TB_playerNaam2.TabIndex = 3;
            // 
            // MiniToLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.PB_logo);
            this.Font = new System.Drawing.Font("Imperial One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MiniToLife";
            this.Text = "Mini-to-Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.Player1.ResumeLayout(false);
            this.Player1.PerformLayout();
            this.Player2.ResumeLayout(false);
            this.Player2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.GroupBox Player1;
        private System.Windows.Forms.TextBox TB_playerNaam1;
        private System.Windows.Forms.TextBox TB_naam_player1;
        private System.Windows.Forms.PictureBox PB_player1;
        private System.Windows.Forms.GroupBox Player2;
        private System.Windows.Forms.TextBox TB_playerNaam2;
        private System.Windows.Forms.TextBox TB_naam_player2;
        private System.Windows.Forms.PictureBox PB_player2;
    }
}

