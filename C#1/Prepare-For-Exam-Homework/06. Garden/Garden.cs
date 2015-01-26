/*Problem 1 – Garden
 SEE 1. Garden.docx*/

using System;

class Garden
{

    static void Main()
    {
        int tomatoSeeds = int.Parse(Console.ReadLine());
        decimal tomatoCost = tomatoSeeds * 0.5m;
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        decimal cucumberCost = cucumberSeeds * 0.4m;
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        decimal potatoCost = potatoSeeds * 0.25m;
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        decimal carrotCost = carrotSeeds * 0.6m;
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        decimal cabbageCost = cabbageSeeds * 0.3m;
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());
        decimal beansCost = beansSeeds * 0.4m;
        int area = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        int beansArea = 250 - area;
        decimal totalCosts = tomatoCost + cucumberCost + potatoCost + carrotCost + cabbageCost + beansCost;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (beansArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}