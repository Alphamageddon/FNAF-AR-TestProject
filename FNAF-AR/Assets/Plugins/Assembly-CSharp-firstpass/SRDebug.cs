using SRDebugger.Services;
using SRDebugger.Services.Implementation;
using SRF.Service;

public static class SRDebug
{
	public const string Version = "1.7.1";

	public static IDebugService Instance => SRServiceManager.GetService<IDebugService>();

	public static void Init()
	{
		if (!SRServiceManager.HasService<IConsoleService>())
		{
			new StandardConsoleService();
		}
		SRServiceManager.GetService<IDebugService>();
	}
}
