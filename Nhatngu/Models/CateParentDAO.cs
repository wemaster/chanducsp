using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class CateParentDAO
    {
        NihongoDBContext context = new NihongoDBContext();
        public List<TblCateParent> Listcate()
        {
            var model = context.TblCateParents.Where(x => x.Status == true).ToList();
            return model;
        }
    }
}