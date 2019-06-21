using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Biblioteka
{

    class DatabaseConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

       public DatabaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            // parametry połączeniowe do serwera bazy danych MySQL
            server = "127.0.0.1";
            database = "biblioteka_projekt";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            // Obsługa błędow w połączeniu się z bazą
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Problem z połączeniem do Bazy Danych.\nSprawdź połączenie internetowe");
            }
            return false;
        }
        
        private bool CloseConnection()
        {
            // Obsługa błędów w zamykaniu połączenia z bazą
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<string>[] SelectPolskie()
        {
            string query = "SELECT * FROM biblioteka_ksiazki where KATEGORIA='polska'";
            
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_KSIAZKI"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["AUTOR_IMIE"] + "");
                    list[3].Add(dataReader["AUTOR_NAZWISKO"] + "");
                    list[4].Add(dataReader["KATEGORIA"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

               dataReader.Close();

               this.CloseConnection();

               return list;
            }
            else
            {
                return list;
            }
        }
        
        public List<string>[] SelectAmerykanska()
        {
            string query = "SELECT * FROM biblioteka_ksiazki where KATEGORIA='amerykańska'";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
                        
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

               while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_KSIAZKI"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["AUTOR_IMIE"] + "");
                    list[3].Add(dataReader["AUTOR_NAZWISKO"] + "");
                    list[4].Add(dataReader["KATEGORIA"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

               dataReader.Close();

               this.CloseConnection();

               return list;
            }
            else
            {
                return list;
            }
        }
       
        public List<string>[] SelectFantastyka()
        {
            string query = "SELECT * FROM biblioteka_ksiazki where KATEGORIA='fantastyka'";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

               while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_KSIAZKI"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["AUTOR_IMIE"] + "");
                    list[3].Add(dataReader["AUTOR_NAZWISKO"] + "");
                    list[4].Add(dataReader["KATEGORIA"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }
       
        public List<string>[] SelectPopularnonaukowe()
        {
            string query = "SELECT * FROM biblioteka_ksiazki where KATEGORIA='popularnonaukowe'";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
               MySqlCommand cmd = new MySqlCommand(query, connection);
               MySqlDataReader dataReader = cmd.ExecuteReader();

               while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_KSIAZKI"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["AUTOR_IMIE"] + "");
                    list[3].Add(dataReader["AUTOR_NAZWISKO"] + "");
                    list[4].Add(dataReader["KATEGORIA"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }
        
        public List<string>[] SelectKsiegozbior()
        {
           string query = "SELECT * FROM biblioteka_ksiazki";

           List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
               MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_KSIAZKI"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["AUTOR_IMIE"] + "");
                    list[3].Add(dataReader["AUTOR_NAZWISKO"] + "");
                    list[4].Add(dataReader["KATEGORIA"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

               dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }

        }
             
        public void DodawanieKsiazek(string tytul, string autor_imie, string autor_nazwisko, string kategoria)
        {
            string query = "INSERT INTO biblioteka_ksiazki (TYTUL,AUTOR_IMIE,AUTOR_NAZWISKO,KATEGORIA) VALUES('" + tytul + "','" + autor_imie + "','" + autor_nazwisko + "'," + kategoria + ")";

           if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public void AktualizacjaKsiazek(int idEdycja, string tytul, string imie, string nazwisko, string kategoria)
        {
            string query = "UPDATE biblioteka_ksiazki SET TYTUL=('" + tytul + "') , AUTOR_IMIE=('" + imie + "'), AUTOR_NAZWISKO=('" + nazwisko + "'), KATEGORIA=('" + kategoria + "') WHERE ID_KSIAZKI=('" + idEdycja + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public void UsuwanieKsiazek(int idUsuwane)
        {
            string query = "delete from biblioteka_ksiazko WHERE ID_KSIAZKI=('" + idUsuwane + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
       
        public List<string>[] SelectUzytkownicy()
        {
            string query = "SELECT * FROM biblioteka_uzytkownicy";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (this.OpenConnection() == true)
            {
               MySqlCommand cmd = new MySqlCommand(query, connection);
               MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_UZ"] + "");
                    list[1].Add(dataReader["UZ_IMIE"] + "");
                    list[2].Add(dataReader["UZ_NAZWISKO"] + "");
                    list[3].Add(dataReader["UZ_TELEFON"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }
       
        public void DodawanieUzytkownikow(string imie, string nazwisko, string telefon)
        {
            string query = "INSERT INTO biblioteka_uzytkownicy (UZ_IMIE,UZ_NAZWISKO,UZ_TELEFON) VALUES('" + imie + "','" + nazwisko + "','" + telefon + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

               cmd.ExecuteNonQuery();

               this.CloseConnection();
            }
        }
       
        public void UsuwanieUzytkownikow(int idUsuwanego)
        {
            string query = "delete from biblioteka_uzytkownicy WHERE ID_UZ=('" + idUsuwanego + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

               cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
       
        public void AktualizacjaDanych(int IdZmiany, string imie, string nazwisko, string telefon)
        {
            string query = "UPDATE biblioteka_uzytkownicy SET UZ_IMIE=('" + imie + "') , UZ_NAZWISKO=('" + nazwisko + "'), UZ_TELEFON=('" + telefon + "') WHERE ID_UZ=('" + IdZmiany + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

               this.CloseConnection();
            }
        }

        public List<string>[] PokazWypozyczenia()
        {
            string query = "SELECT biblioteka_wypozyczenia.ID_WYPOZ, biblioteka_ksiazki.TYTUL, biblioteka_uzytkownicy.UZ_NAZWISKO, biblioteka_uzytkownicy.UZ_IMIE, biblioteka_wypozyczenia.ZWROT, biblioteka_ksiazki.CZY_DOSTEPNA FROM biblioteka_ksiazki INNER JOIN (biblioteka_uzytkownicy INNER JOIN biblioteka_wypozyczenia ON biblioteka_uzytkownicy.ID_UZ = biblioteka_wypozyczenia.ID_UZ) ON biblioteka_ksiazki.ID_KSIAZKI = biblioteka_wypozyczenia.ID_KSIAZKI";
            
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            

            if (this.OpenConnection() == true)
            {
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_WYPOZ"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["UZ_NAZWISKO"] + "");
                    list[3].Add(dataReader["UZ_IMIE"] + "");
                    list[4].Add(dataReader["ZWROT"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

                dataReader.Close();

               this.CloseConnection();

               return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SzukajPoTytule(string ksiazkaTytul)
        {
            string query = "SELECT biblioteka_wypozyczenia.ID_WYPOZ, biblioteka_ksiazki.TYTUL, biblioteka_uzytkownicy.UZ_NAZWISKO, biblioteka_uzytkownicy.UZ_IMIE, biblioteka_wypozyczenia.ZWROT, biblioteka_ksiazki.CZY_DOSTEPNA FROM biblioteka_ksiazki INNER JOIN (biblioteka_uzytkownicy INNER JOIN biblioteka_wypozyczenia ON biblioteka_uzytkownicy.ID_UZ = biblioteka_wypozyczenia.ID_UZ) ON biblioteka_ksiazki.ID_KSIAZKI = biblioteka_wypozyczenia.ID_KSIAZKI WHERE biblioteka_ksiazki.TYTUL=('" + ksiazkaTytul + "')";
           
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_WYPOZ"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["UZ_NAZWISKO"] + "");
                    list[3].Add(dataReader["UZ_IMIE"] + "");
                    list[4].Add(dataReader["ZWROT"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SzukajPoNazwisku(string uzytkownikNazwisko)
        {
            string query = "SELECT biblioteka_wypozyczenia.ID_WYPOZ, biblioteka_ksiazki.TYTUL, biblioteka_uzytkownicy.UZ_NAZWISKO, biblioteka_uzytkownicy.UZ_IMIE, biblioteka_wypozyczenia.ZWROT, biblioteka_ksiazki.CZY_DOSTEPNA FROM biblioteka_ksiazki INNER JOIN (biblioteka_uzytkownicy INNER JOIN biblioteka_wypozyczenia ON biblioteka_uzytkownicy.ID_UZ = biblioteka_wypozyczenia.ID_UZ) ON biblioteka_ksiazki.ID_KSIAZKI = biblioteka_wypozyczenia.ID_KSIAZKI WHERE biblioteka_uzytkownicy.UZ_NAZWISKO=('" + uzytkownikNazwisko + "')";
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_WYPOZ"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["UZ_NAZWISKO"] + "");
                    list[3].Add(dataReader["UZ_IMIE"] + "");
                    list[4].Add(dataReader["ZWROT"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SzukajKsiazke(string SzukajKsiazkeTytul)
        {
            string query = "SELECT * FROM biblioteka_ksiazki where TYTUL=('" + SzukajKsiazkeTytul + "')";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_KSIAZKI"] + "");
                    list[1].Add(dataReader["TYTUL"] + "");
                    list[2].Add(dataReader["AUTOR_IMIE"] + "");
                    list[3].Add(dataReader["AUTOR_NAZWISKO"] + "");
                    list[4].Add(dataReader["KATEGORIA"] + "");
                    list[5].Add(dataReader["CZY_DOSTEPNA"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SzukajUzytkownika(string SzukajUzytkownika)
        {
            string query = "SELECT * FROM biblioteka_uzytkownicy where UZ_NAZWISKO=('" + SzukajUzytkownika + "')";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>(); 
            list[3] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_UZ"] + "");
                    list[1].Add(dataReader["UZ_IMIE"] + "");
                    list[2].Add(dataReader["UZ_NAZWISKO"] + "");
                    list[3].Add(dataReader["UZ_TELEFON"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }



        public void WypozyczKsiazke(int idUzytkownika, int idKsiazki, string dataZwrotu)
        {
            string query = "INSERT INTO biblioteka_wypozyczenia (ID_KSIAZKI,ID_UZ,ZWROT) VALUES ('" + idKsiazki + "','" + idUzytkownika + "','" + dataZwrotu + "')";
            string query2 = "UPDATE biblioteka_ksiazki Set CZY_DOSTEPNA = 'nie' where ID_KSIAZKI = ('" + idKsiazki + "')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        
        public void ZwrotKsiazki(int idWypozyczenia)
        {
            string query2 = "UPDATE biblioteka_ksiazki SET CZY_DOSTEPNA= 'tak' WHERE biblioteka_ksiazki.ID_KSIAZKI=( SELECT biblioteka_wypozyczenia.ID_KSIAZKI FROM biblioteka_wypozyczenia WHERE biblioteka_wypozyczenia.ID_WYPOZ=('" + idWypozyczenia + "'))";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                cmd2.ExecuteNonQuery();

                this.CloseConnection();
            }
        }         
    }
}

