using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject text; 
    private Text scoreText;
    public int playerHealth = 10; 

    void Start()
    {
        scoreText = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("HIT ENTERED");
        playerHealth -= 10;
        scoreText.text = "Health:" + playerHealth.ToString();

    }
}
