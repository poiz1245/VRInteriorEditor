using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Test : MonoBehaviour
{
    public static Test Instance;

    public Vector3 rayPos;
    public GameObject objPreviewPrefab;
    GameObject objPreviewinstance;


    [SerializeField] LayerMask raycastLayerMask;
    [SerializeField] Transform controllerPos;
    [SerializeField] bool isActive;

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
        Spawn();
    }

    public void Spawn()
    {
        if (Physics.Raycast(controllerPos.position, controllerPos.forward, out hitInfo, 10f, raycastLayerMask))
        {
            if (!isActive && objPreviewinstance == null)
            {
                objPreviewinstance = Instantiate(objPreviewPrefab, hitInfo.point, Quaternion.identity);
                isActive = true;
            }

            rayPos = hitInfo.point;
        }
        else
        {
            if (isActive)
            {
                Destroy(objPreviewinstance);
                objPreviewinstance = null;
                isActive = false;
            }
        }
    }
}
