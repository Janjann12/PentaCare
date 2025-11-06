using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PentaCare
{
    public partial class DoctorandRecords : Form
    {
        public DoctorandRecords()
        {
            InitializeComponent();
        }

        private void DoctorandRecords_Load(object sender, EventArgs e)
        {

            // DOCTOR// 

            // DOCTOR //
            docRecords.Size = new Size(689, 297);
            docRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            docRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            docRecords.ScrollBars = ScrollBars.Both;

            string dbconnect = "server=127.0.0.1; database=pentacare; uid=root;";
            MySqlConnection conn = new MySqlConnection(dbconnect);
            MySqlCommand sqlcmd = new MySqlCommand();

            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet sqlDS = new DataSet();

            conn.Open();

            sqlcmd.CommandText = $"SELECT DoctorID, Doctor_Name, Specialty, Contact_No FROM doctor";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = conn;

            sqlDA.SelectCommand = sqlcmd;
            sqlDA.Fill(sqlDS, "recordsfetch");

            docRecords.DataSource = sqlDS;
            docRecords.DataMember = "recordsfetch";

            conn.Close();


            // PATIENT //
            dataGridView1.Size = new Size(689, 297);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Both;

            string con = "server=127.0.0.1; database=pentacare; uid=root;";
            MySqlConnection connect = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand();

            MySqlDataAdapter patient = new MySqlDataAdapter();
            DataSet set = new DataSet();

            connect.Open();

            cmd.CommandText = $"SELECT Name, RoomID, Status FROM patient";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            patient.SelectCommand = cmd;
            patient.Fill(set, "patientfetch");

            dataGridView1.DataSource = set;
            dataGridView1.DataMember = "patientfetch";

            connect.Close();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Action";
            btn.HeaderText = "Action";
            btn.Text = "View";
            btn.UseColumnTextForButtonValue = true;  // ✅ Same text for all buttons
            dataGridView1.Columns.Add(btn);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                // Get the selected row data
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string patientID = row.Cells["PatientID"].Value.ToString();
                string patientName = row.Cells["Name"].Value.ToString();
                string roomNo = row.Cells["RoomID"].Value.ToString();
                string doctorName = row.Cells["Doctor"].Value.ToString();


                // Open new form and pass data
                PatientLabRecord labForm = new PatientLabRecord(patientID, patientName, roomNo, doctorName);
                labForm.Show();  // Or .ShowDialog() if you want it modal
                this.Hide();
            }

        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            AssignToPatient assignToPatient = new AssignToPatient();
            assignToPatient.Show();
            this.Hide();
        }
    }
}
