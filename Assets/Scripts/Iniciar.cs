using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public bool inicio;
    public ControllTouch boton;

    // Update is called once per frame
    void Update()
    {
        if (boton.pulsar == true && inicio == true) 
        {
            SceneManager.LoadScene(1);

        
        }

        
    }
}
