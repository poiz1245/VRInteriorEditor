using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] GameObject activePanel;

    public void TurnOffPanel()
    {
        UIManager.Instance.currentPanel.SetActive(false);
        activePanel.SetActive(true);

        UIManager.Instance.currentPanel = activePanel;
    }
}
