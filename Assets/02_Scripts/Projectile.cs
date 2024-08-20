using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Movespeed;

    private void Update()
    {
        transform.Translate(transform.forward * Movespeed * Time.deltaTime);
    }
}
