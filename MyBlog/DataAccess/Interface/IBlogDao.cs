using MyBlog.Models;

namespace MyBlog.DataAccess.Interface
{
    public interface IBlogDao
    {
        /// <summary>
        /// 创建一个blog
        /// </summary>
        /// <param name="blog">ablog对象</param>
        /// <returns>是否创建成功</returns>
        bool CreatBlog(ABlog blog);
        /// <summary>
        /// 得到blog的集合
        /// </summary>
        /// <returns>blog集合</returns>
        IEnumerable<ABlog> GetBlogs();
        /// <summary>
        /// 使用id获取blog
        /// </summary>
        /// <param name="bId"></param>
        /// <returns>ablog对象</returns>
        ABlog GetBlogById(string bId);
        /// <summary>
        /// 更新ablog对象
        /// </summary>
        /// <param name="blog">目标blog</param>
        /// <returns>是否更新成功</returns>
        bool UpdateBlog(ABlog blog);
        /// <summary>
        /// 用id删除ablog对象
        /// </summary>
        /// <param name="bId">目标id</param>
        /// <returns>是否删除成功</returns>
        bool DeletBlogById(string bId);
    }
}
