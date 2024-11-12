using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OriginValueChanger : MonoBehaviour
{
    public Player currentCharacter;

    private GameObject HP;
    private GameObject MP;
    private GameObject Damage;
    private GameObject Armor;
    private GameObject Range;
    private GameObject MoveSpeed;
    private GameObject AttackSpeed;

    public void ChangeCharacterCondition(Condition condition, float value)
    {
        condition.originValue = value;
        condition.curValue = value;
    }

    private void Awake()
    {
        HP = transform.GetChild(0).gameObject;
        MP = transform.GetChild(1).gameObject;
        Damage = transform.GetChild(2).gameObject;
        Armor = transform.GetChild(3).gameObject;
        Range = transform.GetChild(4).gameObject;
        MoveSpeed = transform.GetChild(5).gameObject;
        AttackSpeed = transform.GetChild(6).gameObject;
    }

    private void Start()
    {
        if (currentCharacter == null) return;

        TMP_InputField HP_IF = HP.transform.GetChild(1).GetComponent<TMP_InputField>();
        TMP_InputField MP_IF = MP.transform.GetChild(1).GetComponent<TMP_InputField>();
        TMP_InputField Damage_IF = Damage.transform.GetChild(1).GetComponent<TMP_InputField>();
        TMP_InputField Armor_IF = Armor.transform.GetChild(1).GetComponent<TMP_InputField>();
        TMP_InputField Range_IF = Range.transform.GetChild(1).GetComponent<TMP_InputField>();
        TMP_InputField MoveSpeed_IF = MoveSpeed.transform.GetChild(1).GetComponent<TMP_InputField>();
        TMP_InputField AttackSpeed_IF = AttackSpeed.transform.GetChild(1).GetComponent<TMP_InputField>();

        HP_IF.text = currentCharacter.HP.originValue.ToString();
        MP_IF.text = currentCharacter.MP.originValue.ToString();
        Damage_IF.text = currentCharacter.Damage.originValue.ToString();
        Armor_IF.text = currentCharacter.Armor.originValue.ToString();
        Range_IF.text = currentCharacter.Range.originValue.ToString();
        MoveSpeed_IF.text = currentCharacter.MoveSpeed.originValue.ToString();
        AttackSpeed_IF.text = currentCharacter.AttackSpeed.originValue.ToString();

        HP_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.HP, float.Parse(HP_IF.text)); });
        MP_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.MP, float.Parse(MP_IF.text)); });
        Damage_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.Damage, float.Parse(Damage_IF.text)); });
        Armor_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.Armor, float.Parse(Armor_IF.text)); });
        Range_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.Range, float.Parse(Range_IF.text)); });
        MoveSpeed_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.MoveSpeed, float.Parse(MoveSpeed_IF.text)); });
        AttackSpeed_IF.onEndEdit.AddListener(delegate { ChangeCharacterCondition(currentCharacter.AttackSpeed, float.Parse(AttackSpeed_IF.text)); });
    }

    private void Update()
    {
        if (currentCharacter == null) return;

    }
}
