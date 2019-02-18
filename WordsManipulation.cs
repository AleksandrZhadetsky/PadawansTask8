using System.Text;
using System.Linq;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
            if (text.Length == 0)
            {
                throw new ArgumentException();
            }

            char[] separators = new char[] { '.', ',', '!', '?', '-', ':', ';', ' ' };
            string[] array = text.Split(separators);
            int idx = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == " ")
                {
                    continue;
                }
                else
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i].Equals(array[j]))
                        {
                            array[j] = " ";
                        }
                    }
                    for (int x = 0; x < array.Length; x++)
                    {
                        if (array[x] != " ")
                        {
                            idx = x;
                        }
                    }
                    if (i < idx)
                    {
                        array[i] += " ";
                    }
                }
            }
            text = null;

            for (int i = 0; i < array.Length; i++)
            {
                text += array[i];
            }
        }
    }
}