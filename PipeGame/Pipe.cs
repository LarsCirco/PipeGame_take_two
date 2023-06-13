using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeGame
{
    internal class Pipe
    {
        private int UserInput { get; set; }
        public string Symbol { get; set; }
        public bool Nord { get; set; }
        public bool Sør { get; set; }
        public bool Vest { get; set; }
        public bool Øst { get; set; }


        public Pipe(string symbol)
        {
            Symbol = symbol;
            switch (symbol)
            {
                case "┃":
                    Nord = true;
                    Sør = true;
                    Vest = false;
                    Øst = false;
                    break;
                case "━":
                    Nord = false;
                    Sør = false;
                    Vest = true;
                    Øst = true;
                    break;
                case "╭":
                    Nord = false;
                    Sør = true;
                    Vest = false;
                    Øst = true;
                    break;
                case "╰":
                    Nord = true;
                    Sør = false;
                    Vest = false;
                    Øst = true;
                    break;
                case "╯":
                    Nord = true;
                    Sør = false;
                    Vest = true;
                    Øst = false;
                    break;
                case "╮":
                    Nord = false;
                    Sør = true;
                    Vest = true;
                    Øst = false;
                    break;
            }
        }

    }

    
}
