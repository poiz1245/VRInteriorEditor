using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnedObject : MonoBehaviour
{
    public InputActionReference yawRotation;
    public InputActionReference pitchRotation;

    [SerializeField] float rotationSpeed = 1;

    void Update()
    {
        Rotation();
    }

    public void Rotation()
    {
        if (yawRotation.action.ReadValue<float>() > 0)
        {
            transform.Rotate(0, 1 * rotationSpeed, 0);
        }
        else if (pitchRotation.action.ReadValue<float>() > 0)
        {
            transform.Rotate(1 * rotationSpeed, 0, 0);
        }
    }
    public void Move()
    {

    }
}


