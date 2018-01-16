using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct10_2017Games.Models
{
    public class Score
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        //we did that much already. then entered some data from its website.
        //what if we want to add more fields to the model?

        //that's where migration comes in...

        //if you just add more stuff to the model, 
        //the program might not run or you'll get errors. so...

        //nuget pck mng console (in tools)
        //something will open at the bottom of the screen
        //that's where you put commands

        //enable-migrations
        //just needed to do ONCE per project
        //oops lol that's not right.
        //but type that, and it will tell you what to use instead
        //it'll open up a new part: Configuration.cs


    }
}