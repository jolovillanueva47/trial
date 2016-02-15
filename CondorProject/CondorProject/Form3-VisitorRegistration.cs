using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form3_VisitorRegistration : Form
    {
        public Form3_VisitorRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boxes = Controls.OfType<TextBox>();

            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the required field.");
                }
            }

            visitorTableAdapter.InsertQuery(txtBoxFirstName.Text, txtBoxLastName.Text, cmbBoxGender.Text, txtBoxIdDetails.Text, txtBoxRelation.Text, txtBoxPurpose.Text, pickerTimeIn.Text, pickerTimeOut.Text);
            this.Hide();
            Form4_VisitorResult form4 = new Form4_VisitorResult();
            form4.Closed += (s, args) => this.Close();
            form4.Show();

            

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_VisitorRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);

        }
    }
}
