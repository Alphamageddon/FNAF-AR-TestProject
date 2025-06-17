using System.Collections.Generic;

public class IllumixErrorData
{
	public string apiEndpoint;

	public int httpCode;

	public string httpStatus;

	public string errorCode;

	public string errorMessage;

	public Dictionary<string, List<string>> ErrorDetails;
}
