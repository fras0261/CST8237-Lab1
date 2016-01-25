using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

    public float respawnDistance;
    public GameObject preFabToSpawn;

    private Vector3 spawnerLocation;
    private Vector3 currentLocation;

    private float distance;
    GameObject kefkaClone;

    // Use this for initialization
    void Start () {
        spawnerLocation = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        distance = Vector3.Distance(transform.position, spawnerLocation);
        
        if (distance > respawnDistance)
        {
            kefkaClone = (GameObject)Instantiate(preFabToSpawn, spawnerLocation, Quaternion.identity);
            kefkaClone.name = "Kefka Clone";
            spawnerLocation = transform.position;
        }


	}
}
