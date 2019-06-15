using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebApi.Models
{
    public class ArticleResultModel
    {
        public string Type { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
    }
}
