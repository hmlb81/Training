using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicLearning
{
    public class Parameter
    {
        #region fields
        /// <summary>
        /// 参数名称 。
        /// </summary>
        private string name = string.Empty;

        /// <summary>
        /// 参数结果 。
        /// </summary>
        private double result = 0.0;

        /// <summary>
        /// 参数单位 。
        /// </summary>
        private string unit = string.Empty;
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets 参数名称 。
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets 参数结果 。
        /// </summary>
        public double Result
        {
            get
            {
                return this.result;
            }

            set
            {
                this.result = value;
            }
        }

        /// <summary>
        /// Gets or sets 单位 。
        /// </summary>
        public string Unit
        {
            get
            {
                return this.unit;
            }

            set
            {
                this.unit = value;
            }
        }
        #endregion

        #region public static methods
        #endregion

        #region public methodsu
        /// <summary>
        /// 重载Equals方法 。
        /// </summary>
        /// <param name="obj">待比较对象 。</param>
        /// <returns>相等返回true，否则返回false 。</returns>
        public override bool Equals(object obj)
        {
            Parameter realobj = obj as Parameter;
            return (!ReferenceEquals(realobj, null))
                && (this.name == realobj.name)
                && (this.result == realobj.result)
                && (this.unit == realobj.unit)
                ;
        }

        /// <summary>
        /// 重载ToString方法 。
        /// </summary>
        /// <returns>实例字符串 。</returns>
        public override string ToString()
        {
            return string.Format(
                CultureInfo.CurrentCulture, 
                "Parameter(name={0}, result={1}, unit={2})", 
                this.name, 
                this.result, 
                this.unit
                );
        }
        #endregion
    }
}