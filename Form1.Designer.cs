namespace PentaCare
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            panel1 = new Panel();
            addPatient = new Panel();
            dischargeBtn = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(233, 484);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1463, 351);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(164, 235);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Patient Name, ID...";
            textBox1.Size = new Size(692, 36);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(1255, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 60);
            panel1.TabIndex = 2;
            panel1.Click += panel1_Click;
            // 
            // addPatient
            // 
            addPatient.BackColor = Color.Transparent;
            addPatient.Location = new Point(137, 912);
            addPatient.Name = "addPatient";
            addPatient.Size = new Size(349, 76);
            addPatient.TabIndex = 3;
            addPatient.Click += addPatient_Click;
            // 
            // dischargeBtn
            // 
            dischargeBtn.BackColor = Color.Transparent;
            dischargeBtn.Location = new Point(765, 912);
            dischargeBtn.Name = "dischargeBtn";
            dischargeBtn.Size = new Size(235, 76);
            dischargeBtn.TabIndex = 4;
            dischargeBtn.Click += dischargeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copy_of_CCP___SYSTEM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dischargeBtn);
            Controls.Add(addPatient);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Panel panel1;
        private Panel addPatient;
        private Panel dischargeBtn;
    }
}
