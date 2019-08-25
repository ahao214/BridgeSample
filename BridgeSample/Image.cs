using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    /// <summary>
    /// 抽象图像类，充当抽象类
    /// </summary>
   abstract class Image
    {
        protected ImageImp imp;
        
        //注入实现类接口对象
        public void SetImageImp(ImageImp imp)
        {
            this.imp = imp;
        }

        public abstract void ParseFile(string fileName);
    }
}
