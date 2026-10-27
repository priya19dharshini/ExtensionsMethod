
using ExtensionsMethod;

LearnAsyncProgramming lsp = new LearnAsyncProgramming();
//await lsp.BasicAsync();
//await lsp.TaskTrackingAsync();
await lsp.SequentialAsync();
await lsp.ConcurrentAsync();
await lsp.CancellationAsync();
await lsp.ExceptionHandlingAsync();
await lsp.WhenAllAsync();
await lsp.WhenAnyAsync();