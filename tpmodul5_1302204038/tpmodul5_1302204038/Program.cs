using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;


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
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);
            Random ids = new Random();
            this.title = judul;
            id = ids.Next(0, 100000);
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int i)
        {
            try
            {
                 if (i >= 10000000) throw new Exception("Melebihi limit angka");
                 PlayCount = PlayCount + i;
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.PlayCount);
        }
    }
}