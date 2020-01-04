using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

//http://tech-journals.com/jonow/2012/01/25/implementing-xml-rpc-services-with-asp-net-mvc
//http://www.aaron-powell.com/posts/2010-06-16-aspnet-mvc-xml-action-result.html
//http://www.aaron-powell.com/posts/2010-06-16-aspnet-mvc-xml-action-result.html
//https://github.com/myquay/Chq.XmlRpc.Mvc

namespace cloudscribe.MetaWeblog
{
    public class XmlResult : ActionResult
    {
        public XDocument Xml { get; private set; }
        public string ContentType { get; set; }
        //public Encoding Encoding { get; set; }

        public XmlResult(XDocument xml)
        {
            this.Xml = xml;
            this.ContentType = "text/xml";
        }

        //#if !DNXCORE50
        public override void ExecuteResult(ActionContext context)
        {
            //context.HttpContext.Response.ContentType = this.ContentType;
            //XmlTextWriter writer = new XmlTextWriter(context.HttpContext.Response.Body, Encoding.UTF8);
            //Xml.WriteTo(writer);
            //writer.Close();

            context.HttpContext.Response.ContentType = this.ContentType;
            if (Xml != null)
            {
                
                Xml.Save(context.HttpContext.Response.Body, SaveOptions.DisableFormatting);

            }
        }
        //#endif

        public override async Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.ContentType = this.ContentType;

            if (Xml != null)
            {
               var xmlWriter = XmlWriter.Create(context.HttpContext.Response.Body, settings: new XmlWriterSettings { Async = true });

                await Xml.WriteToAsync(xmlWriter, default);
                //Synchronous operations are disallowed. Call WriteAsync or set AllowSynchronousIO to true instead
                //await  Xml.SaveAsync(context.HttpContext.Response.Body, SaveOptions.DisableFormatting, default);
                await xmlWriter.FlushAsync();

            }
          
        }
    }
}
