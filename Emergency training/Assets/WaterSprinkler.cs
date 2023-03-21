using UnityEngine;

public class WaterSprinkler : MonoBehaviour
{
    public ParticleSystem WaterParticles; // assign your particle system here
    public float ParticleEmissionRate = 100f;
    public float ParticleEmissionAngle = 30f;
    public float ParticleEmissionSpeed = 2f;
    public float MaxRotationSpeed = 100f;
    public float RotationAcceleration = 10f;
    //  public ParticleSystem WaterParticles;

    private float currentRotationSpeed = 0f;
    private float targetRotationSpeed = 0f;

    void Update()
    {
        // Rotate the sprinkler based on user input
        float rotationInput = Input.GetAxisRaw("Horizontal");
        targetRotationSpeed = rotationInput * MaxRotationSpeed;
        currentRotationSpeed = Mathf.MoveTowards(currentRotationSpeed, targetRotationSpeed, RotationAcceleration * Time.deltaTime);
        transform.Rotate(Vector3.up, currentRotationSpeed * Time.deltaTime);

        // Emit water particles in the desired direction and properties
        var emission = WaterParticles.emission;
        emission.rateOverTime = ParticleEmissionRate;
        emission.enabled = true;

        var shape = WaterParticles.shape;
        shape.angle = ParticleEmissionAngle;

        var velocityOverLifetime = WaterParticles.velocityOverLifetime;
        velocityOverLifetime.speedModifier = ParticleEmissionSpeed;
    }
}
