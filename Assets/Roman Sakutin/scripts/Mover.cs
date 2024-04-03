using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection; //показывает юнити, что надо отобразить в испекторе
    void Update()
    {
        transform.Translate(_movementDirection); //сдвигает в указанном направлении персонажа
        //transform.Translate(_movementDirection, Space.Self); //сдвигает в локальных координатах
        //transform.Translate(_movementDirection, Space.World); //сдвигает в глобальных координатах
    }
}
