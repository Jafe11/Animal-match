using System;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int weidth;
    public int height;
    public GameObject tilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupBoard();
    }

    private void SetupBoard()
    {
        for (int x = 0; x < weidth; x++) 
        {
            for (int y = 0; y < height; y++)
            {
                var o = Instantiate(tilePrefab, new Vector3(x, y, -5), Quaternion.identity);
                o.transform.parent = transform;


            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
