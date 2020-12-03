
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public partial class ModType
{
    [JsonProperty("sell_price_types")]
    public List<string> SellPriceTypes { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }
}


