using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrentValueChanger : MonoBehaviour
{
    public Player currentCharacter;

    private GameObject HP;
    private GameObject MP;
    private GameObject Damage;
    private GameObject Armor;
    private GameObject Range;
    private GameObject MoveSpeed;
    private GameObject AttackSpeed;

    private Slider HP_Slider;
    private Slider MP_Slider;
    private Slider Damage_Slider;
    private Slider Armor_Slider;
    private Slider Range_Slider;
    private Slider MoveSpeed_Slider;
    private Slider AttackSpeed_Slider;

    public void ChangeCharacterCondition(Condition condition, float value)
    {
        condition.curValue = value;
    }

    private void UpdateSlider()
    {
        HP_Slider.minValue = 0;
        MP_Slider.minValue = 0;
        Damage_Slider.minValue = 0;
        Armor_Slider.minValue = 0;
        Range_Slider.minValue = 0;
        MoveSpeed_Slider.minValue = 0;
        AttackSpeed_Slider.minValue = 0;

        HP_Slider.maxValue = currentCharacter.HP.GetValue();
        MP_Slider.maxValue = currentCharacter.MP.GetValue();
        Damage_Slider.maxValue = currentCharacter.Damage.GetValue();
        Armor_Slider.maxValue = currentCharacter.Armor.GetValue();
        Range_Slider.maxValue = currentCharacter.Range.GetValue();
        MoveSpeed_Slider.maxValue = currentCharacter.MoveSpeed.GetValue();
        AttackSpeed_Slider.maxValue = currentCharacter.AttackSpeed.GetValue();

        // 현재 값 최신화
        HP.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.HP.curValue.ToString();
        MP.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.MP.curValue.ToString();
        Damage.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.Damage.curValue.ToString();
        Armor.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.Armor.curValue.ToString();
        Range.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.Range.curValue.ToString();
        MoveSpeed.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.MoveSpeed.curValue.ToString();
        AttackSpeed.transform.GetChild(1).GetComponent<TMP_Text>().text = currentCharacter.AttackSpeed.curValue.ToString();

        // 슬라이더 최소값 최신화
        HP.transform.GetChild(2).GetComponent<TMP_Text>().text = HP_Slider.minValue.ToString();
        MP.transform.GetChild(2).GetComponent<TMP_Text>().text = MP_Slider.minValue.ToString();
        Damage.transform.GetChild(2).GetComponent<TMP_Text>().text = Damage_Slider.minValue.ToString();
        Armor.transform.GetChild(2).GetComponent<TMP_Text>().text = Armor_Slider.minValue.ToString();
        Range.transform.GetChild(2).GetComponent<TMP_Text>().text = Range_Slider.minValue.ToString();
        MoveSpeed.transform.GetChild(2).GetComponent<TMP_Text>().text = MoveSpeed_Slider.minValue.ToString();
        AttackSpeed.transform.GetChild(2).GetComponent<TMP_Text>().text = AttackSpeed_Slider.minValue.ToString();

        // 슬라이더 최대값 최신화
        HP.transform.GetChild(4).GetComponent<TMP_Text>().text = HP_Slider.maxValue.ToString();
        MP.transform.GetChild(4).GetComponent<TMP_Text>().text = MP_Slider.maxValue.ToString();
        Damage.transform.GetChild(4).GetComponent<TMP_Text>().text = Damage_Slider.maxValue.ToString();
        Armor.transform.GetChild(4).GetComponent<TMP_Text>().text = Armor_Slider.maxValue.ToString();
        Range.transform.GetChild(4).GetComponent<TMP_Text>().text = Range_Slider.maxValue.ToString();
        MoveSpeed.transform.GetChild(4).GetComponent<TMP_Text>().text = MoveSpeed_Slider.maxValue.ToString();
        AttackSpeed.transform.GetChild(4).GetComponent<TMP_Text>().text = AttackSpeed_Slider.maxValue.ToString();

        // 슬라이더 값 초기화 (캐릭터 현재 HP에 따라 변경되도록)
        HP_Slider.value = currentCharacter.HP.curValue;
        MP_Slider.value = currentCharacter.MP.curValue;
        Damage_Slider.value = currentCharacter.Damage.curValue;
        Armor_Slider.value = currentCharacter.Armor.curValue;
        Range_Slider.value = currentCharacter.Range.curValue;
        MoveSpeed_Slider.value = currentCharacter.MoveSpeed.curValue;
        AttackSpeed_Slider.value = currentCharacter.AttackSpeed.curValue;
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

        HP_Slider = HP.transform.GetChild(3).GetComponent<Slider>();
        MP_Slider = MP.transform.GetChild(3).GetComponent<Slider>();
        Damage_Slider = Damage.transform.GetChild(3).GetComponent<Slider>();
        Armor_Slider = Armor.transform.GetChild(3).GetComponent<Slider>();
        Range_Slider = Range.transform.GetChild(3).GetComponent<Slider>();
        MoveSpeed_Slider = MoveSpeed.transform.GetChild(3).GetComponent<Slider>();
        AttackSpeed_Slider = AttackSpeed.transform.GetChild(3).GetComponent<Slider>();
    }

    private void Start()
    {
        if (currentCharacter == null) return;

        // 리스너 등록 (curValue 변경 시)
        currentCharacter.HP.OnCurValueChanged += UpdateSlider;
        currentCharacter.MP.OnCurValueChanged += UpdateSlider;
        currentCharacter.Damage.OnCurValueChanged += UpdateSlider;
        currentCharacter.Armor.OnCurValueChanged += UpdateSlider;
        currentCharacter.Range.OnCurValueChanged += UpdateSlider;
        currentCharacter.MoveSpeed.OnCurValueChanged += UpdateSlider;
        currentCharacter.AttackSpeed.OnCurValueChanged += UpdateSlider;

        // 리스너 등록 (OriginValue 변경 시)
        currentCharacter.HP.OnOriginValueChanged += UpdateSlider;
        currentCharacter.MP.OnOriginValueChanged += UpdateSlider;
        currentCharacter.Damage.OnOriginValueChanged += UpdateSlider;
        currentCharacter.Armor.OnOriginValueChanged += UpdateSlider;
        currentCharacter.Range.OnOriginValueChanged += UpdateSlider;
        currentCharacter.MoveSpeed.OnOriginValueChanged += UpdateSlider;
        currentCharacter.AttackSpeed.OnOriginValueChanged += UpdateSlider;

        // 리스너 등록 (슬라이더 값 변경 시)
        HP_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.HP, HP_Slider.value); });
        MP_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.MP, MP_Slider.value); });
        Damage_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.Damage, Damage_Slider.value); });
        Armor_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.Armor, Armor_Slider.value); });
        Range_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.Range, Range_Slider.value); });
        MoveSpeed_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.MoveSpeed, MoveSpeed_Slider.value); });
        AttackSpeed_Slider.onValueChanged.AddListener(delegate { ChangeCharacterCondition(currentCharacter.AttackSpeed, AttackSpeed_Slider.value); });

        UpdateSlider();
    }

}
