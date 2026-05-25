using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Aids
{
    public static class GetRandom
    {
        private static readonly Random r = Random.Shared;

        public static int Int32(int min = int.MinValue, int max = int.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return r.Next(min, max);
        }

        public static long Int64(long min = long.MinValue, long max = long.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return r.NextInt64(min, max);
        }

        public static double Double(double min = double.MinValue, double max = double.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return min + r.NextDouble() * (max - min);
        }

        public static sbyte Int8(sbyte min = sbyte.MinValue, sbyte max = sbyte.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (sbyte)r.Next(min, max);
        }

        public static short Int16(short min = short.MinValue, short max = short.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (short)r.Next(min, max);
        }

        public static byte UInt8(byte min = byte.MinValue, byte max = byte.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (byte)r.Next(min, max);
        }

        public static ushort UInt16(ushort min = ushort.MinValue, ushort max = ushort.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (ushort)r.Next(min, max);
        }

        public static uint UInt32(uint min = uint.MinValue, uint max = uint.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (uint)r.NextInt64(min, max);
        }

        public static ulong UInt64(ulong min = ulong.MinValue, ulong max = ulong.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            ulong range = max - min;
            return min + (ulong)(r.NextDouble() * range);
        }

        public static decimal Decimal(decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return min + (decimal)r.NextDouble() * (max - min);
        }

        public static float Float(float min = float.MinValue, float max = float.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return min + (float)r.NextDouble() * (max - min);
        }

        public static string String(int length = 10, string chars 
            = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789")
        {
            if (length <= 0) return string.Empty;
            var buf = new char[length];
            for (int i = 0; i < length; i++) buf[i] = chars[r.Next(chars.Length)];
            return new string(buf);
        }

        public static char Char(char min = char.MinValue, char max = char.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (char)r.Next(min, max);
        }

        public static bool Bool() => r.Next(2) == 0;

        public static DateTime DateTime(DateTime? min = null, DateTime? max = null)
        {
            DateTime lo = min ?? System.DateTime.MinValue;
            DateTime hi = max ?? System.DateTime.MaxValue;
            if (lo == hi) return lo;
            if (lo > hi) (lo, hi) = (hi, lo);
            long ticks = Int64(lo.Ticks, hi.Ticks);
            return new DateTime(ticks);
        }

        public static TimeSpan TimeSpan(TimeSpan? min = null, TimeSpan? max = null)
        {
            TimeSpan lo = min ?? System.TimeSpan.MinValue;
            TimeSpan hi = max ?? System.TimeSpan.MaxValue;
            if (lo == hi) return lo;
            if (lo > hi) (lo, hi) = (hi, lo);
            return new TimeSpan(Int64(lo.Ticks, hi.Ticks));
        }

        public static Guid Guid()
        {
            var bytes = new byte[16];
            r.NextBytes(bytes);
            return new Guid(bytes);
        }
    }
}
