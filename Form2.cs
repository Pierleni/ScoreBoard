using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoard
{
    public partial class Form2 : Form
    {                
        Form1 display = new Form1();
        Form1 mirror = new Form1();

        Timer myTimer = new Timer();

        public int m, s, cent, totalSeconds, scoreA, scoreB, foulsA, foulsB;
        bool pause;
        
        public Form2()
        {
            InitializeComponent();

            myTimer.Interval = 100;
            myTimer.Tick += new EventHandler(myTimer_Tick);
            myTimer.Enabled = false;
            pause = false;

            if (ComboBoxMinutes.SelectedItem != null) m = int.Parse(ComboBoxMinutes.Text);
            if (ComboBoxSeconds.SelectedItem != null) s = int.Parse(ComboBoxSeconds.Text);
            cent = 0;
            scoreA = 0;
            scoreB = 0;
            foulsA = 0;
            foulsB = 0;

            // Populate ComboBoxes
            for (int i=0; i<60; i++){
                ComboBoxMinutes.Items.Add(i.ToString());
                ComboBoxSeconds.Items.Add(i.ToString());
            }
            
            InitiateStats();
            
            display.Show();

            mirror.Size = new System.Drawing.Size(400,300);
            mirror.Show();
        }
        ///////////////////////
        //  I N I T I A T E  //
        ///////////////////////

        public void InitiateStats(){
            // Set Timer
            TimerDisplay.Text = $"{m.ToString().PadLeft(2,'0')}:{s.ToString().PadLeft(2,'0')}.{cent.ToString()}";
            
            // Set Score to Zero
            SCORES_A.Text = scoreA.ToString().PadLeft(2,'0');
            SCORES_B.Text = scoreB.ToString().PadLeft(2,'0');

            // Default Zeros on ComboText
            ComboBoxMinutes.Text = "0";
            ComboBoxSeconds.Text = "0";
        }
        
        /////////////////////////////////////
        //   D I S P L A Y - U P D A T E S //
        /////////////////////////////////////

        public void updateScoreA(){
            SCORES_A.Text = scoreA.ToString().PadLeft(2,'0');
            display.displayHome = scoreA.ToString().PadLeft(2,'0');
            mirror.displayHome = scoreA.ToString().PadLeft(2,'0');
        }
        public void updateScoreB(){
            SCORES_B.Text = scoreB.ToString().PadLeft(2,'0');
            display.displayGuest = scoreB.ToString().PadLeft(2,'0');
            mirror.displayGuest = scoreB.ToString().PadLeft(2,'0');
        }
        public void updateTimers(){
            TimerDisplay.Text = $"{m.ToString().PadLeft(2,'0')}:{s.ToString().PadLeft(2,'0')}.{cent.ToString()}";
            display.displayTimer = $"{m.ToString().PadLeft(2,'0')}:{s.ToString().PadLeft(2,'0')}.{cent.ToString()}";
            mirror.displayTimer = $"{m.ToString().PadLeft(2,'0')}:{s.ToString().PadLeft(2,'0')}.{cent.ToString()}";
        }
        public void updateTeamsName(string inputA, string inputB){
            string name_A = inputA;
            string name_B = inputB;
            if (name_A.Length > 10) name_A = inputA[0..10];
            if (name_B.Length > 10) name_B = inputB[0..10];
            display.displayHomeName = name_A;
            display.displayGuestName = name_B;
            mirror.displayHomeName = name_A;
            mirror.displayGuestName = name_B;
        }

        ///////////////////////
        //      K E Y S      //
        ///////////////////////

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (TextBoxA.Focused == false & TextBoxB.Focused == false) 
            {
            
                switch (e.KeyCode) {
                    case Keys.A:
                    scoreA++;
                    updateScoreA();
                    break;

                    case Keys.Z:
                    scoreA--;
                    if (scoreA < 0) scoreA = 0;
                    updateScoreA();
                    break;

                    case Keys.K:
                    scoreB++;
                    updateScoreB();
                    break;

                    case Keys.M:
                    scoreB--;
                    if (scoreB < 0) scoreB = 0;
                    updateScoreB();
                    break;

                    case Keys.Space:
                    if (BtnSet.Enabled == false){
                        pause = !pause;
                        timerStopRestart(pause);
                    }
                    break;
                }
            }
            else if (TextBoxA.Focused == true | TextBoxB.Focused == true) {
                
                switch (e.KeyCode) {
                    case Keys.Enter:
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(this, true, true, false, false);
                    updateTeamsName(TextBoxA.Text.ToUpper(), TextBoxB.Text.ToUpper());
                    break;
                }
            }
        }

        ///////////////////////
        //   B U T T O N S   //
        ///////////////////////
        // Timer Set
        public void BtnSet_Click(object sender, EventArgs e){
            m = int.Parse(ComboBoxMinutes.Text);
            s = int.Parse(ComboBoxSeconds.Text);
            totalSeconds = ((m * 60) + s) * 10;              // Total Seconds
            
            updateTimers();

            BtnSTART.Focus();
        }

        // Btn START
        public void BtnStart_Click(object sender, EventArgs e){
            myTimer.Enabled = true;
            pause = false;

            BtnSet.Enabled = false;
            BtnSet.BackColor = Color.LightGray;

            Button10.Focus();                   // DSPLY
            BtnSTART.BackColor = Color.LightGray;     // START COLOR

            timerStopRestart(pause);
        }

        // Btn Reset
        public void btnReset_Click(object sender, EventArgs e){
            if (pause == true){
                m = 0;
                s = 0;
                cent = 0;
                totalSeconds = 0;

                updateTimers();

                BtnSet.Enabled = true;
                BtnSet.BackColor = Color.Gold;
                BtnSTART.BackColor = Color.SpringGreen;

                BtnSTOP.BackColor = Color.Tomato;
                BtnSTOP.Text = "STOP";
            }
        }

        ///////////////////////
        //     T I M E R     //
        ///////////////////////
        
        public void myTimer_Tick(object sender, EventArgs e) {
            if (totalSeconds > 0){
                totalSeconds--;

                m = (totalSeconds/10) / 60;
                s = (totalSeconds/10) - (m * 60);
                cent = totalSeconds % 10;
            }

            updateTimers();
        }

        public void timerStopRestart(bool status){
            if (status == true) {
                myTimer.Stop();

                BtnRESET.Enabled = true;
                BtnRESET.BackColor = Color.Gold;

                BtnSTOP.BackColor = Color.SpringGreen;
                BtnSTOP.Text = "START";
                
            }
            else if (status == false) {
                myTimer.Start();

                BtnRESET.Enabled = false;
                BtnRESET.BackColor = Color.LightGray;

                BtnSTOP.BackColor = Color.Tomato;
                BtnSTOP.Text = "STOP";
            }
        }
    }
}
