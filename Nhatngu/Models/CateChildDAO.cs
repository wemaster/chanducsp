using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class CateChildDAO
    {
        NihongoDBContext context = new NihongoDBContext();
        public List<TblCateChild> ListChild()
        {
            var model = context.TblCateChilds.Where(x => x.Status == true).ToList();
            return model;
        }

    }
}