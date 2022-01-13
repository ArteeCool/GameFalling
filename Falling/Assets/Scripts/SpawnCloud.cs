using System;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public class SpawnCloud : MonoBehaviour
{
    public Transform Player;
    public GameObject Cloud;
    public GameObject WaterDrop;
    private static float _timer;
    private static float _timer1;
    private static float Timer;
    public float CloudSpawnTime;
    public float WaterDropSpawnTime;
    public static float CloudSpeed;
    public List<Sprite> _cloud;

    
    private void Start()
    {
        _timer1 = 4;
        Timer = 0;
        CloudSpeed = 2.5f;
    }

    private void Update()
    {
        if (Random.Range(0, 100) <= 10)
        {
            CloudScript.CloudSprite = _cloud[1];
        }
        else
        {
            CloudScript.CloudSprite = _cloud[0];
        }

        

        if (Time.time > _timer)
        {
            _timer = Time.time + CloudSpawnTime;
            var obj =  Instantiate(Cloud);
            obj.transform.position = new Vector3(Random.Range(-2.7f, 2.7f), -10, 0);
            Timer += 1;
        }
            
        if (Timer> _timer1)
        {
            _timer1 = Timer + WaterDropSpawnTime;
            if (Random.Range(0, 100) <= 50)
            {
                var obj =  Instantiate(WaterDrop);
                obj.transform.position = new Vector3(Player.position.x, 4, 0);
            }
        }
        
        CloudSpeed += 0.0003f;

    }
    

}
