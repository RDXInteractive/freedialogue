using TMPro;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public ChoiceManager choiceManager;
    public TMP_Text endingText;
    public GameObject endingPanel;
    public void checkEnding()
    {
        if (choiceManager.choices[3] == 1)
        {
            endingText.text = "Silas was the Murderer";
            endingPanel.SetActive(true);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
