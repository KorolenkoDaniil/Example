using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(1, 1, 0); //�������� ������� � ������ ������ ������ �� ��� Y   
        //transform.Rotate(0, 5, 5); //�������� ������� ������ ��� �� Z   
        //transform.RotateAround(transform.position, transform.up, 2f * Time.deltaTime); //�������� ������ ���    
    }
}
