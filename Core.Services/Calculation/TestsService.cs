using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Calculation
{
    public class TestService
    {
        public void Loop64()
        {
            for (UInt64 i = 0; i < UInt64.MaxValue; i++)
            {
                var result = Math.Sqrt(i);
            }
        }
    }
}
