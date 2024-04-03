using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleLogger : MonoBehaviour
{
    // Start is called before the first frame update
    //private void Start()
    //{
    //    Debug.Log("Game Started");
    //}

    //// Update is called once per frame
    //private void Update()
    //{
    //    Debug.Log("New cadr");
    //}


    private void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    private void Update()
    {
        float vertical = Input.GetAxis("Horizontal");
        float horizontal = Input.GetAxis("Horizontal");
        Debug.LogFormat("{Horizontal:{0} Vertical:{1}", horizontal, vertical);
    }
}
