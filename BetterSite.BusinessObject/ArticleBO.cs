﻿using BetterSite.DataAccess;
using BetterSite.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetterSite.BusinessObject
{
    public class ArticleBO
    {
        #region 单例
        private ArticleDA da = null;
        private void InitDA()
        { da = new ArticleDA(); }
        public ArticleBO()
        {
            //保证只有一个实例
            if (da == null)
            {
                lock (typeof(ArticleDA))
                {
                    if (da == null)
                    {
                        InitDA();
                    }
                }
            }
        }
        #endregion
        ///插入
      public object Insert(M_Article model)
      {
          return da.Insert(model);
      }
      ///更新
      public int Update(M_Article model)
      {
          return da.Update(model);
      }
      ///删除
      public int Delete(int id)
      {
          return da.Delete(id);
      }
      ///查询对象
      public M_Article Get(int id)
      {
          return da.Get(id);
      }
      ///查询列表
      public IList<M_Article> QueryForEntityList(M_Article where)
      {
          return da.QueryForEntityList(where);
      }
      public IList QueryForList(M_Article where)
      {
          return da.QueryForList(where);
      }
      public IList QueryForPageList(M_Article where)
      {
          return da.QueryForPageList(where);
        }  ///更新点击数
        public int UpdateArticleClickQuantity(int id)
        {
            Hashtable param = new Hashtable();
            param.Add("Id", id);
            return da.UpdateArticleClickQuantity(param);
        }
        public object AddArticleComment(M_ArticleComment model)
        {
            return da.AddArticleComment(model);
        }
        public IList QueryArticleCommentForList(M_ArticleComment where)
        {
            return da.QueryArticleCommentForList(where);
        }
    }
}
