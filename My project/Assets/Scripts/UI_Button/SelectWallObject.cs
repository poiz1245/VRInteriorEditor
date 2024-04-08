using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWallObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;

    public void SelectButton()
    {
        PreviewSpawner.Instance.selectedObjectCategory = 1;
        PreviewSpawner.Instance.objPreviewPrefab = selectedObjectPreview;
        ObjectSpawner.Instance.selectedObject = selectedObject;
        State.Instance.currentState = State.CurrentState.Build;
    }
}
