using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerGame : MonoBehaviour {

    private static MusicPlayerGame mpg;

    // Use this for initialization
    void Awake(){
        if (mpg == null)
        {
            mpg = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
