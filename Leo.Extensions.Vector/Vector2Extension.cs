using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class Vector2Extension
    {
        public static Vector2 Vector2Lerp(this float amount, Vector2 v1, Vector2 v2)
        {
            return Vector2.Lerp(v1, v2, amount);
        }
    }
}
