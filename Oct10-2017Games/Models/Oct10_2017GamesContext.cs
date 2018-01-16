﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Oct10_2017Games.Models
{
    public class Oct10_2017GamesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Oct10_2017GamesContext() : base("name=Oct10_2017GamesContext")
        {
        }

        public System.Data.Entity.DbSet<Oct10_2017Games.Models.Score> Scores { get; set; }
    }
}
