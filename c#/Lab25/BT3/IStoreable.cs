using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{  /// <summary>
   /// Khai bao giao dien
   /// </summary>
    internal interface IStoreable
    {
        void Read();
        void Write(object data);
    }
}
