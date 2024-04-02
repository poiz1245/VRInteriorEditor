using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorObjectSpawn : MonoBehaviour
{
    [SerializeField] GameObject selectedObj;

    public void SelectButton()
    {
        Test.Instance.objPreviewPrefab = selectedObj;
        Test.Instance.spawnedObjectCategory = 1;

    }
}
