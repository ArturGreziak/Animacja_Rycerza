using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BochaterController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalk", true);
        }
        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalk", false);
        }

        if (Input.GetKey("j"))
        {
            animator.SetBool("isJump", true);
        }
        if (!Input.GetKey("j"))
        {
            animator.SetBool("isJump", false);
        }
        if (Input.GetKey("a"))
        {
            animator.SetBool("isAttack", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isAttack", false); 
        }
        if (Input.GetKey("l"))
        {
            animator.SetBool("isTurnLeft", true);
        }
        if (!Input.GetKey("l"))
        {
            animator.SetBool("isTurnLeft", false);
        }
        if (Input.GetKey("r"))
        {
            animator.SetBool("isTurnRight", true);
        }
        if (!Input.GetKey("r"))
        {
            animator.SetBool("isTurnRight", false);
        }
    }
}
