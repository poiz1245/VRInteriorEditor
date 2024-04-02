using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObjectSpawn : MonoBehaviour
{
    [SerializeField] GameObject selectedObj;

    public void SelectButton()
    {
        Test.Instance.objPreviewPrefab = selectedObj;
        Test.Instance.spawnedObjectCategory = 2;

    }
}
