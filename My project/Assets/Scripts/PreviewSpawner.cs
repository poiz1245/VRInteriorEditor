using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PreviewSpawner : MonoBehaviour
{
    public static PreviewSpawner Instance;

    public Vector3 rayPos;
    public Vector3 eulerAngle;
    public int selectedObjectCategory;

    public GameObject objPreviewPrefab;
    //[SerializeField] GameObject objPreviewinstance;
    [SerializeField] PreviewControll objPreviewinstance;

    [SerializeField] Transform controllerPos;
    public bool isActive { get; private set; }

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
        LayerMaskSetting();

        if (StateManager.Instance.currentState == StateManager.CurrentState.Build)
        {
            Spawn();
        }
        else
        {
            Despawn();
        }
    }

    public void Spawn()
    {
        if (Physics.Raycast(controllerPos.position, controllerPos.forward, out hitInfo, 10f, raycastLayerMask))
        {
            hitLayer = hitInfo.collider.gameObject.layer;
            EulerSetting();
            rayPos = hitInfo.point;
            if (!isActive)
            {
                objPreviewinstance = ObjectPool.GetObject();
                isActive = true;
            }
            /*if (!isActive && objPreviewinstance == null && objPreviewPrefab != null)
            {
                objPreviewinstance = Instantiate(objPreviewPrefab, hitInfo.point, Quaternion.Euler(eulerAngle));
                isActive = true;
            }*/
        }
        else if (isActive)
        {
            ObjectPool.ReturnObject(objPreviewinstance);
            isActive = false;
            //Despawn();
        }
    }

    private void Despawn()
    {
        Destroy(objPreviewinstance);
        objPreviewinstance = null;
        isActive = false;
    }

    private void LayerMaskSetting()
    {
        if (selectedObjectCategory == 1)
        {
            raycastLayerMask = (1 << 8) | (1 << 9) | (1 << 10);
        }
        else if (selectedObjectCategory == 2)
        {
            raycastLayerMask = (1 << 7);
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
    }
}
