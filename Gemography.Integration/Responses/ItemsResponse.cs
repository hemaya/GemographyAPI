using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemography.Integration.Responses
{
  public class ItemsResponse
        {
            public long id { get; set; }
            public string node_id { get; set; }
            public string name { get; set; }
            public string full_name { get; set; }
            public string html_url { get; set; }
            public string url { get; set; }
            public string language { get; set; }


        }
}
