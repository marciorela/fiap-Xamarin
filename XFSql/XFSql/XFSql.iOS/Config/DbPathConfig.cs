using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFSql.Config;

[assembly: Dependency(typeof(XFSql.iOS.Config.DbPathConfig))]
namespace XFSql.iOS.Config
{
    public class DbPathConfig : IDbPathConfig
    {
        private string _path;

        public string Path
        {
            get
            {
                if (string.IsNullOrEmpty(_path))
                {
                    _path = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _path = System.IO.Path.Combine(_path, "..", "Library");
                }
                return _path;
            }
        }
    }
}
