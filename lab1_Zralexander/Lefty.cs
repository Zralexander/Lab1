using System;

namespace lab1_Zralexander
{
    public class Lefty : Pitcher
    {
        public Lefty(){
            Throws = "left";
            SetPitchBehavior(new Curveball());
        }
    }
}