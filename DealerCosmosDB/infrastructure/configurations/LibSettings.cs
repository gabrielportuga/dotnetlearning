using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelearCosmosbd.infrastructure.configurations
{
    public class LibSettings
    {
        public string EndPointUrlCosmosDb { get; set; } = "";
        public string PrimarykeyCosmosDb { get; set; } = "";
        public string DatabaseId { get; set; } = "";
        public string ContainerId { get; set; } = "";
    }
}