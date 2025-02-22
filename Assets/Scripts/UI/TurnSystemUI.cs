using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystemUI : MonoBehaviour
{
  
    [SerializeField] private Button endTurnButton;
    [SerializeField] private TextMeshProUGUI turnText;
    [SerializeField] private GameObject enemyTurnVisualGameObject;


    private void Start() {
        endTurnButton.onClick.AddListener(()=>{
            TurnSystem.Instance.NextTurn();
        });
        TurnSystem.Instance.OnTurnChanged += TurnSystem_OnTurnChanged;
        UpdateTurnText();
        UpdateEnemyTurnVisual();
        UpdateEndTurnButtonVisibility();
    }
    private void TurnSystem_OnTurnChanged(object sender, EventArgs e){
        UpdateTurnText();
        UpdateEnemyTurnVisual();
        UpdateEndTurnButtonVisibility();
    }
    private void UpdateTurnText() {
        turnText.text = "TURN: "+ TurnSystem.Instance.GetTurnNumber().ToString();
    }

    private void UpdateEnemyTurnVisual(){
        enemyTurnVisualGameObject.SetActive(!TurnSystem.Instance.IsPlayerTurn());
    }

    private void UpdateEndTurnButtonVisibility(){
        endTurnButton.gameObject.SetActive(TurnSystem.Instance.IsPlayerTurn());
    }

}
