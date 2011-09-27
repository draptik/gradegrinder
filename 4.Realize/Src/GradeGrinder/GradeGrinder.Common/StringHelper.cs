using System;

namespace GradeGrinder.Common
{
    public static class StringHelper
    {
        public static bool IsNullOrEmpty(this string input)
        {
            return String.IsNullOrEmpty(input);
        }
    }
}
