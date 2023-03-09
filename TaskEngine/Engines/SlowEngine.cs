class SlowEngine : FakestEngine, IMyEngineActions
{
    public bool Execute()
    {
        FakeEngineBeingBusy(2, 5);
        return true;
    }
}
