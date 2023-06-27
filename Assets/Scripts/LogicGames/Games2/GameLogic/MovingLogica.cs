using UnityEngine;

public class MovingLogica : MonoBehaviour
{
    [SerializeField] private float PlayerPositionX;
    [SerializeField] private float PlayerPositionZ;
    private Rigidbody _rigidbody;
    

    public void Start()
    {
        if(_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        PlayerPositionX = transform.position.x;
        PlayerPositionZ = transform.position.z;
        
    }
    

    public void Logica(Vector3 Move)
    {
        
        _rigidbody.MovePosition(Move);
        GlobalEventSystem.SignatureStaps();
        
    }

    public void MoveRight()
    {
        Vector3 Move = new Vector3(++PlayerPositionX, transform.position.y, PlayerPositionZ);
        Logica(Move);
       
    }

    public void MoveLeft()
    {
        Vector3 Move  = new Vector3(--PlayerPositionX, transform.position.y, PlayerPositionZ);
        Logica(Move);
        
    }

    public void MoveUp()
    {
        Vector3 Move = new Vector3(PlayerPositionX, transform.position.y, ++PlayerPositionZ);
        Logica(Move);
        
    }
    public void MoveDown()
    {
        Vector3 Move = new Vector3(PlayerPositionX, transform.position.y, --PlayerPositionZ);
        Logica(Move);
        
    }

    





    }
