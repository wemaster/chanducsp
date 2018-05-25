using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class TestDAO
    {
        NihongoDBContext context = new NihongoDBContext();
        public ModelTblTest ListTest(int IDCate)
        {
            string sql = @"SELECT TOP 1 * FROM TblTest WHERE TblTest.Status= 'true' AND TblTest.IDCate='"+IDCate+"' ORDER BY NEWID()";
            return context.Database.SqlQuery<ModelTblTest>(sql).FirstOrDefault();
        }
        public TblTest ListTestTrue (int IdTest)
        {
            var model = context.TblTests.Where(x=>x.IDTest == IdTest).FirstOrDefault();
            return model;
        }
    }
}