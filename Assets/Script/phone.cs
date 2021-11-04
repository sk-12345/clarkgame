using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class phone : MonoBehaviour
{

    public GameObject canvas;

    public GameObject mail;

    public GameObject box;

    public GameObject back;

    public GameObject Mainback;

    public GameObject FPS;

    public GameObject Boxa;

    public GameObject Belt;

    public GameObject Tie;

    public GameObject School;

    public GameObject Belt2;

    public GameObject Tie2;

    public GameObject School2;

    public float belt = 0;

    public float tie = 0;

    public float Schoolemblem = 0;

    public player belt2;

    public player tie2;

    public player Schoolemblem2;

    public GameObject play;


    // Start is called before the first frame update
    void Start()
    {
        play = GameObject.Find("FPSController (1)");
        belt2 = play.GetComponent<player>();
        tie2 = play.GetComponent<player>();
        Schoolemblem2 = play.GetComponent<player>();
        
    }

    // Update is called once per frame
    void Update()
    {

        belt = belt2.belt;
        tie = tie2.tie;
        Schoolemblem = Schoolemblem2.Schoolemblem;

        if (Input.GetKeyDown(KeyCode.N))
        {
            canvas.gameObject.SetActive(true);
            FPS.gameObject.SetActive(false);
          
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            canvas.gameObject.SetActive(false);
            FPS.gameObject.SetActive(true);
            back.gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            box.gameObject.SetActive(true);
            FPS.gameObject.SetActive(false);
            Debug.Log(belt + "///");

        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            box.gameObject.SetActive(false);
            FPS.gameObject.SetActive(true);
            

        }

        if (belt == 1)
        {
            Belt2.gameObject.SetActive(false);
            Belt.gameObject.SetActive(true);
            
        }

        if (tie == 1)
        {
            Tie2.gameObject.SetActive(false);
            Tie.gameObject.SetActive(true);
        }

        if (Schoolemblem == 1)
        {
            School2.gameObject.SetActive(false);
            School.gameObject.SetActive(true);
        }

    }

    public void Mail()
    {
        mail.gameObject.SetActive(true);
        Debug.Log("on");
        
    }

    public void Box()
    {
        box.gameObject.SetActive(true);
    }

    public void Back()
    {
        back.gameObject.SetActive(false);
        Debug.Log("on");

    }

}
