using UnityEngine;
using UnityEngine.UI;

public class FrameAnimation : MonoBehaviour
{
	[Tooltip("资源文件夹路径(相对于Resources文件夹)")]
	[Header("动画设置")]
	public string resourceFolderPath;

	[Tooltip("每秒播放帧数")]
	public float framesPerSecond;

	[Tooltip("是否自动播放")]
	public bool autoPlay;

	private Image imageComponent;

	private Sprite[] frameSprites;

	private float startTime;

	private bool isPlaying;

	private float frameDuration;

	private int totalFrames;

	private void Start()
	{
	}

	private void LoadSprites()
	{
	}

	private void Update()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void SetFrame(int frameIndex)
	{
	}

	public void SetSpeed(float fps)
	{
	}

	private void OnDisable()
	{
	}
}
