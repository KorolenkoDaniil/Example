using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Leader : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoinnts;
    [SerializeField] private float _speed;

    private int _currentWayPoint = 0;

    private void Update()
    {
        if (transform.position == _wayPoinnts[_currentWayPoint].position)
        {
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoinnts.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _wayPoinnts[_currentWayPoint].position, _speed * Time.deltaTime);
    }
}
