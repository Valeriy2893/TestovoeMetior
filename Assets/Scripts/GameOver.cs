using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] public TMP_Text timeText;
    [SerializeField] public TMP_Text countGameText;

    private void Start()
    {
     
        timeText.text = CanvasManager.instance.time.ToString();
        countGameText.text= CanvasManager.instance.count.ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeDifficulty()
    {
        SceneManager.LoadScene(0);
    }
}
