using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D rigiBody = null;
    private Animator anim = null;
    private SpriteRenderer spriRender = null;
    private AudioSource audio = null;
    public Transform pointDisparo;
    public Transform pointDisparoIzq;
    public Transform bala;
    public Transform balaIzq;
    public List<AudioClip> sonidos = new List<AudioClip>();

    public float speed = 5.0f;
    public float speddjump = 3.0f;

    // Use this for initialization
    void Start()
    {
        rigiBody = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
        spriRender = this.GetComponent<SpriteRenderer>();
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Los valores de v y h varian entre 1,0,-1
        float h = Input.GetAxis("Horizontal");

        rigiBody.velocity = new Vector2(h * speed, rigiBody.velocity.y);
        anim.SetFloat("horizontal", Mathf.Abs(h));
        //AL presionar la tecla X ataca dependiendo del derecha o izquierda
        if (Input.GetKeyDown(KeyCode.X) & spriRender.flipX==false)
        {
            
            anim.SetTrigger("attack");
            Transform balaIns = Instantiate(bala, pointDisparo.position, pointDisparo.localRotation);
            Physics2D.IgnoreCollision(balaIns.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
            SonidoID(1);

        }
        else if(Input.GetKeyDown(KeyCode.X) & spriRender.flipX==true)
        {
            
            anim.SetTrigger("attack");
            Transform balaIns = Instantiate(balaIzq, pointDisparoIzq.position, pointDisparoIzq.localRotation);
            Physics2D.IgnoreCollision(balaIns.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
            SonidoID(1);
        }

        //AL presionar la tecla Space salta
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigiBody.velocity = new Vector2(h * speed, 2 * speddjump);
            SonidoID(0);//Saltar
        }

        //Para voltear el personaje
        if(h>0.1f){
            spriRender.flipX=false;
        }
        else if(h<-0.1f){
            spriRender.flipX = true;
        }
    }

    private void SonidoID(int id)
    {
        audio.clip = sonidos[id];
        audio.Play();
    }
}
