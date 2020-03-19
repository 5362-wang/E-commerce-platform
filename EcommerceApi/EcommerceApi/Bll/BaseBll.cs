using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    /// <summary>
    /// 单利模式
    /// </summary>
        public abstract class BaseBll<T> where T : new()
        {
            private static T _instance;
            public static T Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new T();
                    return _instance;
                }
            }
        }

}
