using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField] GameObject selectedObj;
    [SerializeField] Transform objSpawnPos;
    [SerializeField] Transform rightController;

    public void SelectButton()
    {
        Test.Instance.objPreviewPrefab = selectedObj;
        Instantiate(selectedObj, objSpawnPos);
    }
}
