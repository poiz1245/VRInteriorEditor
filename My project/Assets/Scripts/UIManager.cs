using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject activePanel { get; set; }
    public GameObject previousPanel { get; set; }
    public GameObject currentPanel { get; set; }

    [SerializeField] GameObject dummyPanel;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentPanel = dummyPanel;
    }
}
