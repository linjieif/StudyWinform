using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWinform
{
    public class GlobalFunc
    {
        // 单例模式
        private static GlobalFunc _Instance = null;

        public static GlobalFunc Instance
        {
            get
                { 
                if( _Instance == null )
                {
                    _Instance = new GlobalFunc();
                }
                return _Instance;
            }
        }

        public string Name = "登录";
        public Form1 formLogin = null;

        public string AcountG = null;
        
    }
}
