using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private GameObject _rowObject;
    [SerializeField] private float _rowSpaceing;
    
    [SerializeField] private GameObject _boxGrid;
    [SerializeField] private GameObject _boxObject;
    
    
    
    [SerializeField]private float _scale;
    // Start is called before the first frame update
    void Start()
    {
        var row = Instantiate(_boxObject);
        GridActivation();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void GridActivation()
    {
       
        Ground.WordleList = new GameObject[5, 5];
        //Creates 5 rows of 5 letterboxes placements
        for (int i = 0; i < 5; i++)
        {
            //Instantiate the position of the row
            Transform row = Instantiate(_rowObject, _boxGrid.transform).transform;
            row.localScale = row.transform.localScale;
            //Makes the objects containing the letterboxes smaller to create gaps between the letters
            _boxGrid.transform.localScale = Vector3.one * _scale;
            for (int k = 0; k < 5; k++)
            {
                //Instantiate the letterboxes inside the row object
                Ground.WordleList[i, k] = Instantiate(_boxObject, row); 
                //Downscale the size of the object to decrease the area of the grid
                Ground.WordleList[i, k].transform.localScale = Vector3.one * _scale;
            }
        }
    }
}

public static class Ground
{
    public static GameObject[,] WordleList;
}
