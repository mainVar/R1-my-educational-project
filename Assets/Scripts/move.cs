﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed=2f ;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    //  void OnMauseDrag()
    {
        //global point player (controller)
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // set game plane 
        //if (mousePos.x > 2.8f) ;

        //    mousePos.x = 2.8f;
        //else
        //    mousePos;
        mousePos.x = mousePos.x > 2.8f ? 2.8f : mousePos.x;
        mousePos.x = mousePos.x < -2.8f ? -2.8f : mousePos.x;
        mousePos.y = mousePos.y > 4.8f ? 4.8f : mousePos.y;
        mousePos.y = mousePos.y < -4.9f ? -4.9f : mousePos.y;

        player.position = Vector2.MoveTowards(player.position,
            new Vector2(mousePos.x, mousePos.y),
            speed * Time.deltaTime );
    } 
    
}