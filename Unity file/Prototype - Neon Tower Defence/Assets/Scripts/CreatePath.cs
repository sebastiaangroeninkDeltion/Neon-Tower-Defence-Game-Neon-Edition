﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour
{

    public Vector2 mapSize;

    public Transform tile;

    [Range(0, 1)]
    public float tileSpacing;

    void Start()
    {
        GenerateMap();

    }

    void GenerateMap() // genereert door speler gegeven aantal tiles op 0,0,0 (worldspace) met een spacing ertussen.
    {
        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                Vector3 tilePos = new Vector3(-mapSize.x / 2 + 0.5f + x, 0, -mapSize.y / 2 + 0.5f + y);
                Transform newTile = Instantiate(tile, tilePos, Quaternion.Euler(Vector3.right * 90)) as Transform;
                newTile.localScale = Vector3.one * (1 - tileSpacing);
            }
        }
    }
}
