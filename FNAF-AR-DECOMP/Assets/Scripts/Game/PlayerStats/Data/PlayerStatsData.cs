using UnityEngine;

namespace Game.PlayerStats.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerStatsData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TotalRemant;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.RemnantDebuffEntry RemnantDebuffInfo;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.PlayerStats.Data.PlayerStatsData CreateEmpty()
        {
            Game.PlayerStats.Data.PlayerStatsData val_1 = new Game.PlayerStats.Data.PlayerStatsData();
            if(val_1 != null)
            {
                    .TotalRemant = 0;
            }
            else
            {
                    mem[16] = 0;
            }
            
            .RemnantDebuffInfo = 0;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerStatsData()
        {
        
        }
    
    }

}
