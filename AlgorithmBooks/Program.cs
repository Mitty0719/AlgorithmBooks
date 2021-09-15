using System;

namespace AlgorithmBooks
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 2588

            int anum = Int32.Parse(Console.ReadLine());
            int bnum = Int32.Parse(Console.ReadLine());
            int idx = 0;
            while(true)
            {
                double powNum = Math.Pow((double)10, (double)idx);

                if (powNum > bnum) break;

                int res = (int)Math.Floor(bnum / powNum);

                Console.WriteLine(bnum * res);
            }
            Console.WriteLine(anum * bnum);


            
            #endregion






            #region 10430
            //string[] strs = Console.ReadLine().Split(' ');
            //int A = Int32.Parse(strs[0]);
            //int B = Int32.Parse(strs[1]);
            //int C = Int32.Parse(strs[2]);

            //Console.WriteLine((A + B) % C);
            //Console.WriteLine(((A % C) + (B % C)) % C);
            //Console.WriteLine((A * B) % C);
            //Console.WriteLine(((A % C) * (B % C)) % C);
            #endregion

            #region 10869
            //string[] strs = Console.ReadLine().Split();
            //Console.WriteLine(Int32.Parse(strs[0]) + Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) - Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) * Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) / Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) % Int32.Parse(strs[1]));
            #endregion


            #region 1000, 1001, 1008, 10998
            //string[] strs = Console.ReadLine().Split();
            //Console.WriteLine(Int32.Parse(strs[0]) + Int32.Parse(strs[1]));
            #endregion

            #region 10172
            //Console.WriteLine("|\\_/|" + "\n" +
            //                  "|q p|   /}" + "\n" +
            //                  "( 0 )\"\"\"\\" + "\n" +
            //                  "|\"^\"`    |" + "\n" +
            //                  "||_/=\\\\__|");
            #endregion
        }
    }
}
