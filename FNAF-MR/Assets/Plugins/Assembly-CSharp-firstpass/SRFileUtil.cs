using System.IO;
using System.Threading;

public static class SRFileUtil
{
	public static void DeleteDirectory(string path)
	{
		try
		{
			Directory.Delete(path, recursive: true);
		}
		catch (IOException)
		{
			Thread.Sleep(0);
			Directory.Delete(path, recursive: true);
		}
	}

	public static string GetBytesReadable(long i)
	{
		string text = ((i < 0) ? "-" : "");
		double num = ((i < 0) ? (-i) : i);
		string text2;
		if (i >= 1152921504606846976L)
		{
			text2 = "EB";
			num = i >> 50;
		}
		else if (i >= 1125899906842624L)
		{
			text2 = "PB";
			num = i >> 40;
		}
		else if (i >= 1099511627776L)
		{
			text2 = "TB";
			num = i >> 30;
		}
		else if (i >= 1073741824)
		{
			text2 = "GB";
			num = i >> 20;
		}
		else if (i >= 1048576)
		{
			text2 = "MB";
			num = i >> 10;
		}
		else
		{
			if (i < 1024)
			{
				return i.ToString(text + "0 B");
			}
			text2 = "KB";
			num = i;
		}
		return text + (num / 1024.0).ToString("0.### ") + text2;
	}
}
