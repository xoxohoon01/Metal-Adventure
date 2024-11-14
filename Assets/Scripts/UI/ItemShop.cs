using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour
{
    public Player currentCharacter;
    
    public void BuyHorn()
    {
        if (InventoryManager.Instance.gold > 200)
        {
            Buff newBuff = new Buff(0.05f, 300f);
            currentCharacter.Damage.AddBuffMultiplication(newBuff, true);
        }
    }

    public void BuyNoiseCanceling()
    {
        if (InventoryManager.Instance.gold > 200)
        {
            Buff newBuff = new Buff(0.05f, 300f);
            currentCharacter.Armor.AddBuffMultiplication(newBuff, true);
        }
    }

    public void BuyAmericano()
    {
        if (InventoryManager.Instance.gold > 100)
        {
            currentCharacter.HP.Add(currentCharacter.HP.GetValue() * 0.5f);
        }
    }

    private void Awake()
    {
        UIManager.Instance.itemShop = this;
    }
}
