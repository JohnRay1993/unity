using System;
namespace sech
{
    public static class KKKConverter
    {
        //public KKKConverter()
        //{

        //}

        public static String Convert(this int var)
        {
            int c = 1;
            double d = var / Math.Pow(1000, c);
            if (d < 1000)
            {
                c = 0;
                d = var;
            }
            while (d > 1000)
            {
                d = 0;
                c++;
                d = var / Math.Pow(1000, c);
            }

            string k = "";
            for (int j = 0; j < c; j++)
                k += "K";

            return String.Format("{0:.##}", d) + " " + k;
        }
    }
}
