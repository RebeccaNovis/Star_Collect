using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code from:https://www.youtube.com/watch?v=_nRzoTzeyxU

public class DialogueTrigger : MonoBehaviour
{
   public Dialogue dialogue;
   public void TriggerDialogue()
   {
       FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
   }
}
