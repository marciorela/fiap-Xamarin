using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFSql.Config;
using XFSql.Model;

namespace XFSql.Repository
{
    public class InvestidorRepository : IDisposable
    {
        private SQLiteConnection connection;

        public InvestidorRepository()
        {
            IDbPathConfig dbPathConfig = DependencyService.Get<IDbPathConfig>();
            var caminho = System.IO.Path.Combine(dbPathConfig.Path, "fiap.db");

            connection = new SQLiteConnection(caminho);
            connection.CreateTable<Investidor>();
        }

        public void DropTable()
        {
            connection.DropTable<Investidor>();
        }

        public IList<Investidor> FindAll()
        {
            return connection.Table<Investidor>().ToList();
        }

        public void Insert(Investidor investidor)
        {
            connection.Insert(investidor);
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
