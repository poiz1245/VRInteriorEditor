using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFloorObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;

    public void SelectButton()
    {
        EditMode editMode = selectedObject.GetComponent<EditMode>();

        PreviewSpawner.Instance.selectedObjectCategory = 2;
        PreviewSpawner.Instance.objectID = editMode.myObjectID;
        StateManager.Instance.currentState = StateManager.CurrentState.Build;
    }
}
