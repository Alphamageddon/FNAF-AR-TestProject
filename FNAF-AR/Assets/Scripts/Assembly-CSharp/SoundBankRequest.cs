using System;

public class SoundBankRequest
{
	public string SoundBankName;

	public Action<string> Success;

	public Action<string> Failure;
}
