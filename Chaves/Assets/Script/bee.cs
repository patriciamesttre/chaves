using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bee : MonoBehaviour
{

    float vel, scaleX, scaleY;




        // Start is called before the first frame update
        void Start()
    {
        vel = 0.03f;
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * vel);

        if (transform.position.x >= 7.74f)
        {
            vel = -0.03f;
            transform.localScale = new Vector2(-scaleX, scaleY);
        }

        if (transform.position.x <= -7.74f)
        {
            vel = 0.03f;
            transform.localScale = new Vector2(scaleX, scaleY);
        }
    }
}
