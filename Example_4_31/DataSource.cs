using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Data
{
    public class DataSource
    {
        public DataSource()
        {
            this.Values = new List<string> {
                "Mike", "November", "Oscar", "Papa", "Quebec",
                "Romeo", "Sierra", "Tango", "Uniform", "Victor"
            };
        }
        public List<string> Values { get; set; }
    }
}
