using Nhatngu.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.Models
{
    public class UserDAO
    {
        NihongoDBContext context = new NihongoDBContext();
        public int loginuser (string user, string password)
        {
            var result = context.TblAccs.SingleOrDefault(x => x.NameAcc == user);
            if (result == null)
            {
                return 0;//Acc null
            }
            else
            {
                if (result.PassAcc != password)
                    return -1;//password not correct
                else
                    return 1;//Login success
            }
        }
        public TblAcc GetIDuser(string user)
        {
            return context.TblAccs.SingleOrDefault(x => x.NameAcc == user);
        }
        #region Add Account

        #endregion
    }
}