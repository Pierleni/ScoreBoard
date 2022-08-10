// namespace ScoreBoard
// {
//     partial class Form1
//     {
//         /// <summary>
//         ///  Required designer variable.
//         /// </summary>
//         private System.ComponentModel.IContainer components = null;

//         /// <summary>
//         ///  Clean up any resources being used.
//         /// </summary>
//         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//         protected override void Dispose(bool disposing)
//         {
//             if (disposing && (components != null))
//             {
//                 components.Dispose();
//             }
//             base.Dispose(disposing);
//         }

//         #region Windows Form Designer generated code

//         /// <summary>
//         ///  Required method for Designer support - do not modify
//         ///  the contents of this method with the code editor.
//         /// </summary>
//         private void InitializeComponent()
//         {
//             this.TimerLabel = new System.Windows.Forms.Label();
//             this.Home = new System.Windows.Forms.Label();
//             this.Guest = new System.Windows.Forms.Label();
//             this.SuspendLayout();
//             //
//             // Timer
//             //
//             this.TimerLabel.AutoSize =  true;
//             this.TimerLabel.Text =  "00:00";
//             this.TimerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
//             this.TimerLabel.Font = new System.Drawing.Font("Digital-7", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//             this.TimerLabel.ForeColor = System.Drawing.Color.FromArgb( 255, 0, 0);
//             this.TimerLabel.Location = new System.Drawing.Point(133,32);
//             this.TimerLabel.Name =  "Timer";
//             this.TimerLabel.Size = new System.Drawing.Size(298,120);
//             this.TimerLabel.Location = new System.Drawing.Point((int)this.Width / 2 -45, 20);
//             this.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
//             //
//             // Home
//             //
//             this.Home.AutoSize =  true;
//             this.Home.Text =  "00";
//             this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
//             this.Home.Font = new System.Drawing.Font("Digital-7", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//             this.Home.ForeColor = System.Drawing.Color.Lime;
//             this.Home.Location = new System.Drawing.Point(-16,204);
//             this.Home.Name =  "Home";
//             this.Home.Size = new System.Drawing.Size(219,159);
//             this.Home.TabIndex = 1;
//             this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//             //
//             // Guest
//             //
//             this.Guest.AutoSize =  true;
//             this.Guest.Text =  "00";
//             this.Guest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
//             this.Guest.Font = new System.Drawing.Font("Digital-7", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//             this.Guest.ForeColor = System.Drawing.Color.Lime;
//             this.Guest.Location = new System.Drawing.Point(350,204);
//             this.Guest.Name =  "Guest";
//             this.Guest.Size = new System.Drawing.Size(219,159);
//             this.Guest.TabIndex = 2;
//             this.Guest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//             //
//             // form
//             //
//             this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
//             this.Location = new System.Drawing.Point(156,156);
//             this.Size = new System.Drawing.Size(520,399);
//             this.ForeColor = System.Drawing.SystemColors.InfoText;
//             this.Name =  "Form1";

//             this.Resize += new System.EventHandler(Form1_Resize);

//             this.Controls.Add(this.TimerLabel);
//             this.Controls.Add(this.Home);
//             this.Controls.Add(this.Guest);
//             this.ResumeLayout(false);
//         }

//         #endregion

//         private System.Windows.Forms.Label TimerLabel;
//         private System.Windows.Forms.Label Home;
//         private System.Windows.Forms.Label Guest;
//     }
// }

// //private void Form1_Resize(System.Object? sender, System.EventArgs e)
// //{
// //
// //}






namespace ScoreBoard
{
    partial class Form1
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
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // LabelTimer
            //
            this.TimerLabel.AutoSize =  true;
            this.TimerLabel.Text =  "00:00.0";
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimerLabel.Font = new System.Drawing.Font("Currier New", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.Color.Red;
            this.TimerLabel.Location = new System.Drawing.Point(130,0);
            this.TimerLabel.Name =  "LabelTimer";
            this.TimerLabel.Size = new System.Drawing.Size(624,198);
            this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            //
            // Home
            //
            this.Home.AutoSize =  true;
            this.Home.Text =  "00";
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.Font = new System.Drawing.Font("Digital-7", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Home.ForeColor = System.Drawing.Color.SpringGreen;
            this.Home.Location = new System.Drawing.Point(1,328);
            this.Home.Name =  "Home";
            this.Home.Size = new System.Drawing.Size(309,225);
            this.Home.TabIndex = 1;
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //
            // Guest
            //
            this.Guest.AutoSize =  true;
            this.Guest.Text =  "00";
            this.Guest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guest.Font = new System.Drawing.Font("Segoe UI", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guest.ForeColor = System.Drawing.Color.SpringGreen;
            this.Guest.Location = new System.Drawing.Point(510,328);
            this.Guest.Name =  "Guest";
            this.Guest.Size = new System.Drawing.Size(309,225);
            this.Guest.TabIndex = 2;
            this.Guest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //
            // Label3
            //
            this.Label3.Controls.Add(this.Label5);
            this.Label3.AutoSize =  true;
            this.Label3.Text =  "HOME";
            this.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(40,260);
            this.Label3.Name =  "Label3";
            this.Label3.Size = new System.Drawing.Size(143,54);
            this.Label3.TabIndex = 3;
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            //
            // Label4
            //
            this.Label4.AutoSize =  true;
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label4.Text =  "GUEST";
            this.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(550,260);
            this.Label4.Name =  "Label4";
            this.Label4.Size = new System.Drawing.Size(146,54);
            this.Label4.TabIndex = 4;
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            //
            // Label5
            //
            this.Label5.AutoSize =  true;
            this.Label5.Text =  "Label5";
            this.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label5.Location = new System.Drawing.Point(1008,-24);
            this.Label5.Name =  "Label5";
            this.Label5.Size = new System.Drawing.Size(146,54);
            this.Label5.TabIndex = 5;
            //
            // Label6
            //
            this.Label6.AutoSize =  true;
            this.Label6.Text =  "FOULS";
            this.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label6.Location = new System.Drawing.Point(336,368);
            this.Label6.Name =  "Label6";
            this.Label6.Size = new System.Drawing.Size(100,37);
            this.Label6.TabIndex = 6;
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            //
            // Label7
            //
            this.Label7.AutoSize =  true;
            this.Label7.Text =  "0";
            this.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.ForeColor = System.Drawing.Color.Gold;
            this.Label7.Location = new System.Drawing.Point(296,410);
            this.Label7.Name =  "Label7";
            this.Label7.Size = new System.Drawing.Size(107,120);
            this.Label7.TabIndex = 7;
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            //
            // Label8
            //
            this.Label8.AutoSize =  true;
            this.Label8.Text =  "0";
            this.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label8.ForeColor = System.Drawing.Color.Gold;
            this.Label8.Location = new System.Drawing.Point(384,410);
            this.Label8.Name =  "Label8";
            this.Label8.Size = new System.Drawing.Size(107,120);
            this.Label8.TabIndex = 8;
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            //
            // form
            //
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(14,12);
            this.Size = new System.Drawing.Size(800,600);
            this.Name =  "Form1";

            this.Resize += new System.EventHandler(Form1_Resize);
            
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Guest;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
    }
}

