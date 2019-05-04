using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class PostEditor
    {
        private readonly SimpleSpellChecker _spellChecker = new SimpleSpellChecker();
        public bool IsSpellCheckComplete { get; private set; }
        public BlogPost Post { get; set; }
        public string PostProperties
        {
            get
            {
                if (this.Post == null) { return null; }
                return this.Post.Properties;
            }
        }
        public string PostContent
        {
            get
            {
                if (this.Post == null) { return null; }
                return this.Post.Content;
            }
            set
            {
                this.Post.Content = value;
            }
        }
    }
}
