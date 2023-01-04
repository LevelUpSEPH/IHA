using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private NavMeshAgent _enemyAgent;
    [SerializeField] private List<Transform> path;
    private int _pathCounter= 0;
    void Start()
    {
        _enemyAgent.destination = path[_pathCounter].position;
        _pathCounter++;
    }

    // Update is called once per frame
    void Update()
    {
        if (_pathCounter == 0 && _enemyAgent.remainingDistance < 1)
        {
            _enemyAgent.destination = path[_pathCounter].position;
            _pathCounter++;
        }
        else if (_pathCounter == 1 && _enemyAgent.remainingDistance < 1)
        {
            _enemyAgent.destination = path[_pathCounter].position;
            _pathCounter++;
        }
        else if (_pathCounter == 2 && _enemyAgent.remainingDistance < 1)
        {
            _enemyAgent.destination = path[_pathCounter].position;
            _pathCounter++;
        }
        else if (_pathCounter == 3 && _enemyAgent.remainingDistance < 1)
        {
            _enemyAgent.destination = path[_pathCounter].position;
            _pathCounter = 0;
        }
    }
}