using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Movement : MonoBehaviour 
{
	Animator anim;

	void Awake() 
	{
		anim = GetComponent<Animator> ();
	}

	void Update() 
	{
        Turning();
        // ! Jumping
        Move();
	}

	void Move()
	{
        if (Input.GetKeyDown(KeyCode.LeftShift))
            anim.SetBool("Run", true);
		if (Input.GetKeyUp(KeyCode.LeftShift))
            anim.SetBool("Run", false);
		
		anim.SetFloat ("Forward", Input.GetAxis("Vertical")); // ! Will Hash Later
	}

    void Turning()
    {
        anim.SetFloat("Turn", Input.GetAxis("Horizontal")); // ! Will Hash Later
    }
}