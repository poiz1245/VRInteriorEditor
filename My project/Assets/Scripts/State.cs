using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public enum CurrentState
    {
        Normal,
        Build,
        Delete
    }

    public CurrentState currentState;

    void Start()
    {
        currentState = CurrentState.Normal;
    }
}
