using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[] tömb = new int[25];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 25; i++)
            {
                tömb[i] = i + 1;
            }

            Kever();
            int sorszám = 0;
            for (int sor = 0; sor < 5; sor++)
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    Kepkocka k = new Kepkocka("lo_" + tömb[sorszám].ToString() + ".jpg", sor, oszlop);               
                    this.Controls.Add(k);
                    sorszám++;
                }
        }

        void Kever()
        {
            Random rnd = new Random();
            int n = 25;
            for (int i = 0; i < n; i++)
            {
                int rdn = rnd.Next(n);
                int köztes = tömb[i];
                tömb[i] = tömb[rdn];
                tömb[rdn] = köztes;
            }
        }



    }
}
