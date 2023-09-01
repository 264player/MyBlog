﻿using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace MyBlog.Models
{
    [Keyless]
    [Table("Blogs")]
    public class ABlog
    {
        public ABlog(string uId,string title,string abstracts,string bId)
        {
            this.UId = uId;
            this.Title = title;
            this.Abstracts = abstracts;
            this.BId = bId;
        }
        [Column("uid")]
        /// <summary>
        /// 博客作者
        /// </summary>
        public string UId { get; set; }
        [Column("title")]
        /// <summary>
        /// 博客标题
        /// </summary>
        public string Title { get; set; }
        [Column("abstracts")]
        /// <summary>
        /// 博客摘要
        /// </summary>
        public string Abstracts { get; set; }
        [Column("bid")]
        /// <summary>
        /// 博客正文Id
        /// </summary>
        public string BId { get; set; }
    }
}