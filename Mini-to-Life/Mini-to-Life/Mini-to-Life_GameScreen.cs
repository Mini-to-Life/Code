using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_to_Life
{
    public partial class MiniToLife : Form
    {
        List<string> MiniP1 = new List<string>();
        List<string> MiniP2 = new List<string>();
        int RondeCount = 0;
        public MiniToLife(List<string> listP1, List<string> listP2)
        {
            this.MiniP1 = listP1;
            this.MiniP2 = listP2;
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            System.Threading.Thread.Sleep(5000);
            Cursor.Current = Cursors.Default;
            TB_Ronde.Text = Convert.ToString(RondeCount);
            string Naam1 = "Player 1";
            string Naam2 = "Player 2";
            TB_playerNaam1.Text = Naam1;
            TB_playerNaam2.Text = Naam2;
            foreach (string itemP1 in MiniP1)
            {
                CB_Modelselector_player1.Items.Add(itemP1);
            }
            foreach (string itemP2 in MiniP2)
            {
                CB_Modelselector_player2.Items.Add(itemP2);
            }

        }

        private void PB_logo_Click(object sender, EventArgs e)
        {
            MiniToLifePlayerRegister settingsForm = new MiniToLifePlayerRegister(null);
            settingsForm.Show();
            this.Close();
        }

        private void BT_DiceTool_Click(object sender, EventArgs e)
        {
            DiceTool settingsForm = new DiceTool();
            settingsForm.Show();
        }

        private void P1_Stats_Clicked(object sender, EventArgs e)
        {
            if (CB_Modelselector_player1.SelectedIndex == 0)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t6''" + System.Environment.NewLine +
                    "- Weapon Skill\t2+" + System.Environment.NewLine +
                    "- Balistic Skill\t2+" + System.Environment.NewLine +
                    "- Strength\t4" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t6" + System.Environment.NewLine +
                    "- Attacks\t\t6" + System.Environment.NewLine +
                    "- Leadership\t8" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 1)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t6''" + System.Environment.NewLine +
                    "- Weapon Skill\t2+" + System.Environment.NewLine +
                    "- Balistic Skill\t3+" + System.Environment.NewLine +
                    "- Strength\t4" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t5" + System.Environment.NewLine +
                    "- Attacks\t\t5" + System.Environment.NewLine +
                    "- Leadership\t8" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 2)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t6''" + System.Environment.NewLine +
                    "- Weapon Skill\t3+" + System.Environment.NewLine +
                    "- Balistic Skill\t4+" + System.Environment.NewLine +
                    "- Strength\t4" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t3" + System.Environment.NewLine +
                    "- Attacks\t\t3" + System.Environment.NewLine +
                    "- Leadership\t7" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 3)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t6''" + System.Environment.NewLine +
                    "- Weapon Skill\t3+" + System.Environment.NewLine +
                    "- Balistic Skill\t4+" + System.Environment.NewLine +
                    "- Strength\t4" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t3" + System.Environment.NewLine +
                    "- Attacks\t\t3" + System.Environment.NewLine +
                    "- Leadership\t7" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 4)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t6''" + System.Environment.NewLine +
                    "- Weapon Skill\t3+" + System.Environment.NewLine +
                    "- Balistic Skill\t4+" + System.Environment.NewLine +
                    "- Strength\t4" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t3" + System.Environment.NewLine +
                    "- Attacks\t\t3" + System.Environment.NewLine +
                    "- Leadership\t7" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_1.Text = Text;
            }
        }

        private void P2_Stats_Clicked(object sender, EventArgs e)
        {
            if (CB_Modelselector_player2.SelectedIndex == 0)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t5''" + System.Environment.NewLine +
                    "- Weapon Skill\t2+" + System.Environment.NewLine +
                    "- Balistic Skill\t2+" + System.Environment.NewLine +
                    "- Strength\t5" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t7" + System.Environment.NewLine +
                    "- Attacks\t\t4" + System.Environment.NewLine +
                    "- Leadership\t9" + System.Environment.NewLine +
                    "- Save\t\t2+";
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 1)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t5''" + System.Environment.NewLine +
                    "- Weapon Skill\t3+" + System.Environment.NewLine +
                    "- Balistic Skill\t2+" + System.Environment.NewLine +
                    "- Strength\t5" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t6" + System.Environment.NewLine +
                    "- Attacks\t\t3" + System.Environment.NewLine +
                    "- Leadership\t9" + System.Environment.NewLine +
                    "- Save\t\t2+";
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 2)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t5''" + System.Environment.NewLine +
                    "- Weapon Skill\t4+" + System.Environment.NewLine +
                    "- Balistic Skill\t3+" + System.Environment.NewLine +
                    "- Strength\t5" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t4" + System.Environment.NewLine +
                    "- Attacks\t\t2" + System.Environment.NewLine +
                    "- Leadership\t8" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 3)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t5''" + System.Environment.NewLine +
                    "- Weapon Skill\t4+" + System.Environment.NewLine +
                    "- Balistic Skill\t3+" + System.Environment.NewLine +
                    "- Strength\t5" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t4" + System.Environment.NewLine +
                    "- Attacks\t\t2" + System.Environment.NewLine +
                    "- Leadership\t8" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 4)
            {
                string Text = "STATS:" + System.Environment.NewLine +
                    "- Movement\t5''" + System.Environment.NewLine +
                    "- Weapon Skill\t4+" + System.Environment.NewLine +
                    "- Balistic Skill\t3+" + System.Environment.NewLine +
                    "- Strength\t5" + System.Environment.NewLine +
                    "- Toughness\t4" + System.Environment.NewLine +
                    "- Wounds\t\t4" + System.Environment.NewLine +
                    "- Attacks\t\t2" + System.Environment.NewLine +
                    "- Leadership\t8" + System.Environment.NewLine +
                    "- Save\t\t3+";
                TB_Player_2.Text = Text;
            }
        }

        private void BT_volgendeRonde_Click(object sender, EventArgs e)
        {
            RondeCount++;
            TB_Ronde.Text = Convert.ToString(RondeCount);
        }
        private void P2_Rules_Clicked(object sender, EventArgs e)
        {
            if (CB_Modelselector_player2.SelectedIndex == 0)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- StormGauntlet" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t12''" + System.Environment.NewLine +
                    "  Type\tPistol 3" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine +
                    "  - Quick draw: This weapon can be used whilst within 1'' of enemy units" + System.Environment.NewLine +
                    "(Melee)" + System.Environment.NewLine +
                    "  Range\tmelee" + System.Environment.NewLine +
                    "  Type\tmelee" + System.Environment.NewLine +
                    "  Strengt\t+2" + System.Environment.NewLine +
                    "  AP\t-2" + System.Environment.NewLine +
                    "  Damage\tD3" + System.Environment.NewLine + System.Environment.NewLine +
                    "- ForgeHammer" + System.Environment.NewLine +
                    "(Melee)" + System.Environment.NewLine +
                    "  Range\tmelee" + System.Environment.NewLine +
                    "  Type\tmelee" + System.Environment.NewLine +
                    "  Strengt\tx2" + System.Environment.NewLine +
                    "  AP\t-3" + System.Environment.NewLine +
                    "  Damage\t3" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Unbalanced: -1 to hit";
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 1)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Plasma Gun" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t36''" + System.Environment.NewLine +
                    "  Type\tHeavy 2" + System.Environment.NewLine +
                    "  Strengt\t7" + System.Environment.NewLine +
                    "  AP\t-2" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine +
                    "(Ranged Overcharge)" + System.Environment.NewLine +
                    "  Range\t36''" + System.Environment.NewLine +
                    "  Type\tHeavy 2" + System.Environment.NewLine +
                    "  Strengt\t8" + System.Environment.NewLine +
                    "  AP\t-3" + System.Environment.NewLine +
                    "  Damage\t2" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Meltdown: when this weapon is Overcharged, on a unmodified hit-roll of 1, the wielder recieves 1 mortal wound" + System.Environment.NewLine + System.Environment.NewLine +
                    "- Bolt Pistol" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t12''" + System.Environment.NewLine +
                    "  Type\tpistol 1" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Quick draw: This weapon can be used whilst within 1'' of enemy units";
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 2)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Stalker Bolt Gun" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t36''" + System.Environment.NewLine +
                    "  Type\tHeavy 2" + System.Environment.NewLine +
                    "  Strengt\t5" + System.Environment.NewLine +
                    "  AP\t-1" + System.Environment.NewLine +
                    "  Damage\t2" + System.Environment.NewLine;
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 3)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Stalker Bolt Gun" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t36''" + System.Environment.NewLine +
                    "  Type\tHeavy 2" + System.Environment.NewLine +
                    "  Strengt\t5" + System.Environment.NewLine +
                    "  AP\t-1" + System.Environment.NewLine +
                    "  Damage\t2" + System.Environment.NewLine;
                TB_Player_2.Text = Text;
            }
            else if (CB_Modelselector_player2.SelectedIndex == 4)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Stalker Bolt Gun" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t36''" + System.Environment.NewLine +
                    "  Type\tHeavy 2" + System.Environment.NewLine +
                    "  Strengt\t5" + System.Environment.NewLine +
                    "  AP\t-1" + System.Environment.NewLine +
                    "  Damage\t2" + System.Environment.NewLine;
                TB_Player_2.Text = Text;
            }
        }

        private void P1_Rules_Clicked(object sender, EventArgs e)
        {
            if (CB_Modelselector_player1.SelectedIndex == 0)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Plasma Pistol" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t12''" + System.Environment.NewLine +
                    "  Type\tPistol 1" + System.Environment.NewLine +
                    "  Strengt\t7" + System.Environment.NewLine +
                    "  AP\t-1" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine +
                    "(Ranged Overcharge)" + System.Environment.NewLine +
                    "  Range\t12''" + System.Environment.NewLine +
                    "  Type\tPistol 1" + System.Environment.NewLine +
                    "  Strengt\t8" + System.Environment.NewLine +
                    "  AP\t-2" + System.Environment.NewLine +
                    "  Damage\t2" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Meltdown: when this weapon is Overcharged, on a unmodified hit-roll of 1, the wielder recieves 1 mortal wound" + System.Environment.NewLine +
                    "  - Quick draw: This weapon can be used whilst within 1'' of enemy units" + System.Environment.NewLine + System.Environment.NewLine +
                    "- Power sword" + System.Environment.NewLine +
                    "(Melee)" + System.Environment.NewLine +
                    "  Range\tmelee" + System.Environment.NewLine +
                    "  Type\tmelee" + System.Environment.NewLine +
                    "  Strengt\t+2" + System.Environment.NewLine +
                    "  AP\t-3" + System.Environment.NewLine +
                    "  Damage\t2" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Skilled: Make 1 additional attack whit this weapon";
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 1)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Absolver Bolt Pistol" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t16''" + System.Environment.NewLine +
                    "  Type\tPistol 1" + System.Environment.NewLine +
                    "  Strengt\t5" + System.Environment.NewLine +
                    "  AP\t-1" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine + System.Environment.NewLine +
                    "- Astartes Combat Knife" + System.Environment.NewLine +
                    "(Melee)" + System.Environment.NewLine +
                    "  Range\tmelee" + System.Environment.NewLine +
                    "  Type\tmelee" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Skilled: Make 1 additional attack whit this weapon";
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 2)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Assault Bolter" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t24''" + System.Environment.NewLine +
                    "  Type\tassault 3" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine;
                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 3)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Assault Bolter" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t24''" + System.Environment.NewLine +
                    "  Type\tassault 3" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine + System.Environment.NewLine +
                    "- M203" + System.Environment.NewLine +
                    "(Ranged Attachment)" + System.Environment.NewLine +
                    "  Range\t24''" + System.Environment.NewLine +
                    "  Type\tAttachment D3" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine +
                    "  Additional Rules:" + System.Environment.NewLine +
                    "  - Attachment: You can fire this weapon in addition with the weapon it is attached to" + System.Environment.NewLine +
                    "  - Combi-weapon: This Item is attached to [Assault Bolter]";

                TB_Player_1.Text = Text;
            }
            else if (CB_Modelselector_player1.SelectedIndex == 4)
            {
                string Text = "RULES:" + System.Environment.NewLine +
                    "- Assault Bolter" + System.Environment.NewLine +
                    "(Ranged)" + System.Environment.NewLine +
                    "  Range\t24''" + System.Environment.NewLine +
                    "  Type\tassault 3" + System.Environment.NewLine +
                    "  Strengt\t4" + System.Environment.NewLine +
                    "  AP\t0" + System.Environment.NewLine +
                    "  Damage\t1" + System.Environment.NewLine;
                TB_Player_1.Text = Text;
            }
        }

    }
}
