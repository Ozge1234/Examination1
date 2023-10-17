using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alternativemovement : MonoBehaviour
{
    public bool Variety3 = false;
    public bool OldAlternateMovement = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OldAlternateMovement == true)
        {
            transform.Translate(.02f, 0, 0 * .1f);
            transform.Rotate(0, 0, .2f, Space.Self);
        }
        
        if(Variety3 == true)
        {
            transform.position = transform.position + new Vector3(Random.Range(-.01f, .01f), Random.Range(-.01f, .01f), Random.Range(0, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "dontforgettoupdatethetag")
        {
            print("got me");
            Destroy(other.gameObject);
            transform.localScale += new Vector3(.5f, .5f, 0);
        }
    }

}

