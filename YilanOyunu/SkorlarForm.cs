using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class SkorlarForm : MetroForm
    {
        public SkorlarForm()
        {
            InitializeComponent();
            SkorlariOku();
            //ListViewItem lvi = new ListViewItem("1");
            //lvi.SubItems.Add("Yiğit");
            //lvi.SubItems.Add("388");
            //lvwSkorlar.Items.Add(lvi);
        }

        private void SkorlariOku()
        {
            try
            {
                string[] satirlar = File.ReadAllLines("skorlar.txt");
                var sira = 1;
                foreach (var satir in satirlar)
                {
                    string[] hucreler = satir.Split(';');
                    int puan = Convert.ToInt32(hucreler[0]);
                    DateTime tarih = DateTime.Parse(hucreler[1]);
                    string ad = hucreler[2];
                    lvwSkorlar.Items.Add(new ListViewItem(new string[] { sira.ToString(), ad, puan.ToString("0000") }));
                    SkorTablosunaEkle(sira, ad, puan, tarih);
                    sira++;
                }

            }
            catch (Exception)
            {

                
            }
            
        }

        private void SkorTablosunaEkle(int sira, string ad, int puan, object zaman)
        {
            ListViewItem lvi = new ListViewItem(sira.ToString());
            lvi.SubItems.Add(ad);
            lvi.SubItems.Add(puan.ToString("0000"));
            lvi.SubItems.Add(zaman.ToString());
            lvwSkorlar.Items.Add(lvi);

        }
    }
}
