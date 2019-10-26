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
    List<GameObject> buildings= new List<GameObject>();
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
        Debug.Log(Global.grid.Capacity);
        while (!end)
        {
            yield return new WaitForSeconds(Random.Range(spawnMinWait, spawnMaxWait));
            try
            {
                
                Debug.Log("Tamaño: " + Global.grid.Count);
                int rand = Random.Range(0, Global.grid.Count);
                Debug.Log(rand);
                gridItem = Global.grid[rand];
                Debug.Log(gridItem);
                //en caso de que queramos que no se meta el primer modelo de casa, meter Random en el instantiate.
                Vector3 pos = new Vector3(gridItem.transform.position.x, gridItem.transform.position.y + 1.33f, gridItem.transform.position.z);
                GameObject instance = Instantiate(models[0], pos, gridItem.transform.rotation);
                buildings.Add(instance);
                Debug.Log(buildings);
                Global.grid.RemoveAt(rand);
            }
            catch
            {
               
            }
           


            
           
            //Destroy
        }
    }
    
}

    
