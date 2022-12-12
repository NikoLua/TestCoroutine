using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigid;
    public float speed = 3;
    public float jumpPower = 100;
    
    void Start()
    {
        Debug.Log(this.gameObject.name);      // this represents component
        Debug.Log(gameObject.name);           // same effect with the above

        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 input = new Vector3(horizontal, 0, vertical);
        rigid.AddForce(input * speed);

        bool b1 = Input.GetButton("Jump");          // keep pressing the key
        bool b2 = Input.GetButtonDown("Jump");      // The moment when the key is pressed
        bool b3 = Input.GetButtonUp("Jump");        // The moment when the button pops up

        if(b1||b2||b3)      // if all three are false,the following sentence will not be entered.
        { Debug.Log($" ‰»Î◊¥Ã¨£∫{b1} {b2} {b3}"); }

        if(Input.GetButtonDown("Jump"))
        { rigid.AddForce(new Vector3(0, jumpPower, 0)); }

        if(Input.GetKeyDown(KeyCode.X))
        { Debug.Log("XXX"); }
    }
}
