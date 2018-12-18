using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RectangleCalculator
{
    class Scanner : System.IO.StringReader
    {
        string currentWord;


        public Scanner(string source) : base(source)
        {
            ReadNextWord(); 
        }


        private void ReadNextWord()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            char nextChar;
            int next;
            do
            {
                next = this.Read();
                if (next < 0)
                    break;
                nextChar = (char)next;
                if (char.IsWhiteSpace(nextChar))
                    break;
                sb.Append(nextChar);
            } while (true);
            while ((this.Peek() >= 0) && (char.IsWhiteSpace((char)this.Peek())))
                this.Read();
            if (sb.Length > 0)
                currentWord = sb.ToString();
            else
                currentWord = null;
        }

        public bool HasNextDouble()
        {
            if (currentWord == null)
            {
                return true;
            }
            return double.TryParse(currentWord, out double dummy);
        }

        public double NextDouble()
        {
            try
            {
                return double.Parse(currentWord);
            }
            finally
            {
                ReadNextWord();
            }
        }


    }
}
