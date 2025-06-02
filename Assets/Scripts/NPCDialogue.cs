using UnityEngine;

[CreateAssetMenu(fileName = "NPCDialogue", menuName = "NPCDialogue")]

public class NPCDialogue : ScriptableObject 
{
    public string Name;
    
    public string[] dialogueLines;
    public bool[] autoProgressLines;

    public float typingSpeed = 0.05f;
    public float autoProgressDelay = 1.5f;

    public AudioClip voice;
    public float voicePitch = 1f;
}
