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
    public partial class Form1 : Form
    {
        private Rectangle originalFormRect;

        private Rectangle originalTimerRect;
        private float timerFontSize;

        private Rectangle originalHomeRect;
        private float homeFontSize;

        private Rectangle originalGuestRect;
        private float guestFontSize;

        private Rectangle originalNameHome;
        private float nameHomeFontSize;

        private Rectangle originalNameGuest;
        private float nameGuestFontSize;

        private Rectangle originalLabelFouls;
        private float labelFoulsFontSize;

        private Rectangle originalFoulsHome;
        private float foulsHomeFontSize;

        private Rectangle originalFoulsGuest;
        private float foulsGuestFontSize;

        // expose and declare editable elements of display
        public string displayHome {get {return this.Home.Text;} set {this.Home.Text = value;}}
        public string displayGuest {get {return this.Guest.Text;} set {this.Guest.Text = value;}}
        public string displayTimer {get {return this.TimerLabel.Text;} set {this.TimerLabel.Text = value;}}
        public string displayHomeName {get {return this.Label3.Text;} set {this.Label3.Text = value;}}
        public string displayGuestName {get {return this.Label4.Text;} set {this.Label4.Text = value;}}
        public string displayFoulsA {get {return this.Label7.Text;} set {this.Label7.Text = value;}}
        public string displayFoulsB {get {return this.Label8.Text;} set {this.Label8.Text = value;}}

        public Label colorTimer {get {return this.TimerLabel;} set {this.TimerLabel = value;}}
        public Label colorScoreA {get {return this.Home;} set {this.Home = value;}}
        public Label colorScoreB {get {return this.Guest;} set {this.Guest = value;}}
        public Label colorFoulsA {get {return this.Label7;} set {this.Label7 = value;}}
        public Label colorFoulsB {get {return this.Label8;} set {this.Label8 = value;}}


        public Form1()
        {
            InitializeComponent();
            originalFormRect = new Rectangle(this.Location, this.Size);
            originalTimerRect = new Rectangle(TimerLabel.Location, TimerLabel.Size);
            originalHomeRect = new Rectangle(Home.Location, Home.Size);
            originalGuestRect = new Rectangle(Guest.Location, Guest.Size);
            originalNameHome = new Rectangle(Label3.Location, Label3.Size);
            originalNameGuest = new Rectangle(Label4.Location, Label4.Size);
            originalLabelFouls = new Rectangle(Label6.Location, Label6.Size);
            originalFoulsHome = new Rectangle(Label7.Location, Label7.Size);
            originalFoulsGuest = new Rectangle(Label8.Location, Label8.Size);
            
            timerFontSize = TimerLabel.Font.Size;
            homeFontSize = Home.Font.Size;
            guestFontSize = Guest.Font.Size;

            nameHomeFontSize = Label3.Font.Size;
            nameGuestFontSize = Label4.Font.Size;
            labelFoulsFontSize = Label6.Font.Size;
            foulsHomeFontSize = Label7.Font.Size;
            foulsGuestFontSize = Label8.Font.Size;

        }

        ////////////////////////////////////
        //          R E S I Z E           //
        ////////////////////////////////////

        public void Form1_Resize(object sender, EventArgs e){
            ResizeControl(TimerLabel, originalTimerRect, timerFontSize);
            ResizeControl(Home, originalHomeRect, homeFontSize);
            ResizeControl(Guest, originalGuestRect, guestFontSize);
            ResizeControl(Label3, originalNameHome, nameHomeFontSize);
            ResizeControl(Label4, originalNameGuest, nameGuestFontSize);
            ResizeControl(Label6, originalLabelFouls, labelFoulsFontSize);
            ResizeControl(Label7, originalFoulsHome, foulsHomeFontSize);
            ResizeControl(Label8, originalFoulsGuest, foulsGuestFontSize);
            /*
                Add Every Element have to be resized
            */
        }
        public void ResizeControl(Control control, Rectangle originalControlRect, float originalFontSize){
            float xRatio = (float)this.ClientRectangle.Width / (float)originalFormRect.Width;
            float yRatio = (float)this.ClientRectangle.Height / (float)originalFormRect.Height;

            float newX = originalControlRect.X * xRatio;
            float newY = originalControlRect.Y * yRatio;

            control.Location = new Point((int)newX, (int)newY);
            control.Width = (int)originalControlRect.Width * (int)xRatio;
            control.Height = (int)originalControlRect.Height * (int)yRatio;

            float newFontSize = originalFontSize * xRatio;
            Font newFont = new Font(control.Font.FontFamily, newFontSize);
            control.Font = newFont;
        }
    }
}
