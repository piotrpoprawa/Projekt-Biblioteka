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
    public partial class Wypozyczenia : Form
    {
        private DatabaseConnection dbConnect;
        private string SzukajTytul, SzukajNazwisko, SzukajKsiazke, SzukajUzytkownika, DataZwrotu;
        private int idZwrot, idKsiazkiWyp, idUzytkownikaWyp;
        public Wypozyczenia()
        {
            InitializeComponent();
            dbConnect = new DatabaseConnection();
            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();
            wypozyczeniaDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = wypozyczeniaDG.Rows.Add();
                wypozyczeniaDG.Rows[number].Cells[0].Value = list[0][i];
                wypozyczeniaDG.Rows[number].Cells[1].Value = list[1][i];
                wypozyczeniaDG.Rows[number].Cells[2].Value = list[2][i];
                wypozyczeniaDG.Rows[number].Cells[3].Value = list[3][i];
                wypozyczeniaDG.Rows[number].Cells[4].Value = list[4][i];
                wypozyczeniaDG.Rows[number].Cells[5].Value = list[5][i];
          
            }
        }
       

        private void szukajButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Jedno lub więcej pól nie zostało wypełnionych. Proszę uzupełnić dane.");
            }
            else
            {
                SzukajTytul = textBox1.Text;
                dbConnect.SzukajPoTytule(SzukajTytul);
            }
            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();
            wypozyczeniaDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = wypozyczeniaDG.Rows.Add();
                wypozyczeniaDG.Rows[number].Cells[0].Value = list[0][i];
                wypozyczeniaDG.Rows[number].Cells[1].Value = list[1][i];
                wypozyczeniaDG.Rows[number].Cells[2].Value = list[2][i];
                wypozyczeniaDG.Rows[number].Cells[3].Value = list[3][i];
                wypozyczeniaDG.Rows[number].Cells[4].Value = list[4][i];
                wypozyczeniaDG.Rows[number].Cells[5].Value = list[5][i];
               
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wypozyczeniaDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void szukajUzButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Jedno lub więcej pól nie zostało wypełnionych. Proszę uzupełnić dane.");
            }
            else
            {
                SzukajUzytkownika = textBox5.Text;
                dbConnect.SzukajUzytkownika(SzukajUzytkownika);
            }
            List<string>[] list;
            list = dbConnect.SzukajUzytkownika(SzukajUzytkownika);
            SkrotUzytkownicyDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = SkrotUzytkownicyDG.Rows.Add();
                SkrotUzytkownicyDG.Rows[number].Cells[0].Value = list[0][i];
                SkrotUzytkownicyDG.Rows[number].Cells[1].Value = list[1][i];
                SkrotUzytkownicyDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
            }
        }

        private void wypozButton_Click_1(object sender, EventArgs e)
        {
            bool successfullyParsed = int.TryParse(textBox7.Text, out idKsiazkiWyp);
            bool successfullyParsed2 = int.TryParse(textBox8.Text, out idUzytkownikaWyp);
            if (successfullyParsed && successfullyParsed2)
            {
                DataZwrotu = textBox6.Text;
                dbConnect.WypozyczKsiazke(idKsiazkiWyp, idUzytkownikaWyp, DataZwrotu);
                MessageBox.Show("Dodano książkę do Wypożyczeń Użytkownika.");
            }
            else
            {
                MessageBox.Show("Wartości ID muszą być liczbami");
            }
            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();
            wypozyczeniaDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = wypozyczeniaDG.Rows.Add();
                wypozyczeniaDG.Rows[number].Cells[0].Value = list[0][i];
                wypozyczeniaDG.Rows[number].Cells[1].Value = list[1][i];
                wypozyczeniaDG.Rows[number].Cells[2].Value = list[2][i];
                wypozyczeniaDG.Rows[number].Cells[3].Value = list[3][i];
                wypozyczeniaDG.Rows[number].Cells[4].Value = list[4][i];
                wypozyczeniaDG.Rows[number].Cells[5].Value = list[5][i];
                
            }
        }

        private void szukajKsiazkeButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Jedno lub więcej pól nie zostało wypełnionych. Proszę uzupełnić dane.");
            }
            else
            {
                SzukajKsiazke = textBox4.Text;
                dbConnect.SzukajKsiazke(SzukajKsiazke);
            }
            List<string>[] list;
            list = dbConnect.SzukajKsiazke(SzukajKsiazke);
            DostepneTytulyDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = DostepneTytulyDG.Rows.Add();
                DostepneTytulyDG.Rows[number].Cells[0].Value = list[0][i];
                DostepneTytulyDG.Rows[number].Cells[1].Value = list[1][i];
                DostepneTytulyDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
            }

        }

        private void zwrotButton_Click_1(object sender, EventArgs e)
        {
            {
                bool successfullyParsed = int.TryParse(textBox3.Text, out idZwrot);
                if (successfullyParsed)
                {
                    dbConnect.ZwrotKsiazki(idZwrot);
                    MessageBox.Show("Dokonano aktualizacji danych!");
                }
                else
                {
                    MessageBox.Show("Wartośc id musi być liczbą!");
                }
            }

            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();
            wypozyczeniaDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = wypozyczeniaDG.Rows.Add();
                wypozyczeniaDG.Rows[number].Cells[0].Value = list[0][i];
                wypozyczeniaDG.Rows[number].Cells[1].Value = list[1][i];
                wypozyczeniaDG.Rows[number].Cells[2].Value = list[2][i];
                wypozyczeniaDG.Rows[number].Cells[3].Value = list[3][i];
                wypozyczeniaDG.Rows[number].Cells[4].Value = list[4][i];
                wypozyczeniaDG.Rows[number].Cells[5].Value = list[5][i];
               
            }

        }

        private void szukajButton2_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Jedno lub więcej pól nie zostało wypełnionych. Proszę uzupełnić dane.");
            }
            else
            {
                SzukajNazwisko = textBox2.Text;
                dbConnect.SzukajPoNazwisku(SzukajNazwisko);
            }
            List<string>[] list;
            list = dbConnect.PokazWypozyczenia();
            wypozyczeniaDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = wypozyczeniaDG.Rows.Add();
                wypozyczeniaDG.Rows[number].Cells[0].Value = list[0][i];
                wypozyczeniaDG.Rows[number].Cells[1].Value = list[1][i];
                wypozyczeniaDG.Rows[number].Cells[2].Value = list[2][i];
                wypozyczeniaDG.Rows[number].Cells[3].Value = list[3][i];
                wypozyczeniaDG.Rows[number].Cells[4].Value = list[4][i];
                wypozyczeniaDG.Rows[number].Cells[5].Value = list[5][i];
               
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
