using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField] GameObject selectedObj;

    public void SelectButton()
    {
        Test.Instance.objPreviewPrefab = selectedObj;
    }
}
