namespace ScoreBoard
{
    partial class Form2
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
            this.SplitContainer0 = new System.Windows.Forms.SplitContainer();
            this.ComboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.ComboBoxSeconds = new System.Windows.Forms.ComboBox();
            this.Label0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnSet = new System.Windows.Forms.Button();
            this.TimerDisplay = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.SCORES_A = new System.Windows.Forms.Label();
            this.SCORES_B = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.PlusPointA = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.MinusPointA = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.PlusPointB = new System.Windows.Forms.Button();
            this.MinusPointB = new System.Windows.Forms.Button();
            this.CLR_A = new System.Windows.Forms.Button();
            this.CLR_B = new System.Windows.Forms.Button();
            this.BtnSTART = new System.Windows.Forms.Button();
            this.BtnRESET = new System.Windows.Forms.Button();
            this.BtnSTOP = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.PlusFoulsA = new System.Windows.Forms.Button();
            this.MinusFoulsA = new System.Windows.Forms.Button();
            this.PlusFoulsB = new System.Windows.Forms.Button();
            this.MinusFoulsB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer0)).BeginInit();
            this.SplitContainer0.Panel1.SuspendLayout();
            this.SplitContainer0.Panel2.SuspendLayout();
            this.SplitContainer0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            //
            // SplitContainer0
            //
            this.SplitContainer0.Panel1.Controls.Add(this.ComboBoxMinutes);
            this.SplitContainer0.Panel1.Controls.Add(this.ComboBoxSeconds);
            this.SplitContainer0.Panel1.Controls.Add(this.Label0);
            this.SplitContainer0.Panel1.Controls.Add(this.Label1);
            this.SplitContainer0.Panel1.Controls.Add(this.BtnSet);
            this.SplitContainer0.Panel1.Controls.Add(this.TimerDisplay);
            this.SplitContainer0.Panel2.Controls.Add(this.SplitContainer1);
            this.SplitContainer0.Panel1.Controls.Add(this.BtnSTART);
            this.SplitContainer0.Panel1.Controls.Add(this.BtnSTOP);
            this.SplitContainer0.Panel1.Controls.Add(this.BtnRESET);
            this.SplitContainer0.Panel1.Controls.Add(this.Button10);
            this.SplitContainer0.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SplitContainer0.Text =  "SplitContainer0";
            this.SplitContainer0.BackColor = System.Drawing.Color.LemonChiffon;
            this.SplitContainer0.Location = new System.Drawing.Point(8,8);
            this.SplitContainer0.Name =  "SplitContainer0";
            this.SplitContainer0.Size = new System.Drawing.Size(768,464);
            this.SplitContainer0.SplitterDistance = 213;
            this.SplitContainer0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
            // ComboBoxMinutes
            //
            this.ComboBoxMinutes.DropDownWidth = 97;
            this.ComboBoxMinutes.ItemHeight = 15;
            this.ComboBoxMinutes.Location = new System.Drawing.Point(24,48);
            this.ComboBoxMinutes.Name =  "ComboBoxMinutes";
            this.ComboBoxMinutes.Size = new System.Drawing.Size(97,23);
            this.ComboBoxMinutes.TabIndex = 1;
            this.ComboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMinutes.Text =  "0";
            //
            // ComboBoxSeconds
            //
            this.ComboBoxSeconds.DropDownWidth = 96;
            this.ComboBoxSeconds.ItemHeight = 15;
            this.ComboBoxSeconds.Location = new System.Drawing.Point(144,48);
            this.ComboBoxSeconds.Name =  "ComboBoxSeconds";
            this.ComboBoxSeconds.Size = new System.Drawing.Size(96,23);
            this.ComboBoxSeconds.TabIndex = 2;
            this.ComboBoxSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSeconds.Text =  "0";
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label0.Text =  "Minutes";
            this.Label0.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(16,16);
            this.Label0.Name =  "Label0";
            this.Label0.Size = new System.Drawing.Size(82,28);
            this.Label0.TabIndex = 3;
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "Seconds";
            this.Label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(136,16);
            this.Label1.Name =  "Label1";
            this.Label1.Size = new System.Drawing.Size(85,28);
            this.Label1.TabIndex = 4;
            //
            // BtnSet
            //
            this.BtnSet.BackColor = System.Drawing.Color.Gold;
            this.BtnSet.Text =  "SET";
            this.BtnSet.Location = new System.Drawing.Point(24,80);
            this.BtnSet.Name =  "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(216,32);
            this.BtnSet.TabIndex = 1;
            this.BtnSet.Click += new System.EventHandler(BtnSet_Click);
            //
            // TimerDisplay
            //
            this.TimerDisplay.AutoSize =  true;
            this.TimerDisplay.Text =  "00:00.0";
            this.TimerDisplay.BackColor = System.Drawing.Color.LemonChiffon;
            this.TimerDisplay.Font = new System.Drawing.Font("Digital-7", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerDisplay.Location = new System.Drawing.Point(260,32);
            this.TimerDisplay.Name =  "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(231,93);
            this.TimerDisplay.TabIndex = 6;
            //
            // SplitContainer1
            //
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.TextBoxA);
            this.SplitContainer1.Panel2.Controls.Add(this.Label4);
            this.SplitContainer1.Panel2.Controls.Add(this.TextBoxB);
            this.SplitContainer1.Panel1.Controls.Add(this.SCORES_A);
            this.SplitContainer1.Panel2.Controls.Add(this.SCORES_B);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel2.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.PlusPointA);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.MinusPointA);
            this.SplitContainer1.Panel2.Controls.Add(this.Label10);
            this.SplitContainer1.Panel2.Controls.Add(this.PlusPointB);
            this.SplitContainer1.Panel2.Controls.Add(this.MinusPointB);
            this.SplitContainer1.Panel1.Controls.Add(this.CLR_A);
            this.SplitContainer1.Panel2.Controls.Add(this.CLR_B);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel2.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.PlusFoulsA);
            this.SplitContainer1.Panel1.Controls.Add(this.MinusFoulsA);
            this.SplitContainer1.Panel2.Controls.Add(this.PlusFoulsB);
            this.SplitContainer1.Panel2.Controls.Add(this.MinusFoulsB);
            this.SplitContainer1.Text =  "SplitContainer1";
            this.SplitContainer1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SplitContainer1.Name =  "SplitContainer1";
            this.SplitContainer1.Size = new System.Drawing.Size(768,296);
            this.SplitContainer1.TabIndex = 7;
            this.SplitContainer1.SplitterDistance = 377;
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //
            // Label3
            //
            this.Label3.AutoSize =  true;
            this.Label3.Text =  "Team A";
            this.Label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(8,24);
            this.Label3.Name =  "Label3";
            this.Label3.Size = new System.Drawing.Size(80,28);
            this.Label3.TabIndex = 8;
            //
            // TextBoxA
            //
            this.TextBoxA.Text =  "Home";
            this.TextBoxA.Modified =  true;
            this.TextBoxA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxA.Location = new System.Drawing.Point(88,24);
            this.TextBoxA.Name =  "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(280,25);
            this.TextBoxA.TabIndex = 9;
            
            //
            // Label4
            //
            this.Label4.AutoSize =  true;
            this.Label4.Text =  "Team B";
            this.Label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(8,24);
            this.Label4.Name =  "Label4";
            this.Label4.Size = new System.Drawing.Size(78,28);
            this.Label4.TabIndex = 10;
            //
            // TextBoxB
            //
            this.TextBoxB.Text =  "Guest";
            this.TextBoxB.Modified =  true;
            this.TextBoxB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxB.Location = new System.Drawing.Point(96,24);
            this.TextBoxB.Name =  "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(280,25);
            this.TextBoxB.TabIndex = 11;
            //
            // SCORES_A
            //
            this.SCORES_A.AutoSize =  true;
            this.SCORES_A.Text =  "00";
            this.SCORES_A.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SCORES_A.Font = new System.Drawing.Font("Digital-7", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SCORES_A.Location = new System.Drawing.Point(8,144);
            this.SCORES_A.Name =  "SCORES_A";
            this.SCORES_A.Size = new System.Drawing.Size(125,92);
            this.SCORES_A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SCORES_A.TabIndex = 12;
            //
            // SCORES_B
            //
            this.SCORES_B.AutoSize =  true;
            this.SCORES_B.Text =  "00";
            this.SCORES_B.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SCORES_B.Font = new System.Drawing.Font("Digital-7", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SCORES_B.Location = new System.Drawing.Point(248,144);
            this.SCORES_B.Name =  "SCORES_B";
            this.SCORES_B.Size = new System.Drawing.Size(125,92);
            this.SCORES_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SCORES_B.TabIndex = 13;
            //
            // Label7
            //
            this.Label7.AutoSize =  true;
            this.Label7.Text =  "0";
            this.Label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label7.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(304,168);
            this.Label7.Name =  "Label7";
            this.Label7.Size = new System.Drawing.Size(63,69);
            this.Label7.TabIndex = 14;
            //
            // Label8
            //
            this.Label8.AutoSize =  true;
            this.Label8.Text =  "0";
            this.Label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label8.Font = new System.Drawing.Font("Digital-7", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label8.Location = new System.Drawing.Point(8,168);
            this.Label8.Name =  "Label8";
            this.Label8.Size = new System.Drawing.Size(61,67);
            this.Label8.TabIndex = 15;
            //
            // PlusPointA
            //
            this.PlusPointA.BackColor = System.Drawing.Color.LightGreen;
            this.PlusPointA.Text =  "+1 (A)";
            this.PlusPointA.Location = new System.Drawing.Point(144,144);
            this.PlusPointA.Name =  "PlusPointA";
            this.PlusPointA.Size = new System.Drawing.Size(88,48);
            this.PlusPointA.TabIndex = 16;
            this.PlusPointA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlusPointA.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //
            // Label9
            //
            this.Label9.AutoSize =  true;
            this.Label9.Text =  "SCORES";
            this.Label9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label9.Location = new System.Drawing.Point(8,112);
            this.Label9.Name =  "Label9";
            this.Label9.Size = new System.Drawing.Size(68,21);
            this.Label9.TabIndex = 17;
            //
            // MinusPointA
            //
            this.MinusPointA.BackColor = System.Drawing.Color.Tomato;
            this.MinusPointA.Text =  "-1 (Z)";
            this.MinusPointA.Location = new System.Drawing.Point(144,192);
            this.MinusPointA.Name =  "MinusPointA";
            this.MinusPointA.Size = new System.Drawing.Size(88,48);
            this.MinusPointA.TabIndex = 18;
            this.MinusPointA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinusPointA.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //
            // Label10
            //
            this.Label10.AutoSize =  true;
            this.Label10.Text =  "SCORES";
            this.Label10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label10.Location = new System.Drawing.Point(312,112);
            this.Label10.Name =  "Label10";
            this.Label10.Size = new System.Drawing.Size(68,21);
            this.Label10.TabIndex = 19;
            //
            // PlusPointB
            //
            this.PlusPointB.BackColor = System.Drawing.Color.LightGreen;
            this.PlusPointB.Text =  "+1 (K)";
            this.PlusPointB.Location = new System.Drawing.Point(144,144);
            this.PlusPointB.Name =  "PlusPointB";
            this.PlusPointB.Size = new System.Drawing.Size(96,48);
            this.PlusPointB.TabIndex = 21;
            this.PlusPointB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlusPointB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //
            // MinusPointB
            //
            this.MinusPointB.BackColor = System.Drawing.Color.Tomato;
            this.MinusPointB.Text =  "-1 (M)";
            this.MinusPointB.Location = new System.Drawing.Point(144,192);
            this.MinusPointB.Name =  "MinusPointB";
            this.MinusPointB.Size = new System.Drawing.Size(96,48);
            this.MinusPointB.TabIndex = 22;
            this.MinusPointB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinusPointB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //
            // CLR_A
            //
            this.CLR_A.BackColor = System.Drawing.Color.Gold;
            this.CLR_A.Text =  "CLR";
            this.CLR_A.Location = new System.Drawing.Point(144,96);
            this.CLR_A.Name =  "CLR_A";
            this.CLR_A.Size = new System.Drawing.Size(88,48);
            this.CLR_A.TabIndex = 23;
            this.CLR_A.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //
            // CLR_B
            //
            this.CLR_B.BackColor = System.Drawing.Color.Gold;
            this.CLR_B.Text =  "CLR";
            this.CLR_B.Location = new System.Drawing.Point(144,96);
            this.CLR_B.Name =  "CLR_B";
            this.CLR_B.Size = new System.Drawing.Size(96,48);
            this.CLR_B.TabIndex = 24;
            this.CLR_B.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //
            // START
            //
            this.BtnSTART.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSTART.Text =  "START";
            this.BtnSTART.Location = new System.Drawing.Point(24,136);
            this.BtnSTART.Name =  "Button7";
            this.BtnSTART.Size = new System.Drawing.Size(216,64);
            this.BtnSTART.TabIndex = 2;
            this.BtnSTART.Click += new System.EventHandler(BtnStart_Click);
            //
            // Button8
            //
            this.BtnRESET.BackColor = System.Drawing.Color.Gold;
            this.BtnRESET.Text =  "RESET";
            this.BtnRESET.Location = new System.Drawing.Point(528,136);
            this.BtnRESET.Name =  "Button8";
            this.BtnRESET.Size = new System.Drawing.Size(216,64);
            this.BtnRESET.TabIndex = 25;
            this.BtnRESET.Click += new System.EventHandler(btnReset_Click);
            //
            // Button9
            //
            this.BtnSTOP.BackColor = System.Drawing.Color.Tomato;
            this.BtnSTOP.Text =  "STOP";
            this.BtnSTOP.Location = new System.Drawing.Point(288,136);
            this.BtnSTOP.Name =  "Button9";
            this.BtnSTOP.Size = new System.Drawing.Size(192,64);
            this.BtnSTOP.TabIndex = 26;
            //
            // Button10
            //
            this.Button10.BackColor = System.Drawing.Color.Black;
            this.Button10.Text =  "DSPLY";
            this.Button10.Location = new System.Drawing.Point(528,40);
            this.Button10.Name =  "Button10";
            this.Button10.Size = new System.Drawing.Size(216,72);
            this.Button10.TabIndex = 3;
            this.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //
            // Label11
            //
            this.Label11.AutoSize =  true;
            this.Label11.Text =  "FOULS";
            this.Label11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label11.Location = new System.Drawing.Point(304,144);
            this.Label11.Name =  "Label11";
            this.Label11.Size = new System.Drawing.Size(42,15);
            this.Label11.TabIndex = 28;
            //
            // Label12
            //
            this.Label12.AutoSize =  true;
            this.Label12.Text =  "FOULS";
            this.Label12.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Label12.Location = new System.Drawing.Point(24,144);
            this.Label12.Name =  "Label12";
            this.Label12.Size = new System.Drawing.Size(42,15);
            this.Label12.TabIndex = 29;
            //
            // PlusFoulsA
            //
            this.PlusFoulsA.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PlusFoulsA.Text =  "+ (S)";
            this.PlusFoulsA.Location = new System.Drawing.Point(240,144);
            this.PlusFoulsA.Name =  "PlusFoulsA";
            this.PlusFoulsA.Size = new System.Drawing.Size(48,48);
            this.PlusFoulsA.TabIndex = 30;
            //
            // MinusFoulsA
            //
            this.MinusFoulsA.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MinusFoulsA.Text =  "- (X)";
            this.MinusFoulsA.Location = new System.Drawing.Point(240,192);
            this.MinusFoulsA.Name =  "MinusFoulsA";
            this.MinusFoulsA.Size = new System.Drawing.Size(48,48);
            this.MinusFoulsA.TabIndex = 31;
            //
            // PlusFoulsB
            //
            this.PlusFoulsB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PlusFoulsB.Text =  "+ (J)";
            this.PlusFoulsB.Location = new System.Drawing.Point(80,144);
            this.PlusFoulsB.Name =  "PlusFoulsB";
            this.PlusFoulsB.Size = new System.Drawing.Size(56,48);
            this.PlusFoulsB.TabIndex = 32;
            //
            // MinusFoulsB
            //
            this.MinusFoulsB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MinusFoulsB.Text =  "_ (N)";
            this.MinusFoulsB.Location = new System.Drawing.Point(80,192);
            this.MinusFoulsB.Name =  "MinusFoulsB";
            this.MinusFoulsB.Size = new System.Drawing.Size(56,48);
            this.MinusFoulsB.TabIndex = 33;
            //
            // form
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(26,26);
            this.MaximizeBox =  false;
            this.MinimizeBox =  false;
            this.Size = new System.Drawing.Size(800,519);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name =  "Form1";
            this.Controls.Add(this.SplitContainer0);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer0)).EndInit();
            this.SplitContainer0.Panel1.ResumeLayout(false);
            this.SplitContainer0.Panel2.ResumeLayout(false);
            this.SplitContainer0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form2_KeyDown);
            
        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer0;
        private System.Windows.Forms.ComboBox ComboBoxMinutes;
        private System.Windows.Forms.ComboBox ComboBoxSeconds;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.Label TimerDisplay;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.Label SCORES_A;
        private System.Windows.Forms.Label SCORES_B;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Button PlusPointA;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Button MinusPointA;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button PlusPointB;
        private System.Windows.Forms.Button MinusPointB;
        private System.Windows.Forms.Button CLR_A;
        private System.Windows.Forms.Button CLR_B;
        private System.Windows.Forms.Button BtnSTART;
        private System.Windows.Forms.Button BtnRESET;
        private System.Windows.Forms.Button BtnSTOP;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Button PlusFoulsA;
        private System.Windows.Forms.Button MinusFoulsA;
        private System.Windows.Forms.Button PlusFoulsB;
        private System.Windows.Forms.Button MinusFoulsB;
    }
}

