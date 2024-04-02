using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Test : MonoBehaviour
{
    public static Test Instance;

    public Vector3 rayPos;
    public GameObject objPreviewPrefab;
    public Vector3 eulerAngle;
    public int spawnedObjectCategory;

    GameObject objPreviewinstance;

    [SerializeField] Transform controllerPos;
    [SerializeField] bool isActive;

    int hitLayer;
    LayerMask raycastLayerMask;
    RaycastHit hitInfo;

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

    private void Start()
    {
        isActive = false;
    }

    private void Update()
    {
        if (spawnedObjectCategory == 1)
        {
            raycastLayerMask = (1 << 8) | (1 << 9) | (1 << 10);
        }
        else if(spawnedObjectCategory == 2)
        {
            raycastLayerMask = 7;
        }

        Spawn();
    }

    public void Spawn()
    {
        if (Physics.Raycast(controllerPos.position, controllerPos.forward, out hitInfo, 10f, raycastLayerMask))
        {
            hitLayer = hitInfo.collider.gameObject.layer;

            EulerSetting();

            if (!isActive && objPreviewinstance == null && objPreviewPrefab != null)
            {
                objPreviewinstance = Instantiate(objPreviewPrefab, hitInfo.point, Quaternion.Euler(eulerAngle));
                isActive = true;
            }

            rayPos = hitInfo.point;
        }
        else if (isActive)
        {
            Destroy(objPreviewinstance);
            objPreviewinstance = null;
            isActive = false;
        }


    }
    private void EulerSetting()
    {
        if (hitLayer == 8)
        {
            eulerAngle = new Vector3(0, -90, 0);
        }
        else if (hitLayer == 9)
        {
            eulerAngle = new Vector3(0, 90, 0);
        }
        else if (hitLayer == 10)
        {
            eulerAngle = new Vector3(0, 0, 0);
        }
        else if(hitLayer == 7)
        {
            eulerAngle = new Vector3(0, 0, 0);
        }
    }
}
