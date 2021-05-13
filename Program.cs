using System;
using System.Linq;
using System.Collections.Generic;

namespace _2_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Введите текст");
            string te = Console.ReadLine();
            int count = 0;
            int indexLetter = 0;
            for(int i = 0; i < te.Length; i++)
            {
                if(te[i] == 'f')
                {
                    count++;
                    if(count == 2)
                    {
                        indexLetter = i;
                        break;
                    }
                }
            }
            if(count == 2)
            {
                Console.WriteLine(indexLetter);
            }
            else if(count == 1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(-2);
            }

            Translit translit = new Translit();
            Console.WriteLine("2.Введите текст");
            string testIn = Console.ReadLine();
            string testOut = translit.TranslitFileName(testIn);
            Console.WriteLine("\'{0}\'", (testIn));
            Console.WriteLine("\'{0}\'", testOut);


            Console.WriteLine("3.Ввод слова");
            string str = Console.ReadLine();
            k.remov(str);



        }
        public class Translit
        {
            Dictionary<string, string> dictionaryChar = new Dictionary<string, string>()
            {
                {"а", "a"},
                {"б", "b"},
                {"в", "v" },
                {"г", "g" },
                {"д", "d" },
                {"е", "e" },
                {"ё", "yo" },
                {"ж", "j" },
                {"з", "z" },
                {"и", "i" },
                {"й", "y" },
                {"к", "k" },
                {"л", "l" },
                {"м", "m" },
                {"н", "n" },
                {"о", "o" },
                {"п", "p" },
                {"р", "r" },
                {"с", "s" },
                {"т", "t" },
                {"у", "u" },
                {"ф", "f" },
                {"х", "h" },
                {"ц", "ts" },
                {"ч", "ch" },
                {"ш", "sch" },
                {"ъ", "'" },
                {"ы", "yi" },
                {"ь", "" },
                {"э", "e" },
                {"ю", "yu" },
                {"я", "ya" }


            };
            public string TranslitFileName(string source)
            {
                var result = "";
                foreach (var ch in source)
                {
                    var ss = "";
                    if (dictionaryChar.TryGetValue(ch.ToString(), out ss))
                    {
                        result += ss;
                    }
                    else result += ch;
                }
                return result;
            }
        }
        
        class k
        {
            public static void remov(string str)
            {
                str = str.Replace('h', 'H');
                Console.WriteLine(str);


            }
        }


    }
}
