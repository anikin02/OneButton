using UnityEngine;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
    public Text ScoreUI;

    public int score = 0;

    private void Update()
    {
        ScoreUI.text = score.ToString();
    }

    public void AddPoint(int points)
    {
        score += points;
    }
}
