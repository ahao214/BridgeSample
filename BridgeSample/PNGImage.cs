using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    /// <summary>
    /// PNG格式图像类，充当扩充抽象类
    /// </summary>
    class PNGImage : Image
    {
        public override void ParseFile(string fileName)
        {
            //模拟解析PNG文件并获取一个像素矩阵对象m
            Matrix m = new Matrix();
            imp.DoPaint(m);
            Console.WriteLine("{0},格式为PNG.", fileName);               
        }
    }
}
