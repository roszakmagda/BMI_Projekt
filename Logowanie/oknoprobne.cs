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


namespace Logowanie
{

    public partial class frmMain : Form
    {
        logowanie logowanie = new logowanie(); // tworzymy instancję klasy logowanie żeby odwołać się do zmiennej login z tamtej klasy
        double h; // zmienna wzrost 
        double w; // zmienna waga 
        double t; // zmienna przechowująca wynik BMI 
       
        StreamWriter plik; // tworzymy streamwritera plik, który później będzie potrzebny przy zapisie wyników do pliku 


        DateTime thisDay = DateTime.Today; // tworzymy zmienną thisDay przechowującą aktualną datę dzienną 
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Reset_Click(object sender, EventArgs e) // funkcja wywoływana po wciśnięciu przycisku reset 
        {
            waga.Clear();
            wzrost.Clear();
            wiek.Clear();
            diagnoza.Clear();
            wynik.Text = ""; // czyścimy wszystkie powyższe komponenty 
            wynik.BackColor = Color.White;
            if (kobieta.Checked == true) // jeśli zaznaczone było pole kobieta lub (poniżej) mężczyzna to odznaczamy je
            {
                kobieta.Checked = false;
            }
            if (mezczyzna.Checked == true)
            {
                mezczyzna.Checked = false;
            }

        }


        private void bt_wylicz_Click(object sender, EventArgs e) // akcja po wciśnięciu przycisku wylicz 
        {
            double num;
            bool isNum = double.TryParse(wiek.Text, out num); // zmienna num (podobnie jak dwie pozostałe poniżej) sprawdza czy wprowadzona wartość jest numerem
            // do sprawdzenia po kolei brane są pola wiek, wzrost i waga 
            double nume;
            bool isNume = double.TryParse(wzrost.Text, out nume);
            double numer;
            bool isNumer = double.TryParse(waga.Text, out numer);
            if (!isNum ||!isNume || !isNumer ) // jeśli któreś z pól nie jest numerem wyświetla się komunikat o niepoprawności danych
            {
                MessageBox.Show("Wprowadzono blędne dane ");
            }
           else if (wiek.Text.Length > 7 || wiek.Text == "" || Double.Parse(wiek.Text) <= 0 || Double.Parse(wiek.Text) > 150) 
                // jeśli długość wprowadzonego wieku przekracza 7 znaków, lub jeśli pole nie zostało uzupełnione, lub jeśli wprowadzona wartość jest mniejsza równa 0
                // lub większa od 150 (zgodnie ze specyfikacją) 
            {
                MessageBox.Show("Niepoprawnie wprowadzony wiek! "); // wyświetl komunikat o błędzie 
                return;
            }


            
            else if (waga.Text.Length > 7 || waga.Text == "" || Double.Parse(waga.Text) <= 0 || Double.Parse(waga.Text) > 500 )
            // jeśli długość wprowadzonej wagi przekracza 7 znaków, lub jeśli pole nie zostało uzupełnione, lub jeśli wprowadzona wartość jest mniejsza równa 0
            // lub większa od 500 (zgodnie ze specyfikacją) 
            {

                MessageBox.Show("Niepoprawnie wprowadzona waga!");
                return;
            }
            else if (wzrost.Text.Length > 7 || wzrost.Text == "" || Double.Parse(wzrost.Text) <= 0 || Double.Parse(wzrost.Text) > 300)
            // jeśli długość wprowadzonego wzrostu przekracza 7 znaków, lub jeśli pole nie zostało uzupełnione, lub jeśli wprowadzona wartość jest mniejsza równa 0
            // lub większa od 300 (zgodnie ze specyfikacją) 
            {

                MessageBox.Show("Niepoprawnie wprowadzony wzrost");
                return;
            }

          

            else // jeśli żaden z powyższych else if nie został spełniony
            {
                double dz = Double.Parse(wiek.Text); // tworzymy zmienną dz, Double.Parse Konwertuje ciąg znaków reprezentujący liczbę na równoważną liczbę zmiennoprzecinkową o podwójnej precyzji.
                                                     
                h = Double.Parse(wzrost.Text); // podobnie postępujemy z pozostałymi zmiennymi 
                w = Double.Parse(waga.Text);

                wynik.BackColor = Color.White;
            
            h = h / 100; // wzrost podany jest w centymetrach (zgodnie ze specyfikacją) dlatego zamieniamy teraz na metry aby podstawić do wzoru
            t = w / (h * h); // wzór na obliczanie bmi
            wynik.Text = String.Format("{0:f}", t); // w polu odpowiadającym za wyświetlanie wyniku wyświetlamy wynik typu float

         
            string nick = logowanie.login; // tworzymy zmienną typu string, która jest zmienną login z klasy logowanie 
                try // staramy się otworzyć plik, aby zapisać dane
                {
                     plik = new StreamWriter(("C: /Users/magda/Desktop/wyniki.txt"), true); // otwieramy połączenie z plikiem 
                    plik.WriteLine("{0,0}{1,36}{2,46}", nick, thisDay.ToString("D"), Math.Round(t, 2)); // zapisujemy dane takie jak nick, data i wartość bmi zaokrąglona do 2 miejsc po przecinku

                    if (dz < 16) // poniżej 16 roku życia uznajemy za dziecko, więc sprawdzmay jaki wiek został podany
                    {

                        if (t < 11) // jeśli wynik jest mniejszy od 11 (wszystkie pozostałe else if pochodzą z danych uzyskanych w internecie nt. analizy wyników BMI) 
                        {
                            diagnoza.Text = "niedowaga";
                            diagnoza.ForeColor = Color.DarkRed;
                        }
                        else if (t < 14)
                        {
                            diagnoza.Text = "szczupłość";
                            diagnoza.ForeColor = Color.OrangeRed;
                        }
                        else if (t < 16)
                        {
                            diagnoza.Text = "waga prawidłowa";
                            diagnoza.ForeColor = Color.Green;
                        }
                        else if (t < 19)
                        {
                            diagnoza.Text = "nadwaga";
                            diagnoza.ForeColor = Color.Blue;
                        }
                        else if (t < 21.5)
                        {
                            diagnoza.Text = "skrajna otyłość";
                            diagnoza.ForeColor = Color.DarkRed;
                        }
                        else
                        {
                            diagnoza.Text = "skrajna otyłość";
                            diagnoza.ForeColor = Color.Brown;
                        }
                    }
                    else // jeśli wiek nie był mniejszy od 16 
                    {
                        if (kobieta.Checked == true) // sprawdzamy czy mamy do czynienia z kobietą 
                        {
                            if (t < 19)
                            {
                                diagnoza.Text = "niedowaga";
                                diagnoza.ForeColor = Color.DarkRed;

                            }
                            else if (t < 24)
                            {
                                diagnoza.Text = "waga prawidłowa";
                                diagnoza.ForeColor = Color.Green;

                            }
                            else if (t < 30)
                            {
                                diagnoza.Text = "nadwaga";
                                diagnoza.ForeColor = Color.Red;
                            }
                            else if (t < 35)
                            {
                                diagnoza.Text = "I stopień otyłości";
                                diagnoza.ForeColor = Color.DarkRed;
                            }
                            else if (t < 40)
                            {
                                diagnoza.Text = "II stopień otyłości";
                                diagnoza.ForeColor = Color.Pink;
                            }
                            else
                            {
                                diagnoza.Text = "Otyłość skrajna";
                                diagnoza.ForeColor = Color.Plum;
                            }
                        }

                        else if (mezczyzna.Checked == true) // czy z mężczyzną
                        {
                            if (t < 19)
                            {
                                diagnoza.Text = "niedowaga";
                                diagnoza.ForeColor = Color.DarkRed; // w zależności od diagnozy kolor tekstu jest inny - od czerwonego po zielony  
                                diagnoza.ForeColor = Color.DarkRed; // w zależności od diagnozy kolor tekstu jest inny - od czerwonego po zielony  

                            }
                            else if (t < 25)
                            {
                                diagnoza.Text = "waga prawidłowa";
                                diagnoza.ForeColor = Color.Green;

                            }
                            else if (t < 30)
                            {
                                diagnoza.Text = "nadwaga";
                                diagnoza.ForeColor = Color.Red;
                            }
                            else if (t < 35)
                            {
                                diagnoza.Text = "I stopień otyłości";
                                diagnoza.ForeColor = Color.DarkRed;
                            }
                            else if (t < 40)
                            {
                                diagnoza.Text = "II stopień otyłości";
                                diagnoza.ForeColor = Color.Pink;
                            }
                            else
                            {
                                diagnoza.Text = "Otyłość skrajna";
                                diagnoza.ForeColor = Color.Plum;
                            }
                        }
                    }
                }
                catch (IOException) // jeśli nie udało się dostać do pliku to wyświetlamy komunikat o błędzie 
                {
                    MessageBox.Show("Nie udało się uzyskać dostępu do pliku, prawdopodobnie jest otwarty w innym oknie"); 
                }

                

            


        }
    }
        
        private void wynik_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // po kliknięciu wyjście 
        {
            plik.Close(); // zamykamy plik 
            Application.Exit(); // wylączamy aplikację
        }

        private void kobieta_CheckedChanged_1(object sender, EventArgs e)
        {
            if (kobieta.Checked == true) // jeśli chcemy zaznaczyć ponownie checkboxa, 
                // np mając zaznaczoną kobietę to nie może być jednocześnie zaznaczony mężczyzna
            {
                mezczyzna.Checked = false;
            }
          
        }

        private void mezczyzna_CheckedChanged_1(object sender, EventArgs e) // analogicznie jak wyżej  opisany przypadek z kobietą
        {
            if (mezczyzna.Checked == true)
            {
                kobieta.Checked = false;
            }
        }

        private void wiek_TextChanged(object sender, EventArgs e)
        {

        }

        private void waga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
