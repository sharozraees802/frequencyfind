using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequenctFind
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("counting word frequency in a paragraph\n");

            //string paragraph = "W W BR Y BL BL W W Y G G W W BL BR BL BR BL BL BR Y Y BL G W BL W W BL W BL BR BL Y BR G BR G W BR Y G BR G W BR Y W BL W BR G Y G Y";

            //string[] words = paragraph.ToLower().Split(' ');

            //Dictionary<string, int> myDictionry = new Dictionary<string, int>();

            //foreach (string word in words)
            //{
            //    if (!myDictionry.ContainsKey(word))
            //    {
            //        myDictionry.Add(word, 1);
            //    }
            //    else
            //    {
            //        myDictionry[word]++;
            //    }
            //}

            //foreach (string key in myDictionry.Keys)
            //{
            //    Console.WriteLine(key + " : " + myDictionry[key] + "\n");

            //}

            //Console.ReadLine();




            int[] data = new int []{58 ,54 ,47 ,40 ,39 ,35 ,50 ,37 ,49 ,42,70 ,32 ,44 ,52 ,39 ,50 ,40 ,53 ,34 ,69,50 ,42 ,52 ,38 ,36 ,45 ,35 ,43 ,48,46,39 ,45 ,63 ,42 ,44 ,63 ,60 ,27 ,42 ,48,62 ,57 ,35 ,60 ,32 ,49 ,68, 29, 57 ,38, };

            int[] check = new int[] {36,37,38,39,40,41,42,43,44 };
            int count = 0;
            for (int i = 0; i <data.Length; i++)
            {
                
                for (int j = 0; j < check.Length; j++)
                {
                    if (data[i]==check[j])
                    {
                        count++;
                    }
                  
                }
            }
            Console.WriteLine("Range of given Limit is {0}:", count);

            Console.ReadLine();


        }
    }
}
