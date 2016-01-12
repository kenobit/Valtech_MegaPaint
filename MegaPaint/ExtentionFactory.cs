using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPaint
{
    class ExtentionFactory
    {
        List<IExtention> ExtentionClasses;

        public ExtentionFactory()
        {
            ExtentionClasses = new List<IExtention>() { };
            ExtentionClasses.Add(new Jpg());
            ExtentionClasses.Add(new Bmp());
            ExtentionClasses.Add(new Png());
        }

        public IExtention GetInstance(string path)
        {
            IExtention instance = null;

            if (path != "")
            {
                string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower();

                foreach (IExtention inst in ExtentionClasses)
                {
                    if (inst.IsYours(extention))
                    {
                        instance = inst;
                    }
                }
            }
            return instance;
        }
    }
}
