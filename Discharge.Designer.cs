namespace PentaCare
{
    partial class Discharge
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(1434, 895);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 70);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // Discharge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copy_of_CCP___SYSTEM__9_;
            ClientSize = new Size(1902, 1063);
            Controls.Add(panel1);
            Name = "Discharge";
            Text = "Discharge";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}