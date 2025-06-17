using System;
using System.Collections.Generic;
using UnityEngine;

namespace PaperPlaneTools
{
	public class Alert
	{
		public enum ButtonType
		{
			Positive = 0,
			Negative = 1,
			Neutral = 2
		}

		public string Title { get; private set; }

		public string Message { get; private set; }

		public AlertButton PositiveButton { get; private set; }

		public AlertButton NegativeButton { get; private set; }

		public AlertButton NeutralButton { get; private set; }

		public List<object> Options { get; private set; }

		public Action OnDismiss { get; private set; }

		public IAlertPlatformAdapter Adapter { get; private set; }

		public Alert(string title = null, string message = null)
		{
			Title = title;
			Message = message;
			Options = new List<object>();
		}

		public Alert SetTitle(string title)
		{
			Title = title;
			Debug.LogError(Title);
			return this;
		}

		public Alert SetMessage(string title)
		{
			Message = title;
			return this;
		}

		public Alert SetPositiveButton(string title, Action handler = null)
		{
			PositiveButton = new AlertButton(title, handler);
			return this;
		}

		public Alert SetNegativeButton(string title, Action handler = null)
		{
			Debug.LogError(title + " is negative button");
			NegativeButton = new AlertButton(title, handler);
			return this;
		}

		public Alert SetNeutralButton(string title, Action handler = null)
		{
			NeutralButton = new AlertButton(title, handler);
			return this;
		}

		public void ClearPositiveButton()
		{
			PositiveButton = null;
		}

		public void ClearNeutralButton()
		{
			NeutralButton = null;
		}

		public void ClearNegativeButton()
		{
			NegativeButton = null;
		}

		public Alert AddOptions(object opt)
		{
			Options.Add(opt);
			return this;
		}

		public Alert SetOptions(List<object> options)
		{
			Options = options;
			return this;
		}

		public Alert SetOnDismiss(Action handler)
		{
			OnDismiss = handler;
			return this;
		}

		public Alert SetAdapter(IAlertPlatformAdapter adaper)
		{
			Adapter = adaper;
			return this;
		}

		public void Show()
		{
			AlertManager.Instance.Show(this);
		}

		public void Dismiss()
		{
			AlertManager.Instance.Dismiss(this);
		}
	}
}
