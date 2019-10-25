using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawns : MonoBehaviour
{
    public List<GameObject> models = new List<GameObject>();
    
    public float spawnWait;
    public float spawnMaxWait=5;
    public float spawnMinWait=15;
    public bool end;
    List<GameObject> grid = Global.grid;
    GameObject gridItem;
    List<GameObject> buildings;
    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waitSpawner()
    {
        
        while (!end)
        {
            yield return new WaitForSeconds(Random.Range(spawnMinWait,spawnMaxWait));
            int rand = Random.Range(0, grid.Capacity);
            gridItem = grid[rand];
            //en caso de que queramos que no se meta el primer modelo de casa, meter Random en el instantiate.
            buildings.Add(Instantiate(models[0], gridItem.transform.position, gridItem.transform.rotation));
            grid.Remove(gridItem);
            //Destroy
        }
    }
    
}

    
