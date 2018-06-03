using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Common : ICommon
    {
        public string ChangePathImage(string _path)
        {
            int index = _path.IndexOf("Image");
            string path = "";
            if (index != -1)
            {
                path = "\\" + _path.Substring(index);
               path = path.Replace("\\", "/");
            }
            return path;
        }
    }
}
