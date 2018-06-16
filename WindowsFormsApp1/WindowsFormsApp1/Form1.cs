using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista kontattów v1.0. \n Autor: Daniel Marcinkowski", "O programie");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet1.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.database2DataSet1.People);
            // TODO: This line of code loads data into the 'database2DataSet1.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.database2DataSet1.People);
            // TODO: This line of code loads data into the 'database2DataSet.Table' table. You can move, or remove it, as needed.
            

        }

     
        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void compantLabel_Click(object sender, EventArgs e)
        {

        }

        private void compantTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lastCallLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastCallDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contactIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void peopleBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet1);

        }
    }
}
