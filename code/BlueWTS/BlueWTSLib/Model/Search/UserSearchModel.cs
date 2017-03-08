using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Model.Search
{
    public class UserSearchModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int? roleType { get; set; }

        public string loginId { get; set; }
    }
}
