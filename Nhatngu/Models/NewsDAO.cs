using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class NewsDAO
    {
        NihongoDBContext context = new NihongoDBContext();
       public string GetviewDate()
        {
//            string sql = @"Select DayCreate = DATEADD(MONTH, DATEDIFF(MONTH, 0, DayCreate), 0) from TblNews WHERE TblNews.Status= 'true'  
//                            GROUP BY DATEADD(MONTH, DATEDIFF(MONTH, 0, DayCreate), 0)";
            var result = context.Database.SqlQuery<string>("TblNews_Select").Single();
            
            return result;
        }
       public List<TblNew> ViewListAll()
       {
           var sql= @"SELECT TOP 3 * FROM TblNews AS T WHERE CONVERT(varchar,T.DayCreate,103) like '%"+ GetviewDate() +"' ";
           var model = context.Database.SqlQuery<TblNew>(sql).OrderByDescending(x=>x.IDNews).ToList();
           return model;
       }
    }
}