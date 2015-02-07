using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour { 
	float time_counter;
	public GUIText timer;
	//public GameObject scorekeeper;
	public GUIText AllyScoreText;
	public GUIText EnemyScoreText;
	public GUIText LevelName;
	//public int AllyScore;
	//public int EnemyScore;
	// Use this for initialization
	public string next_level;
	//public string level_name;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		time_counter += Time.deltaTime;
		timer.text = (200f - time_counter).ToString("F2");
		AllyScoreText.text = GameState.AllyScore.ToString();

		EnemyScoreText.text = GameState.EnemyScore.ToString();
		LevelName.text = Application.loadedLevelName;


		if (time_counter > 200) {
						Application.LoadLevel (next_level);
				}
	}
}
