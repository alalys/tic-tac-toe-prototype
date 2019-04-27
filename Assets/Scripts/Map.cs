using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public Transform tilePrefab;
    public Vector2 mapSize;

    public Transform[,] allTiles;

    [Range(0,1)]
    public float outlineRange;

    void Start()
    {
        GenerateMap();
    }

    public void GenerateMap()
    {
        for(int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                Vector3 tilePosition = new Vector3(-mapSize.x/2+.5f+x, 0, -mapSize.y/2+.5f+y);
                Transform newTile = Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.right * 1));
                newTile.localScale = Vector3.one * (1 - outlineRange);
                newTile.parent = this.transform;
            }
        }
    }
}
