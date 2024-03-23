using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField] GameObject selectedObj;
    [SerializeField] Transform rightHandPos;

    public void SelectButton()
    {
        Instantiate(selectedObj, rightHandPos);
    }
}
