public class ModelProcessor : ModelProcessorBase, IModelProcessor
{
    public override void Process(Model model)
    {
        CheckPrecondition();
        base.Process(model);
    }
}