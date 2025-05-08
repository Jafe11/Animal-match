using System;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;

    public float CameraSizeOffset;
    public float CameraVerticalOffset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupBoard();
        PositionCamera();
    }

    private void PositionCamera()
    {
        float newPosx = (float)width / 2f;
        float newPosy = (float)height / 2f;

        Camera.main.transform.position = new Vector3(newPosx - 0.5f, newPosy - 0.5f + CameraVerticalOffset, -10);
        
        float horizontal = width + 1;
        float vertical = (height / 2) + 1;
    
        Camera.main.orthographicSize = horizontal > vertical ? 
            horizontal + CameraSizeOffset : vertical + CameraSizeOffset;
    }

    private void SetupBoard()
    {
        for (int x = 0; x < width; x++) 
        {
            for (int y = 0; y < height; y++)
            {
                var o = Instantiate(tilePrefab, new Vector3(x, y, -5), Quaternion.identity);
                o.transform.parent = transform;
                o.GetComponent<Tile>().Setup(x, y, this);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
