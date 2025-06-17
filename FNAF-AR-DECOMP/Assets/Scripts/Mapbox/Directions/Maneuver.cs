using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Maneuver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <BearingAfter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Type>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Modifier>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <BearingBefore>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <Location>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Instruction>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BearingAfter { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Modifier { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BearingBefore { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Location { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Instruction { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_BearingAfter()
        {
            return (int)this.<BearingAfter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BearingAfter(int value)
        {
            this.<BearingAfter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Type()
        {
            return (string)this.<Type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Type(string value)
        {
            this.<Type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Modifier()
        {
            return (string)this.<Modifier>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Modifier(string value)
        {
            this.<Modifier>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_BearingBefore()
        {
            return (int)this.<BearingBefore>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BearingBefore(int value)
        {
            this.<BearingBefore>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Location()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<Location>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Location(Mapbox.Utils.Vector2d value)
        {
            this.<Location>k__BackingField = value;
            mem[1152921520014462712] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Instruction()
        {
            return (string)this.<Instruction>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Instruction(string value)
        {
            this.<Instruction>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Maneuver()
        {
        
        }
    
    }

}
