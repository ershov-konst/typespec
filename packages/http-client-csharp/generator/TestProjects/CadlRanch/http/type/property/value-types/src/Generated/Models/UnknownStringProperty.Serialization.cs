// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Property.ValueTypes.Models
{
    public partial class UnknownStringProperty : IJsonModel<UnknownStringProperty>
    {
        void IJsonModel<UnknownStringProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        UnknownStringProperty IJsonModel<UnknownStringProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual UnknownStringProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<UnknownStringProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        UnknownStringProperty IPersistableModel<UnknownStringProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual UnknownStringProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<UnknownStringProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(UnknownStringProperty unknownStringProperty) => throw null;

        public static explicit operator UnknownStringProperty(ClientResult result) => throw null;
    }
}