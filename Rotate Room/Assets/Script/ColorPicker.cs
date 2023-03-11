using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

   
    void Update()
    {
        
    }
    public void Bluecolor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }
    public void DarkBluecolor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }
    public void Greencolor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }
    public void Pupplecolor()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }
    public void Redcolor()
    {
        renderer.material = BodyColorMat[4];
        CurrMat = renderer.material;
    }
    public void WhiteCreamcolor()
    {
        renderer.material = BodyColorMat[5];
        CurrMat = renderer.material;
    }
    public void Yellowcolor()
    {
        renderer.material = BodyColorMat[6];
        CurrMat = renderer.material;
    }
}
