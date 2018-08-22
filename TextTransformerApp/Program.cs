using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="odc";
            string str1 = null;
            TextTransformer text = new TextTransformer();
            for (int i = 0; i < 5; i++)
            {
                text.Add(str);
                str += "b";
            }
            text.Add(str1);
            text.Show();
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
