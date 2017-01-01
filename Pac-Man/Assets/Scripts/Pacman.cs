using UnityEngine;
using System.Collections;

public class Pacman : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f, moveY = 0f;

        if (Input.GetButton("Left"))
        {
            moveX = -speed * Time.deltaTime;
            spriteRenderer.flipX = true;
            spriteRenderer.flipY = false;

            animator.SetBool("MoveX", true);
            animator.SetBool("MoveY", false);
        }
        else if (Input.GetButton("Right"))
        {
            moveX = speed * Time.deltaTime;
            spriteRenderer.flipX = false;
            spriteRenderer.flipY = false;

            animator.SetBool("MoveX", true);
            animator.SetBool("MoveY", false);
        }
        else if (Input.GetButton("Up"))
        {
            moveY = speed * Time.deltaTime;
            spriteRenderer.flipX = false;
            spriteRenderer.flipY = false;

            animator.SetBool("MoveX", false);
            animator.SetBool("MoveY", true);
        }
        else if (Input.GetButton("Down"))
        {
            moveY = -speed * Time.deltaTime;
            spriteRenderer.flipX = false;
            spriteRenderer.flipY = true;

            animator.SetBool("MoveX", false);
            animator.SetBool("MoveY", true);
        }
        else
        {
            animator.SetBool("MoveX", false);
            animator.SetBool("MoveY", false);
        }

        transform.Translate(moveX, moveY, 0f);
    }
}
