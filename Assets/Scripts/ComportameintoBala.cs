using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportameintoBala : MonoBehaviour {

    private Rigidbody2D rigidbody = null;
    public float speedBala = 5.0f;
    private AudioSource audioS = null;
    public Transform particulaE;
    public Transform psangre;
    // Use this for initialization
    void Start () {
        rigidbody = this.GetComponent<Rigidbody2D>();
        audioS = this.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        rigidbody.velocity = new Vector2((2 * speedBala), 0);
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        ContactPoint2D contact = col.contacts[0];
        Quaternion rotacion = Quaternion.FromToRotation(Vector3.up, contact.normal);
        audioS.Play();
        Instantiate(particulaE, contact.point, rotacion);
        //Instantiate(psangre, contact.point, rotacion);
        Destroy(this.gameObject, 1.0f);
        if (col.gameObject.tag == "Enemy")
        {

            Destroy(col.gameObject);
            GameInformation.NumMonedas = GameInformation.NumMonedas + 1;

        }
        if(col.gameObject.tag == "caja")
        {
            Destroy(col.gameObject);
        }
    }
}
