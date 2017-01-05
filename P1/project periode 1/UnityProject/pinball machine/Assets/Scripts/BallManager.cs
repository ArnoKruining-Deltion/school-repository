using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour
{
	public GameObject ball;
	public Transform spawnPosition;
	public TextMesh display;
	public int lives = 3;
	public bool gameOver = false;
	
	void Update()
	{
		if(lives < 0)
		{
			if(display)
			{
				display.text = "Game Over";
				gameOver = true;
			}
		}
		
		if(!GameObject.FindGameObjectWithTag("Ball") && !gameOver)
		{
			lives--;
			Instantiate(ball,spawnPosition.position,ball.transform.rotation);
			if(display)
			{
				display.text = lives.ToString();
			}
		}
		
		if(gameOver)
		{
			if(Input.GetKeyDown(KeyCode.Return))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
