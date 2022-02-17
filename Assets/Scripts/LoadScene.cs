using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Collider Col;
    public Collider Itan;

    // Start is called before the first frame update
    void Start()
    {

    }

   

        // Update is called once per frame
        void Update()
        {
       
        }
    void NextScene(int number)

    {
        if (Col.name == Itan.name)
        {
            
            SceneManager.LoadScene(2);
        }
    }
}
