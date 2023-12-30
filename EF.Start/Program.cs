using EF.Start.Data;
using System;
using System.Linq;

namespace EF.Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db  = new ApplicationContext())
            {
                Toggle toggle = new Toggle { 
                    Name = "SubscriptionPayment", 
                    Description = "Включает оплату подписки",
                    IsEnabled = false
                };

                db.Toggles.Add(toggle);
                db.SaveChanges();

                var toggles = db.Toggles.ToList();
                foreach(Toggle t in toggles)
                {
                    Console.WriteLine($"" +
                        $"Id = {t.Id}, " +
                        $"Name = {t.Name}, " +
                        $"Description = {t.Description}," +
                        $"IsEnabled = {t.IsEnabled}");
                }
                Console.ReadKey();
            }
        }
    }
}