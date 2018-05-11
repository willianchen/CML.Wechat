using System;

namespace CML.Wechat.Domain
{
    public class NewsInfo
    {
        public int FID { get; set; }
        public string FTitle { get; set; }
        public string FImg { get; set; }
        public string FContent { get; set; }

        public int FSourceType { get; set; }

        public DateTime FCreateTime { get; set; }

        public string FSourceUrl { get; set; }

        public bool FIsDelete { get; set; }
    }
}
