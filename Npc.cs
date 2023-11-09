using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    int level;
    int health;
    Vector3 new_pos;
    float speed = 1.5f;
    void Start()
    {
        level = 1;
        health = 10;
        health = health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        new_pos = transform.position;
        new_pos.x += speed * Time.deltaTime;
        transform.position = new_pos;
    }
}
