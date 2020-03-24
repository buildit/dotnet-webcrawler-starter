using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
namespace Buildit.Webcrawler.Models
{
    public class Page
    {
        public string uri { get; set; }
        public ArrayList internalLinks { get; set; }
        public ArrayList externalLinks { get; set; }
        public ArrayList images { get; set; }

        public Page() {
            uri = "";
            internalLinks = new ArrayList();
            externalLinks = new ArrayList();
            images = new ArrayList();
        }
    }
}
