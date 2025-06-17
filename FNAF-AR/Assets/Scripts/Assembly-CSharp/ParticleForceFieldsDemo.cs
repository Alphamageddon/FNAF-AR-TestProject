using MirzaBeig.Scripting.Effects;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ParticleForceFieldsDemo : MonoBehaviour
{
	[Header("Overview")]
	public Text FPSText;

	public Text particleCountText;

	public Toggle postProcessingToggle;

	public MonoBehaviour postProcessing;

	[Header("Particle System Settings")]
	public ParticleSystem particleSystem;

	private ParticleSystem.MainModule particleSystemMainModule;

	private ParticleSystem.EmissionModule particleSystemEmissionModule;

	public Text maxParticlesText;

	public Text particlesPerSecondText;

	public Slider maxParticlesSlider;

	public Slider particlesPerSecondSlider;

	[Header("Attraction Particle Force Field Settings")]
	public AttractionParticleForceField attractionParticleForceField;

	public Text attractionParticleForceFieldRadiusText;

	public Text attractionParticleForceFieldMaxForceText;

	public Text attractionParticleForceFieldArrivalRadiusText;

	public Text attractionParticleForceFieldArrivedRadiusText;

	public Text attractionParticleForceFieldPositionTextX;

	public Text attractionParticleForceFieldPositionTextY;

	public Text attractionParticleForceFieldPositionTextZ;

	public Slider attractionParticleForceFieldRadiusSlider;

	public Slider attractionParticleForceFieldMaxForceSlider;

	public Slider attractionParticleForceFieldArrivalRadiusSlider;

	public Slider attractionParticleForceFieldArrivedRadiusSlider;

	public Slider attractionParticleForceFieldPositionSliderX;

	public Slider attractionParticleForceFieldPositionSliderY;

	public Slider attractionParticleForceFieldPositionSliderZ;

	[Header("Vortex Particle Force Field Settings")]
	public VortexParticleForceField vortexParticleForceField;

	public Text vortexParticleForceFieldRadiusText;

	public Text vortexParticleForceFieldMaxForceText;

	public Text vortexParticleForceFieldRotationTextX;

	public Text vortexParticleForceFieldRotationTextY;

	public Text vortexParticleForceFieldRotationTextZ;

	public Text vortexParticleForceFieldPositionTextX;

	public Text vortexParticleForceFieldPositionTextY;

	public Text vortexParticleForceFieldPositionTextZ;

	public Slider vortexParticleForceFieldRadiusSlider;

	public Slider vortexParticleForceFieldMaxForceSlider;

	public Slider vortexParticleForceFieldRotationSliderX;

	public Slider vortexParticleForceFieldRotationSliderY;

	public Slider vortexParticleForceFieldRotationSliderZ;

	public Slider vortexParticleForceFieldPositionSliderX;

	public Slider vortexParticleForceFieldPositionSliderY;

	public Slider vortexParticleForceFieldPositionSliderZ;

	private void Start()
	{
		if ((bool)postProcessing)
		{
			postProcessingToggle.isOn = postProcessing.enabled;
		}
		particleSystemMainModule = particleSystem.main;
		particleSystemEmissionModule = particleSystem.emission;
		maxParticlesSlider.value = particleSystemMainModule.maxParticles;
		particlesPerSecondSlider.value = particleSystemEmissionModule.rateOverTime.constant;
		maxParticlesText.text = "Max Particles: " + maxParticlesSlider.value;
		particlesPerSecondText.text = "Particles Per Second: " + particlesPerSecondSlider.value;
		attractionParticleForceFieldRadiusSlider.value = attractionParticleForceField.radius;
		attractionParticleForceFieldMaxForceSlider.value = attractionParticleForceField.force;
		attractionParticleForceFieldArrivalRadiusSlider.value = attractionParticleForceField.arrivalRadius;
		attractionParticleForceFieldArrivedRadiusSlider.value = attractionParticleForceField.arrivedRadius;
		Vector3 position = attractionParticleForceField.transform.position;
		attractionParticleForceFieldPositionSliderX.value = position.x;
		attractionParticleForceFieldPositionSliderY.value = position.y;
		attractionParticleForceFieldPositionSliderZ.value = position.z;
		attractionParticleForceFieldRadiusText.text = "Radius: " + attractionParticleForceFieldRadiusSlider.value;
		attractionParticleForceFieldMaxForceText.text = "Max Force: " + attractionParticleForceFieldMaxForceSlider.value;
		attractionParticleForceFieldArrivalRadiusText.text = "Arrival Radius: " + attractionParticleForceFieldArrivalRadiusSlider.value;
		attractionParticleForceFieldArrivedRadiusText.text = "Arrived Radius: " + attractionParticleForceFieldArrivedRadiusSlider.value;
		attractionParticleForceFieldPositionTextX.text = "Position X: " + attractionParticleForceFieldPositionSliderX.value;
		attractionParticleForceFieldPositionTextY.text = "Position Y: " + attractionParticleForceFieldPositionSliderY.value;
		attractionParticleForceFieldPositionTextZ.text = "Position Z: " + attractionParticleForceFieldPositionSliderZ.value;
		vortexParticleForceFieldRadiusSlider.value = vortexParticleForceField.radius;
		vortexParticleForceFieldMaxForceSlider.value = vortexParticleForceField.force;
		Vector3 eulerAngles = vortexParticleForceField.transform.eulerAngles;
		vortexParticleForceFieldRotationSliderX.value = eulerAngles.x;
		vortexParticleForceFieldRotationSliderY.value = eulerAngles.y;
		vortexParticleForceFieldRotationSliderZ.value = eulerAngles.z;
		Vector3 position2 = vortexParticleForceField.transform.position;
		vortexParticleForceFieldPositionSliderX.value = position2.x;
		vortexParticleForceFieldPositionSliderY.value = position2.y;
		vortexParticleForceFieldPositionSliderZ.value = position2.z;
		vortexParticleForceFieldRadiusText.text = "Radius: " + vortexParticleForceFieldRadiusSlider.value;
		vortexParticleForceFieldMaxForceText.text = "Max Force: " + vortexParticleForceFieldMaxForceSlider.value;
		vortexParticleForceFieldRotationTextX.text = "Rotation X: " + vortexParticleForceFieldRotationSliderX.value;
		vortexParticleForceFieldRotationTextY.text = "Rotation Y: " + vortexParticleForceFieldRotationSliderY.value;
		vortexParticleForceFieldRotationTextZ.text = "Rotation Z: " + vortexParticleForceFieldRotationSliderZ.value;
		vortexParticleForceFieldPositionTextX.text = "Position X: " + vortexParticleForceFieldPositionSliderX.value;
		vortexParticleForceFieldPositionTextY.text = "Position Y: " + vortexParticleForceFieldPositionSliderY.value;
		vortexParticleForceFieldPositionTextZ.text = "Position Z: " + vortexParticleForceFieldPositionSliderZ.value;
	}

	private void Update()
	{
		FPSText.text = "FPS: " + 1f / Time.deltaTime;
		particleCountText.text = "Particle Count: " + particleSystem.particleCount;
	}

	public void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void SetMaxParticles(float value)
	{
		particleSystemMainModule.maxParticles = (int)value;
		maxParticlesText.text = "Max Particles: " + value;
	}

	public void SetParticleEmissionPerSecond(float value)
	{
		particleSystemEmissionModule.rateOverTime = value;
		particlesPerSecondText.text = "Particles Per Second: " + value;
	}

	public void SetAttractionParticleForceFieldRadius(float value)
	{
		attractionParticleForceField.radius = value;
		attractionParticleForceFieldRadiusText.text = "Radius: " + value;
	}

	public void SetAttractionParticleForceFieldMaxForce(float value)
	{
		attractionParticleForceField.force = value;
		attractionParticleForceFieldMaxForceText.text = "Max Force: " + value;
	}

	public void SetAttractionParticleForceFieldArrivalRadius(float value)
	{
		attractionParticleForceField.arrivalRadius = value;
		attractionParticleForceFieldArrivalRadiusText.text = "Arrival Radius: " + value;
	}

	public void SetAttractionParticleForceFieldArrivedRadius(float value)
	{
		attractionParticleForceField.arrivedRadius = value;
		attractionParticleForceFieldArrivedRadiusText.text = "Arrived Radius: " + value;
	}

	public void SetAttractionParticleForceFieldPositionX(float value)
	{
		Vector3 position = attractionParticleForceField.transform.position;
		position.x = value;
		attractionParticleForceField.transform.position = position;
		attractionParticleForceFieldPositionTextX.text = "Position X: " + value;
	}

	public void SetAttractionParticleForceFieldPositionY(float value)
	{
		Vector3 position = attractionParticleForceField.transform.position;
		position.y = value;
		attractionParticleForceField.transform.position = position;
		attractionParticleForceFieldPositionTextY.text = "Position Y: " + value;
	}

	public void SetAttractionParticleForceFieldPositionZ(float value)
	{
		Vector3 position = attractionParticleForceField.transform.position;
		position.z = value;
		attractionParticleForceField.transform.position = position;
		attractionParticleForceFieldPositionTextZ.text = "Position Z: " + value;
	}

	public void SetVortexParticleForceFieldRadius(float value)
	{
		vortexParticleForceField.radius = value;
		vortexParticleForceFieldRadiusText.text = "Radius: " + value;
	}

	public void SetVortexParticleForceFieldMaxForce(float value)
	{
		vortexParticleForceField.force = value;
		vortexParticleForceFieldMaxForceText.text = "Max Force: " + value;
	}

	public void SetVortexParticleForceFieldRotationX(float value)
	{
		Vector3 eulerAngles = vortexParticleForceField.transform.eulerAngles;
		eulerAngles.x = value;
		vortexParticleForceField.transform.eulerAngles = eulerAngles;
		vortexParticleForceFieldRotationTextX.text = "Rotation X: " + value;
	}

	public void SetVortexParticleForceFieldRotationY(float value)
	{
		Vector3 eulerAngles = vortexParticleForceField.transform.eulerAngles;
		eulerAngles.y = value;
		vortexParticleForceField.transform.eulerAngles = eulerAngles;
		vortexParticleForceFieldRotationTextY.text = "Rotation Y: " + value;
	}

	public void SetVortexParticleForceFieldRotationZ(float value)
	{
		Vector3 eulerAngles = vortexParticleForceField.transform.eulerAngles;
		eulerAngles.z = value;
		vortexParticleForceField.transform.eulerAngles = eulerAngles;
		vortexParticleForceFieldRotationTextZ.text = "Rotation Z: " + value;
	}

	public void SetVortexParticleForceFieldPositionX(float value)
	{
		Vector3 position = vortexParticleForceField.transform.position;
		position.x = value;
		vortexParticleForceField.transform.position = position;
		vortexParticleForceFieldPositionTextX.text = "Position X: " + value;
	}

	public void SetVortexParticleForceFieldPositionY(float value)
	{
		Vector3 position = vortexParticleForceField.transform.position;
		position.y = value;
		vortexParticleForceField.transform.position = position;
		vortexParticleForceFieldPositionTextY.text = "Position Y: " + value;
	}

	public void SetVortexParticleForceFieldPositionZ(float value)
	{
		Vector3 position = vortexParticleForceField.transform.position;
		position.z = value;
		vortexParticleForceField.transform.position = position;
		vortexParticleForceFieldPositionTextZ.text = "Position Z: " + value;
	}
}
