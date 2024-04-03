using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(1, 1, 0); //вращение обьекта в данном случае только по оси Y   
        //transform.Rotate(0, 5, 5); //вращение обьекта теперь еще по Z   
        //transform.RotateAround(transform.position, transform.up, 2f * Time.deltaTime); //вращение вокруг оси    
    }
}
