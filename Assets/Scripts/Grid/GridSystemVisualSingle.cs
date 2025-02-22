using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemVisualSingle : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    

    private void Start() {
        Hide();
    }
    public void Show(Material material){
        meshRenderer.enabled = true;
        meshRenderer.material = material;
    }
    public void Hide(){
        meshRenderer.enabled = false;
    }
}
