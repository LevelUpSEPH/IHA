using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] private float _sensitivity;
    private Vector2 rotation = Vector2.zero;
    [SerializeField] private float _yRotationLimit = 90f  ;

    // Update is called once per frame
    void Update()
    {
        rotation.x += Input.GetAxis("Mouse X") * _sensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * _sensitivity;
        rotation.y = Mathf.Clamp(rotation.y, - _yRotationLimit, _yRotationLimit);
        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);
        transform.localRotation = xQuat * yQuat;
    }
}
