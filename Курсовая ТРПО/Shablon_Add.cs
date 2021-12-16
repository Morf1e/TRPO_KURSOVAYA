using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Shablon_Add : Form
    {
       
        public Shablon_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            double Num;
            bool isNum = true;
            if ((isNum == int.TryParse(Kol_Box.Text, out num)) && (isNum == double.TryParse(Ves_Box.Text, out Num)))
            {
                

                Product product = new Product(Fio_Box.Text, Int32.Parse(Nomer_Box.Text), Shifer_Box.Text, Convert.ToInt32(Kol_Box.Text), Convert.ToDouble(Ves_Box.Text));
                GeneralForm.table_of_products.Add(product);

                this.Close();
            }
            else
                MessageBox.Show("В поле 'Размер партии' должны быть только целые числа, а в поле 'стоимость' только числа");
            
            
        }
    }
}
