using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// K.V.

namespace Cards
{
    class PathContainer
    {
        private static string projectpath;
        private static string databasepath;

        public void MakeStrings()
        {
            string pathdebug = Path.GetDirectoryName(Application.ExecutablePath);
            int firstindex = pathdebug.IndexOf("\\bin", 0);
            projectpath = pathdebug.Remove(firstindex, pathdebug.Length - firstindex);
            databasepath = "Data Source=" + projectpath + @"\Base.db";
        }
        public string ConnStrGet()
        {
            if (databasepath == null)
            {
                MakeStrings();
            }
            return databasepath;
        }
        public string ProjectPathGet()
        {
            if (projectpath == null)
            {
                MakeStrings();
            }
            return projectpath;
        }
        public string ImagesPathGet()
        {
            if (projectpath == null)
            {
                MakeStrings();
            }
            return projectpath + @"\Photo\Images";
        }
        public string IconsPathGet()
        {
            if (projectpath == null)
            {
                MakeStrings();
            }
            return projectpath + @"\Photo\Icons";
        }
        public string AnimationPathGet()
        {
            if (projectpath==null)
            {
                MakeStrings();
            }
            return projectpath + @"\Photo\Animation";
        }
    }
}
