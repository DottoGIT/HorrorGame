using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScripts : MonoBehaviour
{
    public GameObject score;

    public void ActivateScore()
    {
        score.SetActive(true);
    }
    
    public void DesactivateScore()
    {
        score.SetActive(false);
    }

    public void WriteNow()
    {
        FindObjectOfType<DialogueManager>().StartWritting();
    }

    public void StopDialogue()
    {
        DialogueManager.isInDialogue = false;
    }
}
