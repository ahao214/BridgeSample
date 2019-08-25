using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    /// <summary>
    /// Windows操作系统实现类，充当具体实现类
    /// </summary>
    class WindowsImp:ImageImp
    {
        public void DoPaint(Matrix m)
        {
            //调用Windows系统的绘制函数绘制像素矩阵
            Console.Write("在Windows操作系统中显示图像：");
        }
    }
}
