using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;


namespace BridgeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image;
            ImageImp imp;

            //读取配置文件
            string imageType = ConfigurationManager.AppSettings["image"];
            string osType = ConfigurationManager.AppSettings["os"];

            //反射生成对象
            image = (Image)Assembly.Load("BridgeSample").CreateInstance(imageType);
            imp = (ImageImp)Assembly.Load("BridgeSample").CreateInstance(osType);

            image.SetImageImp(imp);
            image.ParseFile("中国地图");
            Console.ReadLine();


        }
    }
}
