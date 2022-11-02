using UnityEngine;

public class Wall : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(-CanvasManager.instance.speed, 0, 0);

    }
}
