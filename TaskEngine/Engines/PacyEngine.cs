class PacyEngine : FakestEngine, IMyEngineActions
{
    public bool Execute()
    {
        FakeEngineBeingBusy(0, 2);
        return true;
    }
}
