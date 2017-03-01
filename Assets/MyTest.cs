using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour {
    Camera cam;
    public GameObject cube;
    public GameObject slider;

    public List<GameObject> cubes;
	// Use this for initialization
	void Start ()
	{
        cam = Camera.main;
        print(cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane)));
        Vector3 tr = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane));
        Vector3 tl = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.nearClipPlane));
        Vector3 br = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.nearClipPlane));
        Vector3 bl = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));



	    cubes.Add(GameObject.Instantiate(cube, tr, Quaternion.identity));
        cubes.Add(GameObject.Instantiate(cube, tl, Quaternion.identity));
        cubes.Add(GameObject.Instantiate(cube, br, Quaternion.identity));
        cubes.Add(GameObject.Instantiate(cube, bl, Quaternion.identity));


         tr = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.farClipPlane));
         tl = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.farClipPlane));
         br = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.farClipPlane));
         bl = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.farClipPlane));

        cubes.Add(GameObject.Instantiate(cube, tr, Quaternion.identity));
        cubes.Add(GameObject.Instantiate(cube, tl, Quaternion.identity));
        cubes.Add(GameObject.Instantiate(cube, br, Quaternion.identity));
        cubes.Add(GameObject.Instantiate(cube, bl, Quaternion.identity));
    }
	
	// Update is called once per frame
	void Update ()
	{
	    cam.fieldOfView =slider.transform.position.x;
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        Vector3 tr = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane));
	        Vector3 tl = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.nearClipPlane));
	        Vector3 br = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.nearClipPlane));
	        Vector3 bl = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
	        cubes[0].transform.position = tr;
            cubes[1].transform.position = tl;
            cubes[2].transform.position = br;
            cubes[3].transform.position = bl;

            tr = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.farClipPlane));
            tl = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.farClipPlane));
            br = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.farClipPlane));
            bl = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.farClipPlane));
            cubes[4].transform.position = tr;
            cubes[5].transform.position = tl;
            cubes[6].transform.position = br;
            cubes[7].transform.position = bl;


        }
    }
}
