namespace Assets.MobileOptimizedWater.Scripts
{
    using Assets.Scripts.Helpers;
    using UnityEngine;
    using UnityEngine.UI;

    public class FPSUI : MonoBehaviour
    {
        [SerializeField] private Text fpsText;
        private FPSCounter fpsCounter;

        public void Awake()
        {
            fpsCounter = new FPSCounter();
        }

        public void Update()
        {
            // fpsCounter가 null이 아닌지 확인
            if (fpsCounter != null)
            {
                fpsCounter.Update(Time.deltaTime);
                fpsText.text = "Fps: " + fpsCounter.GetAverageFps(1f).ToString("###");
            }
            else
            {
                // 필요에 따라 null인 경우의 처리를 추가할 수 있습니다.
                Debug.LogWarning("fpsCounter is null!");
            }
        }
    }
}
