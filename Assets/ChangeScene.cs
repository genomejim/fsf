using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour { 
	float time_counter;
	//public GUIText timer;
	//public GameObject scorekeeper;
	public GUIText AllyScoreText;
	public GUIText EnemyScoreText;
	public int AllyScore;
	public int EnemyScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		time_counter += Time.deltaTime;
		//timer.text = (500f - time_counter).ToString("F2");
		AllyScoreText.text = GameState.AllyScore.ToString();

		EnemyScoreText.text = GameState.EnemyScore.ToString();
		//AllyScore = other.AllyScore;

		if (time_counter > 500) {
						Application.LoadLevel ("monkey");
				}
	}
}
