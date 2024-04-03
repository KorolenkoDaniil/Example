using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class AdaptiveFollower : Follower {

    //[SerializeField] private Transform _target;
    //[SerializeField] private float _lenghtRay;
    //[SerializeField] private Vector3 _offset;
    

    //void Start()
    //{
    //    _offset = transform.position - _target.position;    
    //}

    //// Update is called once per frame
    //protected override void Move()
    //{
    //    transform.position = _target.position + _offset;
    //    transform.RotateAround(_target.position, Vector3.up, Speed);
    //    transform.LookAt(_target.position);
    //    _offset = transform.position - _target.position;
    //    Debug.DrawRay(transform.position, transform.forward * _lenghtRay, Color.red);
    //}
    protected override void Move()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position, Speed);
    }
}
