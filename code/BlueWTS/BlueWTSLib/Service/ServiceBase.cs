using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueWTSLib.Data;

namespace BlueWTSLib.Service
{
    public class ServiceBase
    {
        private string dbString; 

        private DataContext context;
        private User user;

        private static object syncObj = new object();

        public string DbString
        {
            get
            {
                return dbString;
            }
        } 

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public DataContext Context
        {
            get
            {
                if (null == context)
                {
                    lock (syncObj)
                    {
                        if (null == context)
                        {
                            context = new DataContext(this.DbString);
                        }
                    }
                }
                return context;
            }
        }

        public ServiceBase() { }

        public ServiceBase(string dbString)
        {
            this.dbString = dbString;
        }

        public ServiceBase(string dbString, User user)
        {
            this.dbString = dbString;
            this.user = user;
        }

    }
}
