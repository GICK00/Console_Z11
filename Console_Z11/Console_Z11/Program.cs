using System;
using System.Text.RegularExpressions;

namespace Console_Z11
{
    class Regular
    {
        private Regex r;
        private string text;

        public void Math()
        {
            bool match = r.IsMatch(text);
            if (match == true)
                Console.WriteLine("| Текст содержит шаблон.");
            else
                Console.WriteLine("| Текст не содержит шаблон.");
        }
        public void MathView()
        {
            Console.Write("| ");
            MatchCollection match = r.Matches(text);
            foreach(Match m in match)
                Console.Write("{0} ", m);
            Console.WriteLine();
        }
        public void MatchDelet()
        {
            string replaced = r.Replace(text, "");
            Console.WriteLine("| {0}", replaced);
        }
        public Regex R
        {
            get { return r; }
            set { r = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("| Классы в C#.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Regular reg = new Regular();
                    Console.WriteLine("| Введите текст.");
                    Console.Write("| : ");
                    reg.Text = Convert.ToString(Console.ReadLine());
                    if (reg.Text.Length <= 0)
                        throw new Exception("Введите текст!");
                    Console.WriteLine("| Введите шаблон.");
                    Console.Write("| : ");
                    reg.R = new Regex($@"{Convert.ToString(Console.ReadLine())}");
                    if (reg.R.ToString().Length <= 0)
                        throw new Exception("Введите строку для поиска!");
                    Console.WriteLine("|-------------------------------------------------");

                    reg.Math();
                    reg.MathView();
                    reg.MatchDelet();

                    Console.WriteLine("|-------------------------------------------------");
                    Console.WriteLine("| Значения R - {0}, Text - {1}", reg.R, reg.Text);
                    rep(out repit);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"| {e.Message}");
                }
            }
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|-------------------------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|-------------------------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}
