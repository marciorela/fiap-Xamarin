using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFSql.Model
{
    public class Investidor
    {
        [PrimaryKey, AutoIncrement]
        public int IdInvestidor { get; set; }

        public string NomeInvestidor { get; set; }

        public string EmailInvestidor { get; set; }

    }
}
