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
    public partial class Form2_ViewFacilitatorList : Form
    {
        public Form2_ViewFacilitatorList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7_CreateFacilitator form7 = new Form7_CreateFacilitator();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }
    }
}
