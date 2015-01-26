using System;

class Program
{
    static void Main()
    {
        
        while (true)
        {
            string z = Console.ReadLine();
        
            if (z == "-1")
            {
                break;
            }
        
            uint y = 1;
            uint x = uint.Parse(z);
            uint x1 = x;
            for (int p = 0; p <= 31; p++)
            {
                uint mask = y << p;
                int v = ((x & (mask)) != 0 ? 1 : 0);

                if (v == 1)
                {
                    x = x & (~(mask));
                    uint mask1 = y << (p + 1);
                    int v1 = ((x1 & (mask1)) != 0 ? 1 : 0);
                    if (v1 == 1)
                    {
                        x = x1;
                        x = x & (~(mask1));
                        for (int q = p + 1; q <= 31 - p; q++)
                        {
                            uint mask2 = y << q;
                            int v2 = ((x1 & (mask2)) != 0 ? 1 : 0);
                            if (v2 == 0)
                            {
                                x = x1;
                                x = x | (mask2);
                            }
                            //else
                            //{
                            //    x = x1;
                            //    x = x & (~(mask2));
                            //}
                        }

                    }
                    //else
                    //{
                    //    x = x1;
                    //    x = x & (~(mask1));
                    //}
                    for (int r = p + 1; r <= 31 - p; r++)
                    {
                        uint mask3 = y << r;
                        int v3 = ((x1 & (mask3)) != 0 ? 1 : 0);
                        if (v3 == 0)
                        {
                            //for (int k = r + 1; k <= 31 - r; k++)
                            //{
                            //    uint mask4 = y << k;
                            //    int v4 = ((x1 & (mask4)) != 0 ? 1 : 0);
                            //    x = x1;
                            //    x = x | (mask4);
                            //}
                        }
                        //else
                        //{
                        //    x = x1;
                        //    x = x & (~(mask3));
                        //}
                    }
                    
                }
                
                                          
            }
            Console.WriteLine(x);
        }
    }
}