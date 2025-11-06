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

    public partial class Update : Form
    {
        private string patientID;
        private string patientName;
        private string doctorName;
        private string roomNo;
        public Update(string id, string name, string dname, string room)
        {
            InitializeComponent();
            patientID = id;
            patientName = name;
            doctorName = dname;
            roomNo = room;

        }

        private void Update_Load(object sender, EventArgs e)
        {
            label1.Text = patientName;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            PatientLabRecord labrec = new PatientLabRecord(patientID, patientName, doctorName, roomNo);
            labrec.Show();
            this.Hide();
        }
    }
}
