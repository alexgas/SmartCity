using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawns : MonoBehaviour
{
    public GameObject[] edificios;
    public Vector3[,] spawnValues;
    public int large;
    public float spawnWait;
    public float spawnMaxWait;
    public float spawnMinWait;
    public int startWait;
    bool found = false;
    public bool end;
    int size;
    List<GameObject> grid;
   GameObject gridItem;
    public GameObject respawnee;

    // Start is called before the first frame update
    void Start()
    {
        spawnValues = new Vector3[10,10];
        size = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!end)
        {
            int rand = Random.Range(0, grid.Capacity);
            gridItem = grid[rand];
            Instantiate(respawnee, gridItem.transform.position, gridItem.transform.rotation);
            grid.Remove(gridItem);
            //Destroy
        }
    }
    
}

    
