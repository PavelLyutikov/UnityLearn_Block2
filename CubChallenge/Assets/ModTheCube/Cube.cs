using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float speedRotateX;
    private float speedRotateY;
    private float speedRotateZ;

    private bool maxPosition = false;

    private int choiceRotate;

    private float scale;

    private float positionX;
    private float positionY;
    private float positionZ;

    private float colorR;
    private float colorG;
    private float colorB;
    private float colorA;

    void Start()
    {
        speedRotateX = Random.Range(10.0f, 40.0f);
        speedRotateY = Random.Range(10.0f, 40.0f);
        speedRotateZ = Random.Range(10.0f, 40.0f);

        choiceRotate = Random.Range(1, 4);

        scale = Random.Range(1f, 3f);

        positionX = Random.Range(0f, 9f);
        positionY = Random.Range(0f, 9f);
        positionZ = Random.Range(0f, 9f);

        colorR = Random.Range(0.0f, 1.0f);
        colorG = Random.Range(0.0f, 1.0f);
        colorB = Random.Range(0.0f, 1.0f);
        colorA = Random.Range(0.0f, 1.0f);

        transform.position = new Vector3(positionX, positionY, positionZ);
        transform.localScale = Vector3.one * scale;

        Material material = Renderer.material;

        material.color = new Color(colorR, colorG, colorB, colorA);
    }

    void Update()
    {

        //ChoiceRotate
        if (choiceRotate == 1)
        {
            transform.Rotate(speedRotateX * Time.deltaTime, 0.0f, 0.0f);

            if (!maxPosition)
            {
                transform.Translate(Vector3.right * 10f * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * 10f * Time.deltaTime);
            }
        }
        else if (choiceRotate == 2)
        {
            transform.Rotate(0.0f, speedRotateY * Time.deltaTime, 0.0f);

            if (!maxPosition)
            {
                transform.Translate(Vector3.up * 10f * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.down * 10f * Time.deltaTime);
            }
        }
        else if (choiceRotate == 3)
        {
            transform.Rotate(0.0f, 0.0f, speedRotateZ * Time.deltaTime);

            if (!maxPosition)
            {
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.back * 10f * Time.deltaTime);
            }
        }


        //MovePositionCube
        //RandomColor
        if (transform.position.x > 9 || transform.position.y > 9 || transform.position.z > 9)
        {
            maxPosition = true;
            RandomColor();
        }
        else if (transform.position.x < -9 || transform.position.y < -9 || transform.position.z < -9)
        {
            maxPosition = false;
            RandomColor();
        }
    }

    void RandomColor()
    {
        colorR = Random.Range(0.0f, 1.0f);
        colorG = Random.Range(0.0f, 1.0f);
        colorB = Random.Range(0.0f, 1.0f);
        colorA = Random.Range(0.0f, 1.0f);

        Material material = Renderer.material;

        material.color = new Color(colorR, colorG, colorB, colorA);
    }
}
