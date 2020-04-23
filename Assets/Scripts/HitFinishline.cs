using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFinishline : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject hitObj = collision.gameObject;

        if(hitObj.tag == "Player" )
        {
            //  transform.parent.gameObject.AddComponent<GameOverScript>();       
        }
    }
}
