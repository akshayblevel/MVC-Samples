using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _34RemoteAttribute.Models
{
    public class Calculate
    {
        public int No1 { get; set; }

        [Remote("IsValid", "Calc")]
        public int No2 { get; set; }

    }
}