using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  private const float minForce = 10f;
  private const float maxForce = 15f;
  private const float minTorque = -10f;
  private const float maxTorque = 10f;
  private const float minXPos = -3f;
  private const float maxXPos = 3f;
  private const float ySpawnPos = -2f;
  private Rigidbody targetRb;
  // Start is called before the first frame update
  void Start()
  {
    targetRb = GetComponent<Rigidbody>();
    RandomForce();
    RandomTorque();
    RandomSpawnPos();
  }

  // Update is called once per frame
  void Update()
  {
     
  }

  private void OnTriggerEnter(Collider other) {
    if(other.CompareTag("Sensor"))
    {
      Destroy(gameObject);
    }
  }

  private void OnMouseDown()
  {
    Destroy(gameObject);
  }

  void RandomForce()
  {
    targetRb.AddForce(Vector3.up * Random.Range(minForce, maxForce), ForceMode.Impulse);
  }

  void RandomTorque()
  {
    targetRb.AddTorque(Random.Range(minTorque, maxTorque), Random.Range(minTorque, maxTorque), Random.Range(minTorque, maxTorque), ForceMode.Impulse);
  }

  void RandomSpawnPos()
  {
    transform.position = new Vector3(Random.Range(minXPos, maxXPos), ySpawnPos);
  }
}
