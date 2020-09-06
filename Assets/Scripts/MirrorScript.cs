using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : MonoBehaviour
{
    [SerializeField]
    Transform playerObject;
    [SerializeField]
    Transform cameraTransform;
    [SerializeField]
    Camera secondaryCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update () {
        Quaternion cameraRotation = cameraTransform.rotation;
        secondaryCamera.transform.rotation = cameraRotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerObject.position + new Vector3(0, 20, 0);
    }
}
