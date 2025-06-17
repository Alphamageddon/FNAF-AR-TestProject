using System.Collections.Generic;

public sealed class AUDIO_DATA
{
	public class Entry
	{
		public string GameAudioEvent { get; set; }

		public WwiseAudioEvents WwiseAudioEvents { get; set; }
	}

	public class Event1 : WwiseEventInfo
	{
		public override string Name { get; set; }
	}

	public class Event2 : WwiseEventInfo
	{
		public override string Name { get; set; }
	}

	public class Event3 : WwiseEventInfo
	{
		public override string Name { get; set; }
	}

	public class Event4 : WwiseEventInfo
	{
		public override string Name { get; set; }
	}

	public class Event5 : WwiseEventInfo
	{
		public override string Name { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class WwiseAudioEvents
	{
		public Event1 Event1 { get; set; }

		public Event2 Event2 { get; set; }

		public Event3 Event3 { get; set; }

		public Event4 Event4 { get; set; }

		public Event5 Event5 { get; set; }
	}

	public abstract class WwiseEventInfo
	{
		public virtual string Name { get; set; }
	}
}
