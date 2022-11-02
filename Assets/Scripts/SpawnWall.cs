using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    [SerializeField] private GameObject wall;

    private GameObject instantWall;


    private void Start()
    {

        InvokeRepeating("CreateWall", 0, CanvasManager.instance.spawnTime);

    }

    private void CreateWall()
    {

        Vector2 position = new Vector2(Random.Range(3, 9), Random.Range(-4, 3));


        instantWall = Instantiate(wall, position, Quaternion.identity);
        instantWall.transform.parent = transform;

        Destroy(instantWall, 10f);

    }
}
