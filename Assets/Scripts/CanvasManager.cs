using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public float time;
    public int count;
    public float speed;
    public float spawnTime;

    public static CanvasManager instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        count=PlayerPrefs.GetInt("Count", count);
    }
}
