using SOLID._3_LiskovSubstiton.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LiskovSubstiton.GoodExample.Concrete
{
   public class DoganSLX:Car
    {
    }

    // Evet burada arabayı çalıştırdık fakan bu aracın klima özelliği olmadığı için burada "IAirConditionable" özelliğini hiç bir şekilde kullanmadık.
}
