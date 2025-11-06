using MySql.Data.MySqlClient;
using System.Data;

namespace PentaCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1110);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "Search by Patient Name, ID...";
            //textBox1.ForeColor = Color.Gray;

            //// Attach events
            //textBox1.Enter += RemoveText;
            //textBox1.Leave += AddText;

            dataGridView1.Size = new Size(1463, 351);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Both; // optional: adds scroll if needed




            string dbconnect = "server= 127.0.0.1; database=pentacare; uid=root; ";
            MySqlConnection conn = new MySqlConnection(dbconnect);
            MySqlCommand sqlcmd = new MySqlCommand();

            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet sqlDS = new DataSet();


            // Step 2: Establish SQL Connection
            conn.Open();


            // Step 3: Request Query

            sqlcmd.CommandText = "SELECT p.PatientID, p.Name, r.Room_No, d.Doctor_Name, p.Status, p.Admission_Date, IFNULL(p.Discharge_Date, '') AS Discharge_Date " +
                      "FROM patient AS p " +
                       "LEFT JOIN room AS r ON p.RoomID = r.RoomID " +
                     "LEFT JOIN doctor AS d ON p.DoctorID = d.DoctorID";



            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = conn;

            // Step 4: Execute SQL Command

            sqlDA.SelectCommand = sqlcmd;
           

            sqlDA.Fill(sqlDS, "recordsfetch");
            dataGridView1.DataSource = sqlDS;
            dataGridView1.DataMember = "recordsfetch";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Action";
            btn.HeaderText = "Action";
            btn.Text = "View Lab Result";
            btn.UseColumnTextForButtonValue = true;  // ✅ Same text for all buttons
            dataGridView1.Columns.Add(btn);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;


            //Step 5: DQ

            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                // Get the selected row data
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string patientID = row.Cells["PatientID"].Value.ToString();
                string patientName = row.Cells["Name"].Value.ToString();
                string roomNo = row.Cells["Room_No"].Value.ToString();
                string doctorName = row.Cells["Doctor_Name"].Value.ToString();


                // Open new form and pass data
                PatientLabRecord labForm = new PatientLabRecord(patientID, patientName, roomNo, doctorName);
                labForm.Show();  // Or .ShowDialog() if you want it modal
                this.Hide();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            AdmissionDischarge admisdi = new AdmissionDischarge();
            admisdi.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            this.Hide();
        }

        private void dischargeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve PatientID and Name from the selected row
                string patientID = selectedRow.Cells["PatientID"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();

                // Ask for confirmation
                DialogResult result = MessageBox.Show($"Discharge patient: {name}?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Connect to the database
                    string dbconnect = "server=127.0.0.1; database=pentacare; uid=root;";
                    using (MySqlConnection conn = new MySqlConnection(dbconnect))
                    {
                        conn.Open();

                        // Update patient status to 'Discharged' and optionally set a Discharge_Date
                        string query = "UPDATE patient SET Status = 'Discharged', Discharge_Date = CURDATE() WHERE PatientID = @PatientID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"{name} has been discharged successfully.");

                        // Refresh DataGridView after update
                        RefreshDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to discharge.");
            }
        }
        private void RefreshDataGrid()
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        
        }
            //    string dbconnect = "server=127.0.0.1; database=pentacare; uid=root;";
            //    using (MySqlConnection conn = new MySqlConnection(dbconnect))
            //    {
            //        conn.Open();
            //        string query = "SELECT p.PatientID, p.Name, r.Room_No, d.Doctor_Name, p.Status, p.Admission_Date " +
            //              "FROM patient AS p " +
            //               "LEFT JOIN room AS r ON p.RoomID = r.RoomID " +
            //             "LEFT JOIN doctor AS d ON p.DoctorID = d.DoctorID";
            //        MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        dataGridView1.DataSource = dt;
            //        if (!dataGridView1.Columns.Contains("Action"))
            //        {
            //            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //            btn.Name = "Action";
            //            btn.HeaderText = "Action";
            //            btn.Text = "View Lab Result";
            //            btn.UseColumnTextForButtonValue = true;
            //            dataGridView1.Columns.Add(btn);
            //        }
            //    }
        }
    }

