using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    float cubesPivotDistance;
    Vector3 cubesPivot;

    public float explosionForce = 50f;
    public float explosionRadius = 4f;
    public float explosionUpward = 0.4f;

    public PlayerMovement movement;
   
    public AnswerNumber an;
    

    public Collider player;

    int lifeNo = 3;

    public Image life1;
    public Image life2;
    public Image life3;

    public AudioSource breakObstacle;
    public AudioSource bump;

    void Start()
    {
        cubesPivotDistance = cubeSize * cubesInRow / 2;
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        //int numberOnCube = an.numberOnCube;
       // int answer = oa.answer;
        //int rightCubeNumber = oa.randomCubeNumber;





        if (collisionInfo.collider.tag == "Obstacle")
        {
            bump.Play();
            //if user still has life, remove it
            if (lifeNo == 3)
            {
                //FindObjectOfType<LifeDissapearance>().fadeOut();
                life1.GetComponent<LifeDissapearance>().fadeOut();
                lifeNo--;
            }
            else if (lifeNo == 2)
            {
                //FindObjectOfType<LifeDissapearance>().fadeOut();
                life2.GetComponent<LifeDissapearance>().fadeOut();
                lifeNo--;
            }
            else if (lifeNo == 1)
            {
                //FindObjectOfType<LifeDissapearance>().fadeOut();
                life3.GetComponent<LifeDissapearance>().fadeOut();
                lifeNo--;
            }
            else
            {
                if (FindObjectOfType<Score>().score > 5) 
                {

                    //stop the object first
                    FindObjectOfType<PlayerMovement>().decreasing = true;

                    FindObjectOfType<LevelComplete>().AssignStars();
                    FindObjectOfType<EquationGenerator>().finishLevelPanel.SetActive(true);
                }
                else
                {
                    if (FindObjectOfType<Score>().score > 3) {
                        FindObjectOfType<AdManager>().showAd();
                    }

                    movement.enabled = false;
                    FindObjectOfType<GameManager>().EndGame();
                }

            }
        }






        if (collisionInfo.collider.tag == "Answer" || collisionInfo.collider.tag == "OriginalAnswer")
        {

            breakObstacle.Play();


            //if correct cube is broken, update score
            FindObjectOfType<Score>().UpdateScore();


            //change equation to the new one
            FindObjectOfType<EquationGenerator>().NextEquation();


            //explode the cube

            collisionInfo.gameObject.SetActive(false);

            //loop 3 times to create 5*5*5 pieces in x, y, z coordinates
            for (int x = 0; x < cubesInRow; x++)
            {
                for(int y = 0; y < cubesInRow; y++)
                {
                    for (int z = 0; z < cubesInRow; z++)
                    {
                        createPiece(x, y, z);
                    }
                }
            }

            //get explosition position
            Vector3 explosionPos = transform.position;
            //get colliders in that position and radius
            Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
            //add explosion force to all colliders in that overlap sphere
            foreach (Collider hit in colliders)
            {
                //get rigidbody from collider object
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    //add explosion force to this body with given parameters
                    rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
                }
            }
            


        }
    }

    

    //create piece for exploding cube
   void createPiece(int x, int y, int z)
    {
        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //set piece position and scale
        piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        //add rigidbody and set mass
        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;

        Physics.IgnoreCollision(piece.GetComponent<Collider>(), player);

    }

}
