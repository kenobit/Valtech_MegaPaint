using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPaint
{
    class ExtentionLLFactory
    {
        IExtentionLinkedList Root;

        public ExtentionLLFactory()
        {
            Root = new Jpg();
            Root.Next = new Png();
            Root.Next.Next = new Bmp();
            Root.Next.Next.Next = new Gif();
            Root.Next.Next.Next.Next = new Icon();
            Root.Next.Next.Next.Next.Next = new Tiff();

        }

        public IExtentionLinkedList GetInstance(string path)
        {
            IExtentionLinkedList instance = null;
            IExtentionLinkedList currentNode = Root;

            if (path != "")
            {
                string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower();

                while (currentNode!=null)
                {
                    if (currentNode.Ext == extention)
                    {
                        instance = currentNode;
                    }
                    currentNode = currentNode.Next;
                }
            }
            return instance;
        }
    }
}
