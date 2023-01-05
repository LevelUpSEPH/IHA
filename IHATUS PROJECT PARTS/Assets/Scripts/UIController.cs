using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TargetPractice _targetPracticeRef;
    [SerializeField] private Image _lockOnScreen;
    void Start()
    {
        //_lockOnScreen.color = new Color(0, 0, 0, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButton(0))
            _lockOnScreen.color = new Color(_targetPracticeRef.imgColor.r, _targetPracticeRef.imgColor.g, _targetPracticeRef.imgColor.b, 0.3f);
        else
            _lockOnScreen.color = new Color(0, 0, 0, 0);*/
    }
}
