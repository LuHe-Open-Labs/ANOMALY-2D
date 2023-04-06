using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRay : MonoBehaviour
{
    public bool ShowRays = false;
    public bool PreyInFront = false;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Prey")
        {
            PreyInFront = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        PreyInFront = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowRays)
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            Color color = spriteRenderer.color;
            color.a = 1f; // Set the alpha value to 0 to make it transparent
            spriteRenderer.color = color; // Apply the new color to the sprite renderer
        } else
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            Color color = spriteRenderer.color;
            color.a = 0f; // Set the alpha value to 0 to make it transparent
            spriteRenderer.color = color; // Apply the new color to the sprite renderer
        }
    }
}