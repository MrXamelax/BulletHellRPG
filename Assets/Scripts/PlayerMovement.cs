using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private Transform playerTF;
    [SerializeField] [Range(0.1f, 1f)] private float movementSpeed;

    private Vector3 direction;

    void Start() {

    }

    void Update() {

        if (Input.anyKey) {
            if (Input.GetKey(KeyCode.W)) {

                Debug.Log("w");
                direction = Vector3.forward;

                if (Input.GetKey(KeyCode.S)) {

                    direction = Vector3.zero;
                    if (Input.GetKey(KeyCode.A)) direction = Vector3.left;
                    if (Input.GetKey(KeyCode.D)) direction = Vector3.right;

                } else if (!(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))) {
                    if (Input.GetKey(KeyCode.A)) direction = Vector3.forward + Vector3.left;
                    else if (Input.GetKey(KeyCode.D)) direction = Vector3.forward + Vector3.right;
                }

            } else if (Input.GetKey(KeyCode.S)) {

                direction = Vector3.back;

                if (!(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))) {
                    if (Input.GetKey(KeyCode.A)) direction = Vector3.back + Vector3.left;
                    if (Input.GetKey(KeyCode.D)) direction = Vector3.back + Vector3.right;
                }

            } else if (Input.GetKey(KeyCode.A)) {

                direction = Vector3.left;
                if (Input.GetKey(KeyCode.D)) direction = Vector3.zero;

            } else

            if (Input.GetKey(KeyCode.D)) {
                direction = Vector3.right;
            }



            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) direction = Vector3.zero;

            playerTF.transform.position += direction.normalized * movementSpeed;
            direction = Vector3.zero;
        }
    }
}
