using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float helth;

    private Rigidbody _RB;
    void Start()
    {
        _RB = GetComponent<Rigidbody>();

        if (_RB == null)
        {
            Debug.LogError("Rigidbody component not found on " + gameObject.name);
        }
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");








        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _RB.AddForce(movement * _speed);
    }
}
