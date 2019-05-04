using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class BlogClient
    {
        private readonly IBlogEditorFacade _blogEditor = null;

        public BlogClient(IBlogEditorFacade iBlogEditor)
        {
            this._blogEditor = iBlogEditor;
        }
    }
}
