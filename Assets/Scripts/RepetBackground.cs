using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetBackground : MonoBehaviour
{
    private BoxCollider2D groung;
    private float horizontal;

    private void Awake()
    {
        groung = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        horizontal = groung.size.x;
        
    }

    void RepositionBackground() 
    {
        transform.Translate(Vector2.right* horizontal*2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -horizontal) 
        {
            RepositionBackground();
        }
        
    }
}
