using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomise : MonoBehaviour
{
    public List<GameObject> points = new List<GameObject>();

    public GameObject Banana;
    public GameObject Cheese;
    public GameObject Hamburger;
    public GameObject Cherry;
    public GameObject Hotdog;
    public GameObject Olive;
    public GameObject WaterMelon;

    public GameObject Enemy;
    
    private int a;
    private int b;
    private int c;
    private int d;
    private int e;
    private int f;
    private int g;

    private int h;

    void Start()
    {
        a = Random.Range(0,82);
        b = Random.Range(0,82);
        c = Random.Range(0,82);
        d = Random.Range(0,82);
        e = Random.Range(0,82);
        f = Random.Range(0,82);
        g = Random.Range(0,82);

        h = Random.Range(83,85);

        Banana.transform.position = new Vector3(points[a].transform.position.x, points[a].transform.position.y, points[a].transform.position.z);
        Cheese.transform.position = new Vector3(points[b].transform.position.x, points[b].transform.position.y, points[b].transform.position.z);
        Hamburger.transform.position = new Vector3(points[c].transform.position.x, points[c].transform.position.y, points[c].transform.position.z);
        Cherry.transform.position = new Vector3(points[d].transform.position.x, points[d].transform.position.y, points[d].transform.position.z);
        Hotdog.transform.position = new Vector3(points[e].transform.position.x, points[e].transform.position.y, points[e].transform.position.z);
        Olive.transform.position = new Vector3(points[g].transform.position.x, points[g].transform.position.y, points[g].transform.position.z);
        WaterMelon.transform.position = new Vector3(points[f].transform.position.x, points[f].transform.position.y, points[f].transform.position.z);
        Enemy.transform.position = new Vector3(points[h].transform.position.x, points[h].transform.position.y, points[h].transform.position.z);
    }

}
