using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicLearning
{
    /// <summary>
    /// 主程序 。
    /// </summary>
    class Program
    {
        #region main method
        /// <summary>
        /// 程序入口 。
        /// </summary>
        /// <param name="args">命令行参数 。</param>
        static void Main(string[] args)
        {
            DemoApplication.Instance.DemoEquals();
            Console.ReadKey();
        }
        #endregion
    }
}
