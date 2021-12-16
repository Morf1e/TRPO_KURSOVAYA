using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Shablon_Delete : Form
    {
        public Shablon_Delete()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Product product = new Product("", 0, "", 0, 0);
            bool isNum = true;
            int num;
            if (isNum == int.TryParse(Delete_Box.Text, out num))
            {
                foreach (Product item in GeneralForm.table_of_products)
                {
                    if (item.echeyka == Int32.Parse(Delete_Box.Text))
                    {
                        product = item;
                    }
                }
                if (product.code_bagaj != "")
                {
                    GeneralForm.table_of_products.Remove(product);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Товара с данным кодом не существует");
                }
            }
            else
                MessageBox.Show("В поле 'Введите код товара, который нужно удалить' должны быть только целые числа");

            
            

        }
    }
}
