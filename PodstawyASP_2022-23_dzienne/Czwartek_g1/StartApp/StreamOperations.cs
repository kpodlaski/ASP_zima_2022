using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StartApp
{
    class StreamOperations
    {
        static void Write()
        {
            StreamWriter sw = new StreamWriter("PanTadeusz.txt");
            sw.Write("Litwo Ojczyzno moja ty jesteś jak zdrowie ...");
            sw.WriteLine("ten tylko się dowie kto cię stracił.");
            sw.Close();
        }

        static void Read()
        {
            StreamReader sr=null;
            try
            {
                sr = new StreamReader("PanTadeusz.txt");
                Console.WriteLine("Udało się otworzyć plik");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Zła ścieżka do pliku");
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Inny błąd");
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                Console.WriteLine("And finally ....");
            }
            while (!sr.EndOfStream)
            {
                Console.WriteLine((char) sr.Read());
            }
            sr.Close();
        }


        static void ReadFromWebPage()
        {
            try
            {
                WebClient wc = new WebClient();
                StreamReader sr = new StreamReader( wc.OpenRead("http://www.uni.lodz.pl"));
                Console.WriteLine("Udało się otworzyć strony www");
                while (!sr.EndOfStream)
                {
                    Console.Write((char)sr.Read());
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wyjątek !!!!!!!");
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                Console.WriteLine("And finally ....");
            }
            
        } 
        static public void Main(String[] a)
        {
            //Write();
            //Read();
            ReadFromWebPage();
        }

        //TODO: 
        /*
         * 1 policzyć ile razy na stronie występuje znakcznik <a 
         * 1.1 stworzyć listę linków przypisanych do znaczników <a 
         * 1.2 zbudować słownik (dict) wiążący tekst linku z adresem (text -> link)
         * 
         * 2. znaleźć wszystkie obrazki na stronie <img ...>
         * 2.1 zrobić listę adresów obrazków na stronie
         * 2.2 znaleźć wszystkie obrazki będce jednoczesnie linkami <a ....><img ...>... </a>
         *     zbudować słownik adres obrazku i link na nim oparty
         */
    }
}
