public class MyPostMethod : IHasPostMethodBuilder2<IAsyncPostMethod2, string>
{
    public IAsyncPostMethod2 Client { get; private set; }

    public MyPostMethod(IAsyncPostMethod2 client)
    {
        Client = client;
    }
}

public class AsyncPostMethod : IAsyncPostMethod2
{
    public async Task PostAsync<T>(T body, CancellationToken cancellationToken)
    {
        // Simulate asynchronous posting logic
        await Task.Delay(1000, cancellationToken);
        Console.WriteLine($"Posted: {body}");
    }
}

public static async Task Main(string[] args)
{
    var client = new AsyncPostMethod();
    var postMethod = new MyPostMethod(client);

    var cancellationTokenSource = new CancellationTokenSource();

    try
    {
        await postMethod.PostAsync("Hello, World!", cancellationTokenSource.Token);
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Operation was canceled.");
    }
}
