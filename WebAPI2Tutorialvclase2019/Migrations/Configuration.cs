namespace WebAPI2Tutorialvclase2019.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPI2Tutorialvclase2019.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI2Tutorialvclase2019.Models.WebAPI2Tutorialvclase2019Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI2Tutorialvclase2019.Models.WebAPI2Tutorialvclase2019Context context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
           new Contacts
           {
               ContactId = 1,
               Name = "Jessica Diaz",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "jdiaz@etsisi.upm.es",
           },
           new Contacts
           {
               ContactId = 2,
               Name = "Jennifer Perez",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "jperez@etsisi.upm.es",
           },
           new Contacts
           {
               ContactId = 1,
               Name = "Agustin Yague",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "ayague@etsisi.upm.es",
           }

 );
        }
    }
}
