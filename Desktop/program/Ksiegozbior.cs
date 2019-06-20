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
    public partial class Ksiegozbior : Form
    {
        private DatabaseConnection dbConnect;
        public Ksiegozbior()
        {
            InitializeComponent();
            dbConnect = new DatabaseConnection();
            
            List<string>[] list;
            list = dbConnect.SelectKsiegozbior(); 
            KsiegozbiorDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = KsiegozbiorDG.Rows.Add();
                KsiegozbiorDG.Rows[number].Cells[0].Value = list[0][i];
                KsiegozbiorDG.Rows[number].Cells[1].Value = list[1][i];
                KsiegozbiorDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
                KsiegozbiorDG.Rows[number].Cells[3].Value = list[4][i];
                KsiegozbiorDG.Rows[number].Cells[4].Value = list[5][i];
             }
        }

        private void KsiegozbiorDG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void polskaButton_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.SelectPolskie(); 
            KsiegozbiorDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = KsiegozbiorDG.Rows.Add();
                KsiegozbiorDG.Rows[number].Cells[0].Value = list[0][i];
                KsiegozbiorDG.Rows[number].Cells[1].Value = list[1][i];
                KsiegozbiorDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
                KsiegozbiorDG.Rows[number].Cells[3].Value = list[4][i];
                KsiegozbiorDG.Rows[number].Cells[4].Value = list[5][i];
            }
        }


                           
        private void backButton_Click_1(object sender, EventArgs e)
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();
            m1.ShowDialog();
        }

        private void edycjaButton_Click_1(object sender, EventArgs e)
        {
            EdycjaKsiegozbioru e1 = new EdycjaKsiegozbioru();
            this.Hide();
            e1.ShowDialog();
        }

        private void wszystkieButton_Click_1(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.SelectKsiegozbior();
            KsiegozbiorDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = KsiegozbiorDG.Rows.Add();
                KsiegozbiorDG.Rows[number].Cells[0].Value = list[0][i];
                KsiegozbiorDG.Rows[number].Cells[1].Value = list[1][i];
                KsiegozbiorDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
                KsiegozbiorDG.Rows[number].Cells[3].Value = list[4][i];
                KsiegozbiorDG.Rows[number].Cells[4].Value = list[5][i];
            }
        }

        private void popularnonaukowaButton_Click_1(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.SelectPopularnonaukowe();
            KsiegozbiorDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = KsiegozbiorDG.Rows.Add();
                KsiegozbiorDG.Rows[number].Cells[0].Value = list[0][i];
                KsiegozbiorDG.Rows[number].Cells[1].Value = list[1][i];
                KsiegozbiorDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
                KsiegozbiorDG.Rows[number].Cells[3].Value = list[4][i];
                KsiegozbiorDG.Rows[number].Cells[4].Value = list[5][i];
            }
        }

        private void fantastykaButton_Click_1(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.SelectFantastyka();
            KsiegozbiorDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = KsiegozbiorDG.Rows.Add();
                KsiegozbiorDG.Rows[number].Cells[0].Value = list[0][i];
                KsiegozbiorDG.Rows[number].Cells[1].Value = list[1][i];
                KsiegozbiorDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
                KsiegozbiorDG.Rows[number].Cells[3].Value = list[4][i];
                KsiegozbiorDG.Rows[number].Cells[4].Value = list[5][i];
            }
        }

        private void amerykanskaButton_Click_1(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.SelectAmerykanska();
            KsiegozbiorDG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = KsiegozbiorDG.Rows.Add();
                KsiegozbiorDG.Rows[number].Cells[0].Value = list[0][i];
                KsiegozbiorDG.Rows[number].Cells[1].Value = list[1][i];
                KsiegozbiorDG.Rows[number].Cells[2].Value = list[2][i] + " " + list[3][i];
                KsiegozbiorDG.Rows[number].Cells[3].Value = list[4][i];
                KsiegozbiorDG.Rows[number].Cells[4].Value = list[5][i];
            }
        }
    }
}
