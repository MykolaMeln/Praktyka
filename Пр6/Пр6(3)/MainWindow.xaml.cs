using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Пр6_3_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        public static PostEditor posteditor = new PostEditor();
        public int count = 1;
        public static BlogPostStorage blogpoststorage = new BlogPostStorage();
        public static BlogEditor blogeditor = new BlogEditor(blogpoststorage, posteditor);
        public BlogEditorFacade blogeditorfacade = new BlogEditorFacade(blogeditor);
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            blog.Visibility = Visibility.Visible;
            llogin.Content = login.Text;
            lserver.Content = server.Text;
            logpath.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            posts.Items.Clear();
            BlogPost blogpost = new BlogPost(count.ToString(), add.Text);        
            count++;
     
            blogeditorfacade.Publish(blogpost);

            foreach (BlogPost post in blogeditorfacade.GetPostList())
            {
                posts.Items.Add(post.Properties + " " + post.Content);
            }
            add.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            posts.Items.Clear();
            blogeditorfacade.DeletePost(Convert.ToInt32(numdel.Text));
            foreach (BlogPost post in blogeditorfacade.GetPostList())
            {
                posts.Items.Add(post.Properties + " " + post.Content);
            }
            numdel.Text = "";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach(BlogPost blp in blogeditorfacade.GetPostList())
            {
                if(blp.Properties == numed.Text)
                {
                    edit.Text = blp.Content;
                    blogeditorfacade.LoadBlog().Post = blp;
                }
                else
                {
                    edit.Text = "";
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            posts.Items.Clear();
            blogeditorfacade.LoadBlog().PostContent = edit.Text;
            foreach (BlogPost blp in blogeditorfacade.GetPostList())
            {
                if (blp.Properties == blogeditorfacade.LoadBlog().PostProperties)
                {
                    blp.Content = blogeditorfacade.LoadBlog().PostContent;
                 }
                else
                {
                    blp.Content = blp.Content;
                }
            }

            foreach (BlogPost post in blogeditorfacade.GetPostList())
            {
                posts.Items.Add(post.Properties+" "+post.Content);
            }
            edit.Text = "";
        }
    }
}
