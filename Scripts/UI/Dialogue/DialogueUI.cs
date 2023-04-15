using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private DialogueDatabase[] dialogueDatabase;
    [SerializeField] private TMP_Text characterName;
    [SerializeField] private TMP_Text characterDialogueContent;
    [SerializeField] private GameObject characterSpriteLeft;
    [SerializeField] private GameObject characterSpriteRight;

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

    public void ShowDialogue() {
        if(currentLine >= dialogueDatabase[currentPlot].Dialogue.Length) {
            HideDialogue();
            return;
        }

        DialogueStruct currentDialogue = dialogueDatabase[currentPlot].Dialogue[currentLine];

        characterName.text = currentDialogue.characterName;
        characterDialogueContent.text = currentDialogue.characterDialogueContent;
        if(currentDialogue.characterImagePosition == "Left") {
            characterSpriteLeft.GetComponent<Image>().sprite = currentDialogue.characterImage;
            characterSpriteLeft.SetActive(true);
            characterSpriteRight.SetActive(false);
        } else if(currentDialogue.characterImagePosition == "Right") {
            characterSpriteRight.GetComponent<Image>().sprite = currentDialogue.characterImage;
            characterSpriteLeft.SetActive(false);
            characterSpriteRight.SetActive(true);
        } else {
            characterSpriteLeft.SetActive(false);
            characterSpriteRight.SetActive(false);
        }

        currentLine++;
    }

    public void HideDialogue() {
        gameObject.SetActive(false);
        PlayerStatusScript.instance.SetPlayerStatus(PlayerStatus.Walk);
    }

    private void Init() {
        currentLine = 0;
        maxPlotNumber = dialogueDatabase.Length;
        currentPlot = Random.Range(0, maxPlotNumber);
    }
}
