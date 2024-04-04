using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWallObject : MonoBehaviour
{
    [SerializeField] GameObject selectedObj;

    public void SelectButton()
    {
        PreviewSpawner.Instance.objPreviewPrefab = selectedObj;
        PreviewSpawner.Instance.spawnedObjectCategory = 1;

    }
}
