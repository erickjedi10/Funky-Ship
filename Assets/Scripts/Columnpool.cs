using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnpool : MonoBehaviour
{

    public int tamanocolumn = 5;
    public GameObject colummnPrefab;

    public float columnMin = -3f;
    public float columnMax = -6.5f;

    private GameObject[] columns;
    private Vector2 objectposicion = new Vector2(6, 0 );

    private float timesinceLast;
    public float spawnRate;

   
    private float spawnxPosicion = 11.5f;
    private int currentColumn;
    
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[tamanocolumn];
        for(int i=0; i<tamanocolumn; i++)
        {
            columns[i] = Instantiate(colummnPrefab, objectposicion, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timesinceLast = timesinceLast + Time.deltaTime;
        if (gamcontroller.gami.gameOver == false && timesinceLast >= spawnRate) 
        {
            timesinceLast = 0;
            float spawnYposicion = Random.Range(columnMin,columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnxPosicion,spawnYposicion);
            currentColumn++;
            if (currentColumn >= tamanocolumn) 
            {
                currentColumn = 0;
            }
        }
        
    }
}
