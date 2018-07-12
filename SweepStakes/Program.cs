using System;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ISweepstakesManager manager = new ISweepstakesManager();
            SweepStakes sweepStakes = new SweepStakes();
            sweepStakes.MainMenu();
        }
    }
}
