using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class BlogPostStorage
    {
        public string Server { get; set; }
        public string Login { get; set; }
        public string Password { private get; set; }
        public List<BlogPost> listblogpost = null;
        public BlogPostStorage() { listblogpost = new List<BlogPost>(); }
        public List<BlogPost> GetPostList()
        {
            return listblogpost;
        }
        public BlogPost GetPost(int postId)
        {
            BlogPost blog = null;
            foreach(BlogPost bp in listblogpost)
            {
                if(bp.Properties == postId.ToString())
                {
                    blog = new BlogPost(bp.Properties, bp.Content);
                }
            }
            return blog;
        }
        public void DeletePost(int postId)
        {
            List<BlogPost> lbp = new List<BlogPost>();
            foreach (BlogPost bp in listblogpost)
            {
                if (bp.Properties != postId.ToString())
                {
                    lbp.Add(bp);
                }
            }
            ListAdd(lbp);
        }
        public void ListAdd(List<BlogPost> list)
        {
            listblogpost = list;
        }
        public void Publish(BlogPost post)
        {
            listblogpost.Add(post);
        }
    }
}
