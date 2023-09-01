using MyBlog.Models;

namespace MyBlog.DataAccess.Interface
{
    public interface IBlogDao
    {
        bool CreatBlog(ABlog blog);
        IEnumerable<ABlog> GetBlogs();

        ABlog GetBlogById(string bId);

        bool UpdateBlog(ABlog blog);

        bool DeletBlogById(string bId);
    }
}
