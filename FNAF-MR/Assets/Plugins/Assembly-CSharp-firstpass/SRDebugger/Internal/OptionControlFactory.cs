using System;
using System.Collections.Generic;
using System.Linq;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;
using SRF;
using UnityEngine;

namespace SRDebugger.Internal
{
	public static class OptionControlFactory
	{
		private static IList<DataBoundControl> _dataControlPrefabs;

		private static ActionControl _actionControlPrefab;

		public static OptionsControlBase CreateControl(OptionDefinition from, string categoryPrefix = null)
		{
			if (_dataControlPrefabs == null)
			{
				_dataControlPrefabs = Resources.LoadAll<DataBoundControl>("SRDebugger/UI/Prefabs/Options");
			}
			if (_actionControlPrefab == null)
			{
				_actionControlPrefab = Resources.LoadAll<ActionControl>("SRDebugger/UI/Prefabs/Options").FirstOrDefault();
			}
			if (_actionControlPrefab == null)
			{
				Debug.LogError("[SRDebugger.Options] Cannot find ActionControl prefab.");
			}
			if (from.Property != null)
			{
				return CreateDataControl(from, categoryPrefix);
			}
			if (from.Method != null)
			{
				return CreateActionControl(from, categoryPrefix);
			}
			throw new Exception("OptionDefinition did not contain property or method.");
		}

		private static ActionControl CreateActionControl(OptionDefinition from, string categoryPrefix = null)
		{
			ActionControl actionControl = SRInstantiate.Instantiate(_actionControlPrefab);
			if (actionControl == null)
			{
				Debug.LogWarning("[SRDebugger.OptionsTab] Error creating action control from prefab");
				return null;
			}
			actionControl.SetMethod(from.Name, from.Method);
			actionControl.Option = from;
			return actionControl;
		}

		private static DataBoundControl CreateDataControl(OptionDefinition from, string categoryPrefix = null)
		{
			DataBoundControl dataBoundControl = _dataControlPrefabs.FirstOrDefault((DataBoundControl p) => p.CanBind(from.Property.PropertyType, !from.Property.CanWrite));
			if (dataBoundControl == null)
			{
				Debug.LogWarning("[SRDebugger.OptionsTab] Can't find data control for type {0}".Fmt(from.Property.PropertyType));
				return null;
			}
			DataBoundControl dataBoundControl2 = SRInstantiate.Instantiate(dataBoundControl);
			try
			{
				string text = from.Name;
				if (!string.IsNullOrEmpty(categoryPrefix) && text.StartsWith(categoryPrefix))
				{
					text = text.Substring(categoryPrefix.Length);
				}
				dataBoundControl2.Bind(text, from.Property);
				dataBoundControl2.Option = from;
			}
			catch (Exception exception)
			{
				Debug.LogError("[SRDebugger.Options] Error binding to property {0}".Fmt(from.Name));
				Debug.LogException(exception);
				UnityEngine.Object.Destroy(dataBoundControl2);
				dataBoundControl2 = null;
			}
			return dataBoundControl2;
		}
	}
}
