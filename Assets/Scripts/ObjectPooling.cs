using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour {
    public GameObject singleObstacle;
    public GameObject doubleObstacle;
    private GameManager gameManager;
    private float spawnTime;
    private float time;
    private List<GameObject> obstacleList;
    private List<GameObject> obstacleTypes;

    private void setSpawnTime()
    {   
        spawnTime = Random.Range(1.5f, 3.0f);
    }

    private GameObject setObstacle()
    {
        return obstacleTypes[Random.Range(0, 2)];
    }

    public void deleteList()
    {
        foreach(GameObject o in obstacleList)
        {
            Destroy(o);
        }
        obstacleList.Clear();
    }

    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        obstacleList = new List<GameObject>();
        obstacleTypes = new List<GameObject>();
        obstacleTypes.Add(singleObstacle);
        obstacleTypes.Add(doubleObstacle);

        time = 0;
        setSpawnTime();	
	}
	
	void FixedUpdate () {

        if (!gameManager.end)
        {

            time += Time.deltaTime;

            if (time >= spawnTime)
            {

                obstacleList.Add(Instantiate(setObstacle()));
                setSpawnTime();
                time = 0;
            }
        }
    }
}
