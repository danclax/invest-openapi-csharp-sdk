using System.Text.Json.Serialization;

namespace Tinkoff.Trading.OpenApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrokerAccountType
    {
        Tinkoff = 1,
        TinkoffIis = 2
    }
}