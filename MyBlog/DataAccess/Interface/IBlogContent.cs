using MyBlog.Models;

namespace MyBlog.DataAccess.Interface
{
    public interface IBlogContent
    {
        bool CreatBlog(ABContent content);

        IEnumerable<ABContent> GetBlogs();

        ABContent GetBlogById(string bId);

        bool UpdateBlog(ABContent blog);

        bool DeletBlogById(string bId);
    }
}
