using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telafasejogo : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chamacenadojogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("fasejogo");
    }
}
