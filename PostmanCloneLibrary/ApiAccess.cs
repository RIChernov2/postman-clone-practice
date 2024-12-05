namespace PostmanCloneLibrary;

using System.Text.Json;
using System.Threading.Tasks;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient _client = new();
    public async Task<string> CallApiAsync(
        string url,
        bool formatOutput = true,
        HttpAction action = HttpAction.GET)
    {
        var response = await _client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            //return json;
            //return $"""{json}""";

            if (!formatOutput) return json;

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            var prettyJson = JsonSerializer.Serialize(jsonElement,
                new JsonSerializerOptions { WriteIndented = true });

            return prettyJson;

        }
        else
        {
            return $"Error {response.StatusCode}";
        }
    }

    public bool CheckUrlValidation(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
