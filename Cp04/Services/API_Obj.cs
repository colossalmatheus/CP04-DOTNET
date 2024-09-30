namespace Cp04.Services;

public class API_Obj
{
    public string result { get; set; }
    public ConversionRate conversion_rates { get; set; }
}

public class ConversionRate
{
    public double BRL { get; set; }
    public double USD { get; set; }
    // Adicione outras moedas conforme necessário
}