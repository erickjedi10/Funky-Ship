using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sCROLLING : MonoBehaviour
{
    private Rigidbody2D RGBD;
    

     void Awake()
    {
        RGBD = GetComponent<Rigidbody2D>();
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
        RGBD.velocity = new Vector2(gamcontroller.gami.speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gamcontroller.gami.gameOver == true) 
        {
            RGBD.velocity = Vector2.zero;
        
        }
    }
}
