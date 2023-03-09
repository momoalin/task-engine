class JabEngine : FakestEngine, IMyEngineActions
{

    protected void Bullet()
    {
        Console.WriteLine("jab jab");
    }
    public bool Execute()
    {
        Bullet();
        return true;
    }
}
