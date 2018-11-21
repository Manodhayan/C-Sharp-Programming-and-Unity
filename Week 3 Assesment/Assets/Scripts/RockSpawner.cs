using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A Rock spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabRock;

    [SerializeField]
    Sprite GreenRock;

    [SerializeField]
    Sprite magentaRock;

    [SerializeField]
    Sprite whiteRock;

    //GameObjects List
    GameObject[] ListOfRocks;

    //spawn control
    const float MinSpawnDelay = 0;
    const float MaxSpawnDelay = 1;
    Timer spawnTimer;

    // spawn location support
    const int SpawnBorderSize = 400;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // save spawn boundaries for efficiency
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // check for number of rocks in the camera

        // check for time to spawn a new rock
        ListOfRocks = GameObject.FindGameObjectsWithTag("prefabRock");
        if (ListOfRocks.Length<3 && spawnTimer.Finished)
        { print(ListOfRocks.Length);
        
            SpawnRock();

            // change spawn timer duration and restart
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
            }

    }

    /// <summary>
    /// Spawns a rock at a random location
    /// </summary>
    void SpawnRock()
    {
        // generate random location and create new Rock
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject Rock = Instantiate(prefabRock) as GameObject;
        Rock.transform.position = worldLocation;

        //Sprite Renderer
        SpriteRenderer spriteRenderer = Rock.GetComponent<SpriteRenderer>();
        int rocksprite = Random.Range(0, 3);
        if (rocksprite == 0) { spriteRenderer.sprite = GreenRock;}
        else if (rocksprite == 1) { spriteRenderer.sprite = magentaRock; }
        else { spriteRenderer.sprite = whiteRock; }
    }
}
