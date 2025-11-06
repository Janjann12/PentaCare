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
    public partial class AssignLabTest : Form
    {

        private string patientID;
        private string patientName;
        private string doctorName;
        private string roomNo;

        public AssignLabTest(string id, string name, string dname, string room)
        {
            InitializeComponent();
            patientID = id;
            patientName = name;
            doctorName = dname;
            roomNo = room;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientLabRecord lab = new PatientLabRecord(patientID, patientName, doctorName, roomNo);
            lab.Show();
        }

        private void AssignLabTest_Load(object sender, EventArgs e)
        {
            pName.Text = patientName;
            doc.Text = doctorName;
            room.Text = roomNo;
        }

        private void LabTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLab = LabTests.SelectedItem.ToString();
            decimal labPrice = 0;

            switch (selectedLab)
            {
                case "Complete Blood Count":
                    labPrice = 350.00m;
                    break;
                case "Urinalysis":
                    labPrice = 300.00m;
                    break;
                case "Fecalysis":
                    labPrice = 250.00m;
                    break;
                case "X-Ray":
                    labPrice = 800.00m;
                    break;
                case "CT Scan":
                    labPrice = 3000.00m;
                    break;
                case "MRI (Magnetic Resonance Imaging)":
                    labPrice = 5000.00m;
                    break;
                case "ECG (Electrocardiogram)":
                    labPrice = 500.00m;
                    break;
                case "Ultrasound":
                    labPrice = 1200.00m;
                    break;
                case "Blood Sugar Test (FBS)":
                    labPrice = 200.00m;
                    break;
                case "COVID-19 PCR Test":
                    labPrice = 2000.00m;
                    break;
                default:
                    labPrice = 0;
                    break;
            }

            // Display the price in the TextBox
            feeBox.Text = labPrice.ToString("F2");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
