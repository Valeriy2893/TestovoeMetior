using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] private float jump;

    [SerializeField] private Rigidbody2D rb2D;

    [SerializeField] public TMP_Text timeText;
    [SerializeField] public TMP_Text countGameText;

    private float timeRound;
    private void Awake()
    {
        timeText = GameObject.Find("Time").GetComponent<TMP_Text>();
        countGameText = GameObject.Find("Count").GetComponent<TMP_Text>();
    }
    private void Start()
    {
        jump = 3.5f;
        CanvasManager.instance.time = 0;


        InvokeRepeating("PowerJump", 15, 15);

        countGameText.text = CanvasManager.instance.count.ToString();
    }


    private void Update()
    {
        Timer();
        Jump();
        
    }

    private void Timer()
    {
        CanvasManager.instance.time += Time.deltaTime;

        timeRound = Mathf.Round(CanvasManager.instance.time);

        timeText.text = timeRound.ToString();
    }

    private void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * jump;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Line")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
            CanvasManager.instance.count++;
            PlayerPrefs.SetInt("Count", CanvasManager.instance.count);



        }
    }

    private void PowerJump()
    {
        if (jump < 10)
        {
            jump++;
        }

    }
}
