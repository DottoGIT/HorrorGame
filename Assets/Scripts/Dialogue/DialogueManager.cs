using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class DialogueManager : MonoBehaviour
{
    public Text nameField;
    public Text textField;
    public Text startField;
    public string kidName;
    public Animator anim;
    public static bool isInDialogue = false;
    public static bool isWaitingForSkip = false;
    public static bool canStartDialogue = false;
    public static bool dialogueFinished = false;

    [TextArea(3,10)]
    public string[] sentences;
    private Queue<string> queuedSentences = new Queue<string>();

    void Start()
    {
        nameField.text = kidName;
    }

    private void Update()
    {
        if (canStartDialogue)
        {
            startField.enabled = true;
        }
        else
        {
            startField.enabled = false;
        }
    }

    public void StartDialogue()
    { 
        textField.text = ""; 
        anim.SetTrigger("Start");
        isInDialogue = true;
        SpiderScript.canMove = false;
        queuedSentences.Clear();
        canStartDialogue = false;

        foreach (string sentence in sentences)
        {
            queuedSentences.Enqueue(sentence);
        }
    }

    public void StartWritting()
    {
        StartCoroutine(TypeSentence(queuedSentences.Dequeue()));
    }

    IEnumerator TypeSentence(string sentence)
    {
        textField.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textField.text += letter;
            yield return null;
        }
        isWaitingForSkip = true;
    }

    public void LoadNextSentence()
    {
        if(queuedSentences.Count == 0)
        {
            EndDialogue();
            isWaitingForSkip = false;
            return;
        }
        isWaitingForSkip = false;
        StartWritting();
    }

    public void EndDialogue()
    {
        dialogueFinished = true;
        anim.SetTrigger("Stop");
        queuedSentences.Clear();
        SpiderScript.canMove = true;
    }

    private void OnTriggerEnter(Collider other)
    {
            canStartDialogue = true;
    }

    private void OnTriggerExit(Collider other)
    {
            canStartDialogue = false;
    }

}
