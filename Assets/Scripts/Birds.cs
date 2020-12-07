using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{

    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float upforce = 100f;
    private Animator animacion;
    public ControllTouch boton;
    // Start is called before the first frame update

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false && Input.GetKeyDown(KeyCode.A) || isDead == false && boton.pulsar == true ) 
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upforce));
            animacion.SetTrigger("Flap");
            SoundSystem.sonidito.PlayFlap();
            //rb2d.AddForce(Vector2.up * upforce);
        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2)
    {
        isDead = true;
        animacion.SetTrigger("Die");
        gamcontroller.gami.birdDie();
        rb2d.velocity = Vector2.zero;
        SoundSystem.sonidito.PlayImpact();
    }
}
