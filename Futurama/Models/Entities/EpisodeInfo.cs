﻿// <auto-generated />

#nullable enable

using ProblemDetailsApiDemo.Futurama.Models.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProblemDetailsApiDemo.Futurama.Models.Entities;

public class EpisodeInfo
{
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("writers")]
    public required string Writers { get; set; }

    [JsonPropertyName("originalAirDate")]
    public required string OriginalAirDate { get; set; }

    [JsonPropertyName("desc")]
    public required string Desc { get; set; }

    [JsonPropertyName("id")]
    public required long Id { get; set; }

    public static List<EpisodeInfo>? FromJson(string json) =>
        JsonSerializer.Deserialize<List<EpisodeInfo>>(json, Converter.Settings);
}

public static class EpisodeInfoExtensions
{
    public static string ToJson(this List<EpisodeInfo> self) =>
        JsonSerializer.Serialize(self, Converter.Settings);
}
