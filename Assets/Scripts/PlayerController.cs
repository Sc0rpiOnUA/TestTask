using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController player;
    [SerializeField] float speed;
    private float xMove;
    private float zMove;
    Vector3 moveDirection;
    [SerializeField] GameObject _losePanel;
    


    void Start()
    {
        player = GetComponent<CharacterController>();
        _losePanel.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
        if (transform.position.y < -2)
        {
            Lose();
        }
    }

    public void PlayerMove()
    {
        xMove = Input.GetAxis("Horizontal");
        zMove = Input.GetAxis("Vertical");

        if(player.isGrounded)
        {
            moveDirection = new Vector3(xMove, 0f, zMove);
            moveDirection = transform.TransformDirection(moveDirection);
        }
        moveDirection.y -= 1;
        player.Move(moveDirection * speed * Time.deltaTime);
    }

    public void Lose()
    {
        Cursor.lockState = CursorLockMode.None;
        _losePanel.SetActive(true);
        Time.timeScale = 0;

    }
}
