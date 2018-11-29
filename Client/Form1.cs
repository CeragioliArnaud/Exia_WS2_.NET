using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiddlewareTrue;

namespace Client
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private MiddlewareProcess processus = new MiddlewareProcess();


        private void Reload_Click(object sender, EventArgs e)
        {
            var dataset = processus.ChargerPersonnes();
            DataGridMain.DataSource = dataset.Tables["CESI"];
        }

        private void Charger_Click(object sender, EventArgs e)
        {

        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            var dataset = processus.AfficherParNom(TextSearchByName.Text);
            DataGridMain.DataSource = dataset.Tables["CESI"];
        }
    }
}
