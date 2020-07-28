﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // L81 ColorDialog is global
        ColorDialog ICD;
        private void button1_Click(object sender, EventArgs e)
        {
            // L81 colordialog name instance
            ICD = new ColorDialog();

            // L81 Verify that user has selected a color
            if (ICD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // L82 apply name to a chosen color
                Color coColorChosen = ICD.Color;
                button1.BackColor = coColorChosen;

                // L82 does this selected color already have a name t/f
                if(coColorChosen.IsNamedColor)
                {
                    MessageBox.Show("coColorChosen name is " + coColorChosen.Name);
                }
                else MessageBox.Show("coColorChosen is not a known named color " + coColorChosen.Name);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // L81 colordialog name instance
            ICD = new ColorDialog();

            // L81 Verify that user has selected a color
            if (ICD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // L82 apply name to a chosen color
                Color coColorChosen = ICD.Color;
                button2.BackColor = coColorChosen;

                // L82 does this selected color already have a name t/f
                if (coColorChosen.IsKnownColor)
                {
                    MessageBox.Show("coColorChosen name in windows is " + coColorChosen.ToKnownColor().ToString());
                }
                else MessageBox.Show("coColorChosen is not a known windows named color " + coColorChosen.ToKnownColor().ToString());

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // L82 apply color to a chosen color name
            Color coColorChosen = Color.LightPink;
            button3.BackColor = coColorChosen;

            // L82 display name of the color
            MessageBox.Show(coColorChosen.Name, "set color using color name");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // L82 apply color to a known color name
            Color coColorChosen = Color.FromKnownColor(KnownColor.Gainsboro);
            button4.BackColor = coColorChosen;

            // L82 display name of the color
            MessageBox.Show(coColorChosen.ToKnownColor().ToString(), "set color using color name");

            // L82 save color as Argb int32, using ToArgb
            int inColor = coColorChosen.ToArgb();

            // L82 show in hex using two methods
            MessageBox.Show(coColorChosen.ToArgb().ToString("X"), "ToArgb ToString");
            MessageBox.Show(inColor.ToString("X"), "int inColor var ToString");

            // L82 change color from Argb int, to Color uing FromArgb
            Color coConvertToColor = Color.FromArgb(inColor);

            // apply coConvertToColor to button5 background
            button5.BackColor = coConvertToColor;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // L82 apply color to a known color name
            Color coColorChosen = Color.FromKnownColor(KnownColor.Red);
            


            // L82 save color as Argb int32, using ToArgb
            int inColor = coColorChosen.ToArgb();


            // L82 change color from Argb int, to Color uing FromArgb
            Color coConvertToColor = Color.FromArgb(inColor);

            // apply coConvertToColor to button5 background
            button5.BackColor = coConvertToColor;
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
          
        }
    }
}
