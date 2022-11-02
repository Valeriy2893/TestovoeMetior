using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{ 
    [SerializeField] private TMP_Text message;

    private bool checkdiffical;
    public void PressEasy()
    {
        message.text = "Выбран лёгкий уровень";
        CanvasManager.instance.speed = 0.05f;
        CanvasManager.instance.spawnTime = 3f;
        checkdiffical=true;
    }

    public void PressNormal()
    {
        message.text = "Выбран средний уровень";
        CanvasManager.instance.speed = 0.10f;
        CanvasManager.instance.spawnTime = 2f;
        checkdiffical = true;
    }
    public void PressHard()
    {
        message.text = "Выбран сложный уровень";
        CanvasManager.instance.speed = 0.15f;
        CanvasManager.instance.spawnTime = 1f;
        checkdiffical = true;
    }

    public void NewGame()
    {
        if (checkdiffical)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            message.text = "Не выбран уровень сложности";
        }
        
    }

}
