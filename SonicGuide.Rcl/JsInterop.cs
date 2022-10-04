namespace SonicGuide.Rcl;

public class JsInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public JsInterop(IJSRuntime jsRuntime) =>
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/SonicGuide.Rcl/js/sonicguide.js").AsTask());

    public async ValueTask<string> SpeakTextAsync(string text)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("speakText", text);
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}
