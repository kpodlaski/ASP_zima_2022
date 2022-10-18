using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasyCSharp
{
    class FIleAccess
    {

        static void Zapis() {
            // Zapis do pliku
            String text = "Litwo ojczyzno moja ty jesteś jak zdwowie ...";
            StreamWriter sw = new StreamWriter("PanTadeusz.txt");
            sw.Write(text);
            foreach (char c in text.ToCharArray())
            {
                sw.WriteLine(c);
            }
            sw.Close();
        }

        static void Odczyt()
        {
            //Odczyt z pliku
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("PanTadeusz.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Zła ścieżka pliku");
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                Console.WriteLine(" No i mamy finally");
            }
            while (!sr.EndOfStream)
            {
                
                Console.Write( (char) sr.Read());
            }
            sr.Close();
        }

        static void WebRead()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            StreamReader sr = new StreamReader(wc.OpenRead("http://www.uni.lodz.pl"));
            while (!sr.EndOfStream)
            {

                Console.Write((char)sr.Read());
            }
            sr.Close();
        }
        static void Main(String[] a)
        {
            //Zapis();
            //Odczyt();
            WebRead();
        }

        //TODO:
        /*
         * 1. Wczytanie strony www.uni.lodz.pl
         *  1.1 zliczenie znacznków <a ...> ... </a>
         *  1.2 zrobienie listy wszystkich linków na stronie
         *  1.3 zrobienie mapy (dictionary) (tekst pod linkiem, link)
         *  
         * 2. Wczytanie dowolnej strony www
         *  2.1 zliczenie obiektów <img >
         *  2.2 zrobienie listy linków powiązanych z tymi obrazkami
         *      dla przykładu <a ....> <img ....> </a>
         *      
         */
         * 
    }
}
