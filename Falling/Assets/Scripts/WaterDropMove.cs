using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropMove : MonoBehaviour
{
    public static Vector3 _targetPosition;
    public static float WaterDropSpeed = 2.5f;
    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void FixedUpdate()
    {
        
        _targetPosition += Vector3.down * WaterDropSpeed * Time.fixedDeltaTime;
        if (transform.position.y >= -10.0f)
        {
            Destroy(this.gameObject);
        }
        

    }
}
