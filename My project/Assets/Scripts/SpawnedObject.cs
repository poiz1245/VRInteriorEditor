using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnedObject : MonoBehaviour
{
    public InputActionReference yawRotation;

    void Update()
    {
        if(Test.Instance.spawnedObjectCategory == 1)
        {
            EulerSetting();
        }

        Move();
    }

    private void OnEnable()
    {
        yawRotation.action.performed += YawRotation;
    }
    private void OnDisable()
    {
        yawRotation.action.performed -= YawRotation;
    }

    public void YawRotation(InputAction.CallbackContext obj)
    {
        print("input yaw");
        transform.Rotate(0, 90, 0);
    }

    public void EulerSetting()
    {
        transform.rotation = Quaternion.Euler(Test.Instance.eulerAngle);
    }
    public void Move()
    {
        transform.position = Test.Instance.rayPos;
    }
}