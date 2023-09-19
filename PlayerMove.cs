using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //�ӵ� �ʱ�ȭ
    public float jump?
    public float speed = 0;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb ������Ʈ ��������
        //Getcomponent <> 0 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //SpaceŰ�� ������ �� ������� (�����ϸ� ���� ������ �ȵǰ�)
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            
        }

        //�̵��ϴ� �ڵ�
        float MovementH = Input.GetAxis("Horizontal");
        float MovementV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (MovementH, 0, MovementV);
        rb.AddForce(movement * speed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }
}
