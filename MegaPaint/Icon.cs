using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPaint
{
    public class Icon : IExtentionLinkedList
    {
        private IExtentionLinkedList next;
        public string Ext
        {
            get
            {
                return this.GetType().Name.ToLower().Remove(3);
            }
        }

        public IExtentionLinkedList Next
        {
            get
            {
                return this.next;
            }

            set
            {
                this.next = value;
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
