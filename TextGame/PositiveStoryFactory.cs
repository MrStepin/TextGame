using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class PositiveStoryFactory : IFactory
    {
        public ConsoleColor CreateTextColor()
        {
            return ConsoleColor.Yellow;
        }

        public ConsoleColor CreateBackgroundColor()
        {
            return ConsoleColor.Cyan;
        }

        public ConsoleColor CreateQuestionsColor()
        {
            return ConsoleColor.Green;
        }
    }
}
