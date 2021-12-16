using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Second_Table : Form
    {
        List<Product> products = new List<Product>();
        public Second_Table(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void Load_Sort_Form(object sender, EventArgs e)
        {
            foreach (Product item in products)
                dataGridView1.Rows.Add(item.fam, item.echeyka, item.code_bagaj, item.kol_veshey, item.ves);
            
            
        }
    }
}
