using System.Text.Json.Serialization;

public record class TokenResponse(
    [property: JsonPropertyName("Token")] string Token,
    [property: JsonPropertyName("Result")] Result Result)
{
   
}

public record class Result(
    [property: JsonPropertyName("ErrorCode")] int ErrorCode)
{
   
}

public record class ChassiPrePopulationResponse(
    [property: JsonPropertyName("VehicleSpecDetails")] VehicleSpecDetails VehicleSpecDetails,
    [property: JsonPropertyName("Result")] Result Result)
{
   
}

public record class VehicleSpecDetails (
    [property: JsonPropertyName("VolVehicleDetails")] VolVehicleDetails[] VolVehicleDetails)
{
   
}

public record class VolVehicleDetails (
    [property: JsonPropertyName("RooftopId")] string RooftopId,
    [property: JsonPropertyName("RegNumber")] string RegNumber,
    [property: JsonPropertyName("VIN")] string VIN,
    [property: JsonPropertyName("MakeCode")] string MakeCode,
    [property: JsonPropertyName("VariantCode")] string VariantCode,
    [property: JsonPropertyName("ModelCode")] string ModelCode) {

}


public record class GetServicesResponse (
    [property: JsonPropertyName("Results")] PriceListData PriceListData,
    [property: JsonPropertyName("Result")] Result Result)
{
   
}

public record class PriceListData (
    [property: JsonPropertyName("PriceListData")] CDKService[] CDKService)
{
   
}

public record class CDKService (
    [property: JsonPropertyName("JobCode")] string JobCode,
    [property: JsonPropertyName("JobDescription")] string JobDescription)
{
   
}
