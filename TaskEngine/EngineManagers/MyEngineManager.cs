using GuardNet;

class MyEngineManager
{
    private List<IMyEngineActions> _actions = new List<IMyEngineActions>();
    private static MyEngineManager? _instance;
    private MyEngineManager()
    {

    }
    public static MyEngineManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new MyEngineManager();
        }
        return _instance;
    }
    public void AddActions(IMyEngineActions action)
    {
        Guard.NotNull(action, "action");
        _actions.Add(action);
    }
    public bool Run()
    {
        Guard.NotNull(_actions, "action");
        RunRecursivelySequencially(_actions);
        return true;
    }
    private bool RunRecursivelySequencially(List<IMyEngineActions> actions)
    {

        if (!actions.Any())
            return true;
        
        var item = actions.LastOrDefault() ?? throw new NullReferenceException();
        item.Execute();
        actions.RemoveAt(actions.Count - 1);
        return RunRecursivelySequencially(actions);
    }
}
