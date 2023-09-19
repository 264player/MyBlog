using System.Data;
using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Interface;
using MyBlog.Models;
using MyBlog.Tools;

namespace MyBlog.Controllers
{
    [Route("Blog")]
    public class BlogController : Controller
    {
        private IBlogDao _blogDao;
        private IBlogContent _blogContent;
        public BlogController(IBlogDao blogDao,IBlogContent contnet)
        {
            _blogDao = blogDao;
            _blogContent = contnet;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index() { return  View(); }
        [HttpPost]
        [Route("Creat")]
        public IActionResult Creat(string title,string abs,string content,string uId, string bId)
        {
            //title = "post失败";
            //title = Request.Form["title"];
            uId = "1";
            bId = MyUniqueId.GuidTo16String();
            ABlog blog = new ABlog(uId,title,abs,bId);   
            ABContent aBContent = new ABContent(bId,content); 
            _blogDao.CreatBlog(blog);
            _blogContent.CreatBlog(aBContent);
            return RedirectToAction("SubmitOK");
        }
        [Route("List")]
        public IActionResult List()
        {
            IEnumerable<ABlog> blogs = _blogDao.GetBlogs();
            Blogs? list = null;
            if (blogs != null)
            {
                list = new Blogs()
                {
                    BlogList = new List<ABlog>(blogs),
                };
                return View(list);
            }
            else
            {
                return View("Index");
            }
            
        }
        [HttpGet]
        [Route("Get/{BId}")]
        public IActionResult Get(string bId)
        {
            var content = _blogContent.GetBlogById(bId);
            var bloginfo = _blogDao.GetBlogById(bId);
            ViewData["bloginfo"] = bloginfo;
            ViewData["content"] = content;
            return View();
        }
        [Route("Delet")]
        public ActionResult<string> Delet(string bId)
        {
            if (string.IsNullOrWhiteSpace(bId))
            {
                return "id 不能为空！";
            }

            var result = _blogDao.DeletBlogById(bId);

            if (result)
            {
                return "删除成功";
            }
            else
            {
                return "删除失败";
            }
        }

        [Route("CreatAll")]
        public IActionResult CreatAll(string title,string abs,string content) 
        {
            var b = new ABlog("1", title, abs, "1");
            return View("Creat",b);
        }

        [Route("SubmitOK")]
        public IActionResult SubmitOK() {return View("SubmitOK"); }
    }
}
