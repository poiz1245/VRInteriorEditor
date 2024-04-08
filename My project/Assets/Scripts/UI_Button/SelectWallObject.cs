using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWallObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;
    [SerializeField] State stateManager;

    public void SelectButton()
    {
        PreviewSpawner.Instance.selectedObjectCategory = 1;
        PreviewSpawner.Instance.objPreviewPrefab = selectedObjectPreview;
        ObjectSpawner.Instance.selectedObject = selectedObject;
        stateManager.currentState = State.CurrentState.Build;
    }
}
