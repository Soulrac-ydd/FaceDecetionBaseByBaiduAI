using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFaceDecetion
{
    public class JsonClientData
    {
        public string Refresh_token { get; set; }

        public long Expires_in { get; set; }

        public string Session_key { get; set; }

        public string Access_token { get; set; }

        public string Scope { get; set; }

        public string Session_secret { get; set; }
    }
}
