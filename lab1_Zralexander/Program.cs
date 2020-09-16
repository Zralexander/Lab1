using System;

namespace lab1_Zralexander
{
    class Program
    {
        static void Main(string[] args)
        {
            IPitch fastball = new Fastball();
            IPitch curve = new Curveball();
            IPitch slider = new Slider();

            Pitcher craftyLefty = new Lefty(){Name = "Crafty Lefty", Team = "Mets"};

            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike!");

            craftyLefty.SetPitchBehavior(fastball);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike!");

            craftyLefty.SetPitchBehavior(slider);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a ball!");

            craftyLefty.SetPitchBehavior(curve);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("strike 3! BATTER OUT!");


        }
    }
}
