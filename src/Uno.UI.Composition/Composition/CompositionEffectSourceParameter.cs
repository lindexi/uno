﻿#nullable enable

using Windows.Graphics.Effects;

namespace Microsoft.UI.Composition;

public partial class CompositionEffectSourceParameter : IGraphicsEffectSource
{
	private string _name;

	public CompositionEffectSourceParameter(string name) => _name = name;

	public string Name => _name;
}
