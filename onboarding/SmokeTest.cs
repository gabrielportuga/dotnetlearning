using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Onboarding;
public class SmokeTest
{
    public async Task<String> GetAuthToken()
    {
        HttpClient client = new HttpClient();

        Body body = new Body("bmwglobalwebapp@bmw.de", "BMWSADev", 1);

        using StringContent jsonContent = new(
            JsonSerializer.Serialize(body),
            System.Text.Encoding.UTF8,
            "application/json");

        client.DefaultRequestHeaders.Accept.Clear();
        // client.DefaultRequestHeaders.Accept.Add(
        // new MediaTypeWithQualityHeaderValue("application/json"));
        // client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
        // client.DefaultRequestHeaders.Add("cache-control", "no-cache");

        using HttpResponseMessage response =
            await client.PostAsJsonAsync("https://sol-portal-r6.dmsdigital.net/api/BMWZA/ServiceOnline/RequestToken", body);

        var code = response.EnsureSuccessStatusCode().StatusCode;
        var jsonResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();
        return jsonResponse!.Token;
    }

    public async Task<Result> CheckPassword(String partnerKey, String token)
    {
        HttpClient client = new HttpClient();

        string? encodedHash = CreateHMAC(token, partnerKey);

        var hash = $"bmwglobalwebapp@bmw.de:{encodedHash!}:bmwglobal2019";
        byte[] hashBytes = Encoding.ASCII.GetBytes(hash);

        encodedHash = Convert.ToBase64String(hashBytes);

        CheckPasswordBody body = new CheckPasswordBody("28153");

        using StringContent jsonContent = new(
            JsonSerializer.Serialize(body),
            System.Text.Encoding.UTF8,
            "application/json");

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"DataHub-Hash {encodedHash}");

        using HttpResponseMessage response =
            await client.PostAsJsonAsync("https://sol-portal-r6.dmsdigital.net/api/BMWZA/ServiceOnline/CheckPassword", body);

        var code = response.EnsureSuccessStatusCode().StatusCode;
        var jsonResponse = await response.Content.ReadFromJsonAsync<Result>();
        return jsonResponse!;
    }

    public async Task<VolVehicleDetails> ChassisPrePopulation(String token)
    {
        HttpClient client = new HttpClient();
        ChassisPrePopulationBody body = new ChassisPrePopulationBody("bmwglobalwebapp@bmw.de", "21730", "WBA12AL0407H97554");

        using StringContent jsonContent = new(
            JsonSerializer.Serialize(body),
            System.Text.Encoding.UTF8,
            "application/json");

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"DataHub-Token {token}");

        using HttpResponseMessage response =
            await client.PostAsJsonAsync("https://sol-portal-r6.dmsdigital.net/api/BMWZA/ServiceOnline/ChassisPrePopulation", body);

        var code = response.EnsureSuccessStatusCode().StatusCode;
        var jsonResponse = await response.Content.ReadFromJsonAsync<ChassiPrePopulationResponse>();
        return jsonResponse!.VehicleSpecDetails.VolVehicleDetails[0];
    }

    public async Task<GetServicesResponse> GetServices(String token, VolVehicleDetails vehicleDetails)
    {
        HttpClient client = new HttpClient();
        GetServicesBody body = new GetServicesBody("21730", "B", "2A15");

        using StringContent jsonContent = new(
            JsonSerializer.Serialize(body),
            System.Text.Encoding.UTF8,
            "application/json");

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"DataHub-Token {token}");

        using HttpResponseMessage response =
            await client.PostAsJsonAsync("https://sol-portal-r6.dmsdigital.net/api/BMWZA/ServiceOnline/GetRecommendedService", body);

        var code = response.EnsureSuccessStatusCode().StatusCode;
        var jsonResponse = await response.Content.ReadFromJsonAsync<GetServicesResponse>();
        return jsonResponse!;
    }

    private static string CreateHMAC(string token, string secret)
    {
        HMACSHA384 hmac = new HMACSHA384();

        byte[] tokenBytes = Encoding.ASCII.GetBytes(token);

        byte[] secretBytes = Encoding.ASCII.GetBytes(secret);

        var hmacData = System.Security.Cryptography.HMACSHA384.HashData(secretBytes, tokenBytes);

        var strHashBase64 = Convert.ToHexString(hmacData);

        return strHashBase64;
    }
}
