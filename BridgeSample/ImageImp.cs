using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    /// <summary>
    /// 抽象操作系统实现类，充当实现类接口
    /// </summary>
    interface ImageImp
    {
        void DoPaint(Matrix m); //显示像素矩阵m
    }
}
