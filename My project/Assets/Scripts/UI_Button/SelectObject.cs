using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;

    public void SelectButton()
    {
        EditMode editMode = selectedObject.GetComponent<EditMode>();

        PreviewSpawner.Instance.selectedObjectCategory = editMode.myObjectCategory;
        PreviewSpawner.Instance.objectID = editMode.myObjectID;
        StateManager.Instance.currentState = StateManager.CurrentState.Build;
    }
}
