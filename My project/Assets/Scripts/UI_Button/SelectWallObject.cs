using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWallObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;
    [SerializeField] int objectNumber;
    public void SelectButton()
    {
        PreviewSpawner.Instance.selectedObjectCategory = 1;
        ObjectPool.Instance.objectNumber = objectNumber;
        /*PreviewSpawner.Instance.objPreviewPrefab = selectedObjectPreview;
        ObjectSpawner.Instance.selectedObject = selectedObject;*/
        StateManager.Instance.currentState = StateManager.CurrentState.Build;
    }
}
