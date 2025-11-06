namespace PentaCare
{
    partial class DoctorandRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorandRecords));
            docRecords = new DataGridView();
            dataGridView1 = new DataGridView();
            assignBtn = new Panel();
            ((System.ComponentModel.ISupportInitialize)docRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // docRecords
            // 
            docRecords.BorderStyle = BorderStyle.Fixed3D;
            docRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            docRecords.Location = new Point(179, 466);
            docRecords.Name = "docRecords";
            docRecords.RowHeadersWidth = 49;
            docRecords.Size = new Size(689, 306);
            docRecords.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1032, 466);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(719, 306);
            dataGridView1.TabIndex = 1;
            // 
            // assignBtn
            // 
            assignBtn.BackColor = Color.Transparent;
            assignBtn.Location = new Point(988, 936);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(298, 52);
            assignBtn.TabIndex = 2;
            assignBtn.Click += assignBtn_Click;
            // 
            // DoctorandRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(assignBtn);
            Controls.Add(dataGridView1);
            Controls.Add(docRecords);
            Name = "DoctorandRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorandRecords";
            Load += DoctorandRecords_Load;
            ((System.ComponentModel.ISupportInitialize)docRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView docRecords;
        private DataGridView dataGridView1;
        private Panel assignBtn;
    }
}