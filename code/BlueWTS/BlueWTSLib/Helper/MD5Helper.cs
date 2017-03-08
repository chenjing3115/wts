using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BlueWTSLib.Helper
{
    public class MD5Helper
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="encry"></param>
        /// <returns></returns>
        public static string Encryt(string encry)
        {
            char[] pwdc = encry.ToCharArray();

            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] md5b = md5.ComputeHash(Encoding.UTF8.GetBytes(encry));

            string byte2String = string.Empty;

            for (int i = 0; i < md5b.Length; i++)
            {
                int val = md5b[i] & 0xff;
                if (val < 16)
                    byte2String += "0";
                byte2String += md5b[i].ToString("x");
            }

            return byte2String;
        }
    }
}
