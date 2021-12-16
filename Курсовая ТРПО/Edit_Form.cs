using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Edit_Form : Form
    {
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            int index = 0;
            
            bool isNum = true;
            double num;
            if (Fam_Box.Text != "")
            {
                int i = 0;
                foreach (Product item in GeneralForm.table_of_products)
                {
                    i++;
                    if (item.fam == Fam_Box.Text)
                        index = i;
                }
                int findex = index;
                if (Code_Box.Text != "")
                {
                    GeneralForm.table_of_products[findex - 1].echeyka = Int32.Parse(Code_Box.Text); 
                }

                if (Shif_Box.Text != "")
                {
                    GeneralForm.table_of_products[findex - 1].code_bagaj = Shif_Box.Text; 
                }

                if (Kol2_Box.Text != "")
                {
                    if (isNum == int.TryParse(Kol2_Box.Text, out index))
                    {
                        GeneralForm.table_of_products[findex - 1].kol_veshey = Int32.Parse(Kol2_Box.Text); 
                    }
                    else
                        MessageBox.Show("В поле должны быть только целые числа");
                }
                

                if (Ves2_Box.Text != "")
                {
                    if (isNum == double.TryParse(Ves2_Box.Text, out num))
                    {
                        GeneralForm.table_of_products[findex - 1].ves = double.Parse(Ves2_Box.Text); 
                    }
                    else
                        MessageBox.Show("В поле должы быть только числа");
                }
                this.Close();


            }
            else
                MessageBox.Show("Вы не ввели код товара");
        }
    }
}
