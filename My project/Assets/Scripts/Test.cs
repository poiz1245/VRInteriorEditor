using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Test : MonoBehaviour
{
    [SerializeField] LayerMask raycastLayerMask;
    [SerializeField] Transform controllerPos;
    [SerializeField] GameObject obj;

    public void Spawn()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(controllerPos.position, controllerPos.forward, out hitInfo,10f , raycastLayerMask))
        {
            Instantiate(obj, hitInfo.point, Quaternion.identity);
        }
    }

    public void DeSpawn()
    {
        print("bbb");

    }


}
