Console.WriteLine("Starting engine");

var instance = MyEngineManager.GetInstance();

instance.AddActions(new JabEngine());
instance.AddActions(new JabEngine());
instance.AddActions(new JabEngine());
instance.Run();

instance.AddActions(new JabEngine());
instance.AddActions(new PacyEngine());
instance.AddActions(new JabEngine());
instance.Run();

instance.AddActions(new JabEngine());
instance.AddActions(new PacyEngine());
instance.Run();

instance.AddActions(new JabEngine());
instance.Run();

instance.AddActions(new SlowEngine());
instance.Run();

instance.AddActions(new JabEngine());
instance.AddActions(new RandomEngine());
instance.AddActions(new JabEngine());
instance.Run();


Console.WriteLine("Shutting down engine");