public class ModelProcessorBase : IModelProcessor
{
    protected void CheckBypassCondition()
    {
        Console.WriteLine("Performing bypass condition check");
    }

    public virtual void Process(Model model)
    {
        Console.WriteLine("Performing actual processing");
    }

    protected void CheckPrecondition()
    {
        Console.WriteLine("Performing pre-condition check");
    }
}