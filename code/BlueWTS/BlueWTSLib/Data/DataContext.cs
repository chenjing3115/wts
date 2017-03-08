using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using BlueWTSLib.Data;

namespace BlueWTSLib.Data
{
    public class DataContext : IDataContextFactory
    {
        private string connStr;
        public DataContext(string connStr)
        {
            this.connStr = connStr;
        }
        private BlueWTSDbDataContext context;

        public System.Data.Linq.DataContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new BlueWTSDbDataContext(this.connStr);
                }
                return context;
            }
        }

        public void SaveAll()
        {
            context.SubmitChanges();
        }
    }
}
