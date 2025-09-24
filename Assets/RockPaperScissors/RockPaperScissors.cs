using TMPro;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{
    [SerializeField] private int Points;
    [SerializeField] private int AiPoints;
    [SerializeField] private float Timer;

    [SerializeField] private GameObject StartButton, RockButton, PaperButton, ScissorsButton;

    [SerializeField] private TextMeshProUGUI PointsText;
    [SerializeField] private TextMeshProUGUI AiPointsText;
    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private TextMeshProUGUI ResultText;
    
    [SerializeField] private TextMeshProUGUI PlayerSelection;
    [SerializeField] private TextMeshProUGUI AISelection;
    [SerializeField] private GameObject TimerGM;

    private int playerSelectedValue;
    private int selectedByAI;

    public void Update()
    {
        Timer -= Time.deltaTime;
        TimerText.text = "Время : " + Timer.ToString("00");

        if (Timer <= 0)
        {
            TimerText.gameObject.SetActive(false);
        }
    }

    public void PlayerWin()
    {
        Points += 1;
        PointsText.text = "Player : " + Points;
        ResultText.text = "Игрок победил";
    }

    public void PlayerLose()
    {
        AiPoints += 1;
        AiPointsText.text = "AI : " + Points;
        ResultText.text = "ИИ победил";
    }

    public void Draw()
    {
        ResultText.text = "Ничья";
    }

    public void StartButtom()
    {
        StartButton.SetActive(false);
        RockButton.SetActive(true);
        PaperButton.SetActive(true);
        ScissorsButton.SetActive(true);
        TimerGM.SetActive(true);
        Timer = 15f;
    }

    public void SelectRock()
    {
        playerSelectedValue = 0;
        CheckResult(playerSelectedValue);
    }
    
    public void SelectPaper()
    {
        playerSelectedValue = 1;
        CheckResult(playerSelectedValue);
    }
    
    public void SelectScissors()
    {
        playerSelectedValue = 2;
        CheckResult(playerSelectedValue);
    }

    public void CheckResult(int playerValue)
    {
        if (playerValue == 0)
        {
            PlayerSelection.text = "Игрок выбрал Камень";
        } else if (playerValue == 1)
        {
            PlayerSelection.text = "Игрок выбрал Бумагу";
        } else if (playerValue == 2)
        {
            PlayerSelection.text = "Игрок выбрал Ножницы";
        }
        
        selectedByAI = Random.Range(0, 3);
        
        if (selectedByAI == 0)
        {
            AISelection.text = "ИИ выбрал Камень";
        } else if (selectedByAI == 1)
        {
            AISelection.text = "ИИ выбрал Бумагу";
        } else if (selectedByAI == 2)
        {
            AISelection.text = "ИИ выбрал Ножницы";
        }
        
        int delta = playerValue - selectedByAI;
        
        // 0 - 1 = -1 - Lose
        // 0 - 2 = -2 - Win
        // 1 - 2 = -1 - Lose
        // 1 - 0 = 1 - Win
        // 2 - 0 = 2 - Lose
        if (delta == -1 || delta == 2)
        {
            PlayerLose();
        } 
        
        else if (delta == -2 || delta == 1)
        {
            PlayerWin();
        } 
        
        else if (delta == 0)
        {
            Draw();
            //Здесь напишем, что ничья
        }
    }

}
