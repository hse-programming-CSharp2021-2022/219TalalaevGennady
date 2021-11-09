using System;

namespace task01
{
    class VideoFile
    {
        private string string_name
        {
            set;
            get;
        }

        private int int_duration
        {
            set;
            get;
        }

        private int int_quality
        {
            set;
            get;
        }

        public VideoFile(string name, int duration, int quality)
        {
            string_name = name;
            int_duration = duration;
            int_quality = quality;
        }

        public int Size()
        {
            return int_duration * int_quality;
        }

        public string GetInfo()
        {
            var s = "Название: " + string_name + "\nДлительность: " + int_duration + "\nКачество: " + int_quality
                       + "\nРазмер: " + Size();
            return s;
        }


    }
    class Program
    {
        static void Main()
        {
            var r = new Random();
            var N = r.Next(5, 16);
            var arr = new VideoFile[N];
            for (var j = 0; j < N; j++)
            {
                var duration = r.Next(60, 361);
                var qq = r.Next(100, 1001);
                var name = ((char)r.Next('a', 'z')).ToString();
                for (var i = 2; i < r.Next(3, 10); i++)
                {
                    name += ((char)r.Next('a', 'z')).ToString();
                }

                arr[j] = new VideoFile(name, duration, qq);
            }

            for (var i = 0; i < N; i++)
            {
                Console.WriteLine("Video file №" + (i + 1));
                Console.WriteLine(arr[i].GetInfo());
                Console.WriteLine();
            }
        }
    }
}