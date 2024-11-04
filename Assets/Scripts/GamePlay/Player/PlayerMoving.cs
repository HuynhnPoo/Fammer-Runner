using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{

    private float laneWidth = 10f;
    private float Speed = 15f; 
    private float inputHold = 0.2f; 

    private bool isMoving = false;
    private Vector3 targetPosition; 

    private float horizontal;

    private int distancePosX = 18;

    private void Start()
    {
        targetPosition =this.transform.position;// khoi tao targetPosition bang vi tri ban dau
    }

    private void Update()
    {
        Moving();// thuc hien ham moving
    }

    public void Moving()
    {
        horizontal = Input.GetAxis("Horizontal");

        CheckInput();
        MoveToPosition();
    }

    void CheckInput()
    {
        // Kiểm tra đầu vào
        if (!isMoving)
        {
            if (horizontal > inputHold)
            {
                targetPosition += Vector3.right * laneWidth;
                isMoving = true;
            }
            else if (horizontal < -inputHold)
            {
                targetPosition += Vector3.left * laneWidth;
                isMoving = true;
            }
        }
    }

    // di chuyen nhan vat den vi tri mong muon
    void MoveToPosition()
    {
        // Di chuyển nhân vật đến vị trí đích
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.Lerp(transform.position, targetPosition, Speed), Speed * Time.deltaTime);

            DistamcePosX();// thuc hien

            // Kiểm tra xem đã đến vị trí đích chưa
            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }


    // kiem tra vi tri nhan vat co di qua truc x hay khong
    void DistamcePosX()
    {
        if (transform.position.x > distancePosX)
        {
            isMoving = false;
            transform.position = new Vector3(10, this.transform.position.y, this.transform.position.z);
        }

        else if (transform.position.x < -distancePosX)
        {
            isMoving = false;
            transform.position = new Vector3(-10, this.transform.position.y, this.transform.position.z);

        }

    }



}

