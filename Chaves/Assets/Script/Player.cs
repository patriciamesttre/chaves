using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forcejump;
    

    bool groundCheck;

    SpriteRenderer player;
    Animator animacao;

    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        animacao = GetComponent<Animator>();
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            animacao.SetBool("move", true);
        }

        else
        {
            animacao.SetBool("move", false);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * 0.05f);
            player.flipX = false;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * 0.05f);
            player.flipX = true;
        }

        if(Input.GetButtonUp("Jump") && groundCheck == true)
        {
            groundCheck = true;
            body.AddForce(new Vector2(0, forcejump));
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "pirulito")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "barril")
        {
            Destroy(this.gameObject);
            print("Game Over!");
        }

        if (collision.gameObject.tag == "bee")
        {
            Destroy(this.gameObject);
            print("Game Over!");
        }

    }
}
