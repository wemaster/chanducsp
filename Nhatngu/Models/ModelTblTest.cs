using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class ModelTblTest
    {
        public ModelTblTest()
        {
            Ischecked1 = false;
            Ischecked2 = false;
            Ischecked3 = false;
            Ischecked4 = false;
        }
       
        public int IDTest { get; set; }

        public int IDCate { get; set; }

        public string NameTest { get; set; }

        public string TestA { get; set; }

        public string TestB { get; set; }

        public string TestC { get; set; }

        public string TestD { get; set; }

        public string TestTrue { get; set; }

        public bool Status { get; set; }

        public DateTime DateCreate { get; set; }

        public bool Ischecked1 { get; set; }

        public bool Ischecked2 { get; set; }

        public bool Ischecked3 { get; set; }

        public bool Ischecked4 { get; set; }
    }
}