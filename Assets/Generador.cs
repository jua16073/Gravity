using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generador : MonoBehaviour {
    public GameObject piedra;
    int x;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Vector2 spawnValues;
    public Text metros;

	// Use this for initialization
	void Start () {
        x = 0;
        StartCoroutine(SpawnObstaculos());
        metros.text = x.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        x++;
        metros.text = x.ToString();
    }



    IEnumerator SpawnObstaculos()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            yield return new WaitForSeconds(startWait);
            Vector2 pos = new Vector2(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
            Instantiate(piedra, pos, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
            yield return new WaitForSeconds(waveWait);
        }    
    }
}
