using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetPractice : MonoBehaviour
{    
    RaycastHit hitBig,hitMid, hitSmall;
    [SerializeField] private GameObject _player;

    bool hitDetectBig, hitDetectMedium, hitDetectSmall;
    [SerializeField] private int _points = 0;
    [SerializeField] private Transform target;

    private Vector3 targetPos;
    [SerializeField] Image targetImage;


    [SerializeField] Camera mainCam;
    void Start() {
        Camera.main.transform.LookAt(target);
    }

    void FixedUpdate()
    {        
        if (Input.GetMouseButton(0))
        {
            SetTarget();
            hitDetectBig = Physics.BoxCast(mainCam.transform.position, Vector3.one * 20, targetPos.normalized, out hitBig, mainCam.transform.rotation);
            hitDetectMedium = Physics.BoxCast(mainCam.transform.position, new Vector3(13, 13, 13), targetPos.normalized, out hitMid, mainCam.transform.rotation);
            hitDetectSmall = Physics.BoxCast(mainCam.transform.position, new Vector3(8f, 8f, 8f), targetPos.normalized, out hitSmall, mainCam.transform.rotation);

            if (hitDetectSmall) {
                if (hitSmall.collider.tag == "Target") {
                    Debug.Log(hitSmall.transform.name);
                    _points += 5;
                    targetImage.color = Color.green;
                    return;
                }
            }

            else if (hitDetectMedium) {
                if (hitMid.collider.tag == "Target") {
                    Debug.Log(hitMid.transform.name);
                    _points += 5;
                    targetImage.color = Color.yellow;
                    return;
                }
            }

            else if (hitDetectBig) {
                if (hitBig.collider.tag == "Target") {
                    Debug.Log(hitBig.transform.name);
                    _points += 5;
                    targetImage.color = Color.white;
                    return;
                }
            }
            else
                targetImage.color = Color.red;
        }
    }

    private void SetTarget() {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
            targetPos = hit.transform.position;
            if (hit.collider.gameObject.CompareTag("Target")) {
                _points += 5;
                Debug.Log(hit.transform.name + "Found!");
            }
                
        }
    }
}
