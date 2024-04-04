using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PreviewControll : MonoBehaviour
{
    public InputActionReference yawRotation;

    void Update()
    {
        if (PreviewSpawner.Instance.selectedObjectCategory == 1)
        {
            EulerSetting();
        }

        Move();

        ObjectSpawner.Instance.eulerAngle = transform.eulerAngles;
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
        transform.Rotate(0, 90, 0);
    }

    public void EulerSetting()
    {
        transform.rotation = Quaternion.Euler(PreviewSpawner.Instance.eulerAngle);
    }
    public void Move()
    {
        transform.position = PreviewSpawner.Instance.rayPos;
    }
}