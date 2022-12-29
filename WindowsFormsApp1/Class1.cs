using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Class1
    {
        public bool IsPower(long m1)
        {
            if (m1 > 0)
            {
                while (m1 % 2 == 0)
                {
                    m1 /= 2;
                }
                if (m1 == 1)
                {
                    return true;
                }
            }
            if (m1 == 0 || m1 != 1)
            {
                return false;
            }
            return false;
        }
        public bool Isprime(long m1)
        {
            bool flag = true;
            for (int i = 2; i <= m1 / 2; i++)
            {
                if (m1 % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public bool relatively_prime(long m1, long c1)
        {
            long result;
            if (c1 < m1) result = c1;
            else if (c1 > m1) result = m1;
            else result = m1;
            while (result > 0)
            {
                if (c1 % result == 0 && m1 % result == 0)
                {
                    break;
                }
                result--;
            }
            if (result == 1) return true;
            else return false;

        }
        public bool resutl(long a, long k, long m)
        {

            long r = 1;
            for (long i = 1; i <= k; i++)
            {
                r = r * a;
            }
            r = r - 1;
            if (r % m == 0) return true;
            else return false;

        }
        public int num_sen(long c, long m, long a, long seed)
        {
            long k = m - 1;
            if (c != 0 && IsPower(m) == true && relatively_prime(c, m) && a == 4 * k + 1)
            {
                return 1;
            }
            if (c == 0 && IsPower(m) == true && seed % 2 != 0)
            {
                if (a == 8 * k + 3 || a == 8 * k + 5)
                {
                    return 2;
                }

            }
            if (c == 0 && Isprime(m) == true && resutl(a, k, m) == true)
            {
                return 3;
            }
            return 4;
        }
        public List<long> sen1(long a, long c, long seed, long m)
        {
            List<long> rees= new List<long>();
            for (int i = 1; i <= m; i++)
            {
                long xx = (a * seed + c) % m;
                rees.Add(xx);
                seed = xx;
            }
            rees.Add(m);
            return rees;

        }
        public List<long> sen2(long a, long c, long seed, long m)
        {
            List<long> rees = new List<long>();
            for (int i = 0; i < m / 4; i++)
            {
                long xx = (a * seed + c) % m;
                rees.Add(xx);
                seed = xx;
                
            }
            rees.Add(m/4);
            return rees;

        }
        public List<long> sen3(long a, long c, long seed, long m)
        {
            List<long> rees = new List<long>();
            for (int i = 0; i < m - 1; i++)
            {
                long xx = (a * seed + c) % m;
                seed = xx;
                rees.Add(xx);
            }
            rees.Add(m-1);
            return rees;
        }
        public List<long> sen4(long a, long c, long seed, long m)
        {
            int cy = 0;
            List<long> rees = new List<long>();
            seed = (a * seed + c) % m;
            rees.Add(seed);
            long fir = seed;

            cy++;

            seed = (a * seed + c) % m;
            if (seed != fir)
            {
                rees.Add(seed);
                cy++;
            }
            while (seed != fir && seed != 0)
            {

                seed = (a * seed + c) % m;
                rees.Add(seed);
                cy++;
            }
            cy--;
            rees.Add(cy);
            return rees;
        }


    }
}
