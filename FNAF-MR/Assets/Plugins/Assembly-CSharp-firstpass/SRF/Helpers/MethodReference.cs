using System.Reflection;

namespace SRF.Helpers
{
	public class MethodReference
	{
		private MethodInfo _method;

		private object _target;

		public string MethodName => _method.Name;

		public MethodReference(object target, MethodInfo method)
		{
			SRDebugUtil.AssertNotNull(target);
			_target = target;
			_method = method;
		}

		public object Invoke(object[] parameters)
		{
			return _method.Invoke(_target, parameters);
		}
	}
}
