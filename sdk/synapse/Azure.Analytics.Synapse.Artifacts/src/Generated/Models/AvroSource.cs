// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Avro source. </summary>
    public partial class AvroSource : CopySource
    {
        /// <summary> Initializes a new instance of AvroSource. </summary>
        public AvroSource()
        {
            Type = "AvroSource";
        }

        /// <summary> Initializes a new instance of AvroSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="storeSettings"> Avro store settings. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal AvroSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, StoreReadSettings storeSettings, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            StoreSettings = storeSettings;
            AdditionalColumns = additionalColumns;
            Type = type ?? "AvroSource";
        }

        /// <summary> Avro store settings. </summary>
        public StoreReadSettings StoreSettings { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
