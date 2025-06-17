using UnityEngine;

public class BatteryColorHandler
{
	private BatteryColorHandlerData _data;

	private const float EPSILON = 0.05f;

	public BatteryColorHandler(BatteryColorHandlerData batteryColorHandlerData)
	{
		_data = batteryColorHandlerData;
	}

	public void Update()
	{
		if (_data.surgeMechanicUIHandler != null)
		{
			UpdateBatteryColor(_data.surgeMechanicUIHandler.BlinkState);
		}
		else
		{
			UpdateBatteryColor(blinkState: false);
		}
	}

	private void UpdateBatteryColor(bool blinkState)
	{
		_data.batteryColor.color = GetBlendedFillColor();
		_data.batteryBG.color = Color.white;
		_data.batteryText.color = Color.white;
		if (blinkState)
		{
			_data.batteryColor.color = _data.batterySurgeColor;
			_data.batteryBG.color = _data.batterySurgeColor;
			_data.batteryText.color = _data.batterySurgeColor;
		}
	}

	private Color GetBlendedFillColor()
	{
		float value = _data.batterySlider.value;
		if (value < 0.5f)
		{
			return Color.Lerp(_data.batteryColorToValues[0].color, _data.batteryColorToValues[1].color, value * 2f);
		}
		return Color.Lerp(_data.batteryColorToValues[1].color, _data.batteryColorToValues[2].color, value * 2f - 1f);
	}
}
