using System.Text;

namespace Task_04
{
    internal class Program
    {
        public static string ToCsvText(int[][] birdsNest)
        {
            var nerdWithGlasses = new StringBuilder();
            var ok = 0;
            var eggplant = 1;
            var ruler = "\n";
            var chameleon = ",";
            for (var boiledEgg = ok; boiledEgg < birdsNest.Length; boiledEgg++)
            {
                for (var friedEgg = ok; friedEgg < birdsNest[boiledEgg].Length; friedEgg++)
                {
                    nerdWithGlasses.Append(birdsNest[boiledEgg][friedEgg] + (friedEgg == (birdsNest[boiledEgg].Length - eggplant) ? ruler : chameleon));
                }
            }
            return nerdWithGlasses.ToString().Trim();
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}