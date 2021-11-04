using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class player : MonoBehaviour
{
    

    public float speed = 5.0f;

    public float Key = 0;

    public GameObject FPScamera;

    public int phone;

    public Transform ownCorridorUp;

    public Transform twoCorridorUp;

    public Transform twoCorridorDown;

    public Transform threeCorridorUp;

    public Transform threeCorridorDown;

    public Transform　fourCorridorUp;

    public Transform fourCorridorDown;

    public Transform　fiveCorridorUp;

    public Transform fiveCorridorDown;

    public Transform sixCorridorDown;

    public Transform twoA;

    public Transform twoa;

    public Transform twoB;

    public Transform twob;

    public Transform threeB;

    public Transform threeb;

    public Transform threeC;

    public Transform threec;

    public Transform threeD;

    public Transform threed;

    public Transform fourA;

    public Transform foura;

    public Transform fourB;

    public Transform fourb;

    public Transform fourC;

    public Transform fourc;

    public Transform fourD;

    public Transform fourd;

    public Transform fiveB;

    public Transform fiveb;

    public Transform fiveC;

    public Transform fivec;

    public Transform fiveD;

    public Transform fived;

    public Transform sixB;

    public Transform sixb;


    public GameObject play;

    CharacterController CR;

    public float belt = 0;

    public float tie = 0;

    public float Schoolemblem = 0;




    //GameObject item;

    //Item script;

    // Start is called before the first frame update
    void Start() {

        //item = GameObject.Find("Item");
        //phone = item.GetComponent<Item>();
        phone = 1;
       

        CR = play.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {




        

    }

    private void OnCollisionEnter(Collision col)
    {

        if (Input.GetKey(KeyCode.Y))
        {

            
            /*
            if (col.gameObject.CompareTag("I"))
            {
                //script.box = 2;
                //Debug.Log(script.box);
            }
            */
        }


        if (col.gameObject.tag == "tie")
        {
            
            Debug.Log("hit");
            Debug.Log(Key);
            Destroy(col.gameObject);
            tie = 1;
        }

        if (col.gameObject.tag == "belt")
        {
           
            Debug.Log(belt);
            Debug.Log(Key);
            Destroy(col.gameObject);
            belt = 1;
          
}

        if (col.gameObject.tag == "School emble")
        {
            
            Debug.Log("hit");
            Debug.Log(Key);
            Destroy(col.gameObject);
            Schoolemblem = 1;
        }

        if (tie + Schoolemblem + belt == 3)
        {
            if (col.gameObject.CompareTag("1d"))
            {
                SceneManager.LoadScene("gend");
            }
        }
        


        if (col.gameObject.tag == "1up")
        {
            CR.enabled = false;
            play.transform.position = ownCorridorUp.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "2up")
        {
            CR.enabled = false;
            play.transform.position = twoCorridorUp.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "2down")
        {
            CR.enabled = false;
            play.transform.position = twoCorridorDown.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3up")
        {
            CR.enabled = false;
            play.transform.position = threeCorridorUp.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3down")
        {
            CR.enabled = false;
            play.transform.position = threeCorridorDown.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4up")
        {
            CR.enabled = false;
            play.transform.position = fourCorridorUp.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4down")
        {
            CR.enabled = false;
            play.transform.position = fourCorridorDown.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5up")
        {
            CR.enabled = false;
            play.transform.position = fiveCorridorUp.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5down")
        {
            CR.enabled = false;
            play.transform.position = fiveCorridorDown.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "6down")
        {
            CR.enabled = false;
            play.transform.position = sixCorridorDown.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "2A")
        {
            CR.enabled = false;
            play.transform.position = twoA.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "2a")
        {
            CR.enabled = false;
            play.transform.position = twoa.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "2B")
        {
            CR.enabled = false;
            play.transform.position = twoB.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "2b")
        {
            CR.enabled = false;
            play.transform.position = twob.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3B")
        {
            CR.enabled = false;
            play.transform.position = threeB.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3b")
        {
            CR.enabled = false;
            play.transform.position = threeb.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3C")
        {
            CR.enabled = false;
            play.transform.position = threeC.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3c")
        {
            CR.enabled = false;
            play.transform.position = threec.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3D")
        {
            CR.enabled = false;
            play.transform.position = threeD.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "3d")
        {
            CR.enabled = false;
            play.transform.position = threed.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4A")
        {
            CR.enabled = false;
            play.transform.position = fourA.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4a")
        {
            CR.enabled = false;
            play.transform.position = foura.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4B")
        {
            CR.enabled = false;
            play.transform.position = fourB.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4b")
        {
            CR.enabled = false;
            play.transform.position = fourb.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4C")
        {
            CR.enabled = false;
            play.transform.position = fourC.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4c")
        {
            CR.enabled = false;
            play.transform.position = fourc.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4D")
        {
            CR.enabled = false;
            play.transform.position = fourD.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "4d")
        {
            CR.enabled = false;
            play.transform.position = fourd.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5B")
        {
            CR.enabled = false;
            play.transform.position = fiveB.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5b")
        {
            CR.enabled = false;
            play.transform.position = fiveb.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5C")
        {
            CR.enabled = false;
            play.transform.position = fiveC.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5c")
        {
            CR.enabled = false;
            play.transform.position = fivec.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5D")
        {
            CR.enabled = false;
            play.transform.position = fiveD.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "5d")
        {
            CR.enabled = false;
            play.transform.position = fived.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "B")
        {
            CR.enabled = false;
            play.transform.position = sixB.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }

        if (col.gameObject.tag == "b")
        {
            CR.enabled = false;
            play.transform.position = sixb.transform.position;
            CR.enabled = true;
            Debug.Log("hit");
        }


        /*if (script.box == 2)
        {
            if (col.gameObject.CompareTag("1d"))
            {
                SceneManager.LoadScene("gend");
            }
        }
        */
        if (col.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("end");
            Debug.Log("hit");
        }

    }

}