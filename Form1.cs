using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area
{
    public partial class area : Form
    {
        public area()
        {
            InitializeComponent();
        }

        private void bangunDatar(string r, string l1, string l2, bool v1 = true, bool v2 = true)
        {
            rumus.Text = r;
            label1.Text = l1;
            label2.Text = l2;
            val1.Enabled = v1;
            val2.Enabled = v2;
        }

        private void area_Load(object sender, EventArgs e)
        {
            bangun_datar.SelectedIndex = 0;
            val1.Clear();
            val2.Clear();
            hasil.Text = "";
        }

        private void bangun_datar_SelectedIndexChanged(object sender, EventArgs e)
        {
            val1.Clear();
            val2.Clear();
            hasil.Text = "";
            switch (bangun_datar.Text)
            {
                case "- Pilih -":
                    bangunDatar("Rumus", "", "", false, false);
                    break;
                case "Persegi":
                    bangunDatar("L = s x s", "Sisi (s)", "", true, false);
                    break;
                case "Persegi Panjang":
                    bangunDatar("L = p x l", "Panjang (p)", "Lebar (l)");
                    break;
                case "Segitiga":
                    bangunDatar("L = 1/2 x a x t", "Alas (a)", "Tinggi (t)");
                    break;
                case "Lingkaran":
                    bangunDatar("L = phi x r x r", "Jari-jari (r)", "", true, false);
                    break;
                case "Trapesium":
                    bangunDatar("L = 1/2 x (s1+s2) x t", "Sisi 1 + Sisi 2 (s1+s2)", "Tinggi (t)");
                    break;
                case "Jajar Genjang":
                    bangunDatar("L = a x t", "Alas (a)", "Tinggi (t)");
                    break;
                case "Belah Ketupat":
                    bangunDatar("L = 1/2 x d1 x d2", "Diagonal 1 (d1)", "Diagonal 2 (d2)");
                    break;
                case "Layang-layang":
                    bangunDatar("L = 1/2 x d1 x d2", "Diagonal 1 (d1)", "Diagonal 2 (d2)");
                    break;
            }
        }

        private void hitung_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(val1.Text, "^-?\\d*(\\,\\d+)?$") ||
                !Regex.IsMatch(val2.Text, "^-?\\d*(\\,\\d+)?$"))
            {
                hasil.Text = "Invalid Input";
            }
            else
            {
                float a, b;
                a = val1.Text == "" ? 0 : float.Parse(val1.Text);
                b = val2.Text == "" ? 0 : float.Parse(val2.Text);
                switch (bangun_datar.Text)
                {
                    case "- Pilih -":
                        hasil.Text = "Pilih Bangun Datar";
                        break;
                    case "Persegi":
                        hasil.Text = Math.Round(a * a, 2).ToString();
                        break;
                    case "Persegi Panjang":
                        hasil.Text = Math.Round(a * b, 2).ToString();
                        break;
                    case "Segitiga":
                        hasil.Text = Math.Round((1 / 2f) * a * b, 2).ToString();
                        break;
                    case "Lingkaran":
                        hasil.Text = Math.Round((22 / 7f) * a * a, 2).ToString();
                        break;
                    case "Trapesium":
                        hasil.Text = Math.Round((1 / 2f) * a * b, 2).ToString();
                        break;
                    case "Jajar Genjang":
                        hasil.Text = Math.Round(a * b, 2).ToString();
                        break;
                    case "Belah Ketupat":
                        hasil.Text = Math.Round((1 / 2f) * a * b, 2).ToString();
                        break;
                    case "Layang-layang":
                        hasil.Text = Math.Round((1 / 2f) * a * b, 2).ToString();
                        break;
                }
            }
        }
    }
}
