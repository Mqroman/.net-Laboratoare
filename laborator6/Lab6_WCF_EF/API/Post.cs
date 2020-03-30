using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_WCF_EF
{
    public partial class Post
    {
        public bool AddPost()
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                if (this.PostId == 0)
                {
                    var it = context.Entry<Post>(this).State = EntityState.Added;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Post UpdatePost(Post newPost)
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                Post oldPost = context.Posts.Find(newPost.PostId);
                if (oldPost == null)
                    return null;
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                context.SaveChanges();
                return oldPost;
            }
        }

        public int DeletePost(int id)
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                Post post = context.Posts.Find(id);
                context.Posts.Remove(post);
                context.SaveChanges();
                return id;
            }
        }

        public Post GetPostById(int id)
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                var items = context.Posts.Where(p => p.PostId == id);
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null;
            }
        }

        public List<Post> GetAllPosts()
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                return context.Posts.Include(p => p.Comments).ToList();
            }
        }

    }
}
