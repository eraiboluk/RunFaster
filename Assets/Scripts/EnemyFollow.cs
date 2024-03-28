using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject Win;
    public Text HealthText;
    public float Health = 100f;
    public float Damage = 0.5f;

    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {   
        
        enemy.SetDestination(Player.position);
  
 
    }
    private void OnTriggerStay (Collider other) { 


        if (other.gameObject.tag  == "Player") {
            Health = Health - Damage;
            HealthText.text = Health.ToString();
        }
        if(Health == 0f)
            Win.SetActive(true); 
    }
}
