// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class WebLinkedServiceTypeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url");
            writer.WriteObjectValue(Url);
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static WebLinkedServiceTypeProperties DeserializeWebLinkedServiceTypeProperties(JsonElement element)
        {
            if (element.TryGetProperty("authenticationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Anonymous": return WebAnonymousAuthentication.DeserializeWebAnonymousAuthentication(element);
                    case "Basic": return WebBasicAuthentication.DeserializeWebBasicAuthentication(element);
                    case "ClientCertificate": return WebClientCertificateAuthentication.DeserializeWebClientCertificateAuthentication(element);
                }
            }
            object url = default;
            WebAuthenticationType authenticationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("authenticationType"))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
            }
            return new WebLinkedServiceTypeProperties(url, authenticationType);
        }
    }
}
