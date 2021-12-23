using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class Vector3Extension
    {
        public static Vector3 Vector3Lerp(this float amount, Vector3 v1, Vector3 v2)
        {
            return Vector3.Lerp(v1, v2, amount);
        }
    }
}
