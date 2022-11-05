using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StartApp
{
    class Strumienie
    {

        static void Zapis()
        {
            StreamWriter sw = new StreamWriter("PanTadeusz.txt");
            sw.Write("L");
            sw.WriteLine("itwo Ojczyzno moja ty jesteś ....");
            sw.Close();
        }

        static void Odczyt()
        {
            try
            {
                //StreamReader sr = new StreamReader("tmp\\PanTadeusz.txt_");
                StreamReader sr = new StreamReader("PanTadeusz.txt");
                Console.WriteLine((char) sr.Read());
                Console.WriteLine(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    Console.Write((char)sr.Read());
                }
                sr.Close();
            }         
            catch (FileNotFoundException e)
            {
                Console.WriteLine("OJOJOJ, ERROR!!!!!");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nFinally Done!!");
            }
        }

        static void OdczytZWWW()
        {
            try
            {
                WebClient wc = new WebClient();
                StreamReader sr = new StreamReader(wc.OpenRead("http://www.uni.lodz.pl"));
                Console.WriteLine((char)sr.Read());
                Console.WriteLine(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    Console.Write((char)sr.Read());
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void Main(String[] a)
        {
            //Zapis();
            //Odczyt();
            OdczytZWWW();
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
