using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleReporter : MonoBehaviour {

    ParticleSystem ps;
    
    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
    }
    // Update is called once per frame
    void LateUpdate () {
        ParticleSystem.Particle[] particles =
                new ParticleSystem.Particle[ps.particleCount];

         ps.GetParticles(particles);
        for (int n = 0; n < particles.Length; n++)
        {
            if (particles[n].velocity.x > 0.1f)
            {
                print("bigger");
            }
        }
        // print(particles[0].velocity.x);
    }
}
