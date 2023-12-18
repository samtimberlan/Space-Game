using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
	//Game score
	public static int Score;

	//Prefix
	public string ScorePrefix = string.Empty;

	//Score text object
	public TMP_Text ScoreText = null;

	public static GameController ThisInstance = null;
	public GameOver GameOverScreen;

	void Awake()
	{
		ThisInstance = this;
	}

	void Update()
	{
		//Update score text
		if (ScoreText != null)
		{
			ScoreText.text = ScorePrefix + Score.ToString();
		}
	}

	public void GameOver()
	{
		GameOverScreen.Setup(Score);
	}
}
