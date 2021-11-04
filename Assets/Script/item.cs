using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{

    public int box;
    
    GameObject player;

    player script;

    

    // Start is called before the first frame update
    void Start()
    {
        box = 1;
       

        player = GameObject.Find("FPSController (1)");
        script = player.GetComponent<player>();

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {

    }
}