using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class BlogPost
    {
        public string Properties { get; set; }
        public string Content { get; set; }
        public BlogPost(string properties, string content)
        {
            Properties = properties;
            Content = content;
        }
    }

}
