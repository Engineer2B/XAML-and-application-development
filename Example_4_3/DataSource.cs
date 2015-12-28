using System.Collections.Generic;

namespace Example_4_3
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