public class ModelProcessorResolver
{
    private readonly IEnumerable<IModelProcessor> processors;

    public ModelProcessorResolver(IEnumerable<IModelProcessor> processors)
    {
        this.processors = processors;
    }

    public IModelProcessor GetModelProcessor()
    {
        return processors.Where(p => p.GetType() == typeof(ModelProcessor)).Single();
    }
}