using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class BlogEditor
    {
        public BlogPostStorage _storage;
        public BlogPostStorage Storage { get{return this._storage;} }
        public PostEditor _editor;
        public PostEditor Editor { get { return this._editor; } }
        public BlogEditor(BlogPostStorage storage, PostEditor editor)
        {
            _storage = storage;
            _editor = editor;
        }
    }
}
