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
    public partial class Uzytkownicy : Form
    {
        private DatabaseConnection dbConnect;
        private string imie, nazwisko, telefon;
        private int idUsun;
        private int idEdycja;
        public Uzytkownicy()
        {
            InitializeComponent();
            dbConnect = new DatabaseConnection();
            List<string>[] list;
            list = dbConnect.SelectUzytkownicy();
            UzytkownicyDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = UzytkownicyDG.Rows.Add();
                UzytkownicyDG.Rows[number].Cells[0].Value = list[0][i];
                UzytkownicyDG.Rows[number].Cells[1].Value = list[1][i];
                UzytkownicyDG.Rows[number].Cells[2].Value = list[2][i];
                UzytkownicyDG.Rows[number].Cells[3].Value = list[3][i];
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodajButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Jedno lub więcej pól nie zostało wypełnionych. Proszę uzupełnić dane.");
            }
            else
            {
                imie = textBox1.Text;
                nazwisko = textBox2.Text;
                telefon = textBox3.Text;
                dbConnect.DodawanieUzytkownikow(imie, nazwisko, telefon);
                MessageBox.Show("Nowy użytkownik został dodany.");
            }
            List<string>[] list;
            list = dbConnect.SelectUzytkownicy();
            UzytkownicyDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = UzytkownicyDG.Rows.Add();
                UzytkownicyDG.Rows[number].Cells[0].Value = list[0][i];
                UzytkownicyDG.Rows[number].Cells[1].Value = list[1][i];
                UzytkownicyDG.Rows[number].Cells[2].Value = list[2][i];
                UzytkownicyDG.Rows[number].Cells[3].Value = list[3][i];
            }

        }

        private void edycjaButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Jedno lub więcej pól nie zostało wypełnionych. Proszę uzupełnić dane.");
            }
            else
            {
                imie = textBox5.Text;
                nazwisko = textBox6.Text;
                telefon = textBox7.Text;
                bool successfullyParsed = int.TryParse(textBox4.Text, out idEdycja);
                if (successfullyParsed)
                {
                    dbConnect.AktualizacjaDanych(idEdycja, imie, nazwisko, telefon);
                    MessageBox.Show("Dane zostały zaktualizowane");
                }
                else
                {
                    MessageBox.Show("Wartość ID musi być liczbą");
                }
            }

            List<string>[] list;
            list = dbConnect.SelectUzytkownicy();
            UzytkownicyDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = UzytkownicyDG.Rows.Add();
                UzytkownicyDG.Rows[number].Cells[0].Value = list[0][i];
                UzytkownicyDG.Rows[number].Cells[1].Value = list[1][i];
                UzytkownicyDG.Rows[number].Cells[2].Value = list[2][i];
                UzytkownicyDG.Rows[number].Cells[3].Value = list[3][i];
            }
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            bool successfullyParsed = int.TryParse(textBox8.Text, out idUsun);
            if (successfullyParsed)
            {
                dbConnect.UsuwanieKsiazek(idUsun);
            }
            else
            {
                MessageBox.Show("Wartość ID musi być liczbą");
            }
            List<string>[] list;
            list = dbConnect.SelectUzytkownicy();
            UzytkownicyDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = UzytkownicyDG.Rows.Add();
                UzytkownicyDG.Rows[number].Cells[0].Value = list[0][i];
                UzytkownicyDG.Rows[number].Cells[1].Value = list[1][i];
                UzytkownicyDG.Rows[number].Cells[2].Value = list[2][i];
                UzytkownicyDG.Rows[number].Cells[3].Value = list[3][i];
            }
        }

        private void powrotMenuButton_Click(object sender, EventArgs e)
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();
            m1.ShowDialog();
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
