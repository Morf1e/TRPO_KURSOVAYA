using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class GeneralForm : Form
    {
        public static List<Product> table_of_products = new List<Product>();
        public static List<Product> SortList = new List<Product>();
        

        public GeneralForm()
        {
            InitializeComponent();
            ShowList(table_of_products);
            Product product = new Product("Хохоркин", 1, "123f", 5, 15);
            table_of_products.Add(product);
            product = new Product("Джонс", 2, "31f", 3, 9);
            table_of_products.Add(product);
            product = new Product("Мэдисон", 3, "23f", 10, 30);
            table_of_products.Add(product);
            product = new Product("Фернандс", 4, "01f", 4, 9.5);
            table_of_products.Add(product);


        }
        
        
        private void Add_button_Click(object sender, EventArgs e)
        {
            Shablon_Add shablon_Add = new Shablon_Add();
            shablon_Add.Show();
        }
        public void ShowList(List<Product> table)
        {
            Table.Rows.Clear();
            
                foreach (Product item in table_of_products)
                    Table.Rows.Add(item.fam, item.echeyka, item.code_bagaj, item.kol_veshey, item.ves);
        }

        public void Refresh_Click(object sender, EventArgs e)
        {
            ShowList(table_of_products);
        }

        private void GeneralForm_Activated(object sender, EventArgs e)
        {
            ShowList(table_of_products);
            const int vesC = 10;
            int i = 0;
            
            SortList.Clear();
            foreach (Product item in table_of_products)
                if (item.ves > vesC )
                {
                    SortList.Add(item);
                    i++;
                }
                Min_Label.Text = $"Число пассажиров с багажом\r\nбольше 10кг: {i}";
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Shablon_Delete shablon_Delete = new Shablon_Delete();
            shablon_Delete.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SortList.Clear();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Edit_Form edit_Form = new Edit_Form();
            edit_Form.Show();
        }

       

        private void Change(object sender, EventArgs e)
        {
            double sum = 0;
            if (Find_Box.Text != "")
            {
                foreach (Product item in table_of_products)
                {
                    if (item.echeyka == Int32.Parse(Find_Box.Text))
                    {

                        //sum += item.ves / item.kol_veshey;
                        SrVes c = new SrVes();
                        sum += c.Sr(item.kol_veshey, item.ves);
                    }
                    Result_label.Text = $"{sum:f1}";
                }
            }
            else
                Result_label.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Second_Table second_Table = new Second_Table(SortList);
            second_Table.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Product prdct = new Product("", 0, "", 0, 0);
            double min = double.MinValue;
            foreach (Product item in table_of_products)
            {
                if (item.ves > min)
                {
                    prdct = item;
                    min = item.ves;
                }
                    
            }
            table_of_products.Remove(prdct);
            ShowList(table_of_products);
        }
    }
}
