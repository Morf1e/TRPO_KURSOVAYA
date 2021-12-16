using System;
using System.Collections.Generic;
using System.Text;

namespace Курсовая_ТРПО
{
    public class Product
    {
        public string fam; // Фамилия пассажира
        public string code_bagaj; // шифр багажа
        public int echeyka; // ячейка багажа
        public int kol_veshey; // кол-во вещей
        public double ves; // вес багажа

        public Product(string fam, int echeyka, string code_bagaj,  int kol, double ves)
        {

            this.fam = fam; 
            this.code_bagaj = code_bagaj;
            this.echeyka = echeyka;
            this.kol_veshey = kol;
            this.ves = ves;
        }
    }
}
