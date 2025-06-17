using UnityEngine;

namespace Game.Workshop.Container
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CurrencyContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _fazTokens;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _parts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _essence;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FazTokens { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Parts { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Essence { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_FazTokens()
        {
            return (int)this._fazTokens;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Parts()
        {
            return (int)this._parts;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Essence()
        {
            return (int)this._essence;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CurrencyContainer()
        {
            this._fazTokens = 0;
            this._parts = 0;
            this._essence = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFazTokens(int amount)
        {
            this._fazTokens = amount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFazTokens(int amount)
        {
            int val_1 = this._fazTokens;
            val_1 = val_1 + amount;
            this._fazTokens = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpendFazTokens(int amount)
        {
            amount = this._fazTokens - amount;
            this._fazTokens = System.Math.Max(val1:  0, val2:  amount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetParts(int amount)
        {
            this._parts = amount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddParts(int amount)
        {
            int val_1 = this._parts;
            val_1 = val_1 + amount;
            this._parts = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpendParts(int amount)
        {
            amount = this._parts - amount;
            this._parts = System.Math.Max(val1:  0, val2:  amount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEssence(int amount)
        {
            this._essence = amount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEssence(int amount)
        {
            int val_1 = this._essence;
            val_1 = val_1 + amount;
            this._essence = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpendEssence(int amount)
        {
            amount = this._essence - amount;
            this._essence = System.Math.Max(val1:  0, val2:  amount);
        }
    
    }

}
