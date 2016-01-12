using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPaint
{
    public interface IExtention
    {
        string Ext { get; }
        bool IsYours(string extention);
        void Save(string path,Bitmap saveBit);
        Bitmap Load(string path);
    }
}
