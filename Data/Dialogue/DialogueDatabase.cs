using UnityEngine;

[System.Serializable]
public struct DialogueStructNameAndContent {
    public string characterNames;
    public string dialogueContent;
}

[CreateAssetMenu(fileName = "NewDialogueDatabase", menuName = "Dialogue System/Dialogue Database")]
public class DialogueDatabase : ScriptableObject
{
    [SerializeField] private DialogueStructNameAndContent[] nameAndContent;

    public DialogueStructNameAndContent[] NameAndContent => nameAndContent;

}
