using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Soldier Computer { get; set; }
        private Soldier Player { get; set; }
        private int attempsleft { get; set; }

        Random randomizer = new Random();
        
        // store numbers for the math problem. 
        int addend1;
        int addend2;
        int add1;
        int add2;
        int multiply1;
        int multiply2;
        int attempsleftreset = 3;

        public Form1()
        {
            InitializeComponent();

            Computer = new Soldier();
            Player = new Soldier();

            ResetGUI();
        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            Player.Action = Actions.Shoot;
            Computer.GenerateRandomAction();

            if (Computer.Action == Actions.Shotgun)
            {
                AnnounceWinner("Computer");
            }
            else if (Computer.Action == Actions.Load)
            {
                AnnounceWinner("Player");
            }
            else if (Computer.Action == Actions.Block)
            {
                Player.AmmunitionCount--;

                if (Player.AmmunitionCount == 0)
                {
                    btnShoot.Enabled = false;
                }
            }
            else if (Computer.Action == Actions.Shoot)
            {
                Player.AmmunitionCount--;
                Computer.AmmunitionCount--;
            }

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblPlayerAction.Text = Player.Action.ToString();
            lblPlayerAmmunitionCount.Text = Player.AmmunitionCount.ToString();

            lblComputerAction.Text = Computer.Action.ToString();
            lblComputerAmmunitionCount.Text = Computer.AmmunitionCount.ToString();
        }

        private void ResetGUI()
        {
            lblWinner.Text = string.Empty;
            btnRestart.Enabled = false;

            lblPlayerAction.Text = "-";
            lblPlayerAmmunitionCount.Text = "-";

            lblComputerAction.Text = "-";
            lblComputerAmmunitionCount.Text = "-";

            btnShoot.Enabled = false;
            btnShotgun.Enabled = false;
            btnBlock.Enabled = true;
            btnLoad.Enabled = true;
        }

        private void AnnounceWinner(string winner)
        {
            lblWinner.Text = winner + " won the game";
            LockControls();
            btnRestart.Enabled = true;
        }

        private void LockControls()
        {
            btnShoot.Enabled = false;
            btnBlock.Enabled = false;
            btnLoad.Enabled = false;
            btnShotgun.Enabled = false;
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            Player.Action = Actions.Block;
            Computer.GenerateRandomAction();

            if (Computer.Action == Actions.Shotgun)
            {
                AnnounceWinner("Computer");
            }
            else if (Computer.Action == Actions.Load)
            {
                Computer.AmmunitionCount++;
            }
            else if (Computer.Action == Actions.Block)
            {

            }
            else if (Computer.Action == Actions.Shoot)
            {
                Computer.AmmunitionCount--;
            }

            UpdateLabels();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Player.Action = Actions.Load;
            Computer.GenerateRandomAction();

            if (Computer.Action == Actions.Shotgun)
            {
                AnnounceWinner("Computer");
            }
            else if (Computer.Action == Actions.Load)
            {
                Computer.AmmunitionCount++;
                Player.AmmunitionCount++;

                btnShoot.Enabled = true;
            }
            else if (Computer.Action == Actions.Block)
            {
                Player.AmmunitionCount++;
                btnShoot.Enabled = true;
            }
            else if (Computer.Action == Actions.Shoot)
            {
                AnnounceWinner("Computer");
            }

            if (Player.AmmunitionCount < 3)
            {
                btnShotgun.Enabled = false;
            }
            else
            {
                btnShotgun.Enabled = true;
            }

            UpdateLabels();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            //resets the whole application
            Player.Reset();
            Computer.Reset();
            
            //added this
            SvarBtn.Enabled = true;
            StartBtn.Enabled = true;

            ResetGUI();
            StartQuiz();
        }

        private void BtnShotgun_Click(object sender, EventArgs e)
        {
            Player.Action = Actions.Shotgun;
            Player.AmmunitionCount -= 3;
            Computer.GenerateRandomAction();

            AnnounceWinner("Player");
            ResetGUI();

            UpdateLabels();
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartQuiz();
            //resets the attemps left to 3.
            attempsleft = attempsleftreset;
            label6.Text = "";
            StartBtn.Enabled = false;
        }
        private void StartQuiz()
        {
            addend1 = randomizer.Next(10);
            addend2 = randomizer.Next(10);

            add1 = randomizer.Next(10);
            add2 = randomizer.Next(10);

            multiply1 = randomizer.Next(10);
            multiply2 = randomizer.Next(10);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            PlusLeftLbl.Text = addend1.ToString();
            PlusRightLbl.Text = addend2.ToString();

            SumLeftLbl.Text = add1.ToString();
            SumRightLbl.Text = add2.ToString();

            MultiplyLeftLbl.Text = multiply1.ToString();
            MultiplyRightLbl.Text = multiply2.ToString();

            Sum.Value = 0;
            Difference.Value = 0;
            Product.Value = 0;
        }
        private bool CheckAnswer()
        {
            if (addend1 + addend2 == Sum.Value && add1 + add2 == Difference.Value && multiply1 * multiply2 == Product.Value)
                return true;
            else
            {
                return false;
            }
        }
        private void SvarBtn_Click(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                Player.Action = Actions.Shotgun;
                Player.AmmunitionCount = 3;
                Computer.GenerateRandomAction();

                AnnounceWinner("Player");
                StartBtn.Enabled = false;
                SvarBtn.Enabled = false;
                UpdateLabels();
                
            }
            // If CheckTheAnswer() return false, keep counting down attempsleft
            else if (attempsleft > 0)
            {
                attempsleft--;
                label6.Text = attempsleft + " tries left ";

            }
            else
            {                
                label6.Text = "Your tries are up!";
                MessageBox.Show("You didn't answer correctly ", "Sorry");
                StartBtn.Enabled = false;
                SvarBtn.Enabled = false;
                Sum.Value = 0;
                Difference.Value = 0;
                Product.Value = 0;
                
            }         
        }
    }
}
