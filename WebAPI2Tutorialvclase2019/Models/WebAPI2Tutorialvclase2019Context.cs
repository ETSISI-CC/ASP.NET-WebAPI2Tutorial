using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI2Tutorialvclase2019.Models
{
    public class WebAPI2Tutorialvclase2019Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebAPI2Tutorialvclase2019Context() : base("name=WebAPI2Tutorialvclase2019Context")
        {
        }

        public System.Data.Entity.DbSet<WebAPI2Tutorialvclase2019.Models.Contacts> Contacts { get; set; }
    }
}
