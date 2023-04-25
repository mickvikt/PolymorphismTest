public class ModelProcessorWithBypass : ModelProcessorBase, IModelProcessor
{
    public override void Process(Model model)
    {
        CheckPrecondition();
        CheckBypassCondition();
        base.Process(model);
    }
}