using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    public float PipeMoveSpeed;

    
    void Update()
    {
        transform.position += Vector3.left * PipeMoveSpeed * Time.deltaTime;
    }
}
