using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelearCosmosbd.domain.models
{
    public class DealerMapping
    {
        public DealerMapping()
        {
            cbs_mapping = new Dictionary<string, string>();
        }

        public string mapping_id { get; set; } = "";
        public string dealer_search_id { get; set; } = "";
        public string vendor_key { get; set; } = "";
        public string time_zone { get; set; } = "";
        public Dictionary<string, string> custom_fields { get; set; } = new();

        public string dealer_name { get; set; } = "";
        public string country { get; set; } = "";
        public string id { get; set; } = "";
        public string _rid { get; set; } = "";
        public string _self { get; set; } = "";
        public string _etag { get; set; } = "";
        public string _attachments { get; set; } = "";
        public string _ts { get; set; } = "";

        public Dictionary<string, string> cbs_mapping { get; set; }
        
        public Dictionary<string, string[]> cbs_codes { get; set; }


        public override int GetHashCode()
        {
            return this.mapping_id.GetHashCode();
        }
    }
}