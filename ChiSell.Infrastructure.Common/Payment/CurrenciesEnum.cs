using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChiSell.Infrastructure.Common.Payment
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrenciesEnum
    {
        USD,
        EUR
    }
}
