using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [SerializeField] GameObject[] objectPrefab;

    List<GameObject>[] pool;

    public int objectNumber;

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
        pool = new List<GameObject>[objectPrefab.Length];

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = new List<GameObject>();
        }
    }

    public static GameObject GetObject(int index)
    {
        GameObject select = null;

        foreach(GameObject obj in Instance.pool[index])
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
            select = Instantiate(Instance.objectPrefab[index], Instance.transform);
            Instance.pool[index].Add(select);
        }

        return select;
    }

    public static void ReturnObject(GameObject obj)
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(Instance.transform);
        //Instance.previewObjectQueue.Enqueue(obj);
    }
}
