using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody RB;

    public PlayerInput PI;

    private Vector2 _input;

    private Vector2 _userInput;
    void Start()
    {
        PI = GetComponent<PlayerInput>(); 
        RB = GetComponent<Rigidbody>();    
    }

    void OnMove(InputValue iv) { 
        _input = iv.Get<Vector2>();
    }

    private void Update()
    {
        //_userInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //if (Input.GetMouseButtonDown(0)) { 
        //    RB.AddForce(Vector3.up*10,ForceMode.Impulse);
        //}
        //print(_input);
    }
    void FixedUpdate()
    {
        //RB.AddForce(new Vector3(_userInput.x, 0, _userInput.y) * Time.fixedDeltaTime * moveSpeed);
    }

}
