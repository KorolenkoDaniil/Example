using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] public Transform Target;
    [SerializeField] public float Speed;
    void Update()
    {
        var direction = Target.position - transform.position.normalized;
        transform.Translate(direction * Speed);
    }

    protected virtual void Move() { }
}
