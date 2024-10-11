using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{
    [SerializeField] private TextMeshPro gridDebugObjectText;
    private object gridObject;

    public virtual void SetGridObject(object gridObject){
        this.gridObject = gridObject;
        
    }

    protected virtual void Update() {
        gridDebugObjectText.text = gridObject.ToString();
    }
}
