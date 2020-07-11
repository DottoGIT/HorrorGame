using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Animator anim;
    public float speed;

    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.E))
        {
            anim.SetTrigger("Start");
        }

        if (SpiderScript.canMove)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            rigid.MovePosition(transform.position + (move * speed * Time.deltaTime));


        }

        if (DialogueManager.isInDialogue && DialogueManager.isWaitingForSkip && Input.GetKey(KeyCode.E))
        {
            FindObjectOfType<DialogueManager>().LoadNextSentence();
        }

        if (DialogueManager.isInDialogue == false && DialogueManager.canStartDialogue == true && Input.GetKey(KeyCode.E))
        {
            FindObjectOfType<DialogueManager>().StartDialogue();
        }
    }
}

