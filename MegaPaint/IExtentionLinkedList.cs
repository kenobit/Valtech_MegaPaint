using System;
using System.Collections.Generic;
using System.Drawing;

namespace MegaPaint
{
    public interface IExtentionLinkedList
    {
        string Ext { get; }
        bool IsYours(string extention);
        void Save(string path, Bitmap saveBit);
        Bitmap Load(string path);
        IExtentionLinkedList Next { get; set; }
    }
}
