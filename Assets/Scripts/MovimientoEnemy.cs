using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemy : MonoBehaviour {


    private Rigidbody2D rigiBody = null;
    private Animator anim = null;

    private SpriteRenderer spriRender = null;
    private AudioSource audio = null;
    public Transform pointDisparo;
    public Transform bala;
    public List<AudioClip> sonidos = new List<AudioClip>();

    public float speed = 0.1f;

    // Use this for initialization
    void Start () {

        rigiBody = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {

        rigiBody.velocity = new Vector2(speed * -1, rigiBody.velocity.y);
        anim.SetFloat("horizontal", speed*-1);
        anim.SetTrigger("attack");
        /*Transform balaIns = Instantiate(bala, pointDisparo.position, pointDisparo.localRotation);
        Physics2D.IgnoreCollision(balaIns.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
        SonidoID(0);*/

    }

    private void SonidoID(int id)
    {
        audio.clip = sonidos[id];
        audio.Play();
    }
}
