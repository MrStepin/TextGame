using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is interactive story generator.");
            Console.WriteLine("What weather in the story do you prefer? \n 1.Good \n 2. Normal \n 3. Bad \n Enter only number:" );
            int weather = Convert.ToInt16(Console.ReadLine());
            IFactory Story = StyleOfStory(weather);

            Console.BackgroundColor = Story.CreateBackgroundColor();
            Console.ForegroundColor = Story.CreateTextColor();
            
            if (weather == 3)
            {
                Console.WriteLine("He walk in the park at the rainy evening");
            }
            if (weather == 1)
            {
                Console.WriteLine("He is spend time on the beach");
            }
            if (weather == 2)
            {
                Console.WriteLine("He is going to the job");
            }
            Console.ForegroundColor = Story.CreateQuestionsColor();
            Console.WriteLine("Is color of text, background and this question changed?");
            Console.WriteLine("Is it magic?");

            Console.ReadKey();
        }

        static IFactory StyleOfStory (int styleOfStory)
        {
            if (styleOfStory == 1 || styleOfStory == 2)
            {
                return new PositiveStoryFactory();
            }

            if (styleOfStory == 3)
            {
                return new NegativeStoryFactory();
            }

            return null;
        }
    }
}
