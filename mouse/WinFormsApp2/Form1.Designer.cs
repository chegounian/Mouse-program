namespace WinFormsApp2
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
            pictureb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureb).BeginInit();
            SuspendLayout();
            // 
            // pictureb
            // 
            pictureb.Dock = DockStyle.Fill;
            pictureb.Image = Properties.Resources.Mouse_icon_vector;
            pictureb.Location = new Point(0, 0);
            pictureb.Name = "pictureb";
            pictureb.Size = new Size(258, 336);
            pictureb.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureb.TabIndex = 0;
            pictureb.TabStop = false;
            pictureb.MouseDown += pictureb_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 336);
            Controls.Add(pictureb);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureb).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureb;
    }
}
