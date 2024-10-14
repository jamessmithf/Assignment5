using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class BookProduct : Product
    {
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nВидавництво: {Publisher}\nКількість сторінок: {PageCount}\nАвтори: {string.Join(", ", Authors)}";
        }
    }
}
