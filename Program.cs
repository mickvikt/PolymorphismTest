using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();
var serviceProvider = sc
  .AddTransient<IModelProcessor, ModelProcessor>()
  .AddTransient<IModelProcessor, ModelProcessorWithBypass>()
  .AddTransient<ModelProcessorResolver, ModelProcessorResolver>()
  .BuildServiceProvider();

var processorResolver = serviceProvider.GetRequiredService<ModelProcessorResolver>();
var processor = processorResolver.GetModelProcessor();
processor.Process(new Model(System.DateTime.UtcNow));
