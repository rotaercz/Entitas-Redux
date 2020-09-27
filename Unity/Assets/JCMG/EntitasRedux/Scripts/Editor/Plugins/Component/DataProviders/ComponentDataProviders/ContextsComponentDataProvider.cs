﻿/*

MIT License

Copyright (c) 2020 Jeff Campbell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using System;
using System.Linq;
using JCMG.Genesis.Editor;

namespace JCMG.EntitasRedux.Editor.Plugins
{
	internal sealed class ContextsComponentDataProvider : IComponentDataProvider,
														  IConfigurable
	{
		private readonly ContextSettingsConfig _contextSettingsConfig = new ContextSettingsConfig();

		public string[] GetContextNames(Type type)
		{
			return Attribute
				.GetCustomAttributes(type)
				.OfType<ContextAttribute>()
				.Select(attr => attr.contextName)
				.ToArray();
		}

		public string[] GetContextNamesOrDefault(Type type)
		{
			var contextNames = GetContextNames(type);
			if (contextNames.Length == 0)
			{
				contextNames = new[]
				{
					_contextSettingsConfig.ContextNames[0]
				};
			}

			return contextNames;
		}

		public void Provide(Type type, ComponentData data)
		{
			var contextNames = GetContextNamesOrDefault(type);
			data.SetContextNames(contextNames);
		}

		public void Configure(GenesisSettings settings)
		{
			_contextSettingsConfig.Configure(settings);
		}
	}

	internal static class ContextsComponentDataExtension
	{
		public const string COMPONENT_CONTEXTS = "Component.ContextNames";

		public static string[] GetContextNames(this ComponentData data)
		{
			return (string[])data[COMPONENT_CONTEXTS];
		}

		public static void SetContextNames(this ComponentData data, string[] contextNames)
		{
			data[COMPONENT_CONTEXTS] = contextNames;
		}
	}
}
