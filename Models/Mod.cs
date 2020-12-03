using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public partial class Mod
{
    [JsonProperty("adds_tags")]
    public List<string> AddsTags { get; set; }

    [JsonProperty("domain")]
    public string Domain { get; set; }

    [JsonProperty("generation_type")]
    public string GenerationType { get; set; }

    [JsonProperty("generation_weights")]
    public List<NWeight> GenerationWeights { get; set; }

    [JsonProperty("grants_buff")]
    public GrantsBuff GrantsBuff { get; set; }

    [JsonProperty("grants_effects")]
    public List<GrantsEffect> GrantsEffects { get; set; }

    [JsonProperty("group")]
    public string Group { get; set; }

    [JsonProperty("is_essence_only")]
    public bool IsEssenceOnly { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("required_level")]
    public int RequiredLevel { get; set; }

    [JsonProperty("spawn_weights")]
    public List<NWeight> SpawnWeights { get; set; }

    [JsonProperty("stats")]
    public List<Stat> Stats { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

public partial class NWeight
{
    [JsonProperty("tag")]
    public string Tag { get; set; }

    [JsonProperty("weight")]
    public int Weight { get; set; }
}

public partial class GrantsBuff
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
    public long? Range { get; set; }
}

public partial class GrantsEffect
{
    [JsonProperty("granted_effect_id")]
    public string GrantedEffectId { get; set; }

    [JsonProperty("level")]
    public long Level { get; set; }
}

public partial class Stat
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("max")]
    public int Max { get; set; }

    [JsonProperty("min")]
    public int Min { get; set; }
}