using System;

namespace task01
{
    public class Cindrella
    {
        public abstract class Something
        {

        }

        public class Lentil : Something
        {
            private double Weight
            {
                get
                {
                    var r = new Random();
                    return r.Next(0, 20) / 10.0;
                }
                set { }
            }
            public override string ToString()
            {
                return $"Lentil, Weight = {this.Weight}";
            }
        }

        public class Ashes : Something
        {
            private double Volume
            {
                get
                {
                    var r = new Random();
                    return r.Next(0, 10) / 10.0;
                }
                set { }
            }
            public override string ToString()
            {
                return $"Ashes, Volume = {this.Volume}";
            }
        }
    }
}
