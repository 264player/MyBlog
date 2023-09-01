using MyBlog.DataAccess.Base;
using MyBlog.DataAccess.Interface;
using MyBlog.Models;

namespace MyBlog.DataAccess.Implement
{
    public class BlogDao : IBlogDao
    {
        private BlogContext _blogContext;
        public BlogDao(BlogContext blogContext) { _blogContext = blogContext; }
        public bool CreatBlog(ABlog blog)
        {
            _blogContext.Blogs.Add(blog);
            return _blogContext.SaveChanges() > 0;
        }

        public bool DeletBlogById(string id)
        {
            var blog = _blogContext.Blogs.SingleOrDefault(s => s.BId == id);
            _blogContext.Blogs.Remove(blog);
            return _blogContext.SaveChanges() > 0;
        }

        public ABlog GetBlogById(string id)
        {
            return _blogContext.Blogs.SingleOrDefault(s => s.BId == id);
        }

        public IEnumerable<ABlog> GetBlogs()
        {
            return _blogContext.Blogs.ToList();
        }

        public bool UpdateBlog(ABlog blog)
        {
            _blogContext.Blogs.Update(blog);
            return _blogContext.SaveChanges() > 0;
        }
    }
}
