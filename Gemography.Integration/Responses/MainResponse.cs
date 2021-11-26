using System.Collections.Generic;

namespace Gemography.Integration.Responses
{

    public class MainResponse
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }

        public List<ItemsResponse> items { get; set; }

    }

}
