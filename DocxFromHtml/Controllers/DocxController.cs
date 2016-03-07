using DocxFromHtml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocxFromHtml.Controllers
{
    public class DocxController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Create(string html)
        {
            return File(WordHelper.HtmlToWord(html), "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
    }
}