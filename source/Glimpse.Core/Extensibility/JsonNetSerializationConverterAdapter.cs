﻿using System;
using System.Linq;
using Newtonsoft.Json;

namespace Glimpse.Core.Extensibility
{
    public class JsonNetSerializationConverterAdapter : JsonConverter
    {
        public JsonNetSerializationConverterAdapter(ISerializationConverter converter)
            {
                Converter = converter;
            }

        private ISerializationConverter Converter { get; set; }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                var dict = Converter.Convert(value);

                serializer.Serialize(writer, dict);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                throw new NotSupportedException();
            }

            public override bool CanConvert(Type objectType)
            {
                return Converter.SupportedTypes.Any(type => type.IsAssignableFrom(objectType));
            }
    }
}