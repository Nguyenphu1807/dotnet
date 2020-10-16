using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practice_dotnet.Models
{
    public class product
    {
        public string Id { get; set; }

        public string name { get; set; }

        public string price { get; set; }


        public string Url { get; set; }

        public int[] Ratings { get; set; }

        public override String ToString() => JsonSerializer.Serialize<product>(this);

    }
}
