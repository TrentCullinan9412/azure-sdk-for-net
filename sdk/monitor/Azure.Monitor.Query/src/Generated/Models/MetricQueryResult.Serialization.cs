// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricQueryResult
    {
        internal static MetricQueryResult DeserializeMetricQueryResult(JsonElement element)
        {
            Optional<int> cost = default;
            string timespan = default;
            Optional<TimeSpan> interval = default;
            Optional<string> @namespace = default;
            Optional<string> resourceregion = default;
            IReadOnlyList<Metric> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timespan"))
                {
                    timespan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("namespace"))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"))
                {
                    resourceregion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<Metric> array = new List<Metric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Metric.DeserializeMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricQueryResult(Optional.ToNullable(cost), timespan, Optional.ToNullable(interval), @namespace.Value, resourceregion.Value, value);
        }
    }
}
