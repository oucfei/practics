using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics.IteratorPattern
{
    class MyIteratorType : IEnumerable<string>
    {
        public string[] strArray = new string[] { "123", "456", "789" }; 

        public IEnumerator<string> GetEnumerator()
        {
            var list = new List<string>();
            list.Add("abc");
            list.Add("dfg");
            list.Add("ghi");
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
