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
            this.LB_Naam_P1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CB_Modelselector_player1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSTB_player1_Stats = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSTB_player1_Buffs = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSTB_player1_Rules = new System.Windows.Forms.ToolStripLabel();
            this.TB_playerNaam1 = new System.Windows.Forms.TextBox();
            this.PB_player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxItemRulings_player2 = new System.Windows.Forms.TextBox();
            this.CB_Modelselector_player2 = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.TB_playerNaam2 = new System.Windows.Forms.TextBox();
            this.PB_player2 = new System.Windows.Forms.PictureBox();
            this.TB_Ronde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Fase = new System.Windows.Forms.TextBox();
            this.BT_volgendeRonde = new System.Windows.Forms.Button();
            this.BT_volgendeFase = new System.Windows.Forms.Button();
            this.BT_DiceTool = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.Player1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player1)).BeginInit();
            this.Player2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.Player1.Controls.Add(this.LB_Naam_P1);
            this.Player1.Controls.Add(this.textBox1);
            this.Player1.Controls.Add(this.CB_Modelselector_player1);
            this.Player1.Controls.Add(this.toolStrip1);
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
            // LB_Naam_P1
            // 
            this.LB_Naam_P1.AutoSize = true;
            this.LB_Naam_P1.Location = new System.Drawing.Point(219, 43);
            this.LB_Naam_P1.Name = "LB_Naam_P1";
            this.LB_Naam_P1.Size = new System.Drawing.Size(95, 26);
            this.LB_Naam_P1.TabIndex = 8;
            this.LB_Naam_P1.Text = "Naam:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 554);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CB_Modelselector_player1
            // 
            this.CB_Modelselector_player1.FormattingEnabled = true;
            this.CB_Modelselector_player1.Location = new System.Drawing.Point(213, 81);
            this.CB_Modelselector_player1.Name = "CB_Modelselector_player1";
            this.CB_Modelselector_player1.Size = new System.Drawing.Size(259, 34);
            this.CB_Modelselector_player1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Imperial One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSTB_player1_Stats,
            this.toolStripSeparator1,
            this.tSTB_player1_Buffs,
            this.toolStripSeparator2,
            this.tSTB_player1_Rules});
            this.toolStrip1.Location = new System.Drawing.Point(213, 118);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(177, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "TS_player1";
            // 
            // tSTB_player1_Stats
            // 
            this.tSTB_player1_Stats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tSTB_player1_Stats.Name = "tSTB_player1_Stats";
            this.tSTB_player1_Stats.Size = new System.Drawing.Size(50, 22);
            this.tSTB_player1_Stats.Text = "Stats";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSTB_player1_Buffs
            // 
            this.tSTB_player1_Buffs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tSTB_player1_Buffs.Name = "tSTB_player1_Buffs";
            this.tSTB_player1_Buffs.Size = new System.Drawing.Size(51, 22);
            this.tSTB_player1_Buffs.Text = "Buffs";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSTB_player1_Rules
            // 
            this.tSTB_player1_Rules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tSTB_player1_Rules.Name = "tSTB_player1_Rules";
            this.tSTB_player1_Rules.Size = new System.Drawing.Size(52, 22);
            this.tSTB_player1_Rules.Text = "Rules";
            // 
            // TB_playerNaam1
            // 
            this.TB_playerNaam1.Location = new System.Drawing.Point(320, 40);
            this.TB_playerNaam1.Name = "TB_playerNaam1";
            this.TB_playerNaam1.ReadOnly = true;
            this.TB_playerNaam1.Size = new System.Drawing.Size(223, 34);
            this.TB_playerNaam1.TabIndex = 2;
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
            this.Player2.Controls.Add(this.label1);
            this.Player2.Controls.Add(this.BoxItemRulings_player2);
            this.Player2.Controls.Add(this.CB_Modelselector_player2);
            this.Player2.Controls.Add(this.toolStrip2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naam:";
            // 
            // BoxItemRulings_player2
            // 
            this.BoxItemRulings_player2.Location = new System.Drawing.Point(6, 133);
            this.BoxItemRulings_player2.Multiline = true;
            this.BoxItemRulings_player2.Name = "BoxItemRulings_player2";
            this.BoxItemRulings_player2.ReadOnly = true;
            this.BoxItemRulings_player2.Size = new System.Drawing.Size(332, 554);
            this.BoxItemRulings_player2.TabIndex = 6;
            this.BoxItemRulings_player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CB_Modelselector_player2
            // 
            this.CB_Modelselector_player2.FormattingEnabled = true;
            this.CB_Modelselector_player2.Location = new System.Drawing.Point(79, 73);
            this.CB_Modelselector_player2.Name = "CB_Modelselector_player2";
            this.CB_Modelselector_player2.Size = new System.Drawing.Size(259, 34);
            this.CB_Modelselector_player2.TabIndex = 5;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Imperial One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.toolStripLabel3});
            this.toolStrip2.Location = new System.Drawing.Point(163, 111);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(177, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "TS_player1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Stats";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "Buffs";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel3.Text = "Rules";
            // 
            // TB_playerNaam2
            // 
            this.TB_playerNaam2.Location = new System.Drawing.Point(6, 33);
            this.TB_playerNaam2.Name = "TB_playerNaam2";
            this.TB_playerNaam2.ReadOnly = true;
            this.TB_playerNaam2.Size = new System.Drawing.Size(226, 34);
            this.TB_playerNaam2.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fase";
            // 
            // TB_Fase
            // 
            this.TB_Fase.Location = new System.Drawing.Point(576, 322);
            this.TB_Fase.Name = "TB_Fase";
            this.TB_Fase.ReadOnly = true;
            this.TB_Fase.Size = new System.Drawing.Size(93, 34);
            this.TB_Fase.TabIndex = 11;
            this.TB_Fase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_volgendeRonde
            // 
            this.BT_volgendeRonde.Location = new System.Drawing.Point(675, 255);
            this.BT_volgendeRonde.Name = "BT_volgendeRonde";
            this.BT_volgendeRonde.Size = new System.Drawing.Size(38, 34);
            this.BT_volgendeRonde.TabIndex = 12;
            this.BT_volgendeRonde.Text = ">";
            this.BT_volgendeRonde.UseVisualStyleBackColor = true;
            // 
            // BT_volgendeFase
            // 
            this.BT_volgendeFase.Location = new System.Drawing.Point(675, 321);
            this.BT_volgendeFase.Name = "BT_volgendeFase";
            this.BT_volgendeFase.Size = new System.Drawing.Size(38, 34);
            this.BT_volgendeFase.TabIndex = 13;
            this.BT_volgendeFase.Text = ">";
            this.BT_volgendeFase.UseVisualStyleBackColor = true;
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
            // MiniToLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BT_DiceTool);
            this.Controls.Add(this.BT_volgendeFase);
            this.Controls.Add(this.BT_volgendeRonde);
            this.Controls.Add(this.TB_Fase);
            this.Controls.Add(this.label3);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_player1)).EndInit();
            this.Player2.ResumeLayout(false);
            this.Player2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox CB_Modelselector_player1;
        private System.Windows.Forms.ToolStripLabel tSTB_player1_Stats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tSTB_player1_Buffs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tSTB_player1_Rules;
        private System.Windows.Forms.ComboBox CB_Modelselector_player2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BoxItemRulings_player2;
        private System.Windows.Forms.TextBox TB_Ronde;
        private System.Windows.Forms.Label LB_Naam_P1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Fase;
        private System.Windows.Forms.Button BT_volgendeRonde;
        private System.Windows.Forms.Button BT_volgendeFase;
        private System.Windows.Forms.Button BT_DiceTool;
    }
}

