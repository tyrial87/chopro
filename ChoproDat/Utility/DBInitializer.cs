using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoproDat.Entities;

namespace ChoproDat.Utility
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Chores.Any())
            {
                return;   // DB has been seeded
            }

            var RandomGeni = new Random();

            var chores = new Chore[]
            {
                new Chore{Name="Clean Toilet",Description="Clean toilet and add gel",Added= DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Wash Bedding",Description="",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Mop Floors",Description="",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Dust",Description="Dust TV's, Computers, Counters and sills",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Clean Bath/Shower",Description="Scrub with anti mold. Clean mirror and shower window",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Vaccum",Description="",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Clean Windows",Description="Wipe down all windows",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))},
                new Chore{Name="Wash Dishcloths",Description="Replace with others in the meantime",Added=DateTime.Now, Cooldown = RandomGeni.Next(0, 14), LastCompletion = DateTime.Now.AddDays(RandomGeni.Next(-10, 0))}
            };
            foreach (Chore s in chores)
            {
                context.Chores.Add(s);
            }
            context.SaveChanges();


            context.SaveChanges();
        }
    }
}
