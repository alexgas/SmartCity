using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawns : MonoBehaviour
{
    public GameObject[] edificios;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMaxWait;
    public float spawnMinWait;
    public int startWait;
    public boolean end;


    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, respawns.Length);
        Instantiate(respawns[rand], transform.position, Quaternion.identity);
        

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
            Vector3 spawnPosition= new Vector3(Random.Range(0,10)*10, 0 ,Random.Range(0,10)*10);

        }
    }

}
