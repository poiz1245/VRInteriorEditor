using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class PreviewObjectPool : MonoBehaviour
{
    public static PreviewObjectPool Instance;

    [SerializeField] GameObject[] previewObjectPrefab;

    List<GameObject>[] previewObjectPool;

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

        Initialize();
    }

    private void Initialize()
    {
        previewObjectPool = new List<GameObject>[previewObjectPrefab.Length];

        for (int i = 0; i < previewObjectPool.Length; i++)
        {
            previewObjectPool[i] = new List<GameObject>();
        }
    }

    public static GameObject GetPreviewObject(int index)
    {
        GameObject select = null;

        foreach(GameObject obj in Instance.previewObjectPool[index])
        {
            if (!obj.activeSelf)
            {
                select = obj;
                select.SetActive(true);
                break;
            }
        }

        if (!select)
        {
            select = Instantiate(Instance.previewObjectPrefab[index], Instance.transform);
            Instance.previewObjectPool[index].Add(select);
        }

        return select;
    }
}
