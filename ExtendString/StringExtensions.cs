using System;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        static Random rand;
        static StringExtensions()
        {
            rand = new Random();
        }

        public static string ToRandomCase(this String s)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                char rc = rand.NextDouble()>0.5 ? char.ToUpper(c) : char.ToLower(c);
                sb.Append(rc);
            }

            return sb.ToString();
        }
    }
}