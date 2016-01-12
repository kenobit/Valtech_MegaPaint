﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPaint
{
    public class Icon : IExtention
    {
        public string Ext
        {
            get
            {
                return this.GetType().Name.ToLower().Remove(3);
            }
        }

        public bool IsYours(string extention)
        {
            return extention.Equals(this.Ext);
        }

        public Bitmap Load(string path)
        {
            return new Bitmap(path);
        }

        public void Save(string path, Bitmap saveBit)
        {
            saveBit.Save(path, System.Drawing.Imaging.ImageFormat.Icon);
        }
    }
}
