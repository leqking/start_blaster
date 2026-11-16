using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
   
    [SerializeField] float leftPos;
    [SerializeField] float rightPos;
    [SerializeField] float upPos;
    [SerializeField] float downPos;


    InputAction moveAction;

    Vector3 moveVector;
    Vector2 minBound;
    Vector2 maxBound;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        IniBound();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        moveVector = moveAction.ReadValue<Vector2>();
        Vector3 newPos = transform.position += moveVector * moveSpeed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, minBound.x+leftPos, maxBound.x- rightPos);
        newPos.y = Mathf.Clamp(newPos.y, minBound.y+upPos, maxBound.y-downPos);

        transform.position += moveVector * moveSpeed * Time.deltaTime;
        transform.position = newPos;
    }
    void IniBound()
    {
        Camera myCamera = Camera.main;
        minBound = myCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBound = myCamera.ViewportToWorldPoint(new Vector2(1, 1));

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Coin"))
        {
          FindFirstObjectByType<scoremanager>().AddScore(10);
            Destroy(other.gameObject);
           
        }
    }
}
