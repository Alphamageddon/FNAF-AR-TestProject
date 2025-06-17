using System;

namespace UnityEngine.Rendering.PostProcessing
{
	internal static class PostProcessEffectRendererExtensions
	{
		public static Exception RenderOrLog(this PostProcessEffectRenderer self, PostProcessRenderContext context)
		{
			try
			{
				self.Render(context);
			}
			catch (Exception ex)
			{
				Debug.LogException(ex);
				return ex;
			}
			return null;
		}
	}
}
