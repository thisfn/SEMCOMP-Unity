using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	public Text displayScore;
	public SpriteRenderer sprite;
	public Rigidbody2D rb;
	public float force;
	public string[] tags;
	public Material[] materials;
	public int score;

	private void Start()
	{
		int num = Random.Range(0, 4);
		tag = tags[num];
		sprite.material = materials[num];
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
		{
			Destroy(gameObject);
			SceneManager.LoadScene(0);
		}

		else
		{
			score = score + 17;
			displayScore.text = score.ToString();
		}
	}
}