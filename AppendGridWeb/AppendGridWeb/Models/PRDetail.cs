using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AppendGridWeb.Models
{
    public class PRDetail
    {
        public int ID { get; set; }
        public string SapPRNo { get; set; }
        public string Description { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal EstNetAmount { get; set; }
        public decimal EstCNYNetAmount { get; set; }
        public Boolean Cancelled { get; set; }

        public static List<PRDetail> List()
        {
            List<PRDetail> details = new List<Models.PRDetail>();

            PRDetail item1 = new PRDetail
            {
                ID = 1,
                SapPRNo = "ABC001",
                Description = "This is test PR",
                DeliveryDate = DateTime.Today,
                EstNetAmount = 100,
                EstCNYNetAmount = 100,
                Cancelled = false
            };
            details.Add(item1);

            PRDetail item2 = new Models.PRDetail
            {
                ID = 2,
                SapPRNo = "ACB002",
                Description = "i am superman....",
                DeliveryDate = DateTime.Today.AddDays(-1),
                EstNetAmount = 100.0m,
                EstCNYNetAmount = 101.0m,
                Cancelled = true
            };
            details.Add(item2);

            return details;
        }

        public static T Deserialize<T>(string json)
        {
            JsonSerializerSettings dateFormatSetting = new JsonSerializerSettings
            {
                DateFormatString = "yyyy/MM/dd"
            };

            T modal = JsonConvert.DeserializeObject<T>(json, dateFormatSetting);

            return modal;
        }
    }
}