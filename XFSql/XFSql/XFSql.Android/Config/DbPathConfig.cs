using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFSql.Config;

[assembly: Dependency(typeof(XFSql.Droid.Config.DbPathConfig))]
namespace XFSql.Droid.Config
{
    public class DbPathConfig : IDbPathConfig
    {
        private string _path;

        public string Path {
            get {
                if (string.IsNullOrEmpty(_path))
                {
                    _path = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return _path;
            }
        }
    }
}
