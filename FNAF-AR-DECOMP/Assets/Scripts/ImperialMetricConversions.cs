using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class ImperialMetricConversions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float METERS_TO_FEET = 3.28084;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float FEET_TO_METERS = 0.3048;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float MILES_TO_FEET = 5280;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float FEET_TO_MILES = 0.0001893939;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float MINUTES_TO_SECONDS = 60;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float SECONDS_TO_MINUTES = 0.01666667;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float HOURS_TO_MINUTES = 60;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const float MINUTES_TO_HOURS = 0.01666667;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MetersToFeet(float meters)
    {
        meters = meters * 3.28084f;
        return (float)meters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float FeetToMeters(float feet)
    {
        feet = feet * 0.3048f;
        return (float)feet;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MilesToFeet(float miles)
    {
        miles = miles * 5280f;
        return (float)miles;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float FeetToMiles(float feet)
    {
        feet = feet * 0.0001893939f;
        return (float)feet;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MetersToMiles(float meters)
    {
        meters = meters * 3.28084f;
        meters = meters * 0.0001893939f;
        return (float)meters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MilesToMeters(float miles)
    {
        miles = miles * 5280f;
        miles = miles * 0.3048f;
        return (float)miles;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MetersPerSecondToFeetPerSecond(float metersPerSecond)
    {
        metersPerSecond = metersPerSecond * 3.28084f;
        return (float)metersPerSecond;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float FeetPerSecondToMetersPerSecond(float feetPerSecond)
    {
        feetPerSecond = feetPerSecond * 0.3048f;
        return (float)feetPerSecond;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MetersPerSecondToMilesPerSecond(float metersPerSecond)
    {
        metersPerSecond = metersPerSecond * 3.28084f;
        metersPerSecond = metersPerSecond * 0.0001893939f;
        return (float)metersPerSecond;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MilesPerSecondToMetersPerSecond(float milesPerSecond)
    {
        milesPerSecond = milesPerSecond * 5280f;
        milesPerSecond = milesPerSecond * 0.3048f;
        return (float)milesPerSecond;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MetersPerSecondToMilesPerMinute(float metersPerSecond)
    {
        metersPerSecond = metersPerSecond * 3.28084f;
        metersPerSecond = metersPerSecond * 0.0001893939f;
        metersPerSecond = metersPerSecond / 0.01666667f;
        return (float)metersPerSecond;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MilesPerMinuteToMetersPerSecond(float milesPerMinute)
    {
        milesPerMinute = milesPerMinute / 60f;
        milesPerMinute = milesPerMinute * 5280f;
        milesPerMinute = milesPerMinute * 0.3048f;
        return (float)milesPerMinute;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MetersPerSecondToMilesPerHour(float metersPerSecond)
    {
        metersPerSecond = metersPerSecond * 3.28084f;
        metersPerSecond = metersPerSecond * 0.0001893939f;
        metersPerSecond = metersPerSecond / 0.01666667f;
        metersPerSecond = metersPerSecond / 0.01666667f;
        return (float)metersPerSecond;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MilesPerHourToMetersPerSecond(float milesPerHour)
    {
        milesPerHour = milesPerHour / 60f;
        milesPerHour = milesPerHour / 60f;
        milesPerHour = milesPerHour * 5280f;
        milesPerHour = milesPerHour * 0.3048f;
        return (float)milesPerHour;
    }

}
