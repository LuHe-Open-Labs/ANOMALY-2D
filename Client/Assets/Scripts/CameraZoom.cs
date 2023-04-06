using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scrollAmount = Input.GetAxis("Mouse ScrollWheel");
        if (scrollAmount > 0f)
        {
            if (!(Camera.main.orthographicSize-zoomSpeed <= 0))
            {
                Camera.main.orthographicSize -= zoomSpeed;
            }
        }
        else if (scrollAmount < 0f)
        {
            Camera.main.orthographicSize += zoomSpeed;
        }
    }
}
