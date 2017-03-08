using BlueWTSLib.Helper;
using BlueWTSLib.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueWTSLib.Data
{
    public partial class User
    {
        public RoleType roleTypeEnum
        {
            get
            {
                if (this.roleType.HasValue)
                {
                    return (RoleType)this.roleType;
                }
                else { return RoleType.UnKnow; }
            }
        }

        public string roleTypeDisplay
        {
            get
            {
                return EnumHelper.GetDescriptionByFiledName(this.roleTypeEnum.ToString(), typeof(RoleType));
            }
        }

        private bool? iswxbind = null;
        public bool isWXBind
        {
            get
            {
                if (!iswxbind.HasValue)
                {
                    iswxbind = !string.IsNullOrEmpty(this.wxOpenId);
                }
                return iswxbind.Value;
            }
            set
            {
                iswxbind = value;
            }
        }

        public string GenSalt()
        {
            // return Guid.NewGuid().ToString();
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[36];
            rng.GetBytes(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);
            return salt;
        }
    }
}
