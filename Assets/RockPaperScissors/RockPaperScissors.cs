using TMPro;
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
    [SerializeField] private GameObject TimerGM;

    private Tools selectedThing;
    private Tools selectedByAI;

    public enum Tools
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }

    public void Update()
    {
        Timer -= Time.deltaTime;
        TimerText.text = "Время : " + Timer.ToString("00");

        if (Timer <= 0)
        {
            TimerGM.SetActive(false);
        }
    }


    public void AddOnePoint()
    {
        Points += 1;
        PointsText.text = "Player : " + Points;
    }

    public void AddAIOnePoint()
    {
        AiPoints += 1;
        AiPointsText.text = "AI : " + Points;
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
        selectedThing = Tools.Rock;

        selectedByAI = (Tools)Random.Range(0, 3);
        if (selectedByAI == Tools.Paper)
        {
            AddAIOnePoint();
        }
        else if (selectedByAI == Tools.Scissors)
        {
            AddOnePoint();
        }
    }
    
    public void SelectPaper()
    {
        selectedThing = Tools.Paper;
        
        selectedByAI = (Tools)Random.Range(0, 3);
        if (selectedByAI == Tools.Scissors)
        {
            AddAIOnePoint();
        }
        else if (selectedByAI == Tools.Rock)
        {
            AddOnePoint();
        }
    }
    
    public void SelectScissors()
    {
        selectedThing = Tools.Scissors;
        selectedByAI = (Tools)Random.Range(0, 3);
        if (selectedByAI == 0)
        {
            AddAIOnePoint();
        }
        else if (selectedByAI == Tools.Paper)
        {
            AddOnePoint();
        }
    }

}
