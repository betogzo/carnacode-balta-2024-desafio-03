using Blazored.LocalStorage;
using Imc.Models;
using Newtonsoft.Json;

namespace Imc.Services;

public class LocalStorageService(ILocalStorageService localStorageService)
{
    private readonly ILocalStorageService _localStorageService = localStorageService;

    public async Task SaveToLocalStorageAsJson(ImcResult data)
    {
        int currentLength = await GetLocalStorageLength();
        await _localStorageService.SetItemAsync($"item-{currentLength + 1}", JsonConvert.SerializeObject(data));
    }

    public async Task<List<ImcResult>> GetAllResultsFromLocalStorage()
    {
        List<ImcResult> results = [];
        int currentLength = await GetLocalStorageLength();
        if (currentLength is 0) return results;
        for (var i = 1; i <= currentLength; i++)
        {
            var itemAsString = await _localStorageService.GetItemAsync<string>($"item-{i}");
            if (String.IsNullOrWhiteSpace(itemAsString)) continue;
            results.Add(JsonConvert.DeserializeObject<ImcResult>(itemAsString));
        }
        
        return results;
    }

    public async Task<int> GetLocalStorageLength()
    {
        return await _localStorageService.LengthAsync();
    }
}

