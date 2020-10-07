using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theNewBoston_Beginner_Tutorial_C_sharp.Tutorial_133_Making_Controls_pt_1
{
    public partial class MyButton1 : UserControl
    {
        public MyButton1()
        {
            InitializeComponent();
        }

        // L138 Color variable for ColorButton property
        Color cMyButtonColor;

        // L136 string to hold text (instead of using a label)
        string sText = "";

        // L136 use DrawButton statement to pass in our color 'Control'
        protected override void OnPaint(PaintEventArgs e)
        {
     
            // L138 if one or more of users chosen color RGB, is to high,
            // and conflicts with our, lightening method of adding a number, and goes out of it max range
            try
            {
                //DrawButton(Color.FromKnownColor(KnownColor.Control));
                // L138 user chosen color for MyButton, instead of setting a default color (Control)
                DrawButton(cMyButtonColor);
            }
            catch
            {

                MessageBox.Show("Choose a color value, who's RGB value is in a lower range than RGB = 255,255,255");
                // NOT in lesson, the try statement did not work out so we reverted to this: 
                // to continue learning in tutorial 139(Next)
                DrawButton(Color.FromKnownColor(KnownColor.Control));
            }
            

            
        }


        /*
        // L 134 create label1 property, to enable changing of label1 text.
        public string ButtonText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        */
        // L 136 draw string text, to enable changing of string sText. (instead of using label)1
        public string ButtonText
        {
            get { return sText; }
            set { sText = value; }
        }

        // L137 change color when mouse hovers over button
        private void MyButton1_MouseHover(object sender, EventArgs e)
        {
            // L137 make color to pass blue highlighted augmentation of the Control color into DrawButton, 
            // use Color.FromArgb arguements: Alpha 255, red chanel of Control (color) dimmed down, same with green channel, blues channels set to 245
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).G - 10, 245);

            // L138 if one or more of users chosen color RGB, is to high,
            // and conflicts with our, lightening method of adding a number, and goes out of it max range
            try
            {
                //DrawButton(Color.FromKnownColor(KnownColor.Control));
                // L138 user chosen color for MyButton, instead of setting a default color (Control)
                DrawButton(cMyButtonColor);
            }
            catch
            {
                MessageBox.Show("Choose a color value, who's RGB value is in a lower range than RGB = 255,255,255");
                // NOT in lesson, the try statement did not work out so we reverted to this: 
                // to continue learning in tutorial 139(Next)
                //DrawButton(Color.FromKnownColor(KnownColor.Control));
            }
        }

        // L138 Color property for MyButton, user chooses color of MyButton
        public Color ButtonColor
        {
            get { return cMyButtonColor; }
            set
            {
                cMyButtonColor = value;
                try
                {
                    DrawButton(cMyButtonColor);
                }
            
            catch
            {
                cMyButtonColor = Color.FromKnownColor(KnownColor.Control);
                MessageBox.Show("Choose a color value, who's RGB value is in a lower range than RGB = 255,255,255");
            }
            } 
        }

        // L137 copy/paste contents of 'protected override void OnPaint(PaintEventArgs e)'
        // takes care of drawing on MyButton, passes in color c
        void DrawButton(Color c)
        {
            // L133 generated code, to be replaced by the creation of instance of solidBrush, fromknowncolor, 
            // Control is the grey blue color controls generally are base.OnPaint(e);, KnownColor.Transparent works also
            //SolidBrush Isb = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            // L137 use passed in color 'c'
            SolidBrush Isb = new SolidBrush(c);

            // L133 create instance for graphics in this meaning this class MyButton
            Graphics Ig = this.CreateGraphics();

            // L133 use graphics instance to paint our rectangle button from top left
            // and fill its width and heigth, using 'this' (MyButton)
            Ig.FillRectangle(Isb, 0, 0, this.Width, this.Height);

            // L135 change the existing color setting of our SolidBrush Instance, to darker color (too dark)
            //Isb.Color = Color.FromKnownColor(KnownColor.ControlDark);

            // L135 the color is layered upon the original color of Isb, making it a darker shade
            //Isb.Color = Color.FromKnownColor(KnownColor.ControlLight);
            // L137 darken passed in color by subtracting from its ARGB, arguements: 
            // Alpha 255, passed in color.R (Red) - 13, color.G(reen)-13, color.B(lue)-13
            Isb.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13);

            // L135 shade bottom half of button,
            Ig.FillRectangle(Isb, 0, this.Height / 2, this.Width, this.Height / 2);

            // L134 center our labels location in the button, x width and y heigth
            //label1.Location = new Point((this.Width / 2) - label1.Width / 2, (this.Height / 2) - label1.Height / 2);

            // L136 create A float Points to align our text coordinates in our form
            PointF fPoint = new Point((this.Width / 2 - (sText.Length * sText.Length / 2)), (this.Height / 2) - sText.Length);

            // L136 create FontFamily property for Font ff arguement
            FontFamily fFamily = new FontFamily("Arial");

            // L136 create font properties, 'FontFamily' is Font prototype for our first arguement, text size
            Font fFont = new System.Drawing.Font(fFamily, 8);

            // L136 change our solidbrush color value to black
            Isb.Color = Color.Black;

            // L136 the draw string method using graphic to draw the string, aguements: 
            // string name, font property name, float Point name
            Ig.DrawString(sText, fFont, Isb, fPoint);
        }

        // L137 return MyButton color back to the color "Control".
        // using our DrawButton method to pass the color in
        private void MyButton1_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                //DrawButton(Color.FromKnownColor(KnownColor.Control));
                // L138 user chooses MyButton color, instead of setting a default color (Control)
                DrawButton(cMyButtonColor);
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }

        // L137 get rid of the delay when hovering the mouse over the button, for the highlighted color to appear
        private void MyButton1_MouseEnter(object sender, EventArgs e)
        {
            // L137 make color to pass blue highlighted augmentation of the Control color into DrawButton, 
            // use Color.FromArgb arguements: Alpha 255, red chanel of Control (color) dimmed down, same with green channel, blues channels set to 245
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).G - 10, 245);

            // L137 pass blue highlighted augmentation of the Control color into DrawButton
            DrawButton(myColor);
        }

        private void MyButton1_MouseDown(object sender, MouseEventArgs e)
        {
            // L138 make color to pass orange highlighted augmentation of the Control color into DrawButton, 
            // use Color.FromArgb arguements: Alpha 255, red chanel of Control (color) dimmed down, same with green channel, blues channels set to 200
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R + 15, Color.FromKnownColor(KnownColor.Control).G - 10, 200);
     
            // L138 pass orange highlighted augmentation of the Control color into DrawButton
            DrawButton(myColor);
        }
    }
}
