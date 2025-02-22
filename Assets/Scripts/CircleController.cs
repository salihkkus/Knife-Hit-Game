using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    [SerializeField] private float RotateSpeed;

    void Update()
    {
        SetRotateCircle();
    }

    private void SetRotateCircle()//,
    {
        transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
    }
}
