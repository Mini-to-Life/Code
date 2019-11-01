namespace Mini_to_Life
{
    partial class DiceTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceTool));
            this.NUD_D3 = new System.Windows.Forms.NumericUpDown();
            this.NUD_D6 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_DL = new System.Windows.Forms.CheckBox();
            this.CB_R1 = new System.Windows.Forms.CheckBox();
            this.TB_Totaal_D3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Rolled_D3 = new System.Windows.Forms.TextBox();
            this.BT_rollDice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Rolled_D6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Totaal_D6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_D6)).BeginInit();
            this.SuspendLayout();
            // 
            // NUD_D3
            // 
            this.NUD_D3.Location = new System.Drawing.Point(499, 12);
            this.NUD_D3.Name = "NUD_D3";
            this.NUD_D3.Size = new System.Drawing.Size(120, 34);
            this.NUD_D3.TabIndex = 0;
            // 
            // NUD_D6
            // 
            this.NUD_D6.Location = new System.Drawing.Point(499, 52);
            this.NUD_D6.Name = "NUD_D6";
            this.NUD_D6.Size = new System.Drawing.Size(120, 34);
            this.NUD_D6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "D6:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "D3:";
            // 
            // CB_DL
            // 
            this.CB_DL.AutoSize = true;
            this.CB_DL.Location = new System.Drawing.Point(13, 13);
            this.CB_DL.Name = "CB_DL";
            this.CB_DL.Size = new System.Drawing.Size(236, 30);
            this.CB_DL.TabIndex = 4;
            this.CB_DL.Text = "Discard lowest";
            this.CB_DL.UseVisualStyleBackColor = true;
            // 
            // CB_R1
            // 
            this.CB_R1.AutoSize = true;
            this.CB_R1.Location = new System.Drawing.Point(13, 49);
            this.CB_R1.Name = "CB_R1";
            this.CB_R1.Size = new System.Drawing.Size(169, 30);
            this.CB_R1.TabIndex = 6;
            this.CB_R1.Text = "Re-roll 1\'s";
            this.CB_R1.UseVisualStyleBackColor = true;
            // 
            // TB_Totaal_D3
            // 
            this.TB_Totaal_D3.Location = new System.Drawing.Point(519, 134);
            this.TB_Totaal_D3.Name = "TB_Totaal_D3";
            this.TB_Totaal_D3.ReadOnly = true;
            this.TB_Totaal_D3.Size = new System.Drawing.Size(100, 34);
            this.TB_Totaal_D3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Totaal:";
            // 
            // TB_Rolled_D3
            // 
            this.TB_Rolled_D3.Location = new System.Drawing.Point(93, 134);
            this.TB_Rolled_D3.Multiline = true;
            this.TB_Rolled_D3.Name = "TB_Rolled_D3";
            this.TB_Rolled_D3.ReadOnly = true;
            this.TB_Rolled_D3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Rolled_D3.Size = new System.Drawing.Size(398, 134);
            this.TB_Rolled_D3.TabIndex = 10;
            // 
            // BT_rollDice
            // 
            this.BT_rollDice.Location = new System.Drawing.Point(12, 97);
            this.BT_rollDice.Name = "BT_rollDice";
            this.BT_rollDice.Size = new System.Drawing.Size(81, 34);
            this.BT_rollDice.TabIndex = 11;
            this.BT_rollDice.Text = "Roll";
            this.BT_rollDice.UseVisualStyleBackColor = true;
            this.BT_rollDice.Click += new System.EventHandler(this.BT_rollDice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "D6:";
            // 
            // TB_Rolled_D6
            // 
            this.TB_Rolled_D6.Location = new System.Drawing.Point(93, 274);
            this.TB_Rolled_D6.Multiline = true;
            this.TB_Rolled_D6.Name = "TB_Rolled_D6";
            this.TB_Rolled_D6.ReadOnly = true;
            this.TB_Rolled_D6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Rolled_D6.Size = new System.Drawing.Size(398, 134);
            this.TB_Rolled_D6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "D3:";
            // 
            // TB_Totaal_D6
            // 
            this.TB_Totaal_D6.Location = new System.Drawing.Point(519, 274);
            this.TB_Totaal_D6.Name = "TB_Totaal_D6";
            this.TB_Totaal_D6.ReadOnly = true;
            this.TB_Totaal_D6.Size = new System.Drawing.Size(100, 34);
            this.TB_Totaal_D6.TabIndex = 15;
            // 
            // DiceTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 418);
            this.Controls.Add(this.TB_Totaal_D6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Rolled_D6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_rollDice);
            this.Controls.Add(this.TB_Rolled_D3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Totaal_D3);
            this.Controls.Add(this.CB_R1);
            this.Controls.Add(this.CB_DL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_D6);
            this.Controls.Add(this.NUD_D3);
            this.Font = new System.Drawing.Font("Imperial One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "DiceTool";
            this.Text = "Mini-to-Life Dice Tool";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_D6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUD_D3;
        private System.Windows.Forms.NumericUpDown NUD_D6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CB_DL;
        private System.Windows.Forms.CheckBox CB_R1;
        private System.Windows.Forms.TextBox TB_Totaal_D3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Rolled_D3;
        private System.Windows.Forms.Button BT_rollDice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Rolled_D6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Totaal_D6;
    }
}