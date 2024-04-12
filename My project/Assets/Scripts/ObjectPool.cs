using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [SerializeField] GameObject[] objectPrefab;

    List<GameObject>[] objectPool;

    public int objectID;

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
        objectPool = new List<GameObject>[objectPrefab.Length];

        for (int i = 0; i < objectPool.Length; i++)
        {
            objectPool[i] = new List<GameObject>();
        }
    }

    public static GameObject GetObject(int index)
    {
        GameObject select = null;

        foreach (GameObject obj in Instance.objectPool[index])
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
            Instance.objectPool[index].Add(select);
        }

        return select;
    }
}
