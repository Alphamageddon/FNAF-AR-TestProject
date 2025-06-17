using PlayFab.Json;

public class ScriptExecutionError
{
	public string error;

	public string message;

	public string stackTrace;

	public JsonObject ToJson()
	{
		return new JsonObject
		{
			["Error"] = error,
			["Message"] = message,
			["StackTrace"] = stackTrace
		};
	}
}
