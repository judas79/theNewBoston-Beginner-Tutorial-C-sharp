namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton11 = new theNewBoston_Beginner_Tutorial_C_sharp.Tutorial_133_Making_Controls_pt_1.MyButton1();
            this.SuspendLayout();
            // 
            // myButton11
            // 
            this.myButton11.Location = new System.Drawing.Point(49, 33);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(92, 32);
            this.myButton11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.myButton11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tutorial_133_Making_Controls_pt_1.MyButton1 myButton11;
    }
}