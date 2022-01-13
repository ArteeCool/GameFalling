using UnityEngine;


public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;      
    public GameObject JoyStick;
    public float speed;
    public AudioSource CoinPickUp;

    private void Awake()
    {
        transform.TryGetComponent(out _rigidbody2D);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            CoinPickUp.Play();
        }
    }

    private void FixedUpdate()
    {
        var x1 = JoyStick.gameObject.GetComponent<FixedJoystick>().Horizontal;
        var y1 = JoyStick.gameObject.GetComponent<FixedJoystick>().Vertical;
        var move = _rigidbody2D.position + new Vector2(x1 , y1) * (Time.fixedDeltaTime * speed);
        move.x = Mathf.Clamp(move.x, -2.7f, 2.7f);
        move.y = Mathf.Clamp(move.y, -4.75f, 2.0f);
        _rigidbody2D.MovePosition(move);
    }
}
