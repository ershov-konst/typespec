// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Property.AdditionalProperties.Models
{
    [PersistableModelProxy(typeof(UnknownExtendsUnknownAdditionalPropertiesDiscriminated))]
    public abstract partial class ExtendsUnknownAdditionalPropertiesDiscriminated : IJsonModel<ExtendsUnknownAdditionalPropertiesDiscriminated>
    {
        void IJsonModel<ExtendsUnknownAdditionalPropertiesDiscriminated>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        ExtendsUnknownAdditionalPropertiesDiscriminated IJsonModel<ExtendsUnknownAdditionalPropertiesDiscriminated>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual ExtendsUnknownAdditionalPropertiesDiscriminated JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<ExtendsUnknownAdditionalPropertiesDiscriminated>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        ExtendsUnknownAdditionalPropertiesDiscriminated IPersistableModel<ExtendsUnknownAdditionalPropertiesDiscriminated>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual ExtendsUnknownAdditionalPropertiesDiscriminated PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<ExtendsUnknownAdditionalPropertiesDiscriminated>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(ExtendsUnknownAdditionalPropertiesDiscriminated extendsUnknownAdditionalPropertiesDiscriminated) => throw null;

        public static explicit operator ExtendsUnknownAdditionalPropertiesDiscriminated(ClientResult result) => throw null;
    }
}