using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManAnh
{
    internal class Game
    {
        public static void Main()
        {
            string ans;
            do
            {
                string[] colors = { "AQUA", "AMBER", "AMETHYST", "BEIGE", "BLACK", "BLUE", "BLUSH", "BRONZE", "BROWN", "BURGUNDY", "CANARY", "CARMINE", "CELESTE", "CERISE", "CERULEAN", "CHAMPAGNE", "CHARCOAL", "CHARTREUSE", "CHERRY", "COBALT", "CORAL", "CREAM", "CRIMSON", "CYAN", "DAFFODIL", "DENIM", "DOVE", "DRAB", "DESIRE", "EBONY", "EMERALD", "EGGPLANT", "FAWN", "FUCHSIA", "FIRE", "FLAX", "FOREST", "GARNET", "GOLD", "GRAY", "GREEN", "GINGER", "HONEYDEW", "HAZEL", "HELIOTROPE", "HONEYSUCKLE", "INDIGO", "IVORY", "ILLUMINATING", "IRIDESCENT", "JADE", "JET", "JUNIPER", "KHAKI", "LAVENDER", "LEMON", "LILAC", "LIME", "MAGENTA", "MAROON", "MAUVE", "MINT", "MUSTARD", "MARSALA", "NAVY", "NEON", "NECTAR", "OCHRE", "OLIVE", "ORANGE", "ORCHID", "PEPPER", "POMEGRANATE", "PEACH", "PEAR", "PERIWINKLE", "PINK", "PLUM", "PURPLE", "RASPBERRY", "RED", "ROSE", "RUBY", "RUST", "REDWOOD", "SALMON", "SAPPHIRE", "SCARLET", "SILVER", "SLATE", "STEEL", "SERENITY", "TAN", "TANGERINE", "TAUPE", "TEAL", "THISTLE", "TOMATO", "TURQUOISE", "TIBET", "VANILLA", "VERMILION", "VIOLET", "WHITE", "WINE", "WHEAT", "WINE", "WILLOWHERB", "YELLOW", "YOLK" };
                Random random = new Random();
                string choose = colors[random.Next(colors.Length)];

                Console.WriteLine("Try to guess which color I picked! You will have 3 times guessing.");
                Console.WriteLine("Before guessing, I will give you a clue!");
                Console.WriteLine();

                char hint = choose[0];
                Console.WriteLine($"Clue: The color start with '{hint}'. Take a guess!");
                Console.WriteLine();

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Your guess: ");
                    string guess = Console.ReadLine();
                    if (guess.ToUpper().Equals(choose))
                    {
                        Console.WriteLine("Bingo! You're must be a genius! I swear I was just thinking about that. You must have been cheeting!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Oops, wrong answer. Let's try another guess.");
                        Console.WriteLine();
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("Ding, ding, ding! Time's up! Looks like you're out of guesses.");
                        Console.WriteLine($"I guess we'll have to call you Einstein next time. The corect answer was '{choose}'.");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Wanna challenge me one more time? (Y/N)");
                ans = Console.ReadLine();
                if (ans.ToUpper().Equals("N"))
                {
                    Console.WriteLine("If you're too scared to play again, that's fine by me.");
                    break;
                }
                else
                {
                    Console.WriteLine("Okay. Let's see if luck is on your side this time.");
                    Console.WriteLine();
                }
            } while (ans == "Y");
            Console.WriteLine("Bye, see ya.");
            Console.ReadKey();
        }
    }
}
