using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformDirected : MovingPlatform
{
    [SerializeField] private Vector3 _direction = new Vector3(0, 0, -0.5f);
    public override void Move()
    {
        transform.position += _direction * Time.deltaTime;
    }
}