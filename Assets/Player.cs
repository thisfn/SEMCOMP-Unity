using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody2D rb;
	public float force;
	public string[] tags; 

	private void Start()
	{
		int num = Random.Range(0, 4);
		print(num);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			rb.velocity = Vector3.up * force;
		}
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag != tag)
			Destroy(gameObject);
	}
}