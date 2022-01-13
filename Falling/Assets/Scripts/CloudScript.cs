using System;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public class CloudScript : MonoBehaviour
{
    private Vector3 _targetPosition;
    public static Sprite CloudSprite;
    

    private void Start()
    {
        _targetPosition = transform.position;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = CloudSprite;
    }

    private void FixedUpdate()
    {
        
        _targetPosition += Vector3.up * SpawnCloud.CloudSpeed * Time.fixedDeltaTime;
        transform.position = Vector3.Lerp(transform.position, _targetPosition, 10 * Time.fixedDeltaTime);

        if (transform.position.y >= 3.36f)
        {
            Destroy(this.gameObject);
        }
        

    }
    
}
