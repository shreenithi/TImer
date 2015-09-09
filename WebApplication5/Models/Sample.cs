using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Sample
    {
        public static string LabelName { get; set; }

        public static string GetSetName(string count)
        {
            string LabelName = count;
            return LabelName;
           
        }
                
    }


}