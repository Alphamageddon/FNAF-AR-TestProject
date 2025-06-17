using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AnimatronicConfigMapper
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AnimatronicEntity.AnimatronicConfigData _data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.ItemDefinition.Data.DataDefinitions.CPUData _cpuData;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AnimatronicConfigMapper(AnimatronicEntity.AnimatronicConfigData data)
    {
        this._data = data;
        this._cpuData = data.<CpuData>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetTravelSpeedMeters()
    {
        if(this._cpuData != null)
        {
                return ImperialMetricConversions.MilesPerHourToMetersPerSecond(milesPerHour:  (float)this._cpuData.TravelSpeedMPH);
        }
        
        return ImperialMetricConversions.MilesPerHourToMetersPerSecond(milesPerHour:  (float)this._cpuData.TravelSpeedMPH);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetSpeedMeters()
    {
        if(this._cpuData != null)
        {
                return ImperialMetricConversions.MilesPerHourToMetersPerSecond(milesPerHour:  (float)this._cpuData.SpeedMPH);
        }
        
        return ImperialMetricConversions.MilesPerHourToMetersPerSecond(milesPerHour:  (float)this._cpuData.SpeedMPH);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetSalvagerSpeedMeters()
    {
        if(this._cpuData != null)
        {
                return ImperialMetricConversions.MilesPerHourToMetersPerSecond(milesPerHour:  (float)this._cpuData.SalvagerSpeedMPH);
        }
        
        return ImperialMetricConversions.MilesPerHourToMetersPerSecond(milesPerHour:  (float)this._cpuData.SalvagerSpeedMPH);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AnimatronicConfigMapper.MinMaxTimers GetStalkingTimers()
    {
        if(this._cpuData != null)
        {
                return new MinMaxTimers() {minTimeSeconds = this._cpuData.StalkingTimerMin, maxTimeSeconds = this._cpuData.StalkingTimerMax};
        }
        
        this._cpuData = this._cpuData;
        if(this._cpuData != null)
        {
                return new MinMaxTimers() {minTimeSeconds = this._cpuData.StalkingTimerMin, maxTimeSeconds = this._cpuData.StalkingTimerMax};
        }
    
    }

}
