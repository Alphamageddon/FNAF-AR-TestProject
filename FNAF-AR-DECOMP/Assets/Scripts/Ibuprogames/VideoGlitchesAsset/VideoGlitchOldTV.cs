using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchOldTV : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float slowScan;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float scanLine;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float vignetteSoftness;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float vignetteScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float vignetteTubeScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float grainOpacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float grainSaturation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float scanDistort;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float timer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float crtDistort;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float crtScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripesCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float stripesOpacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float barsCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float moireOpacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float moireScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float tvLines;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float tvLinesOpacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float tvDots;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float tvDotsBlend;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableScanline = "_Scanline";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSlowscan = "_Slowscan";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableVignetteSoftness = "_VignetteSoftness";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableVignetteScale = "_VignetteScale";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableGrainOpacity = "_GrainOpacity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSaturation = "_SaturationTV";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableScanDistort = "_ScanDistort";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTimer = "_Timer";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableSpeed = "_Speed";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDistort = "_Distort";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableScale = "_Scale";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableStripesCount = "_StripesCount";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableOpacity = "_Opacity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableBarsCount = "_BarsCount";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableOpacityMoire = "_OpacityMoire";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableMoireScale = "_MoireScale";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTVLines = "_TVLines";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTVLinesOpacity = "_TVLinesOpacity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTVTubeVignetteScale = "_TVTubeVignetteScale";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTVDots = "_TVDots";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableTVDotsBlend = "_TVDotsBlend";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SlowScan { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ScanLine { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float VignetteSoftness { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float VignetteScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float VignetteTubeScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GrainOpacity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GrainSaturation { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ScanDistort { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Timer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CRTDistort { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CRTScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripesCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float StripesOpacity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BarsCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MoireOpacity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MoireScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TVLines { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TVLinesOpacity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TVDots { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TVDotsBlend { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_SlowScan()
        {
            return (float)this.slowScan;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_SlowScan(float value)
        {
            this.slowScan = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ScanLine()
        {
            return (float)this.scanLine;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ScanLine(float value)
        {
            this.scanLine = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  2f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_VignetteSoftness()
        {
            return (float)this.vignetteSoftness;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_VignetteSoftness(float value)
        {
            this.vignetteSoftness = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_VignetteScale()
        {
            return (float)this.vignetteScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_VignetteScale(float value)
        {
            this.vignetteScale = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_VignetteTubeScale()
        {
            return (float)this.vignetteTubeScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_VignetteTubeScale(float value)
        {
            this.vignetteTubeScale = UnityEngine.Mathf.Clamp(value:  value, min:  0.01f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_GrainOpacity()
        {
            return (float)this.grainOpacity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_GrainOpacity(float value)
        {
            this.grainOpacity = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  100f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_GrainSaturation()
        {
            return (float)this.grainSaturation;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_GrainSaturation(float value)
        {
            this.grainSaturation = UnityEngine.Mathf.Clamp01(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ScanDistort()
        {
            return (float)this.scanDistort;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ScanDistort(float value)
        {
            this.scanDistort = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Timer()
        {
            return (float)this.timer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Timer(float value)
        {
            this.timer = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  5f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Speed()
        {
            return (float)this.speed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Speed(float value)
        {
            this.speed = UnityEngine.Mathf.Clamp(value:  value, min:  1f, max:  5f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_CRTDistort()
        {
            return (float)this.crtDistort;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CRTDistort(float value)
        {
            this.crtDistort = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  5f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_CRTScale()
        {
            return (float)this.crtScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CRTScale(float value)
        {
            this.crtScale = UnityEngine.Mathf.Clamp(value:  value, min:  1f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripesCount()
        {
            return (float)this.stripesCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripesCount(float value)
        {
            this.stripesCount = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1000f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_StripesOpacity()
        {
            return (float)this.stripesOpacity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_StripesOpacity(float value)
        {
            this.stripesOpacity = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_BarsCount()
        {
            return (float)this.barsCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BarsCount(float value)
        {
            this.barsCount = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1000f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MoireOpacity()
        {
            return (float)this.moireOpacity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MoireOpacity(float value)
        {
            this.moireOpacity = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  100f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MoireScale()
        {
            return (float)this.moireScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MoireScale(float value)
        {
            this.moireScale = UnityEngine.Mathf.Clamp(value:  value, min:  0.01f, max:  100f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_TVLines()
        {
            return (float)this.tvLines;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TVLines(float value)
        {
            this.tvLines = UnityEngine.Mathf.Clamp(value:  value, min:  0.01f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_TVLinesOpacity()
        {
            return (float)this.tvLinesOpacity;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TVLinesOpacity(float value)
        {
            this.tvLinesOpacity = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_TVDots()
        {
            return (float)this.tvDots;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TVDots(float value)
        {
            this.tvDots = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  4f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_TVDotsBlend()
        {
            return (float)this.tvDotsBlend;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TVDotsBlend(float value)
        {
            this.tvDotsBlend = UnityEngine.Mathf.Clamp(value:  value, min:  0f, max:  1000f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Old broken TV.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.slowScan = ;
            this.scanLine = ;
            this.vignetteSoftness = 0.9f;
            this.vignetteScale = 0.14f;
            this.grainOpacity = ;
            this.grainSaturation = ;
            this.scanDistort = 0.03f;
            this.timer = 0.85f;
            this.speed = ;
            this.crtDistort = ;
            this.crtScale = 1.06f;
            this.stripesCount = 0.5f;
            this.vignetteTubeScale = 0.7f;
            this.tvLines = ;
            this.tvLinesOpacity = ;
            this.tvDots = 1f;
            this.tvDotsBlend = 1f;
            mem[1152921520043426592] = 998445679;
            this.stripesOpacity = ;
            this.barsCount = ;
            this.moireOpacity = 1f;
            this.moireScale = 0.15f;
            mem[1152921520043426536] = 1065353216;
            mem[1152921520043426564] = 1065353216;
            mem[1152921520043426596] = 1;
            mem[1152921520043426548] = ;
            mem[1152921520043426600] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetFloat(name:  "_Scanline", value:  this.scanLine);
            SetFloat(name:  "_Slowscan", value:  this.slowScan);
            SetFloat(name:  "_VignetteSoftness", value:  this.vignetteSoftness);
            SetFloat(name:  "_VignetteScale", value:  this.vignetteScale);
            SetFloat(name:  "_GrainOpacity", value:  this.grainOpacity);
            SetFloat(name:  "_SaturationTV", value:  this.grainSaturation);
            SetFloat(name:  "_ScanDistort", value:  this.scanDistort);
            SetFloat(name:  "_Timer", value:  this.timer);
            SetFloat(name:  "_Speed", value:  this.speed);
            SetFloat(name:  "_Distort", value:  this.crtDistort);
            SetFloat(name:  "_Scale", value:  this.crtScale);
            SetFloat(name:  "_StripesCount", value:  this.stripesCount);
            SetFloat(name:  "_Opacity", value:  this.stripesOpacity);
            SetFloat(name:  "_BarsCount", value:  this.barsCount);
            SetFloat(name:  "_OpacityMoire", value:  this.moireOpacity);
            SetFloat(name:  "_MoireScale", value:  this.moireScale);
            SetFloat(name:  "_TVLines", value:  this.tvLines);
            SetFloat(name:  "_TVLinesOpacity", value:  this.tvLinesOpacity);
            SetFloat(name:  "_TVTubeVignetteScale", value:  this.vignetteTubeScale);
            SetFloat(name:  "_TVDots", value:  this.tvDots);
            SetFloat(name:  "_TVDotsBlend", value:  this.tvDotsBlend);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchOldTV()
        {
            this.slowScan = ;
            this.scanLine = ;
            this.vignetteSoftness = 0.9f;
            this.vignetteScale = 0.14f;
            this.vignetteTubeScale = 0.7f;
            this.grainOpacity = 5f;
            this.scanDistort = ;
            this.timer = ;
            this.speed = 2f;
            this.crtDistort = 0.03f;
            this.crtScale = ;
            this.stripesCount = ;
            this.stripesOpacity = 1f;
            this.barsCount = 5f;
            this.moireOpacity = 1f;
            this.moireScale = 5.510186E-41f;
            this.tvLines = ;
            this.tvLinesOpacity = ;
            this.tvDots = 1f;
            this.tvDotsBlend = 1f;
        }
    
    }

}
