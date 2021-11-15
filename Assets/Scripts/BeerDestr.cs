using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerDestr : MonoBehaviour
{

    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player"&& gameObject.tag == "Beer")
        {
            Destr();
        }
    }
    public void Destr()
    {
        Destroy(gameObject);
    }
}
