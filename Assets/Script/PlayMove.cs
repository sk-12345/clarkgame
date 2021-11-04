using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove : MonoBehaviour
{
    public GameObject twoCorridor;

    public GameObject play;

    CharacterController CR;

    // Start is called before the first frame update
    void Start()
    {
        CR = play.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "1up")
        {
            CR.enabled = false;
            play.transform.position = twoCorridor.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }
    }
}