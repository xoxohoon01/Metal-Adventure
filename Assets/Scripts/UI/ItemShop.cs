using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour
{
    public Player currentCharacter;
    
    public void BuyHorn()
    {
        Buff newBuff = new Buff(0.05f, 300f);
        currentCharacter.Damage.AddBuffMultiplication(newBuff, true);
    }

    public void BuyNoiseCanceling()
    {
        Buff newBuff = new Buff(0.05f, 300f);
        currentCharacter.Armor.AddBuffMultiplication(newBuff, true);
    }

    public void BuyAmericano()
    {
        currentCharacter.HP.Add(currentCharacter.HP.GetValue() * 0.5f);
    }
}
