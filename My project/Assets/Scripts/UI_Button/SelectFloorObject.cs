using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFloorObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;
    [SerializeField] int objectNumber;
    public void SelectButton()
    {
        PreviewSpawner.Instance.selectedObjectCategory = 2;
        PreviewSpawner.Instance.objectNumber = objectNumber;
        StateManager.Instance.currentState = StateManager.CurrentState.Build;
    }
}
