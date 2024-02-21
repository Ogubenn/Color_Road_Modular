using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Touch touch;

    [Range(10, 100)]
    public float touchSpeed;
    [Range(10, 100)]
    public float ballForwordSpeed;
    private bool firstTouchBool = false;
    private bool speedBallforword = false;
    public EventSystem eventSystem = EventSystem.current;
    public Camera camera;

    [Header("Bounds")]
    public GameObject vectorBack;
    public GameObject vectorForward;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                if (!eventSystem.IsPointerOverGameObject(touch.fingerId))
                {
                    if(!firstTouchBool)
                    {
                        GameManager.Instance.firstTouch = 1;
                        firstTouchBool = true;
                    }
                }
            }

            else if(touch.phase == TouchPhase.Moved)
            {
                if (!eventSystem.IsPointerOverGameObject(touch.fingerId))
                {
                    rb.velocity = new Vector3(touch.deltaPosition.x * touchSpeed * Time.deltaTime,
                                             0,
                                             touch.deltaPosition.y * touchSpeed * Time.deltaTime);
                    if(!firstTouchBool)
                    {
                        GameManager.Instance.firstTouch = 1;
                        firstTouchBool = true;
                    }
                }
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                
                rb.velocity = Vector3.zero;
            }
        }
    }

    private void LateUpdate()
    {
        if(GameManager.Instance.firstTouch == 1 && speedBallforword == false)
        {
            
            transform.position += new Vector3(0, 0, ballForwordSpeed * Time.deltaTime);
            camera.transform.position += new Vector3(0, 0, ballForwordSpeed * Time.deltaTime);
            vectorBack.transform.position += new Vector3(0, 0, ballForwordSpeed * Time.deltaTime);
            vectorForward.transform.position += new Vector3(0, 0, ballForwordSpeed * Time.deltaTime);
        }

              
    }
}//class
