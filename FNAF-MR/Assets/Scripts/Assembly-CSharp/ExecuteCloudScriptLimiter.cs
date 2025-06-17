using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ExecuteCloudScriptLimiter : IExecuteScriptRequest
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public ExecuteCloudScriptLimiter _003C_003E4__this;

		public ExecuteScriptParameters parameters;

		internal void _003CExecute_003Eg__OnRequestResult_007C0(ExecuteScriptResult executeScriptResult)
		{
			_003C_003E4__this.TimeoutActiveCall();
			parameters.resultCallback(executeScriptResult);
		}

		internal void _003CExecute_003Eg__OnRequestError_007C1(IllumixErrorData illumixErrorData)
		{
			_003C_003E4__this.TimeoutActiveCall();
			parameters.errorCallback(illumixErrorData);
		}
	}

	private readonly int _maxOperations;

	private readonly float _timeout;

	private readonly IExecuteScriptRequest _requester;

	private readonly Queue<ExecuteScriptParameters> _queue;

	private readonly List<float> timeoutList;

	private int _activeCalls;

	public ExecuteCloudScriptLimiter(int maxOperations, float timeout, IExecuteScriptRequest requester)
	{
		_queue = new Queue<ExecuteScriptParameters>();
		timeoutList = new List<float>();
		_maxOperations = maxOperations;
		_timeout = timeout;
		_requester = requester;
		_activeCalls = 0;
	}

	public void ExecuteParameters(ExecuteScriptParameters parameters)
	{
		if (IsStackFull())
		{
			Debug.LogError("stack full, queueing");
			_queue.Enqueue(parameters);
		}
		else
		{
			Debug.LogError("stack not full, executin");
			Execute(parameters);
		}
	}

	public void Update(float time)
	{
		UpdateTimeouts(time);
		if (!IsStackFull() && _queue.Count >= 1)
		{
			Execute(_queue.Dequeue());
		}
	}

	private bool IsStackFull()
	{
		return _activeCalls + timeoutList.Count >= _maxOperations;
	}

	private void Execute(ExecuteScriptParameters parameters)
	{
		Debug.LogError("limiter executing to playfab executer");
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.parameters = parameters;
		_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
		ExecuteScriptParameters executeScriptParameters = new ExecuteScriptParameters(parameters);
		executeScriptParameters.resultCallback = _003C_003Ec__DisplayClass10_._003CExecute_003Eg__OnRequestResult_007C0;
		executeScriptParameters.errorCallback = _003C_003Ec__DisplayClass10_._003CExecute_003Eg__OnRequestError_007C1;
		_activeCalls++;
		_requester.ExecuteParameters(executeScriptParameters);
	}

	private void TimeoutActiveCall()
	{
		if (_activeCalls != 0)
		{
			_activeCalls--;
			timeoutList.Add(_timeout);
		}
		else
		{
			new InvalidConstraintException("Active Calls Are Already 0!");
		}
	}

	private void UpdateTimeouts(float time)
	{
		if (timeoutList.Count < 1)
		{
			return;
		}
		int num = timeoutList.Count - 1;
		while (timeoutList != null)
		{
			float num2 = timeoutList[num];
			timeoutList[num] = num2 - time;
			if (timeoutList[num] <= 0f)
			{
				timeoutList.RemoveAt(num);
			}
			num--;
			if (num < 0)
			{
				break;
			}
		}
	}
}
