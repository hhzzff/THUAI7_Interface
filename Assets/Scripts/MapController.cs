using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : SingletonMono<MapController>
{
    // Start is called before the first frame update
    public GameObject[] plate;
    void Start()
    {
        for (int i = 1; i <= 50; i++) {
            for (int j = 1; j <= 50; j++) {
                Instantiate(plate[0], new Vector2((i - 25), -(j - 25)), Quaternion.identity, transform).GetComponent<SpriteRenderer>().sortingLayerName = "BackGround";
            }
        }
        for (int i = 1; i <= 50; i++) {
            for (int j = 1; j <= 50; j++) {
                if (i == 1 || i == 50 || j == 1 || j == 50) {
                    System.Random r = new System.Random();
                    Instantiate(plate[r.Next(1, 3)], new Vector2((i - 25), -(j - 25)), Quaternion.identity, transform);
                } else {
                    if(i == 2)
                        Instantiate(plate[3], new Vector2((i - 25), -(j - 25)), Quaternion.identity, transform);

                    if((i == 4 && j == 47) || (i == 47 && j == 4))
                        Instantiate(plate[4], new Vector2((i - 25), -(j - 25)), Quaternion.identity, transform);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
