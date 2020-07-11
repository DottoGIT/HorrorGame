using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLightController : MonoBehaviour
{
    public Light spotlight;
    public static Ray ViewRay
    {
        get
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
    private CrucialController lastCrucial = null;
    public Animator CursorAnim;
    private AudioSource audioSrc;

    private void Start()
    {
        spotlight.enabled = false;
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
       

        if (SpiderScript.canMove)
        {
            if(spotlight.enabled == false && Input.GetMouseButton(0))
            {
                audioSrc.Play();
            }
            spotlight.enabled = Input.GetMouseButton(0);
        }


        if(DialogueManager.dialogueFinished == true) { 
        var ray = ViewRay;
        RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                CrucialController selectedCrucial = selection.GetComponent<CrucialController>();


                if (selectedCrucial != null && Input.GetMouseButton(0) && Vector3.Distance(gameObject.transform.position, selection.transform.position) < selectedCrucial.minimumDistance)
                {
                    CursorAnim.SetTrigger("Start");
                    selectedCrucial.anim.SetTrigger("Start");
                    lastCrucial = selectedCrucial;
                }
                else
                {
                    CursorAnim.SetTrigger("Stop");
                    if (lastCrucial != null && GameObject.Find(lastCrucial.name) != null)
                    {
                        lastCrucial.anim.SetTrigger("Stop");
                    }
                }
            }
        }
    }
    
}
