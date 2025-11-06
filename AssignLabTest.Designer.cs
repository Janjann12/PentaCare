namespace PentaCare
{
    partial class AssignLabTest
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
            saveBtn = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            doc = new Label();
            room = new Label();
            pName = new Label();
            LabTests = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            feeBox = new TextBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Transparent;
            saveBtn.Location = new Point(118, 907);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(247, 85);
            saveBtn.TabIndex = 0;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(382, 914);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 85);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Location = new Point(1533, 914);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 85);
            panel3.TabIndex = 1;
            panel3.Click += panel3_Click;
            // 
            // doc
            // 
            doc.AutoSize = true;
            doc.BackColor = Color.Transparent;
            doc.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doc.Location = new Point(425, 262);
            doc.Name = "doc";
            doc.Size = new Size(92, 36);
            doc.TabIndex = 7;
            doc.Text = "Value";
            // 
            // room
            // 
            room.AutoSize = true;
            room.BackColor = Color.Transparent;
            room.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            room.Location = new Point(1459, 205);
            room.Name = "room";
            room.Size = new Size(130, 60);
            room.TabIndex = 6;
            room.Text = "Value";
            // 
            // pName
            // 
            pName.AutoSize = true;
            pName.BackColor = Color.Transparent;
            pName.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pName.Location = new Point(625, 205);
            pName.Name = "pName";
            pName.Size = new Size(130, 60);
            pName.TabIndex = 5;
            pName.Text = "Value";
            // 
            // LabTests
            // 
            LabTests.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabTests.FormattingEnabled = true;
            LabTests.Items.AddRange(new object[] { "Complete Blood Count", "Urinalysis", "Fecalysis", "X-Ray", "CT Scan", "MRI (Magnetic Resonance Imaging)", "ECG (Electrocardiogram)", "Ultrasound", "Blood Sugar Test (FBS)", "COVID-19 PCR Test" });
            LabTests.Location = new Point(491, 458);
            LabTests.Name = "LabTests";
            LabTests.Size = new Size(397, 45);
            LabTests.TabIndex = 8;
            LabTests.SelectedIndexChanged += LabTests_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(491, 554);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(416, 43);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(331, 651);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 36);
            textBox1.TabIndex = 10;
            // 
            // feeBox
            // 
            feeBox.BorderStyle = BorderStyle.None;
            feeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feeBox.Location = new Point(321, 651);
            feeBox.Name = "feeBox";
            feeBox.Size = new Size(245, 40);
            feeBox.TabIndex = 11;
            // 
            // AssignLabTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copy_of_CCP___SYSTEM__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(feeBox);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(LabTests);
            Controls.Add(doc);
            Controls.Add(room);
            Controls.Add(pName);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(saveBtn);
            Name = "AssignLabTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignLabTest";
            Load += AssignLabTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel saveBtn;
        private Panel panel2;
        private Panel panel3;
        private Label doc;
        private Label room;
        private Label pName;
        private ComboBox LabTests;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox feeBox;
    }
}