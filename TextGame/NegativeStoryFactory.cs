using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class NegativeStoryFactory : IFactory
    {
        public ConsoleColor CreateTextColor()
        {
            return ConsoleColor.DarkRed;
        }

        public ConsoleColor CreateBackgroundColor()
        {
            return ConsoleColor.DarkGray;
        }

        public ConsoleColor CreateQuestionsColor()
        {
            return ConsoleColor.Black;
        }
    }
}
