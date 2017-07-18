using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造初始化与声明初始化测试
            StaticMeMberTest s1 = new StaticMeMberTest();
            Console.WriteLine("S1I:{0}, S1II:{1}", s1.GetNextI(), s1.GetNextII());
            StaticMeMberTest s2 = new StaticMeMberTest();
            Console.WriteLine("S1I:{0}, S1II:{1}", s1.GetNextI(), s1.GetNextII());
            Console.WriteLine("S2I:{0}, S2II:{1}", s2.GetNextI(), s2.GetNextII());
            
            ////浅拷贝与深拷贝测试
            //Class1Copy copy1 = new Class1Copy();
            //copy1.CMember = new ClassMember() {NClassMember = 1};
            //copy1.SMember = "copy1";
            //copy1.NMember = 1;

            //Class1Copy copy2 = copy1;
            //Class1Copy copy3 = copy1.Clone();
            //Class1Copy copy4 = copy1.Copy();

            ////Console.WriteLine("copy1:{0}\r\ncopy2:{1}\r\ncopy3:{2}\r\ncopy4:{3}", copy1.ToString(),
            ////    copy2.ToString(), copy3.ToString(), copy4.ToString());

            //copy1.NMember = 2;
            //copy1.SMember = "copy2";
            //copy1.CMember.NClassMember = 2;

            //Console.WriteLine("copy1:{0}\r\ncopy2:{1}\r\ncopy3:{2}\r\ncopy4:{3}", copy1,
            //   copy2, copy3, copy4);
            
            //////异常捕获测试
            ////MessageBox.Show("test");
            ////Console.WriteLine("here");
            ////try
            ////{
            ////    test();
            ////}
            ////catch (Exception)
            ////{
            ////   Console.WriteLine("here");
            ////}

            Console.Read();
        }

        static void test()
        {
            string s = null;
            try
            {
                Console.Write(s.Length);
            }
            catch (Exception)
            {
                
               Console.WriteLine("test");
            }
            Console.WriteLine("next");
        }
    }
}
