using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlParser
{
    internal class HtmlHelper
    {
        private IBrowsingContext _browsingContext;
        private IConfiguration _config;
        private IDocument _document;

        public HtmlHelper(string html, IConfiguration configuration = null)
        {
            _config = configuration ?? Configuration.Default;
            _browsingContext = BrowsingContext.New(_config);

            _document = _browsingContext.OpenAsync(x => x.Content(html)).Result;
        }

        internal void ReplaceContnent(string id, string value)
        {
            _document.QuerySelector("#" + id).TextContent = value;
        }

        internal string GetHtml()
        {
            return _document.ToHtml();
        }
    }
}
