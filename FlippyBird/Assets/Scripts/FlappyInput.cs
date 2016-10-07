using UnityEngine;
using System.Collections;

public class FlappyInput : MonoBehaviour {

    public float jumpforce = 40f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        DetectInput();
	}

    void DetectInput()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("ButtonPressed");
            Jump();
        }
    }

    void Jump ()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f);
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpforce, 0f));
    }

}
