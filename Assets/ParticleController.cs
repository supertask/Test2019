using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particleSystemObj;

    private Vector3 previousMousePos;
    private ParticleSystem particleSystem;

    private ParticleSystem.Particle[] particles;

    void Start()
    {
        this.particleSystem = this.particleSystemObj.GetComponent<ParticleSystem>();

        previousMousePos = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f); //Camera.main.nearClipPlane + 1.0f);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(screenPosition);
            Vector3 forwardDir = mousePos - previousMousePos;
            Vector3 backDir = - forwardDir;

            /*
            int maxParticles = this.particleSystem.main.maxParticles;
            if (particles == null || particles.Length < maxParticles)
            {
                particles = new ParticleSystem.Particle[maxParticles];
            }

            var power = 100.0f;
            int particleNum = this.particleSystem.GetParticles(particles);

            for (int i = 0; i < particleNum; i++)
            {
                var particleVelocity = particles[i].velocity;
                particleVelocity.x = backDir.x * power;
                particleVelocity.y = backDir.y * power;
                particles[i].velocity = particleVelocity; // * (i / (float) particleNum);
            }

            this.particleSystem.SetParticles(particles, particleNum);
            */

            //particleSystemObj.transform.rotation = Quaternion.LookRotation(dir) * Quaternion.Euler(-90, 0, 0);
            particleSystemObj.transform.position = mousePos;

            previousMousePos = mousePos;
        }

    }
}
