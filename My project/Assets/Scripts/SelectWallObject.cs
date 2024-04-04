using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWallObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObjectPreview;
    [SerializeField] GameObject selectedObject;

    public void SelectButton()
    {
        PreviewSpawner.Instance.objPreviewPrefab = selectedObjectPreview;
        ObjectSpawner.Instance.selectedObject = selectedObject;
        PreviewSpawner.Instance.selectedObjectCategory = 1;

    }
}
