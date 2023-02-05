using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DM : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;
    
    private Queue<string> Sentences;
        
    // Start is called before the first frame update
    void Start()
    {
        Sentences = new Queue<string>();
    }//end start

    public void SD(Dialogue dialogue)
    {
        animator.SetBool("DialogueBox_Open", true);


        nameText.text = dialogue.name;

        Sentences.Clear();


        foreach (string sentence in dialogue.sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
        public void DisplayNextSentence()
            {
            if (Sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        }

    IEnumerator TypeSentence(string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            yield return null;
        }
    }
        void EndDialogue()
        {
        animator.SetBool("DialogueBox_Open", false);
    }
    
}
