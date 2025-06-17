using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Container
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.AnimatronicStatsDomain _animatronicStatsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> _stats;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Container(Animatronics.AnimatronicStats.AnimatronicStatsDomain animatronicStatsDomain)
        {
            this._stats = new System.Collections.Generic.Dictionary<System.String, Animatronics.AnimatronicStats.StatsData>();
            this._animatronicStatsDomain = animatronicStatsDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> GetStatsToSave()
        {
            return (System.Collections.Generic.Dictionary<System.String, Animatronics.AnimatronicStats.StatsData>)this._stats;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetStatsFromLoad(System.Collections.Generic.Dictionary<string, Animatronics.AnimatronicStats.StatsData> stats)
        {
            this._stats = stats;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] GetAllAnimatronicIds()
        {
            return System.Linq.Enumerable.ToArray<System.String>(source:  this._stats.Keys);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DoesDataExistForAnimatronic(string animatronicId)
        {
            if(this._stats != null)
            {
                    return this._stats.ContainsKey(key:  animatronicId);
            }
            
            return this._stats.ContainsKey(key:  animatronicId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.StatsData GetDataForAnimatronic(string animatronicId)
        {
            var val_3;
            if((this.DoesDataExistForAnimatronic(animatronicId:  animatronicId)) != false)
            {
                    Animatronics.AnimatronicStats.StatsData val_2 = this._stats.Item[animatronicId];
                return (Animatronics.AnimatronicStats.StatsData)val_3;
            }
            
            val_3 = 0;
            return (Animatronics.AnimatronicStats.StatsData)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDataForAnimatronic(Animatronics.AnimatronicStats.StatsData statsData, string animatronicId)
        {
            this._stats.set_Item(key:  animatronicId, value:  statsData);
        }
    
    }

}
