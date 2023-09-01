using System.Reflection.Metadata;
using MyBlog.DataAccess.Base;
using MyBlog.DataAccess.Interface;
using MyBlog.Models;

namespace MyBlog.DataAccess.Implement
{
    public class BlogContent : IBlogContent
    {
        private BlogContext _blogContext;
        public BlogContent(BlogContext blogContext) { _blogContext = blogContext; }
        public bool CreatBlog(ABContent content)
        {
            _blogContext.Contents.Add(content);
            return _blogContext.SaveChanges() > 0;
        }

        public IEnumerable<ABContent> GetBlogs()
        {
            return _blogContext.Contents.ToList();
        }

        public bool DeletBlogById(string bId)
        {
            var content = _blogContext.Contents.SingleOrDefault(s => s.BId == bId);
            _blogContext.Contents.Remove(content);
            return _blogContext.SaveChanges() > 0;
        }

        public ABContent GetBlogById(string bId)
        {
            return _blogContext.Contents.SingleOrDefault(s => s.BId == bId);
        }

        public bool UpdateBlog(ABContent content)
        {
            _blogContext.Contents.Update(content);
            return _blogContext.SaveChanges() > 0;
        }
    }
}
