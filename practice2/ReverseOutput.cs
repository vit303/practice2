using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class ReverseOutput
    {
        public static List<int> Output(int n) {
            List<int> output = new List<int>();
            for (int i = 1; i <= n; i++) {
                output.Add(n - i);
            }
            return output;
        }
    }
}
