using System;
using System.IO;

namespace HtmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = LoadHtmlFile();
            var htmlHelper = new HtmlHelper(html);

            htmlHelper.ReplaceContnent("address", "3091 countryside dr");

            Console.WriteLine(htmlHelper.GetHtml());
            Console.ReadLine();
        }

        private static string LoadHtmlFile()
        {
            var file = new FileInfo("TestPage.html");

            using var reader = file.OpenText();

            return reader.ReadToEnd();
        }
    }
}
