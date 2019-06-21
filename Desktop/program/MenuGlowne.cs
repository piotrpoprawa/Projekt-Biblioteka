using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void ksiegozbiorButton_Click(object sender, EventArgs e)
        {
            Ksiegozbior k1 = new Ksiegozbior();
            this.Hide();//
            k1.ShowDialog();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uzytkownicyButton_Click(object sender, EventArgs e)
        {
            // Przyciski w menu głównym - użytkownicy
            Uzytkownicy u1 = new Uzytkownicy();
            this.Hide();
            u1.ShowDialog();
        }

        private void wypozyczeniaButton_Click(object sender, EventArgs e)
        {
            //  Przyciski w menu głównym - wypożyczenia
            Wypozyczenia w1 = new Wypozyczenia();
            this.Hide();
            w1.ShowDialog();
        }
    }
}
