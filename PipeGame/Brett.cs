using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PipeGame
{
    internal class Brett
    {
        private Random random = new Random();
        public List<Pipe> Pipes { get; set; }
        private bool won = false;
        private int StartPoint = 0;
        private int EndPoint = 99;

        public Brett()
        {
            Pipes = new List<Pipe>();
            InitialiserBrett();
            DrawBoard();
        }
        private void InitialiserBrett()
        {
            for (var i = 0; i < 100; i++)
            {
                string symboler = RandomPipe();
                var symbol = new Pipe(symboler); // kaster inn i switchen
                Pipes.Add(symbol); // legger inn random pipe i lista!
            }

        }

        public void DrawBoard()
        {
            Console.Clear();
            int count = 0;
            string padding = new string(' ', 10);
            foreach (var pipe in Pipes)
            {
                Console.Write(pipe.Symbol + " ");
                count++;
                if (count % 10 == 0)
                {
                    Console.WriteLine("#"); 
                }


            }
            Console.WriteLine();
        }

        private string RandomPipe()
        {
            var symboler = new List<string> { "┃", "━", "╭", "╰", "╯", "╮" };
            int tilfeldig = random.Next(symboler.Count);
            return symboler[tilfeldig];
        }

        public void brukerInput(string pil, string Rettning)
        {
            int tall = int.Parse(pil);
            
            if (tall < 0 || tall > Pipes.Count)
            {
                Console.WriteLine("Du har skrivet feil index");
                return;
            }

            if (Rettning == "1")
            {
                Rettning = "┃"; }
            else if (Rettning == "2")
            {
                Rettning = "━";
            }
            else if (Rettning == "3")
            {
                Rettning = "╭";
            }
            else if (Rettning == "4")
            {
                Rettning = "╰";
            }
            else if(Rettning == "5") 
            {
                Rettning = "╰";

            }
            else if (Rettning == "6") 
            {
                Rettning = "╰";

            }
            else
            {
                Console.WriteLine("Ugyldig rettning input");
                return;
            }

            Pipes[tall] = new Pipe(Rettning); // måtte lage masse if-er virker ikke ut som consolen skjønner når jeg copy paster unicode inn som input...
            DrawBoard();
            Console.WriteLine();
            
        }



    }
}
