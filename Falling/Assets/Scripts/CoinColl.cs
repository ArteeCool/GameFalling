using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;




public class CoinColl : MonoBehaviour
{
    public float Speed;
    public static Vector3 CoinMove;

    
    private Vector3 _targetPosition;

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Collision Enter" + collision);
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            CoinScript.Coins++;
        }
        else if (collision.gameObject.tag == "Cloud")
        {
            Destroy(this.gameObject);
            Debug.Log("In Cloud");
        }
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



    private void Start()
    {
        _targetPosition = transform.position;
    }
    
    

    
    
}
