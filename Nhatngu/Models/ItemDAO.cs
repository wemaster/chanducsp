using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    [Serializable]
    public class ItemDAO
    {
        public string Img { get; set; }
        public string TestTrue { get; set; }
        public decimal CountTotal { get; set; }
    }
}