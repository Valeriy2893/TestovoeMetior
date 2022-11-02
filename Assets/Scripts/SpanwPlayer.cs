using UnityEngine;

public class SpanwPlayer : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private void Start()
    {
        Instantiate(ball, transform);
    }



}
