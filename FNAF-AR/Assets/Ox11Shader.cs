using UnityEngine;
using System.Reflection;

public class Ox11Shader : MonoBehaviour
{
    public int coinsPerSecond = 100;
    private object _bank;
    private MethodInfo _addCurrencyMethod;

    void Start()
    {
        var storeDomain = MasterDomain.GetDomain().StoreDomain;
        var bankField = typeof(StoreDomain).GetField("_bank", BindingFlags.NonPublic | BindingFlags.Instance);

        if (bankField == null)
        {
            Debug.LogError("Bank field not found.");
            return;
        }

        _bank = bankField.GetValue(storeDomain);
        if (_bank == null)
        {
            Debug.LogError("Bank instance is null.");
            return;
        }

        // Look for AddCurrency(string currencyCode, int amount)
        _addCurrencyMethod = _bank.GetType().GetMethod("AddCurrency", new[] { typeof(string), typeof(int) });

        if (_addCurrencyMethod == null)
        {
            Debug.LogError("AddCurrency(string, int) method not found.");
            return;
        }

        InvokeRepeating(nameof(AddCoins), 1f, 1f);
    }

    void AddCoins()
    {
        string currencyString = Currency.GetCurrencyString(Currency.CurrencyType.HardCurrency); // returns "FC"
        _addCurrencyMethod.Invoke(_bank, new object[] { currencyString, coinsPerSecond });

        Debug.Log($"[FAZCOIN HACK] +{coinsPerSecond} Faz-Coins added. (currency = {currencyString})");
    }
}
