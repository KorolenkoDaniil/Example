using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("������ ������");
    }
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("������� �� �������");
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("���� ������");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("����� �� ��������");
    }
}
