using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _33CompareValidator.Models
{
    public class Calculate
    {
        public int No1 { get; set; }

        [Compare("No1")]
        public int No2 { get; set; }
    }
}