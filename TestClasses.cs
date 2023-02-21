using System;

namespace BinaryFormatterIssue.Shared
{
	[Serializable]
	public class EmptyClass
	{

	}

	[Serializable]
	public class NotEmptyClass
	{
		public int SomeProperty { get; set; }
	}
}