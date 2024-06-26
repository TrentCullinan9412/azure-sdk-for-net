// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningComputeResource : IJsonModel<MachineLearningComputeData>
    {
        void IJsonModel<MachineLearningComputeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningComputeData>)Data).Write(writer, options);

        MachineLearningComputeData IJsonModel<MachineLearningComputeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningComputeData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningComputeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MachineLearningComputeData IPersistableModel<MachineLearningComputeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningComputeData>(data, options);

        string IPersistableModel<MachineLearningComputeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningComputeData>)Data).GetFormatFromOptions(options);
    }
}
