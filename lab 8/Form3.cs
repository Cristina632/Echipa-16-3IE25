using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bd.accdb");
            string sql = @"Select denumire, sum(iesiri.cantitate) as total_canitate_vanduta, sum(intrari.cantitate) as total_canitate_achizitionata
                            from produse, iesiri, intrari
                            where produse.id_produs=iesiri.id_produs and produse.id_produs=intrari.id_produs
                            group by denumire";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Rezultat");
            dataGridView1.DataSource = ds.Tables["Rezultat"];
            chart1.Series.Clear();
            chart1.Series.Add("Achizitii");
            chart1.Series.Add("Vanzari");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                chart1.Series["Vanzari"].Points.AddXY(ds.Tables["Rezultat"].Rows[i].Field<string>("denumire"), ds.Tables["Rezultat"].Rows[i].Field<double>("total_canitate_vanduta"));
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                chart1.Series["Achizitii"].Points.AddXY(ds.Tables["Rezultat"].Rows[i].Field<string>("denumire"), dataGridView1.Rows[i].Cells[2].Value);
            chart1.Titles.Add("Grafic total achizitii si vanzari");
            chart1.Series["Achizitii"].IsValueShownAsLabel = true;
            chart1.Series["Vanzari"].IsValueShownAsLabel = true;



        }
    }
}

