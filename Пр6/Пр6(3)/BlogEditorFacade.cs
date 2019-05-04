using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class BlogEditorFacade : IBlogEditorFacade
    {
        private BlogEditor _blogEditor;
        public bool IsSpellCheckComplete { get; }
        public string PostProperties { get; }
        public string PostContent { get; }
        public BlogEditorFacade(BlogEditor blogEditor)
        {
            if (blogEditor == null)
            {
                throw new ArgumentNullException("blogEditor can't be null");
            }
            this._blogEditor = blogEditor;
        }

        public string Server
        {
            get { return this._blogEditor.Storage.Server; }
            set { this._blogEditor.Storage.Server = value; }
        }
        public string Login
        {
            get { return this._blogEditor.Storage.Login; }
            set { this._blogEditor.Storage.Login = value; }
        }
        public string Password
        {    
            set { this._blogEditor.Storage.Password = value; }
        }
        public void LoadPost(int postId)
        {
        //    int postid = postId - 1;
            BlogPost post = this._blogEditor.Storage.GetPost(postId);
            if (post != null)
            {
                this._blogEditor.Editor.Post = post;
            }
        }
        public  PostEditor LoadBlog()
        {
            PostEditor posted = this._blogEditor._editor;
            return posted;
        }

        public void DeletePost(int postId)
        {
        //    int postid = postId - 1;
                _blogEditor.Storage.DeletePost(postId);
        }

        public void Publish(BlogPost post)
        {
            _blogEditor.Storage.Publish(post);
        }
        public List<BlogPost> GetPostList()
        {
            return _blogEditor.Storage.GetPostList();
        }
    }
}
