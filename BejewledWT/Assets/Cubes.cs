using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    private float Deltatime = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Deltatime += Time.deltaTime;
        if (Deltatime >= 2)
        {
            transform.position = GameData.WordleList[Random.Range(0,(int)GameData.AmountOfRows),Random.Range(0,(int)GameData.AmountOfColums)].transform.position;
            Deltatime = 0;
        }
    }
}
