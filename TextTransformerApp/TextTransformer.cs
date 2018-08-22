using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformerApp
{
    class TextTransformer
    {
        private List<string> Text = new List<string>();

        public TextTransformer(string str)
        {
            Text.Add(str);
        }

        public TextTransformer() { }

        public void Add(string item)
        {
            Text.Add(item);
        }

        public void Show()
        {
            foreach (string item in Text)
                Console.WriteLine(item);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string item in Text)
            {
                if (item != null)
                    yield return item.ToUpper();
                else
                    yield return "This string was empty";
            }
        }
    }
}
