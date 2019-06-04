using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DocAsCode.MarkdownLite;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarkdownService
{
    [Route("/")]
    public class MdlController : Controller
    {
        private readonly IMarkdownEngine engine;

        public MdlController(IMarkdownEngine engine)
        {
            this.engine = engine;
        }

        [HttpPost]
        public IActionResult Convert()
        {
            var reader = new StreamReader(Request.Body);
            var markdown = reader.ReadToEnd();
            var result = engine.Markup(markdown);
            return Content(result);
        }
    }
}
