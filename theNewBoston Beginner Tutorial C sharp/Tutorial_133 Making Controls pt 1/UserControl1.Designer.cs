﻿namespace theNewBoston_Beginner_Tutorial_C_sharp.Tutorial_133_Making_Controls_pt_1
{
    partial class MyButton1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyButton1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MyButton1";
            this.Size = new System.Drawing.Size(92, 32);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyButton1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MyButton1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyButton1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MyButton1_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
