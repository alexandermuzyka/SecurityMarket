﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.WebUI.Models;
using System.Web.Mvc;
using System.Text;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {

        public static MvcHtmlString PageLinks(
      this HtmlHelper html,
      PagingInfo pagingInfo,
      Func<int, string> pageUrl)
    {
      StringBuilder result = new StringBuilder();

      for (int i = 1; i <= pagingInfo.TotalPages; i++)
      {
        TagBuilder tag = new TagBuilder("a"); // Construct an <a> tag
        tag.MergeAttribute("href", pageUrl(i));
        tag.InnerHtml = i.ToString();
        if (i == pagingInfo.CurrentPage)
          tag.AddCssClass("selected");
        result.Append(tag.ToString());
      }

      return MvcHtmlString.Create(result.ToString());
    }

    }
}