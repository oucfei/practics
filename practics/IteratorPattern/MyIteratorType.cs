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
            yield return strArray[2];
            yield return strArray[0];
            yield return strArray[1];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
