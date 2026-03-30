using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject mainPanel, controlPaenl;
    public Transform man;
    private Vector3 startPos, startScale;
    private Quaternion startRotation;
    public float moveScal = 1f;
    void Start()
    {
        startPos = man.position;
        startScale = man.localScale;
        startRotation = man.localRotation;
    }

    public void StartGame()
    {
        mainPanel.SetActive(false);
        controlPaenl.SetActive(true);
    }

    public void Rotate(bool isClockwise)
    {
        if (isClockwise)
        {
            man.Rotate(0, 30f, 0, Space.World);
        }
        else
        {
            man.Rotate(0, -30f, 0, Space.World);
        }
    }

    public void BackToMainMenu()
    {
        mainPanel.SetActive(true);
        controlPaenl.SetActive(false);
    }

    public void SetSize(bool isBig)
    {
        if (isBig)
        {
            man.localScale = man.localScale - (Vector3.one * 0.2f);
        }
        else
        {
            man.localScale = man.localScale + (Vector3.one * 0.2f);
        }
    }

    public void Move(int foce)
    {
        //四个方向，上下左右
        switch (foce)
        {
            case 0:
                man.position += Vector3.forward * moveScal;
                break;
                case 1:
                man.position += Vector3.back * moveScal;
                break;
                case 2:
                man.position += Vector3.left * moveScal;
                break;
                case 3:
                man.position += Vector3.right * moveScal;
                break;
        }
    }
    public void Reset()
    {
        man.position = startPos;
        man.localScale = startScale;
        man.localRotation = startRotation;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
