using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Companiion : Follower
{

    [SerializeField] private Transform Leader;
    [SerializeField] private float _lenghtRay;
    [SerializeField] private Vector3 _offset;


    void Start()
    {
        _offset = transform.position - Target.position;
    }

    // Update is called once per frame
    protected override void Move()
    {
        transform.position = Target.position + _offset;
        transform.RotateAround(Target.position, Vector3.up, Speed);
        transform.LookAt(Target.position);
        _offset = transform.position - Target.position;
        Debug.DrawRay(transform.position, transform.forward * _lenghtRay, Color.red);
    }
}
