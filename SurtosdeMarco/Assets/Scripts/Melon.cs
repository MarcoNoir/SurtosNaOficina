using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
  
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            GamerController.instance.totalScore += Score;
            GamerController.instance.UpdateScoreText();

            Destroy(gameObject, 0.25f);
        }
    }
}
