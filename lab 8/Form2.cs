using lab_8.bdDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdDataSet.Iesiri' table. You can move, or remove it, as needed.
            this.iesiriTableAdapter.Fill(this.bdDataSet.Iesiri);
            // TODO: This line of code loads data into the 'bdDataSet.produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.bdDataSet.produse);
        }

        private void produseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdDataSet);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}

