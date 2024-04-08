using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public static State Instance;

    public enum CurrentState
    {
        Normal,
        Build,
        Edit
    }

    public CurrentState currentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currentState = CurrentState.Normal;
    }
}
