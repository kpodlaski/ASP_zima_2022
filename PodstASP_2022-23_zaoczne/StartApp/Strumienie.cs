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
    }
}
