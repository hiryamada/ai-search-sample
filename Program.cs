using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Models;

// エンドポイント、キー、インデックス名を環境変数から読み取り
string endpoint = Environment.GetEnvironmentVariable("SEARCH_ENDPOINT") ?? "";
string key = Environment.GetEnvironmentVariable("SEARCH_KEY") ?? "";
string index = Environment.GetEnvironmentVariable("SEARCH_INDEX") ?? "";

// 検索クライアントを作成
var client = new SearchClient(new Uri(endpoint), index, new AzureKeyCredential(key));

// 検索を実行
var response = client.Search<SearchDocument>("山本", new SearchOptions()
{
    Filter = "Location eq '東京'",
});

// 検索結果を表示
await foreach (var result in response.Value.GetResultsAsync())
{
    Console.WriteLine($"Name: {result.Document["Name"]}");
}