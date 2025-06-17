public class AttackSequenceConfigs
{
	private float _noiseMeterPollingInterval;

	private float _minAngleDelta;

	private float _minPosDelta;

	public float MinAngleDelta => _minAngleDelta;

	public float MinPosDelta => _minPosDelta;

	public float NoiseMeterPollingInterval => _noiseMeterPollingInterval;

	public AttackSequenceConfigs()
	{
		_minPosDelta = 0f;
		_noiseMeterPollingInterval = 0f;
		_minAngleDelta = 0f;
	}
}
