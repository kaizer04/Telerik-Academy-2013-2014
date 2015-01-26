/*Problem 5 – Neuron Mapping*/

using System;

class NeuronMapping
{
    static void Main()
    {
        //uint i; // 00000000000000000000000000000101 i = 5
        //// 01000000000000000000000000000100 new i = 1073741828
        //uint y = 1;
        //int p1;
        //int p2;
        //uint k;
        //int n;
        
        
        //for (int i = 1; i < 2147483647; i++)
        //{
            long x = uint.Parse(Console.ReadLine());

            //if (x != -1)
            //{
                
                uint y = 1;

                for (int p = 0; p <= 31; p++)
                {
                    //uint mask = y << p;
                    //int v = ((x & mask) != 0 ? 1 : 0);

                    //if (v == 1)
                    //{
                      x = x | (~(1 << p));
                        
                        //for (int q )
                    //}


                    //if (v == 0)
                    //{
                    //    x = x & (~mask);
                    //}
                    //else
                    //{
                    //    x = x | (mask);
                    //}
                    //Console.WriteLine("Exchanged Bits number x = {0}", x);
                    
                }

                Console.WriteLine("Exchanged Bits number x = {0}", x);
                
                //Console.WriteLine("The third bit of {0} is: {1}", x, (x & mask) != 0 ? 1 : 0);
                
                
                
                //for (n = 0; n < k; n++)
                //{
                //    uint mask1 = y << (p1 + n);
                //    int v1 = ((i & mask1) != 0 ? 1 : 0);
                //    uint mask2 = y << (p2 + n);
                //    int v2 = ((i & mask2) != 0 ? 1 : 0);
                //    int v = v1;
                //    v1 = v2;
                //    v2 = v;
                //    if (v1 == 0)
                //    {
                //        i = i & (~mask1);
                //    }
                //    else
                //    {
                //        i = i | (mask1);
                //    }
                //    if (v2 == 0)
                //    {
                //        i = i & (~mask2);
                //    }
                //    else
                //    {
                //        i = i | (mask2);
                //    }
                //}
                //Console.WriteLine("Exchanged Bits number x = {0}", x);
            //}
            //else
            //{
            //    break;//Console.WriteLine(x);
            //    //Console.WriteLine("Exchanged Bits number x = {0}", x1);
            //}

            
       // }

        
        //while (x != -1);
    }
}