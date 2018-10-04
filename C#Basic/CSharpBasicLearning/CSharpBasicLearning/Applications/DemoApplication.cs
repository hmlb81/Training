using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicLearning
{
    public class DemoApplication
    {
        #region fields
        /// <summary>
        /// 单体实例 。
        /// </summary>
        private static DemoApplication instance = new DemoApplication();
        #endregion

        #region constructor
        /// <summary>
        /// Prevents a default instance of the DemoApplication class from being created.
        /// </summary>
        private DemoApplication()
        {
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets 单体实例 。
        /// </summary>
        public static DemoApplication Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        #region public methods
        /// <summary>
        /// ToString示例 。
        /// </summary>
        public void DemoShowToString()
        {
            Parameter parameter = new Parameter() { Name = "WBC", Result = 1.0, Unit = "10^9/L", };
            string s = parameter.ToString();
            Console.WriteLine(s);
        }

        /// <summary>
        /// 相等比较示例 。
        /// </summary>
        public void DemoEquals()
        {
            Parameter parameter = new Parameter() { Name = "WBC", Result = 1.0, Unit = "10^9/L", };
            bool result = parameter.Equals(null);
        }
        #endregion
    }
}
