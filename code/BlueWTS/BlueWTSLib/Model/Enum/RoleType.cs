using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Model.Enum
{

    public enum RoleType
    {
        [Description("超级管理员")]
        Admin = 100,


        [Description("未知角色")]
        UnKnow = 999
    }
}