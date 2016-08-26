using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using AppendGridWeb.Models;
using Newtonsoft.Json;


namespace AppendGridWeb.Ashx
{
    /// <summary>
    /// DeletePRDetail 的摘要描述
    /// </summary>
    public class DeletePRDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string json = new StreamReader(context.Request.InputStream).ReadToEnd();

            PRDetail modal = PRDetail.Deserialize<PRDetail>(json);

            string msg = String.Format("{0}: Delete: {1}", modal.ID == 1 ? "No" : "OK", modal.Description);

            context.Response.ContentType = "text/plain";
            context.Response.Write(msg);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}