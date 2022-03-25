using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace tpmodul5_1302204038
{
    internal class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Fan");
            video.PrintVideoDetails();
            video.IncreasePlayCount(1);
            video.PrintVideoDetails();
        }
    }

    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int PlayCount;

        public SayaTubeVideo(String judul)
        {
            Random ids = new Random();
            this.title = title;
            id = ids.Next(0, 100000);
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int i)
        {
            PlayCount = PlayCount + i;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.PlayCount);
        }
    }
}