using System;

namespace Core.Services.Calculation
{
    public class TestService
    {
        public void Loop64()
        {
            for (UInt64 i = 0; i < UInt64.MaxValue; i++)
            {
                var result = i/4 + i/8;
            }
        }

        public void Loop16()
        {
            for (UInt16 i = 0; i < UInt16.MaxValue; i++)
            {
                var result = i / 4 + i / 8;
            }
        }

        public void Loop32()
        {
            for (UInt32 i = 0; i < UInt32.MaxValue; i++)
            {
                var result = i / 4 + i / 8;
            }
        }
    }
}
