using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController player;
    [SerializeField] float speed;
    private float xMove;
    private float zMove;
    Vector3 moveDirection;


    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        xMove = Input.GetAxis("Horizontal");
        zMove = Input.GetAxis("Vertical");
        moveDirection = new Vector3(xMove, 0f, zMove);
        moveDirection = transform.TransformDirection(moveDirection);
        player.Move(moveDirection);
    }
}
