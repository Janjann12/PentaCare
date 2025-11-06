namespace PentaCare
{
    partial class PatientLabRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLabRecord));
            panel1 = new Panel();
            pName = new Label();
            room = new Label();
            doc = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            viewbtn = new Panel();
            updbtn = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(1526, 915);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 80);
            panel1.TabIndex = 1;
            panel1.Click += panel1_Click;
            // 
            // pName
            // 
            pName.AutoSize = true;
            pName.BackColor = Color.Transparent;
            pName.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pName.Location = new Point(636, 215);
            pName.Name = "pName";
            pName.Size = new Size(130, 60);
            pName.TabIndex = 2;
            pName.Text = "Value";
            // 
            // room
            // 
            room.AutoSize = true;
            room.BackColor = Color.Transparent;
            room.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            room.Location = new Point(1412, 215);
            room.Name = "room";
            room.Size = new Size(130, 60);
            room.TabIndex = 3;
            room.Text = "Value";
            // 
            // doc
            // 
            doc.AutoSize = true;
            doc.BackColor = Color.Transparent;
            doc.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doc.Location = new Point(428, 278);
            doc.Name = "doc";
            doc.Size = new Size(90, 41);
            doc.TabIndex = 4;
            doc.Text = "Value";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Transparent;
            textBox1.Location = new Point(583, 458);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Test Name...";
            textBox1.Size = new Size(655, 36);
            textBox1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(129, 915);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 73);
            panel2.TabIndex = 7;
            panel2.Click += panel2_Click;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.Transparent;
            viewbtn.Location = new Point(734, 914);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(171, 74);
            viewbtn.TabIndex = 8;
            viewbtn.Click += viewbtn_Click;
            // 
            // updbtn
            // 
            updbtn.BackColor = Color.Transparent;
            updbtn.Location = new Point(935, 914);
            updbtn.Name = "updbtn";
            updbtn.Size = new Size(178, 74);
            updbtn.TabIndex = 9;
            updbtn.Click += updbtn_Click;
            // 
            // PatientLabRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(updbtn);
            Controls.Add(viewbtn);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(doc);
            Controls.Add(room);
            Controls.Add(pName);
            Controls.Add(panel1);
            Name = "PatientLabRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientLabRecord";
            Load += PatientLabRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label pName;
        private Label room;
        private Label doc;
        private TextBox textBox1;
        private Panel panel2;
        private Panel viewbtn;
        private Panel updbtn;
    }
}