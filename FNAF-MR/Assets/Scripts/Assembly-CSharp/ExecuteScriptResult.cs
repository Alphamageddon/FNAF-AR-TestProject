using PlayFab.Json;

public class ExecuteScriptResult
{
	public ScriptExecutionError error;

	public JsonObject functionResult;

	public bool HasError()
	{
		return !string.IsNullOrEmpty(error.error);
	}
}
