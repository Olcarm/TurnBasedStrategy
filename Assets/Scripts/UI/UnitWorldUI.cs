using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UnitWorldUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI actionPointsText;
    [SerializeField] private Image healthBarImage;
    [SerializeField] private HealthSystem healthSystem;
 
    [SerializeField] private Unit unit;

    private void Start()
    {
        Unit.OnAnyActionPointsChanged += Unit_OnAnyActionPointsChanged;
        healthSystem.OnDamaged += HealthSystem_OnDamaged;
        UpdateActionPointsText();
        UpdateHealthBar();
    }
    private void UpdateActionPointsText()
    {
        actionPointsText.text = unit.GetActionPoints().ToString();
    }
    private void Unit_OnAnyActionPointsChanged(object sender, EventArgs e){
        UpdateActionPointsText();
    }

    private void HealthSystem_OnDamaged(object sender, EventArgs e){
        UpdateHealthBar();
    }
    private void UpdateHealthBar(){

        healthBarImage.fillAmount = healthSystem.GetHealthNormalized();
    }
}
