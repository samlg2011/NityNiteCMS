using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace ViewModel
{
    public class ContentViewModel
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string PageSubTitle { get; set; }
        public ContentStatus PageLevel { get; set; }
        public string PageContent1Title { get; set; }
        public string PageContent1 { get; set; }
        public string PageContent2Title { get; set; }
        public string PageContent2 { get; set; }
        public string PageContent3Title { get; set; }
        public string PageContent3 { get; set; }
    }
}
