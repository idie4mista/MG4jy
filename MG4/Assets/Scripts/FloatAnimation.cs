using UnityEngine;

public class FloatAnimation : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5.0f;
    [SerializeField] private float _switchSpeed = 3.0f;
    
    private bool _up;
    private float _timer;

    private void Start ()
    {
        _timer = _switchSpeed;
    }

    private void Update()
    {
        if (_up)
        {
            transform.Translate(0, _moveSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, -_moveSpeed * Time.deltaTime, 0);
        }

        _timer -= Time.deltaTime;      
        if (_timer <= 0.0f)
        {
            _timer = _switchSpeed;

            // this line sets _up to the OPPOSITE value it currently has.
            // so if up currently is TRUE, it's set to FALSE;
            // if up is currently FALSE, it's set to TRUE.
            // read the "!" as "NOT".
            _up = !_up;
        }
    }

    public void StopAnimation ()
    {
        enabled = false;
    }
}
