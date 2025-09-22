using TMPro;
using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{
    [SerializeField] private int Points;
    [SerializeField] private int AiPoints;
    [SerializeField] private TextMeshProUGUI PointsText;
    
    [SerializeField] private TextMeshProUGUI AiPointsText;

    private Tools selectedThing;
    private Tools selectedByAI;

    public void AddOnePoint()
    {
        Points = Points + 1;
        PointsText.text = "Очки: " + Points;
    }

    public void SelectRock()
    {
        selectedThing = Tools.Rock;
        selectedByAI = (Tools)Random.Range(0, 3);
        if (selectedByAI == Tools.Paper)
        {
            AiPoints += 1;
            AiPointsText.text = "Очки ИИ: " + AiPoints;
        }
        else if (selectedByAI == Tools.Scissors)
        {
            AddOnePoint();
        }
        else if (selectedByAI == Tools.Rock)
        {
            
        }
    }
    
    public void SelectPaper()
    {
        selectedThing = Tools.Paper;
        
        selectedByAI = (Tools)Random.Range(0, 3);
        if (selectedByAI == Tools.Scissors)
        {
            AiPoints += 1;
            AiPointsText.text = "Очки ИИ: " + AiPoints;
        }
        else if (selectedByAI == Tools.Rock)
        {
            AddOnePoint();
        }
        else if (selectedByAI == Tools.Paper)
        {
            
        }
    }
    
    public void SelectScissors()
    {
        selectedThing = Tools.Scissors;
        selectedByAI = (Tools)Random.Range(0, 3);
        if (selectedByAI == 0)
        {
            AiPoints += 1;
            AiPointsText.text = "Очки ИИ: " + AiPoints;
        }
        else if (selectedByAI == Tools.Paper)
        {
            AddOnePoint();
        }
        else if (selectedByAI == Tools.Scissors)
        {
            
        }
    }

    public enum Tools
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }
}
