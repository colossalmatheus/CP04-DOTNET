using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace Cp04.Services;

public class ConversionRate : IConversionRate
{
    [SwaggerSchema("Câmbio do USD para BRL.")]
    public double BRL { get; set; }
}