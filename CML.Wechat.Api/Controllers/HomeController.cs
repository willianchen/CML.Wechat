using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CML.Lib.Domains;
using CML.Lib.Result;
using CML.Wechat.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CML.Wechat.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        public object Index()
        {
            List<NewsListDto> listNews = new List<NewsListDto>();

            for (int i = 0; i < 10; i++)
                listNews.Add(new NewsListDto() { FID = i, FTitle = "test1" + i.ToString(), FImg = "https://pic4.zhimg.com/v2-24b83b0b4f1b7d2c90a2a28b6bbf116b.jpg"  });
            PagerList<NewsListDto> pagelist = new PagerList<NewsListDto>(1, 10, 100, listNews);
            return new AjaxResponse(pagelist);
        }
    }
}