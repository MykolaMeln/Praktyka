using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public interface IBlogEditorFacade
    {
        string Server { get; set; }
        string Login { set; }
        string Password { set; }
        bool IsSpellCheckComplete { get; }
        string PostProperties { get; }
        string PostContent { get; }
        List<BlogPost> GetPostList();
        void LoadPost(int postid);
        void Publish(BlogPost post);
        void DeletePost(int postid);
    }
}
