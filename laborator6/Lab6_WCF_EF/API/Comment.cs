using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_WCF_EF
{
    public partial class Comment
    {
        public bool AddComment()
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                if (this == null || this.PostPostId == 0)
                    return false;
                if (this.CommentId == 0)
                {
                    context.Entry<Comment>(this).State = EntityState.Added;
                    Post p = context.Posts.Find(this.PostPostId);
                    context.Entry<Post>(p).State = EntityState.Unchanged;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Comment UpdateComment(Comment newComment)
        {
            using (ModelPostCommentContainer context = new ModelPostCommentContainer())
            {
                Comment comment = context.Comments.Find(newComment.CommentId);
                
                if (newComment.Text != null)
                    comment.Text = newComment.Text;
                
                if ((comment.PostPostId != newComment.PostPostId)
                    && (newComment.PostPostId != 0))
                        comment.PostPostId = newComment.PostPostId;
                context.SaveChanges();
                return comment;
            }
        }

        public Comment GetCommentById(int id)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                var items = ctx.Comments.Where(c => c.CommentId == id);
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }




    }
}
