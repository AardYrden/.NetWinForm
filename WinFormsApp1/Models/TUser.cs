﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models
{
    public partial class TUser
    {
        public TUser()
        {
            TBorrow = new HashSet<TBorrow>();
            TObj = new HashSet<TObj>();
        }

        public int Uid { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Uno { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Upwd { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Uname { get; set; }
        /// <summary>
        /// 性别(0女，1男)
        /// </summary>
        public int? Usxey { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Ubdate { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Utele { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public byte[] Uimg { get; set; }
        /// <summary>
        /// 0用户，1管理员
        /// </summary>
        public int? Isadmin { get; set; }
        /// <summary>
        /// 0信用差，1已被警告，2信用好
        /// </summary>
        public int? Good { get; set; }

        public virtual ICollection<TBorrow> TBorrow { get; set; }
        public virtual ICollection<TObj> TObj { get; set; }
    }
}