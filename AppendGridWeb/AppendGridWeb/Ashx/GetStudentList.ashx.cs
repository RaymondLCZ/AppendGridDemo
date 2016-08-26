using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using AppendGridWeb.Models;

namespace AppendGridWeb.Ashx
{
    /// <summary>
    /// GetStudentList 的摘要描述
    /// </summary>
    public class GetStudentList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            JsonSerializerSettings dateFormatSetting = new JsonSerializerSettings
            {
                DateFormatString = "yyyy/MM/dd"
            };

            context.Response.ContentType = "application/json";
            context.Response.Charset = "utf-8";
            context.Response.Write(JsonConvert.SerializeObject(Student.List(), dateFormatSetting));

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