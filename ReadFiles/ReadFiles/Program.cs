using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.GetFiles(@"C:\Users\toker\ReadFilesPractice"); 
            //var files = Directory.GetFiles(@"C:\Users\toker\ReadFilesPractice\pnl.csv");
            var path = @"C:\Users\toker\ReadFilesPractice\pnl.csv.txt";

            /*
            foreach (var file in files)
            {
                Console.WriteLine(file);
            C:\Users\toker\ReadFilesPractice
            }
            */

            //Read the document 

            // Create a list 

            List<StrategyPnl> strategies = new List<StrategyPnl>();
            List<Pnl> pnls = new List<Pnl>();
            StrategyPnl strategyPnl = new StrategyPnl();
            strategyPnl.Strategy = "Strategy1";
            strategyPnl.Pnls = pnls; 
            strategies.Add(strategyPnl);


            Pnl pnl1 = new Pnl();
            pnl1.Date = new DateTime (2010,01,01);
            pnl1.Amount = 95045;
            pnls.Add(pnl1); 
            

            //,





            var StrategyPnl = new List<StrategyPnl>();
            var pnl = new Pnl(); 
      
            String[] info = File.ReadAllLines(path); 

            foreach (var infos in info)
            {
                var split = infos.Split(",");

                var strategy = new StrategyPnl() {Strategy =split[3]};
                //var pnl2 = new Pnl() {Date =DateTime.Now(split[0])};
               
                
                
                //var strategy2 = new StrategyPnl() { strategy2.Pnls =split[0]};
                Console.WriteLine(strategy.Strategy);


                //var strategy = new StrategyPnl() { name = split[0], number = int.Parse(split[1])};
                //Contacts.Add(contact);

            }
            /*
            foreach(var person in Contacts)
            {
                Console.WriteLine($"{person.name} {person.number}");
            }
            */



           


        }
    }
}
