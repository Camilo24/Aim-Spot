using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    public GameObject panelgane;
    public int numene;
    // Start is called before the first frame update
    void Start()
    {
        numene = GameObject.FindGameObjectsWithTag("Enemigo").Length;
        panelgane.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void restarene()
    {
        numene--;
        if (numene <= 0)
        {
            panelgane.SetActive(true);
        }
    }

    public void rein()
    {
        SceneManager.LoadScene("Juego");
    }
}
