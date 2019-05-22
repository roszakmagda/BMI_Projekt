using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
//using CS_BMI_Kalkulator;


namespace Logowanie
{
    public partial class logowanie : Form
    {
        public static string login; // zmienna statyczna login przechowująca login 
        string qqq;

        public logowanie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // funckja uruchamia się po wciśnięciu przysicku Wyjście. 
        {
            this.Close(); // zamknięcie okna aplikacji 


        }

        static string GetMd5Hash(MD5 md5Hash, string wpisane) // funckja kodująca - MD5, dla zmiennej string wpisane
        {

            
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(wpisane)); // konwersja zmiennej wpisane na tablicę bajtów  i obliczenie hash 

           
            StringBuilder sBuilder = new StringBuilder(); // stworzymy StringBuildera który przechowuje te bajty

            
            for (int i = 0; i < data.Length; i++) // każdy bajt na długości 
            {
                sBuilder.Append(data[i].ToString("x2")); // kodujemy i zapisujemy jako heksadecymalny string
            }

           
            return sBuilder.ToString(); // na koniec zwracamy heksadecymalny string 
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string wpisane, string qqq) // funkcja boolowska sprawdzająca poprawność 
        {
            
            string hashOfInput = GetMd5Hash(md5Hash, wpisane); // hash wejściowy 

           
            StringComparer comparer = StringComparer.OrdinalIgnoreCase; // tworzymy string comparer do porównywania wartości 

            if (0 == comparer.Compare(hashOfInput, qqq)) // jeśli porównane wartości są jednakowe 
            {
                return true; // zwracamy prawdę 
            }
            else
            {
                return false;
            }
        }



        public void btnLogin_Click(object sender, EventArgs e) // akcja po wsiśnięciu przysiku zaloguj 
        {
            // tworzymy połączenie z bazą danych. Do wprowadzonego adresu dostajemy się wchodząc widok>eksplorator serwera>nazwa_tabeli>właściwości 
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\magda\Desktop\baza_logowanie.mdf;Integrated Security=True;Connect Timeout=30");
            
            // zmienna qqq przechowuje tekst wpisany do labela odpowiadającego za wpisanie hasła 
            qqq = txtPassword.Text.Trim();
            

            using (MD5 md5Hash = MD5.Create()) 
            {
                string hash = GetMd5Hash(md5Hash, txtPassword.Text); // tworzymy string hash - zawiera on hasło po zakodowaniu 

           
                string query = "Select * from [Table] Where username = '" + txtUsername.Text.Trim() + "' and password = '" + hash.Trim()+ "'"; // polecenie pobierające dane z bazy danych
                // pobieramy takie gdzie pole username jest równe wprowadzonemu loginowi, natomiast hasło (!!!) porównujemy zakodowane, a nie wprowadzone do labela
                
                SqlDataAdapter sdaa = new SqlDataAdapter(query, sqlcon); // właściwości dataadapter to polecenie sql + polączona baza danych 
                    DataTable dtbl = new DataTable(); 
                    sdaa.Fill(dtbl); // wypełnienie bazy danych 
                    if (dtbl.Rows.Count == 1) // jeśli są pasujące kolumny (czyli zarówno hasło jak i login są wprowadzone poprawnie) 
                    {
                        login = txtUsername.Text.Trim(); // do zmiennej login zapisujemy tekst z pola txtUserName. Zmienna przyda nam się w klasie oknoprobne.cs
                        frmMain objfrmMain = new frmMain(); // tworzymy obiekt frmMain czyli okna probnego 
                        this.Hide(); // zamykamy okno lokowania 
                        objfrmMain.Show(); // wyswietlamy okno probne 
                    }

                else
                {
                    MessageBox.Show("Niepoprawne dane ");
                }
         
            }
        }

            private void logowanie_Load(object sender, EventArgs e)
            {

            }
        }
    } 
