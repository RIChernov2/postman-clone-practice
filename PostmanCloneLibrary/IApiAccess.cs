namespace PostmanCloneLibrary;

using System.Threading.Tasks;

public interface IApiAccess
{
    Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
    bool CheckUrlValidation(string url);
}