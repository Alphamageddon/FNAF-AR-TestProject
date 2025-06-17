using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ConsoleLogger_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentIndex;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int CurrentClassIndex { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string CurrentClassName { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool CurrentClassLogErrors { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool CurrentClassLogWarnings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool CurrentClassLogDebugs { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ConsoleLogger_SROptions()
    {
        null = null;
        this.currentIndex = (ConsoleLogger.ClassList.Count < 1) ? -1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_CurrentClassIndex()
    {
        return (int)this.currentIndex;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CurrentClassIndex(int value)
    {
        int val_9;
        var val_10;
        System.Collections.Generic.List<ClassLoggingOptions> val_11;
        var val_12;
        var val_13;
        val_9 = value;
        val_10 = null;
        val_10 = null;
        val_11 = ConsoleLogger.ClassList;
        if(val_11.Count < 1)
        {
            goto label_4;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = ConsoleLogger.ClassList;
        if(val_11.Count <= val_9)
        {
            goto label_8;
        }
        
        if((val_9 & 2147483648) == 0)
        {
            goto label_14;
        }
        
        val_13 = null;
        val_13 = null;
        val_9 = ConsoleLogger.ClassList.Count - 1;
        goto label_14;
        label_4:
        val_9 = 0;
        goto label_14;
        label_8:
        val_9 = 0;
        label_14:
        this.currentIndex = val_9;
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassIndex");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassName");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogErrors");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogWarnings");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogDebugs");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_CurrentClassName()
    {
        int val_3;
        var val_4;
        var val_5;
        val_3 = this.currentIndex;
        if((val_3 & 2147483648) == 0)
        {
                val_4 = null;
            val_4 = null;
            val_3 = this.currentIndex;
            ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[val_3];
            GameUI.EmailUIDataHandler val_2 = val_1.<ClassName>k__BackingField.emailUIDataHandler;
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_CurrentClassLogErrors()
    {
        int val_2;
        var val_3;
        var val_4;
        val_2 = this.currentIndex;
        if((val_2 & 2147483648) == 0)
        {
                val_3 = null;
            val_3 = null;
            val_2 = this.currentIndex;
            ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[val_2];
            val_4;
        }
        else
        {
                val_4 = 0;
        }
        
        val_4 = val_4 & 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CurrentClassLogErrors(bool value)
    {
        null = null;
        ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[this.currentIndex];
        int val_4 = this.currentIndex;
        val_4 = value & (~(val_4 >> 31));
        bool val_2 = val_4;
        ConsoleLogger.ClassList.set_Item(index:  this.currentIndex, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_1.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_1.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_1.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_1.<LogDebugs>k__BackingField});
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogErrors");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_CurrentClassLogWarnings()
    {
        int val_2;
        var val_3;
        var val_4;
        val_2 = this.currentIndex;
        if((val_2 & 2147483648) == 0)
        {
                val_3 = null;
            val_3 = null;
            val_2 = this.currentIndex;
            ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[val_2];
            val_4;
        }
        else
        {
                val_4 = 0;
        }
        
        val_4 = val_4 & 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CurrentClassLogWarnings(bool value)
    {
        null = null;
        ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[this.currentIndex];
        int val_4 = this.currentIndex;
        val_4 = value & (~(val_4 >> 31));
        bool val_2 = val_4;
        ConsoleLogger.ClassList.set_Item(index:  this.currentIndex, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_1.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_1.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_1.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_1.<LogDebugs>k__BackingField});
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogWarnings");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_CurrentClassLogDebugs()
    {
        int val_2;
        var val_3;
        var val_4;
        val_2 = this.currentIndex;
        if((val_2 & 2147483648) == 0)
        {
                val_3 = null;
            val_3 = null;
            val_2 = this.currentIndex;
            ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[val_2];
            val_4;
        }
        else
        {
                val_4 = 0;
        }
        
        val_4 = val_4 & 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CurrentClassLogDebugs(bool value)
    {
        null = null;
        ClassLoggingOptions val_1 = ConsoleLogger.ClassList.Item[this.currentIndex];
        int val_4 = this.currentIndex;
        val_4 = value & (~(val_4 >> 31));
        bool val_2 = val_4;
        ConsoleLogger.ClassList.set_Item(index:  this.currentIndex, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_1.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_1.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_1.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_1.<LogDebugs>k__BackingField});
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogDebugs");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EnableAllLogs()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_6 = 0;
            do
        {
            val_7 = null;
            val_7 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_6 = val_6 + 1;
        }
        while(val_1 != val_6);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogErrors");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogWarnings");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogDebugs");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EnableAllErrors()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogErrors");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EnableAllWarnings()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogWarnings");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EnableAllDebugs()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogDebugs");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DisableAllLogs()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_6 = 0;
            do
        {
            val_7 = null;
            val_7 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_6 = val_6 + 1;
        }
        while(val_1 != val_6);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogErrors");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogWarnings");
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogDebugs");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DisableAllErrors()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogErrors");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DisableAllWarnings()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogWarnings");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DisableAllDebugs()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = ConsoleLogger.ClassList.Count;
        if(val_1 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            ClassLoggingOptions val_2 = ConsoleLogger.ClassList.Item[0];
            ConsoleLogger.ClassList.set_Item(index:  0, value:  new ClassLoggingOptions() {<ClassName>k__BackingField = val_2.<ClassName>k__BackingField, <LogErrors>k__BackingField = val_2.<LogErrors>k__BackingField, <LogWarnings>k__BackingField = val_2.<LogWarnings>k__BackingField, <LogDebugs>k__BackingField = val_2.<LogDebugs>k__BackingField});
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
        }
        
        SROptions.Current.OnPropertyChanged(propertyName:  "CurrentClassLogDebugs");
    }

}
