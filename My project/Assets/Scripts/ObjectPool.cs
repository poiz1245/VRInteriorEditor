using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [SerializeField] GameObject[] poolingObjectPrefab;

    Queue<PreviewControll> previewObjectQueue = new Queue<PreviewControll>();

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

    private void Initialize()
    {
        for(int i = 0; i < poolingObjectPrefab.Length; i++)
        {
            previewObjectQueue.Enqueue(CreateNewObject());
        }
    }

    private PreviewControll CreateNewObject()
    {
        PreviewControll newObject = Instantiate(poolingObjectPrefab[0]).GetComponent<PreviewControll>();
        newObject.gameObject.SetActive(false);
        newObject.transform.SetParent(transform);
        return newObject;
    }

    public static PreviewControll GetObject()
    {
        if(Instance.previewObjectQueue.Count > 0)
        {
            PreviewControll obj = Instance.previewObjectQueue.Dequeue();
            obj.transform.SetParent(null);
            obj.gameObject.SetActive(true);
            return obj;
        }
        else
        {
            PreviewControll newObject = Instance.CreateNewObject();
            newObject.transform.SetParent(null);
            newObject.gameObject.SetActive(true);
            return newObject;

        }
    }

    public static void ReturnObject(PreviewControll obj)
    {
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(Instance.transform);
        Instance.previewObjectQueue.Enqueue(obj);
    }
}
