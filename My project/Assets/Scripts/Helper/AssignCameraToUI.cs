using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCameraToUI : MonoBehaviour
{
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();

        if(canvas != null)
        {
            canvas.worldCamera = Camera.main;
        }
    }
}
