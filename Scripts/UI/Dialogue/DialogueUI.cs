using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private DialogueDatabase[] dialogueDatabase;
    [SerializeField] private TMP_Text characterNameText;
    [SerializeField] private TMP_Text dialogueLineText;

    private int currentPlot = 0;
    private int maxPlotNumber = 0;
    private int currentLine = 0;


    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            HideDialogue();
        }
    }


    private void OnEnable() {
        Init();
        ShowDialogue();
        PlayerStatusScript.instance.SetPlayerStatus(PlayerStatus.Dialogue);
    }

    private void OnDisable() {
        PlayerStatusScript.instance.SetPlayerStatus(PlayerStatus.Walk);
    }


    public void ShowDialogue() {
        if(currentLine >= dialogueDatabase[currentPlot].NameAndContent.Length) {
            HideDialogue();
            return;
        }

        characterNameText.text = dialogueDatabase[currentPlot].NameAndContent[currentLine].characterNames;
        dialogueLineText.text = dialogueDatabase[currentPlot].NameAndContent[currentLine].dialogueContent;
        
        currentLine++;
    }

    public void HideDialogue() {
        gameObject.SetActive(false);
    }

    private void Init() {
        currentLine = 0;
        maxPlotNumber = dialogueDatabase.Length;
        currentPlot = Random.Range(0, maxPlotNumber);
    }
}
