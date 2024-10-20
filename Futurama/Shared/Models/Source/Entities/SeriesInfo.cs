﻿// <auto-generated />

#nullable enable

using ProblemDetailsApiDemo.Futurama.Shared.Models.Source.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProblemDetailsApiDemo.Futurama.Shared.Models.Source.Entities;

public class SeriesInfo
{
    [JsonPropertyName("synopsis")]
    public required string Synopsis { get; set; }

    [JsonPropertyName("yearsAired")]
    public required string YearsAired { get; set; }

    [JsonPropertyName("creators")]
    public required List<Creator> Creators { get; set; }

    [JsonPropertyName("id")]
    public required long Id { get; set; }

    public static List<SeriesInfo>? FromJson(string json) =>
        JsonSerializer.Deserialize<List<SeriesInfo>>(json, Converter.Settings);
}

public class Creator
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("url")]
    public required Uri Url { get; set; }
}

public static class SeriesInfoExtensions
{
    public static string ToJson(this List<SeriesInfo> self) =>
        JsonSerializer.Serialize(self, Converter.Settings);
}
