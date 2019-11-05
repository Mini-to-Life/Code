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
            this.P1_Rules = new System.Windows.Forms.Button();
            this.P1_Stats = new System.Windows.Forms.Button();
            this.LB_Naam_P1 = new System.Windows.Forms.Label();
            this.TB_Player_1 = new System.Windows.Forms.TextBox();
            this.CB_Modelselector_player1 = new System.Windows.Forms.ComboBox();
            this.TB_playerNaam1 = new System.Windows.Forms.TextBox();
            this.PB_player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.GroupBox();
            this.P2_Rules = new System.Windows.Forms.Button();
            this.P2_Stats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Player_2 = new System.Windows.Forms.TextBox();
            this.CB_Modelselector_player2 = new System.Windows.Forms.ComboBox();
            this.TB_playerNaam2 = new System.Windows.Forms.TextBox();
            this.PB_player2 = new System.Windows.Forms.PictureBox();
            this.TB_Ronde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_volgendeRonde = new System.Windows.Forms.Button();
            this.BT_DiceTool = new System.Windows.Forms.Button();
            this.P1_Buffs = new System.Windows.Forms.Button();
            this.P2_Buffs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.Player1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player1)).BeginInit();
            this.Player2.SuspendLayout();
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
            this.PB_logo.Click += new System.EventHandler(this.PB_logo_Click);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Controls.Add(this.P1_Buffs);
            this.Player1.Controls.Add(this.P1_Rules);
            this.Player1.Controls.Add(this.P1_Stats);
            this.Player1.Controls.Add(this.LB_Naam_P1);
            this.Player1.Controls.Add(this.TB_Player_1);
            this.Player1.Controls.Add(this.CB_Modelselector_player1);
            this.Player1.Controls.Add(this.TB_playerNaam1);
            this.Player1.Controls.Add(this.PB_player1);
            this.Player1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Player1.Location = new System.Drawing.Point(13, 10);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(550, 700);
            this.Player1.TabIndex = 1;
            this.Player1.TabStop = false;
            this.Player1.Text = "Player 1";
            // 
            // P1_Rules
            // 
            this.P1_Rules.Location = new System.Drawing.Point(321, 124);
            this.P1_Rules.Name = "P1_Rules";
            this.P1_Rules.Size = new System.Drawing.Size(108, 46);
            this.P1_Rules.TabIndex = 10;
            this.P1_Rules.Text = "Rules";
            this.P1_Rules.UseVisualStyleBackColor = true;
            this.P1_Rules.Click += new System.EventHandler(this.P1_Rules_Clicked);
            // 
            // P1_Stats
            // 
            this.P1_Stats.Location = new System.Drawing.Point(213, 124);
            this.P1_Stats.Name = "P1_Stats";
            this.P1_Stats.Size = new System.Drawing.Size(101, 46);
            this.P1_Stats.TabIndex = 9;
            this.P1_Stats.Text = "Stats";
            this.P1_Stats.UseVisualStyleBackColor = true;
            this.P1_Stats.Click += new System.EventHandler(this.P1_Stats_Clicked);
            // 
            // LB_Naam_P1
            // 
            this.LB_Naam_P1.AutoSize = true;
            this.LB_Naam_P1.Location = new System.Drawing.Point(219, 43);
            this.LB_Naam_P1.Name = "LB_Naam_P1";
            this.LB_Naam_P1.Size = new System.Drawing.Size(95, 26);
            this.LB_Naam_P1.TabIndex = 8;
            this.LB_Naam_P1.Text = "Naam:";
            // 
            // TB_Player_1
            // 
            this.TB_Player_1.Location = new System.Drawing.Point(213, 176);
            this.TB_Player_1.Multiline = true;
            this.TB_Player_1.Name = "TB_Player_1";
            this.TB_Player_1.ReadOnly = true;
            this.TB_Player_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Player_1.Size = new System.Drawing.Size(337, 518);
            this.TB_Player_1.TabIndex = 7;
            this.TB_Player_1.Text = "None";
            // 
            // CB_Modelselector_player1
            // 
            this.CB_Modelselector_player1.FormattingEnabled = true;
            this.CB_Modelselector_player1.Location = new System.Drawing.Point(213, 81);
            this.CB_Modelselector_player1.Name = "CB_Modelselector_player1";
            this.CB_Modelselector_player1.Size = new System.Drawing.Size(259, 34);
            this.CB_Modelselector_player1.TabIndex = 4;
            // 
            // TB_playerNaam1
            // 
            this.TB_playerNaam1.Location = new System.Drawing.Point(320, 40);
            this.TB_playerNaam1.Name = "TB_playerNaam1";
            this.TB_playerNaam1.ReadOnly = true;
            this.TB_playerNaam1.Size = new System.Drawing.Size(223, 34);
            this.TB_playerNaam1.TabIndex = 2;
            this.TB_playerNaam1.Text = "Naam";
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
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Controls.Add(this.P2_Buffs);
            this.Player2.Controls.Add(this.P2_Rules);
            this.Player2.Controls.Add(this.P2_Stats);
            this.Player2.Controls.Add(this.label1);
            this.Player2.Controls.Add(this.TB_Player_2);
            this.Player2.Controls.Add(this.CB_Modelselector_player2);
            this.Player2.Controls.Add(this.TB_playerNaam2);
            this.Player2.Controls.Add(this.PB_player2);
            this.Player2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Player2.Location = new System.Drawing.Point(788, 17);
            this.Player2.Name = "Player2";
            this.Player2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2.Size = new System.Drawing.Size(550, 700);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            this.Player2.Text = "Player 2";
            // 
            // P2_Rules
            // 
            this.P2_Rules.Location = new System.Drawing.Point(124, 117);
            this.P2_Rules.Name = "P2_Rules";
            this.P2_Rules.Size = new System.Drawing.Size(108, 46);
            this.P2_Rules.TabIndex = 11;
            this.P2_Rules.Text = "Rules";
            this.P2_Rules.UseVisualStyleBackColor = true;
            this.P2_Rules.Click += new System.EventHandler(this.P2_Rules_Clicked);
            // 
            // P2_Stats
            // 
            this.P2_Stats.Location = new System.Drawing.Point(238, 117);
            this.P2_Stats.Name = "P2_Stats";
            this.P2_Stats.Size = new System.Drawing.Size(101, 46);
            this.P2_Stats.TabIndex = 11;
            this.P2_Stats.Text = "Stats";
            this.P2_Stats.UseVisualStyleBackColor = true;
            this.P2_Stats.Click += new System.EventHandler(this.P2_Stats_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naam:";
            // 
            // TB_Player_2
            // 
            this.TB_Player_2.Location = new System.Drawing.Point(0, 169);
            this.TB_Player_2.Multiline = true;
            this.TB_Player_2.Name = "TB_Player_2";
            this.TB_Player_2.ReadOnly = true;
            this.TB_Player_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_Player_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Player_2.Size = new System.Drawing.Size(338, 525);
            this.TB_Player_2.TabIndex = 6;
            this.TB_Player_2.Text = "None";
            // 
            // CB_Modelselector_player2
            // 
            this.CB_Modelselector_player2.FormattingEnabled = true;
            this.CB_Modelselector_player2.Location = new System.Drawing.Point(79, 73);
            this.CB_Modelselector_player2.Name = "CB_Modelselector_player2";
            this.CB_Modelselector_player2.Size = new System.Drawing.Size(259, 34);
            this.CB_Modelselector_player2.TabIndex = 5;
            // 
            // TB_playerNaam2
            // 
            this.TB_playerNaam2.Location = new System.Drawing.Point(6, 33);
            this.TB_playerNaam2.Name = "TB_playerNaam2";
            this.TB_playerNaam2.ReadOnly = true;
            this.TB_playerNaam2.Size = new System.Drawing.Size(226, 34);
            this.TB_playerNaam2.TabIndex = 3;
            this.TB_playerNaam2.Text = "Naam";
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
            // TB_Ronde
            // 
            this.TB_Ronde.Location = new System.Drawing.Point(576, 256);
            this.TB_Ronde.Name = "TB_Ronde";
            this.TB_Ronde.ReadOnly = true;
            this.TB_Ronde.Size = new System.Drawing.Size(93, 34);
            this.TB_Ronde.TabIndex = 4;
            this.TB_Ronde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ronde";
            // 
            // BT_volgendeRonde
            // 
            this.BT_volgendeRonde.Location = new System.Drawing.Point(675, 255);
            this.BT_volgendeRonde.Name = "BT_volgendeRonde";
            this.BT_volgendeRonde.Size = new System.Drawing.Size(38, 34);
            this.BT_volgendeRonde.TabIndex = 12;
            this.BT_volgendeRonde.Text = ">";
            this.BT_volgendeRonde.UseVisualStyleBackColor = true;
            this.BT_volgendeRonde.Click += new System.EventHandler(this.BT_volgendeRonde_Click);
            // 
            // BT_DiceTool
            // 
            this.BT_DiceTool.Location = new System.Drawing.Point(574, 630);
            this.BT_DiceTool.Name = "BT_DiceTool";
            this.BT_DiceTool.Size = new System.Drawing.Size(202, 74);
            this.BT_DiceTool.TabIndex = 14;
            this.BT_DiceTool.Text = "Dice Tool";
            this.BT_DiceTool.UseVisualStyleBackColor = true;
            this.BT_DiceTool.Click += new System.EventHandler(this.BT_DiceTool_Click);
            // 
            // P1_Buffs
            // 
            this.P1_Buffs.Location = new System.Drawing.Point(435, 124);
            this.P1_Buffs.Name = "P1_Buffs";
            this.P1_Buffs.Size = new System.Drawing.Size(101, 46);
            this.P1_Buffs.TabIndex = 11;
            this.P1_Buffs.Text = "Buffs";
            this.P1_Buffs.UseVisualStyleBackColor = true;
            this.P1_Buffs.Click += new System.EventHandler(this.P1_Buffs_Clicked);
            // 
            // P2_Buffs
            // 
            this.P2_Buffs.Location = new System.Drawing.Point(17, 117);
            this.P2_Buffs.Name = "P2_Buffs";
            this.P2_Buffs.Size = new System.Drawing.Size(101, 46);
            this.P2_Buffs.TabIndex = 12;
            this.P2_Buffs.Text = "Buffs";
            this.P2_Buffs.UseVisualStyleBackColor = true;
            this.P2_Buffs.Click += new System.EventHandler(this.P2_Buffs_Clicked);
            // 
            // MiniToLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BT_DiceTool);
            this.Controls.Add(this.BT_volgendeRonde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Ronde);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.PB_logo);
            this.Font = new System.Drawing.Font("Imperial One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MiniToLife";
            this.Text = "Mini-to-Life Game";
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.Player1.ResumeLayout(false);
            this.Player1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player1)).EndInit();
            this.Player2.ResumeLayout(false);
            this.Player2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.GroupBox Player1;
        private System.Windows.Forms.TextBox TB_playerNaam1;
        private System.Windows.Forms.PictureBox PB_player1;
        private System.Windows.Forms.GroupBox Player2;
        private System.Windows.Forms.TextBox TB_playerNaam2;
        private System.Windows.Forms.PictureBox PB_player2;
        private System.Windows.Forms.ComboBox CB_Modelselector_player1;
        private System.Windows.Forms.ComboBox CB_Modelselector_player2;
        private System.Windows.Forms.TextBox TB_Player_1;
        private System.Windows.Forms.TextBox TB_Player_2;
        private System.Windows.Forms.TextBox TB_Ronde;
        private System.Windows.Forms.Label LB_Naam_P1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_volgendeRonde;
        private System.Windows.Forms.Button BT_DiceTool;
        private System.Windows.Forms.Button P1_Rules;
        private System.Windows.Forms.Button P1_Stats;
        private System.Windows.Forms.Button P2_Rules;
        private System.Windows.Forms.Button P2_Stats;
        private System.Windows.Forms.Button P1_Buffs;
        private System.Windows.Forms.Button P2_Buffs;
    }
}

