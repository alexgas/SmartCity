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
    
    // Start is called before the first frame update


    void Start()
    {
       StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waitSpawner()
    {
       
        while (!end)
        {
            yield return new WaitForSeconds(Random.Range(spawnMinWait, spawnMaxWait));
            try
            {
                
                int rand = Random.Range(0, Global.grid.Count);
                gridItem = Global.grid[rand];
                //en caso de que queramos que no se meta el primer modelo de casa, meter Random en el instantiate.
                Vector3 pos = new Vector3(gridItem.transform.position.x, gridItem.transform.position.y + 1.33f, gridItem.transform.position.z);
                GameObject instance = Instantiate(models[Random.Range(0,3)], pos, gridItem.transform.rotation);
                Global.houses.Add(instance);
                Global.grid.RemoveAt(rand);
            }
            catch
            {
               
            }

        }
    }
    
}

    
