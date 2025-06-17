using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CurrencyBank
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, int> accounts;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CurrencyBank()
        {
            this.accounts = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetBank(System.Collections.Generic.Dictionary<string, int> bankData)
        {
            this.accounts.Clear();
            this.UpdateBank(bankData:  bankData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateBank(System.Collections.Generic.Dictionary<string, int> bankData)
        {
            var val_4;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = bankData.Keys.GetEnumerator();
            label_11:
            if((1686614512 & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            if((this.accounts.ContainsKey(key:  val_5)) == false)
            {
                goto label_5;
            }
            
            this.accounts.set_Item(key:  val_5, value:  bankData.Item[val_5]);
            goto label_11;
            label_5:
            this.accounts.Add(key:  val_5, value:  bankData.Item[val_5]);
            goto label_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddCurrency(string currencyName, int amount)
        {
            var val_5;
            if((this.accounts.ContainsKey(key:  currencyName)) == false)
            {
                    return;
            }
            
            if(this.accounts != null)
            {
                    val_5 = this.accounts.Item[currencyName];
            }
            else
            {
                    val_5 = 0.Item[currencyName];
            }
            
            this.accounts.set_Item(key:  currencyName, value:  val_5 + amount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetCurrency(string currencyName)
        {
            if((this.accounts.ContainsKey(key:  currencyName)) == false)
            {
                    return 0;
            }
            
            if(this.accounts != null)
            {
                    return this.accounts.Item[currencyName];
            }
            
            return this.accounts.Item[currencyName];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanAfford(TheGame.Currency.CurrencyType type, int amount)
        {
            string val_3;
            if(type <= 3)
            {
                    val_3 = mem[66464736 + (type) << 3];
                val_3 = 66464736 + (type) << 3;
                return (bool)((this.GetCurrency(currencyName:  val_3 = "")) >= amount) ? 1 : 0;
            }
            
            return (bool)((this.GetCurrency(currencyName:  val_3)) >= amount) ? 1 : 0;
        }
    
    }

}
