using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.LookAt(target);
    }
    RaycastHit colWorst,colMid, colBest;
    [SerializeField] private GameObject _player;
    public Color imgColor = Color.white;
    bool hitDetectBig, hitDetectMedium, hitDetectSmall;
    [SerializeField] private int _points = 0;
    [SerializeField] private Transform target;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            hitDetectBig = Physics.BoxCast(Camera.main.transform.position, Vector3.one, Camera.main.transform.forward, out colWorst);
            hitDetectMedium = Physics.BoxCast(Camera.main.transform.position, new Vector3(0.3f, 0.3f, 0.3f), Camera.main.transform.forward, out colMid);
            hitDetectSmall = Physics.BoxCast(Camera.main.transform.position, new Vector3(0.1f, 0.1f, 0.1f), Camera.main.transform.forward, out colBest);

            if (hitDetectBig || hitDetectMedium || hitDetectSmall)
            {
                if (colBest.collider.tag == "Target")
                {
                    _points += 5;
                    imgColor = Color.green;
                }
                else if (colMid.collider.tag == "Target")
                {
                    _points += 3;
                    imgColor = Color.yellow;
                }
                else if (colWorst.collider.tag == "Target")
                {
                    _points++;
                    imgColor = new Color(252, 119, 3, 1);
                }
                else
                {
                    // _points -= 3;
                    imgColor = Color.red;
                }
            }
        }
    }
}
