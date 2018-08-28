using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSource : MonoBehaviour {

    public GameObject samuraiObject;
    public GameObject ufoObject;
    AudioSource ufoAudio;
    AudioSource samuraiAudio;
	// Use this for initialization
	void Start () {

        ufoAudio = ufoObject.GetComponent<AudioSource>();
        samuraiAudio = samuraiObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                if (raycastHit.collider.name == "mesh01")
                {
                    Debug.Log("mesh01 Hit");
                    ufoAudio.PlayOneShot(ufoAudio.clip);
                }

                if (raycastHit.collider.name == "Plane007")
                {
                    Debug.Log("Plane007 Hit");
                    samuraiAudio.PlayOneShot(samuraiAudio.clip);
                }

                //OR with Tag

                //if (raycastHit.collider.CompareTag("SoccerTag"))
                //{
                //    
                //}
            }
        }
    }


	private void OnMouseDown()
	{
        Debug.Log("Mouse Down Called");

	}
}
