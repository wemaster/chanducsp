using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class KanjiDAO
    {
        NihongoDBContext context = new NihongoDBContext();
        public List<TblKanji> ViewKanji()
        {
            var list = context.Database.SqlQuery<TblKanji>("TblKanji_selectRandom").ToList();
            return list;
        }
    }
}