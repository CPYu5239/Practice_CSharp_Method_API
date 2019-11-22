using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Tooltip("角色移動速度")]
    [Range(0.1f, 99.9f)]
    public float speed = 1f;

    public Rigidbody2D rig;
    public SpriteRenderer psr;

    private void FoxMove()
    { 
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            Vector3 vecR = new Vector3(speed * Time.deltaTime, 0, 0);
            psr.transform.Translate(vecR);
            psr.flipX = false;
            rig.AddForce(new Vector2(speed * Time.deltaTime, 0));
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            Vector3 vecL = new Vector3(-speed * Time.deltaTime, 0, 0);
            psr.transform.Translate(vecL);
            psr.flipX = true;
            rig.AddForce(new Vector2(-speed * Time.deltaTime, 0));
        }
    }
    
    private void FixedUpdate()
    {
        FoxMove();
    }
}
