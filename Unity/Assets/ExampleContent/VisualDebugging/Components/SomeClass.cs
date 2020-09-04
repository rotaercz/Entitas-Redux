using System;

namespace ExampleContent.VisualDebugging
{
	[Serializable]
	[VisualDebug]
	public class SomeClass : ICloneable
	{
		public string name;

		public SomeClass(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone()
		{
			return new SomeClass(name);
		}
	}
}
