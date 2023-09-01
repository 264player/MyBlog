using System;

namespace MyBlog.Tools
{
    public class MyUniqueId
    {
        /// <summary>
        /// 获得32位有分隔符的唯一标识符
        /// </summary>
        /// <returns>Guid</returns>
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 根据guid生成16位唯一标识符
        /// </summary>
        /// <returns>16位唯一标识符</returns>
        public static string GuidTo16String()
        {
            long i = 1;
            foreach(byte b in Guid.NewGuid().ToByteArray()) 
            {
                i *= ((long)b + 1);
            }
            return string.Format("{0:x}",i - DateTime.Now.Ticks);
        }
    }
}
