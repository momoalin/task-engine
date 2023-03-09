class RandomEngine : FakestEngine, IMyEngineActions
{
    public bool Execute()
    {
        FakeEngineBeingBusy(0, 5);
        return true;
    }
}
