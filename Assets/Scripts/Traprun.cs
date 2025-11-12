using UnityEngine;

public class Traprun : MonoBehaviour
{
   public Vector3 trapmaxPosision;
    public Vector3 trapminPosision;
 
   public bool moveUp = true;

    public void Start()
    {
       trapmaxPosision = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        trapminPosision = transform.position;
    }
    private void Update()
    {
        if(moveUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, trapmaxPosision, 2f * Time.deltaTime);
            if(Vector3.Distance(transform.position, trapmaxPosision) <= 0.3f)
            {
                moveUp = false;
            }
        }
        else if(!moveUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, trapminPosision, 2f * Time.deltaTime);
            if(Vector3.Distance(transform.position, trapminPosision) <= 0.3f)
            {
                moveUp = true;
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();
            playerController.hurt(playerController.health);
        }else if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            EnemyController enemyController = collision.collider.GetComponent<EnemyController>();
            enemyController.hurt(enemyController.health);
        } } }
