using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public interface IFactory
    {
        ConsoleColor CreateTextColor();

        ConsoleColor CreateQuestionsColor();

        ConsoleColor CreateBackgroundColor();
    }
}
