﻿using System;
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

        // L133 type 'overide OnPaint'  then click 'Enter' button to grnerate the rest of the Overide code
        // overrides the  use of the drawing method from the UserControl class, use our own drawing
        protected override void OnPaint(PaintEventArgs e)
        {
            // L133 generated code, to be replaced by the creation of instance of solidBrush, fromknowncolor, 
            // Control is the grey blue color controls generally are
            //base.OnPaint(e);
            SolidBrush Isb = new SolidBrush(Color.FromKnownColor(KnownColor.Control));

            // L133 create instance for graphics in this meaning this class MyButton
            Graphics Ig = this.CreateGraphics();

            // L133 use graphics instance to paint our rectangle button from top left
            // and fill its width and heigth, using 'this' (MyButton)
            Ig.FillRectangle(Isb, 0, 0, this.Width, this.Height);

            // L134 center our labels location in the button, x width and y heigth
            label1.Location = new Point((this.Width / 2) - label1.Width / 2, (this.Height / 2) - label1.Height / 2);
        }

        // L 134 create label1 property, to enable changing of label1 text.
        public string ButtonText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
            
        
        
    }
}
