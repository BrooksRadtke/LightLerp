using System.Collections;
using UnityEngine;

public class LightLerp : MonoBehaviour
{
    public float smooth = 2f;
    private Vector3 newPosition;
    private float newIntensity;
    private Color newColor;


    private void Awake()
    {
        newPosition = transform.position;
        newIntensity = GetComponent<Light>().intensity;
        newColor = GetComponent<Light>().color;
    }

    // Update is called once per frame
    void Update()
    {
        PositionChange();
        IntensityChange();
        ColorChange();
    }

    void PositionChange()
    {
        Vector3 positionA = new Vector3(3, .5f, 0);
        Vector3 positionS = new Vector3(0, .5f, 1.5f);
        Vector3 positionD = new Vector3(-3, .5f, 0);
        Vector3 positionW = new Vector3(0, .5f, -1.5f);

        if (Input.GetKeyDown(KeyCode.A))
        {
            newPosition = positionA;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            newPosition = positionD;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            newPosition = positionS;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            newPosition = positionW;
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);
    }

    void IntensityChange()
    {
        float intensityA = 0.5f;
        float intensityB = 5f;
        float intentityC = 10f;
        float intensityD = 35f;

        if (Input.GetKeyDown(KeyCode.A))
        {
            newIntensity = intensityA;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newIntensity = intensityB;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            newIntensity = intentityC;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            newIntensity = intensityD;
        }

        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, newIntensity, Time.deltaTime * smooth);
    }

    void ColorChange()
    {
        Color colorA = Color.red;
        Color colorB = Color.blue;
        Color colorC = Color.white;
        Color colorD = Color.green;

        if (Input.GetKeyDown(KeyCode.A))
        {
            newColor = colorA;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newColor = colorB;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            newColor = colorC;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            newColor = colorD;
        }

        GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, newColor, Time.deltaTime * smooth);
    }
}
