using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SpinAction : BaseAction
{

    private float totalSpinAmount;


    private void Update()
    {

        if (!isActive)
        {
            return;
        }

        float spinAddAmound = 360f * Time.deltaTime;
        transform.eulerAngles += new Vector3(0, spinAddAmound, 0);

        totalSpinAmount += spinAddAmound;
        if (totalSpinAmount >= 360f)
        {


            ActionComplete();
        }
    }
    public override void TakeAction(GridPosition gridPosition, Action onActionComplete)
    {
        totalSpinAmount = 0f;

        ActionStart(onActionComplete);

    }

    public override string GetActionName()
    {
        return "Spin";
    }
    public override List<GridPosition> GetValidActionGridPositionList()
    {
        List<GridPosition> validGridPositionList = new List<GridPosition>();

        GridPosition unitGridPosition = unit.GetGridPosition();
        return new List<GridPosition>{
            unitGridPosition
        };
    }

    public override int GetActionPointsCost()
    {
        return 1;
    }
    public override EnemyAIAction GetEnemyAIAction(GridPosition gridPosition)
    {
        return new EnemyAIAction{
            gridPosition = gridPosition,
            actionValue = 0,
        };
    }

}
