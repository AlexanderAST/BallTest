using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    Rigidbody _RB;

    void Start()
    {
        _RB = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movment = new Vector3 (v * _speed, _RB.velocity.y, h*_speed);
        _RB.AddForce(movment);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + "ResultWON");
        }
        if (this.CompareTag("Player") && other.CompareTag("Lose"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + "ResultLose");
        }
      
    }

}
