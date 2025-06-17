using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatteryColorHandlerData
{
	public SurgeMechanicUIHandler surgeMechanicUIHandler;

	public Slider batterySlider;

	public Image batteryColor;

	public Image batteryBG;

	public TextMeshProUGUI batteryText;

	public List<BatteryColorToValue> batteryColorToValues;

	public Color batterySurgeColor;

	public float batterySurgeBlinkDuration;

	public BatteryColorHandlerData(SurgeMechanicUIHandler surgeMechanicUIHandler, Slider batterySlider, Image batteryColor, Image batteryBG, TextMeshProUGUI batteryText, List<BatteryColorToValue> batteryColorToValues, Color batterySurgeColor)
	{
		this.surgeMechanicUIHandler = surgeMechanicUIHandler;
		this.batterySlider = batterySlider;
		this.batteryColor = batteryColor;
		this.batteryBG = batteryBG;
		this.batteryText = batteryText;
		this.batteryColorToValues = batteryColorToValues;
		this.batterySurgeColor = batterySurgeColor;
	}
}
