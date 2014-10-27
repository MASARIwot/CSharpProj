using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
     /*
      * Class for vertex coordinates of figures
      */
    public sealed class Coordinates
    {
        /*
         *This method retun length of side .parama: 2 point
         * can use like->Figure.getLengthSide(Figure.getPointArr(x, y), Figure.getPointArr(x, y))
         * Create side by 2 point
         */
        public static double getLengthSide(int[] point, int[] point2)
        {
            double result = Math.Sqrt(Math.Pow((point2[0] - point[0]), 2) + Math.Pow((point2[1] - point[1]), 2));

            return result;
        }

        /*
         *This method return int[] arr -> result"[x,y]" :->call- Figure.getPointArr(x, y)
         */
        public static int[] getPointArr(int x, int y)
        {
            int[] result = new int[2];
            result[0] = x;
            result[1] = y;
            return result;
        }
        /*
         *find  3 side by 3 point
         */
        public static void getABC(ref int[] A, ref int[] B, ref int[] C, out double AB, out double BC, out double CA)
        {
            AB = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2));
            BC = Math.Sqrt(Math.Pow((C[0] - B[0]), 2) + Math.Pow((C[1] - B[1]), 2));
            CA = Math.Sqrt(Math.Pow((A[0] - C[0]), 2) + Math.Pow((A[1] - C[1]), 2));

        }
        /*
         *find 1 side by 2 point
         */
        public static void getABC(ref int[] A, ref int[] B, out double AB)
        {
            AB = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2));
        }

        /*
         *this method find any Perimetr. Parama: side ,more than one (>=1)
         *
         * 
         * Part for home 5
         *
         * 
         */
        public static double getPerimetr(params double[] parties)
        {
            /*for (int i = 0; i < parties.Length; i++) { 
                if (parties[i] < 0) throw new MyExeptioClass("Length of parama < 0 !!");
             * // --> Can be here
             * }*/
            double result = 0;
            foreach (double res in parties)
            {if (res < 0) throw new MyExeptioClass("Length of parama < 0 !!");
                result += res;
            }
            if (result == 0) throw new MyExeptioClass("Length of parama les that one");
            return result;
        }
    
    }

}
