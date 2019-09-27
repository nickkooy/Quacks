using System;
using System.Collections.Generic;
using System.Text;

namespace Quacks
{
    public interface IRandom
    {
        /// <summary>
        /// Returns a random integer that's greater than 0 and less than max
        /// </summary>
        /// <param name="max">Exclusive</param>
        /// <returns></returns>
        int Next(int max);
    }
}
