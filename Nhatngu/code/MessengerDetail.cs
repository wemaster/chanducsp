using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nhatngu.code
{
    public class MessengerDetail
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public string Messenger { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm}",
               ApplyFormatInEditMode = true)]
        public TimeSpan TimeSend { get; set; }
    }
}