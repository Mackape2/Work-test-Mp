using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private GameObject _rowObject;

    [SerializeField] private GameObject _boxGrid;
    [SerializeField] private GameObject _boxObject;

    [SerializeField]private float _SetRowAmount;
    [SerializeField]private float _SetColumAmount;
    
    
    [SerializeField]private float _scale;
    // Start is called before the first frame update
    void Start()
    {
        GameData.AmountOfRows = _SetRowAmount;
        GameData.AmountOfColums = _SetColumAmount;
        
        GridActivation();
    }
    
    void GridActivation()
    {
       
        GameData.WordleList = new GameObject[(int)GameData.AmountOfRows, (int)GameData.AmountOfColums];
        //Creates 5 rows of 5 letterboxes placements
        for (int i = 0; i < GameData.AmountOfRows; i++)
        {
            //Instantiate the position of the row
            Transform row = Instantiate(_rowObject, _boxGrid.transform).transform;
            row.localScale = row.transform.localScale;
            //Makes the objects containing the letterboxes smaller to create gaps between the letters
            _boxGrid.transform.localScale = Vector3.one * _scale;
            for (int k = 0; k < GameData.AmountOfColums; k++)
            {
                //Instantiate the letterboxes inside the row object
                GameData.WordleList[i, k] = Instantiate(_boxObject, row); 

            }
        }
    }
}

public static class GameData
{
    public static GameObject[,] WordleList;
    
    public static float AmountOfRows;
    public static float AmountOfColums;
}
