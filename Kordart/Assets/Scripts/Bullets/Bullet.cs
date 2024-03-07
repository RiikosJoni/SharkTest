using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float currentSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.down * currentSpeed * Time.deltaTime);
    }
}
