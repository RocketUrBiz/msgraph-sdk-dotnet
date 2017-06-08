﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    public class DurationConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(Duration))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Deserialize the edm.duration into an Microsoft.Graph.Duration object.
        /// </summary>
        /// <returns>A Microsoft.Graph.Duration object.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                if (reader.TokenType == JsonToken.Null)
                {
                    return null;
                }

                var value = (Microsoft.Graph.Duration)serializer.Deserialize(reader, typeof(Microsoft.Graph.Duration));

                return value;
            }
            catch (JsonSerializationException serializationException)
            {
                throw new ServiceException(
                    new Error
                    {
                        Code = ErrorConstants.Codes.GeneralException,
                        Message = "Unable to deserialize duration"
                    },
                    serializationException);
            }
        }

        /// <summary>
        /// Serializes the edm.duration representation of the Microsoft.Graph.Duration object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var duration = value as Duration;

            if (duration != null)
            {
                writer.WriteValue(duration.ToString());
            }
            else
            {
                // Test the service whether it will accept an empty string. No need to throw an exception then.
                throw new ServiceException(
                    new Error
                    {
                        Code = ErrorConstants.Codes.GeneralException,
                        Message = "Invalid type for Duration converter"
                    });
            }
        }
    }
}
