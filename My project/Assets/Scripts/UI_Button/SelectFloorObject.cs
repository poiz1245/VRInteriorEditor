using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFloorObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;

    public void SelectButton()
    {
        PreviewSpawner.Instance.selectedObjectCategory = 2;
        PreviewSpawner.Instance.objPreviewPrefab = selectedObjectPreview;
        ObjectSpawner.Instance.selectedObject = selectedObject;
        StateManager.Instance.currentState = StateManager.CurrentState.Build;
    }
}
