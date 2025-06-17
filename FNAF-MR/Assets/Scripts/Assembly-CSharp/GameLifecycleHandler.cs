public class GameLifecycleHandler
{
	public StartupHandler StartupHandler;

	public ShutdownHandler ShutdownHandler;

	public GameLifecycleHandler(StartupParameters startupParams, ShutdownParameters shutdownData)
	{
		StartupHandler = new StartupHandler();
		StartupHandler.Setup(startupParams);
		ShutdownHandler = new ShutdownHandler();
		ShutdownHandler.Setup(shutdownData);
	}

	public void Teardown()
	{
		if (ShutdownHandler != null)
		{
			ShutdownHandler.Teardown();
		}
		ShutdownHandler = null;
		if (StartupHandler != null)
		{
			StartupHandler.Teardown();
		}
		StartupHandler = null;
	}
}
