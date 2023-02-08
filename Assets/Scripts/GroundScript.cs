using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundScript : MonoBehaviour
{

    public GameObject Player;




        void OnTriggerEnter(Collider Player)
        {
            Debug.Log("Player fell");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
}
