using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //속도 초기화
    public float jump?
    public float speed = 0;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb 컴포넌트 가져오기
        //Getcomponent <> 0 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Space키를 눌렀을 때 점프기능 (가능하면 이중 점프가 안되게)
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            
        }

        //이동하는 코드
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
