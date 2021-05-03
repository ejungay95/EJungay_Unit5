using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  private const float spawnRate = 2f;

  private int score = 0;

  public List<GameObject> prefabs;
  public TextMeshProUGUI scoreText;

  // Start is called before the first frame update
  void Start()
  {
    UpdateScore(0);
    StartCoroutine(SpawnTarget());
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  IEnumerator SpawnTarget()
  {
    while(true)
    {
      yield return new WaitForSeconds(spawnRate);
      Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
    }
  }

  public void UpdateScore(int scoreToAdd)
  {
    score += scoreToAdd;
    if(score < 0)
    {
      score = 0;
    }
    scoreText.text = "Score: " + score;
  }
}
