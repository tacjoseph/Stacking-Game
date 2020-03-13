using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool collideWithGround = false;
    public int moveCount = 0;
    public Transform crateSpawnPos;
    public Vector3 cameraTargetPos;
    public Text bestScore;
    public Text scoreText;
    public int score = 0;
    public GameObject gameOverText;
    //Crate crate

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
