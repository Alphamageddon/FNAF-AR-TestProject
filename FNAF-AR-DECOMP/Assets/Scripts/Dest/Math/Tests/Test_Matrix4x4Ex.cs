using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Matrix4x4Ex : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime now;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Plane3 plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject shadowObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter MF;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshRenderer MR;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Light LightSource;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            this.plane = 0;
            mem[1152921519572042004] = 0;
            mem[1152921519572042012] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_23;
            float val_24;
            float val_25;
            var val_26;
            float val_27;
            UnityEngine.Transform val_2 = this.LightSource.transform;
            if(this.LightSource.type == 1)
            {
                    UnityEngine.Vector3 val_3 = val_2.forward;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                val_23 = val_4.x;
                val_24 = val_4.y;
                val_25 = val_4.z;
                val_26 = null;
                val_27 = 0f;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = val_2.position;
                val_23 = val_5.x;
                val_24 = val_5.y;
                val_25 = val_5.z;
                val_26 = null;
                val_27 = 1f;
            }
            
            UnityEngine.Vector4 val_6 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
            UnityEngine.Matrix4x4 val_9 = this.MF.transform.localToWorldMatrix;
            UnityEngine.Matrix4x4 val_14 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            UnityEngine.Graphics.DrawMesh(mesh:  this.MF.sharedMesh, matrix:  new UnityEngine.Matrix4x4() {m00 = val_18, m10 = val_18, m20 = val_18, m30 = val_18, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_16, m12 = val_16, m22 = val_16, m32 = val_16, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17}, material:  this.MR.sharedMaterial, layer:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LogCorrectness(bool value, string log)
        {
            if(value != false)
            {
                    Dest.Math.Logger.LogWarning(value:  log);
                return;
            }
            
            Dest.Math.Logger.LogError(value:  log);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BeginTest()
        {
            System.DateTime val_1 = System.DateTime.Now;
            this.now = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double EndTest()
        {
            System.DateTime val_1 = System.DateTime.Now;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.now});
            return (double)val_2._ticks.TotalSeconds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestCorrectness()
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_52;
            float val_53;
            float val_54;
            float val_55;
            float val_65;
            float val_66;
            float val_67;
            float val_68;
            float val_78;
            float val_79;
            float val_80;
            float val_81;
            float val_91;
            float val_92;
            float val_93;
            float val_94;
            float val_105;
            float val_106;
            float val_107;
            float val_108;
            float val_109;
            float val_110;
            float val_111;
            float val_112;
            float val_118;
            float val_119;
            float val_120;
            float val_121;
            float val_122;
            float val_123;
            float val_124;
            float val_125;
            float val_127;
            float val_128;
            float val_129;
            float val_130;
            float val_135;
            float val_136;
            float val_137;
            float val_138;
            float val_143;
            float val_144;
            float val_145;
            float val_146;
            float val_152;
            float val_153;
            float val_154;
            float val_155;
            float val_161;
            float val_162;
            float val_163;
            float val_164;
            float val_170;
            float val_171;
            float val_172;
            float val_173;
            float val_185;
            float val_186;
            float val_187;
            float val_188;
            float val_199;
            float val_200;
            float val_201;
            float val_202;
            float val_203;
            float val_204;
            float val_205;
            float val_206;
            float val_211;
            float val_212;
            float val_213;
            float val_214;
            float val_215;
            float val_216;
            float val_217;
            float val_218;
            float val_224;
            float val_225;
            float val_226;
            float val_227;
            float val_228;
            float val_229;
            float val_230;
            float val_231;
            float val_233;
            float val_234;
            float val_235;
            float val_236;
            float val_247;
            float val_248;
            float val_249;
            float val_250;
            float val_251;
            float val_252;
            float val_253;
            float val_254;
            float val_259;
            float val_260;
            float val_261;
            float val_262;
            float val_263;
            float val_264;
            float val_265;
            float val_266;
            float val_272;
            float val_273;
            float val_274;
            float val_275;
            float val_276;
            float val_277;
            float val_278;
            float val_279;
            float val_284;
            float val_285;
            float val_286;
            float val_287;
            float val_288;
            float val_289;
            float val_290;
            float val_291;
            float val_293;
            float val_294;
            float val_295;
            float val_296;
            float val_307;
            float val_308;
            float val_309;
            float val_310;
            float val_311;
            float val_312;
            float val_313;
            float val_314;
            float val_316;
            float val_317;
            float val_318;
            float val_319;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.AngleAxis(angle:  78f, axis:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            mem[1152921519573138684] = val_1.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_2.y;
            mem[1152921519573138648] = val_2.z;
            mem[1152921519573138640] = val_2.x;
            UnityEngine.Matrix4x4 val_3 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_1.x, y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            UnityEngine.Matrix4x4 val_9 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, q:  new UnityEngine.Quaternion() {x = val_1.x, y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_15.y;
            mem[1152921519573138648] = val_15.z;
            mem[1152921519573138640] = val_15.x;
            UnityEngine.Matrix4x4 val_16 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            Dest.Math.Matrix4x4ex.CreateTranslation(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_22 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_17, m10 = val_17, m20 = val_17, m30 = val_17, m01 = val_18, m11 = val_18, m21 = val_18, m31 = val_18, m02 = val_19, m12 = val_19, m22 = val_19, m32 = val_19, m03 = val_20, m13 = val_20, m23 = val_20, m33 = val_20}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_17);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_25 = "transEqual: "("transEqual: ") + val_22.ToString();
            val_25.LogCorrectness(value:  (val_22 == true) ? 1 : 0, log:  val_25);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.identity;
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            UnityEngine.Matrix4x4 val_28 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, q:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            Dest.Math.Matrix4x4ex.CreateScale(scale:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_34 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_31, m12 = val_31, m22 = val_31, m32 = val_31, m03 = val_32, m13 = val_32, m23 = val_32, m33 = val_32}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_29);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_36 = "scaleEqual: "("scaleEqual: ") + val_34.ToString();
            val_36.LogCorrectness(value:  val_34, log:  val_36);
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_38.y;
            mem[1152921519573138648] = val_38.z;
            mem[1152921519573138640] = val_38.x;
            UnityEngine.Matrix4x4 val_39 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, q:  new UnityEngine.Quaternion() {x = val_1.x, y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            Dest.Math.Matrix4x4ex.QuaternionToRotationMatrix(quaternion:  new UnityEngine.Quaternion() {x = val_1.x, y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_45 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_43, m10 = val_43, m20 = val_43, m30 = val_43, m01 = val_42, m11 = val_42, m21 = val_42, m31 = val_42, m02 = val_41, m12 = val_41, m22 = val_41, m32 = val_41, m03 = val_40, m13 = val_40, m23 = val_40, m33 = val_40}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_43);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_47 = "rotationConversionEqual: "("rotationConversionEqual: ") + val_45.ToString();
            val_47.LogCorrectness(value:  val_45, log:  val_47);
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_49 = UnityEngine.Quaternion.AngleAxis(angle:  45f, axis:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            mem[1152921519573138680] = val_1.x;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_50.y;
            mem[1152921519573138648] = val_50.z;
            mem[1152921519573138640] = val_50.x;
            UnityEngine.Matrix4x4 val_51 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, q:  new UnityEngine.Quaternion() {x = val_49.x, y = val_49.y, z = val_49.z, w = val_49.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            Dest.Math.Matrix4x4ex.CreateRotationAngleAxis(angleInDegrees:  45f, rotationAxis:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_57 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_52, m10 = val_52, m20 = val_52, m30 = val_52, m01 = val_55, m11 = val_55, m21 = val_55, m31 = val_55, m02 = val_54, m12 = val_54, m22 = val_54, m32 = val_54, m03 = val_53, m13 = val_53, m23 = val_53, m33 = val_53}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_52);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_59 = "angleAxisEqual: "("angleAxisEqual: ") + val_57.ToString();
            val_59.LogCorrectness(value:  val_57, log:  val_59);
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.right;
            UnityEngine.Quaternion val_62 = UnityEngine.Quaternion.AngleAxis(angle:  45f, axis:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_63.y;
            mem[1152921519573138648] = val_63.z;
            mem[1152921519573138640] = val_63.x;
            UnityEngine.Matrix4x4 val_64 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, q:  new UnityEngine.Quaternion() {x = val_62.x, y = val_62.y, z = val_62.z, w = val_62.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            Dest.Math.Matrix4x4ex.CreateRotationX(angleInDegrees:  45f, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_70 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_68, m10 = val_68, m20 = val_68, m30 = val_68, m01 = val_67, m11 = val_67, m21 = val_67, m31 = val_67, m02 = val_66, m12 = val_66, m22 = val_66, m32 = val_66, m03 = val_65, m13 = val_65, m23 = val_65, m33 = val_65}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_68);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_72 = "rotXEqual: "("rotXEqual: ") + val_70.ToString();
            val_72.LogCorrectness(value:  val_70, log:  val_72);
            UnityEngine.Vector3 val_73 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_74 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_75 = UnityEngine.Quaternion.AngleAxis(angle:  45f, axis:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_76 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_76.y;
            mem[1152921519573138648] = val_76.z;
            mem[1152921519573138640] = val_76.x;
            UnityEngine.Matrix4x4 val_77 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z}, q:  new UnityEngine.Quaternion() {x = val_75.x, y = val_75.y, z = val_75.z, w = val_75.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            Dest.Math.Matrix4x4ex.CreateRotationY(angleInDegrees:  45f, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_83 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_81, m10 = val_81, m20 = val_81, m30 = val_81, m01 = val_80, m11 = val_80, m21 = val_80, m31 = val_80, m02 = val_79, m12 = val_79, m22 = val_79, m32 = val_79, m03 = val_78, m13 = val_78, m23 = val_78, m33 = val_78}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_81);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_85 = "rotYEqual: "("rotYEqual: ") + val_83.ToString();
            val_85.LogCorrectness(value:  val_83, log:  val_85);
            UnityEngine.Vector3 val_86 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_87 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_88 = UnityEngine.Quaternion.AngleAxis(angle:  45f, axis:  new UnityEngine.Vector3() {x = val_87.x, y = val_87.y, z = val_87.z});
            UnityEngine.Vector3 val_89 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_89.y;
            mem[1152921519573138648] = val_89.z;
            mem[1152921519573138640] = val_89.x;
            UnityEngine.Matrix4x4 val_90 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_86.z}, q:  new UnityEngine.Quaternion() {x = val_88.x, y = val_88.y, z = val_88.z, w = val_88.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            Dest.Math.Matrix4x4ex.CreateRotationZ(angleInDegrees:  45f, matrix: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_96 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_94, m10 = val_94, m20 = val_94, m30 = val_94, m01 = val_93, m11 = val_93, m21 = val_93, m31 = val_93, m02 = val_92, m12 = val_92, m22 = val_92, m32 = val_92, m03 = val_91, m13 = val_91, m23 = val_91, m33 = val_91}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_94);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_98 = "rotZEqual: "("rotZEqual: ") + val_96.ToString();
            val_98.LogCorrectness(value:  val_96, log:  val_98);
            UnityEngine.Quaternion val_99 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_100 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_100.y;
            mem[1152921519573138648] = val_100.z;
            mem[1152921519573138640] = val_100.x;
            UnityEngine.Matrix4x4 val_101 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_99.x, y = val_99.y, z = val_99.z, w = val_99.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Vector3 val_102 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_103 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_103.y;
            mem[1152921519573138648] = val_103.z;
            mem[1152921519573138640] = val_103.x;
            UnityEngine.Matrix4x4 val_104 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_102.x, y = val_102.y, z = val_102.z}, q:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_113 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_108, m10 = val_108, m20 = val_108, m30 = val_108, m01 = val_107, m11 = val_107, m21 = val_107, m31 = val_107, m02 = val_106, m12 = val_106, m22 = val_106, m32 = val_106, m03 = val_105, m13 = val_105, m23 = val_105, m33 = val_105}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_112, m10 = val_112, m20 = val_112, m30 = val_112, m01 = val_111, m11 = val_111, m21 = val_111, m31 = val_111, m02 = val_110, m12 = val_110, m22 = val_110, m32 = val_110, m03 = val_109, m13 = val_109, m23 = val_109, m33 = val_109});
            UnityEngine.Vector3 val_114 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Quaternion val_115 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_116 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_116.y;
            mem[1152921519573138648] = val_116.z;
            mem[1152921519573138640] = val_116.x;
            UnityEngine.Matrix4x4 val_117 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_114.x, y = val_114.y, z = val_114.z}, q:  new UnityEngine.Quaternion() {x = val_115.x, y = val_115.y, z = val_115.z, w = val_115.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_126 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_121, m10 = val_121, m20 = val_121, m30 = val_121, m01 = val_120, m11 = val_120, m21 = val_120, m31 = val_120, m02 = val_119, m12 = val_119, m22 = val_119, m32 = val_119, m03 = val_118, m13 = val_118, m23 = val_118, m33 = val_118}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_125, m10 = val_125, m20 = val_125, m30 = val_125, m01 = val_124, m11 = val_124, m21 = val_124, m31 = val_124, m02 = val_123, m12 = val_123, m22 = val_123, m32 = val_123, m03 = val_122, m13 = val_122, m23 = val_122, m33 = val_122});
            Dest.Math.Matrix4x4ex.CreateRotation(rotationOrigin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, result: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_132 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_127, m10 = val_127, m20 = val_127, m30 = val_127, m01 = val_129, m11 = val_129, m21 = val_129, m31 = val_129, m02 = val_128, m12 = val_128, m22 = val_128, m32 = val_128, m03 = val_130, m13 = val_130, m23 = val_130, m33 = val_130}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_127);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_134 = "rotAroundEqual: "("rotAroundEqual: ") + val_132.ToString();
            val_134.LogCorrectness(value:  val_132, log:  val_134);
            Dest.Math.Matrix4x4ex.Transpose(matrix: ref  new UnityEngine.Matrix4x4() {m00 = val_127, m10 = val_127, m20 = val_127, m30 = val_127, m01 = val_129, m11 = val_129, m21 = val_129, m31 = val_129, m02 = val_128, m12 = val_128, m22 = val_128, m32 = val_128, m03 = val_130, m13 = val_130, m23 = val_130, m33 = val_130}, transpose: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_140 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_135, m10 = val_135, m20 = val_135, m30 = val_135, m01 = val_136, m11 = val_136, m21 = val_136, m31 = val_136, m02 = val_137, m12 = val_137, m22 = val_137, m32 = val_137, m03 = val_138, m13 = val_138, m23 = val_138, m33 = val_138}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_135);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_142 = "transpEqual: "("transpEqual: ") + val_140.ToString();
            val_142.LogCorrectness(value:  val_140, log:  val_142);
            Dest.Math.Matrix4x4ex.Inverse(matrix: ref  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, inverse: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f}, epsilon:  1E-05f);
            bool val_148 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_143, m10 = val_143, m20 = val_143, m30 = val_143, m01 = val_144, m11 = val_144, m21 = val_144, m31 = val_144, m02 = val_145, m12 = val_145, m22 = val_145, m32 = val_145, m03 = val_146, m13 = val_146, m23 = val_146, m33 = val_146}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_143);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_150 = "invEqual: "("invEqual: ") + val_148.ToString();
            val_150.LogCorrectness(value:  val_148, log:  val_150);
            UnityEngine.Matrix4x4 val_151 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            Dest.Math.Matrix4x4ex.Multiply(matrix0: ref  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, matrix1: ref  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11}, result: out  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            bool val_157 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_152, m10 = val_152, m20 = val_152, m30 = val_152, m01 = val_153, m11 = val_153, m21 = val_153, m31 = val_153, m02 = val_154, m12 = val_154, m22 = val_154, m32 = val_154, m03 = val_155, m13 = val_155, m23 = val_155, m33 = val_155}, rhs:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            Dest.Math.Logger.LogInfo(value:  val_152);
            Dest.Math.Logger.LogInfo(value:  0);
            string val_159 = "matrMultEqual: "("matrMultEqual: ") + val_157.ToString();
            val_159.LogCorrectness(value:  val_157, log:  val_159);
            UnityEngine.Matrix4x4 val_160 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            Dest.Math.Matrix4x4ex.MultiplyRight(matrix0: ref  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, matrix1: ref  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            bool val_166 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_161, m10 = val_161, m20 = val_161, m30 = val_161, m01 = val_162, m11 = val_162, m21 = val_162, m31 = val_162, m02 = val_163, m12 = val_163, m22 = val_163, m32 = val_163, m03 = val_164, m13 = val_164, m23 = val_164, m33 = val_164}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            Dest.Math.Logger.LogInfo(value:  val_161);
            Dest.Math.Logger.LogInfo(value:  val_6);
            string val_168 = "matrMultRightEqual: "("matrMultRightEqual: ") + val_166.ToString();
            val_168.LogCorrectness(value:  val_166, log:  val_168);
            UnityEngine.Matrix4x4 val_169 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            Dest.Math.Matrix4x4ex.MultiplyLeft(matrix1: ref  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, matrix0: ref  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            bool val_175 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_170, m10 = val_170, m20 = val_170, m30 = val_170, m01 = val_171, m11 = val_171, m21 = val_171, m31 = val_171, m02 = val_172, m12 = val_172, m22 = val_172, m32 = val_172, m03 = val_173, m13 = val_173, m23 = val_173, m33 = val_173}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            Dest.Math.Logger.LogInfo(value:  val_170);
            Dest.Math.Logger.LogInfo(value:  val_6);
            string val_177 = "matrMultLeftEqual: "("matrMultLeftEqual: ") + val_175.ToString();
            val_177.LogCorrectness(value:  val_175, log:  val_177);
            UnityEngine.Vector4 val_178 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, vector:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            UnityEngine.Vector4 val_179 = Dest.Math.Matrix4x4ex.Multiply(matrix: ref  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5}, vector:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            bool val_181 = UnityEngine.Vector4.op_Equality(lhs:  new UnityEngine.Vector4() {x = val_178.x, y = val_178.y, z = val_178.z, w = val_178.w}, rhs:  new UnityEngine.Vector4() {x = val_179.x, y = val_179.y, z = val_179.z, w = val_179.w});
            Dest.Math.Logger.LogInfo(value:  val_178);
            Dest.Math.Logger.LogInfo(value:  val_179);
            string val_183 = "vecMultEqual: "("vecMultEqual: ") + val_181.ToString();
            val_183.LogCorrectness(value:  val_181, log:  val_183);
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            UnityEngine.Matrix4x4 val_184 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            Dest.Math.Matrix4x4ex.CreateSRT(scaling:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, translation:  new UnityEngine.Vector3() {x = 0f, y = 0f}, result: out  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            bool val_190 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_185, m10 = val_185, m20 = val_185, m30 = val_185, m01 = val_186, m11 = val_186, m21 = val_186, m31 = val_186, m02 = val_187, m12 = val_187, m22 = val_187, m32 = val_187, m03 = val_188, m13 = val_188, m23 = val_188, m33 = val_188}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            Dest.Math.Logger.LogInfo(value:  val_185);
            Dest.Math.Logger.LogInfo(value:  val_6);
            string val_192 = "srt: "("srt: ") + val_190.ToString();
            val_192.LogCorrectness(value:  val_190, log:  val_192);
            UnityEngine.Quaternion val_193 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_194 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_194.y;
            mem[1152921519573138648] = val_194.z;
            mem[1152921519573138640] = val_194.x;
            UnityEngine.Matrix4x4 val_195 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_193.x, y = val_193.y, z = val_193.z, w = val_193.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Quaternion val_196 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_197 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_197.y;
            mem[1152921519573138648] = val_197.z;
            mem[1152921519573138640] = val_197.x;
            UnityEngine.Matrix4x4 val_198 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_196.x, y = val_196.y, z = val_196.z, w = val_196.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_207 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_202, m10 = val_202, m20 = val_202, m30 = val_202, m01 = val_201, m11 = val_201, m21 = val_201, m31 = val_201, m02 = val_200, m12 = val_200, m22 = val_200, m32 = val_200, m03 = val_199, m13 = val_199, m23 = val_199, m33 = val_199}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_206, m10 = val_206, m20 = val_206, m30 = val_206, m01 = val_205, m11 = val_205, m21 = val_205, m31 = val_205, m02 = val_204, m12 = val_204, m22 = val_204, m32 = val_204, m03 = val_203, m13 = val_203, m23 = val_203, m33 = val_203});
            UnityEngine.Vector3 val_208 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_209 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_209.y;
            mem[1152921519573138648] = val_209.z;
            mem[1152921519573138640] = val_209.x;
            UnityEngine.Matrix4x4 val_210 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_208.x, y = val_208.y, z = val_208.z}, q:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_219 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_214, m10 = val_214, m20 = val_214, m30 = val_214, m01 = val_213, m11 = val_213, m21 = val_213, m31 = val_213, m02 = val_212, m12 = val_212, m22 = val_212, m32 = val_212, m03 = val_211, m13 = val_211, m23 = val_211, m33 = val_211}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_218, m10 = val_218, m20 = val_218, m30 = val_218, m01 = val_217, m11 = val_217, m21 = val_217, m31 = val_217, m02 = val_216, m12 = val_216, m22 = val_216, m32 = val_216, m03 = val_215, m13 = val_215, m23 = val_215, m33 = val_215});
            UnityEngine.Vector3 val_220 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Quaternion val_221 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_222 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_222.y;
            mem[1152921519573138648] = val_222.z;
            mem[1152921519573138640] = val_222.x;
            UnityEngine.Matrix4x4 val_223 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_220.x, y = val_220.y, z = val_220.z}, q:  new UnityEngine.Quaternion() {x = val_221.x, y = val_221.y, z = val_221.z, w = val_221.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_232 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_227, m10 = val_227, m20 = val_227, m30 = val_227, m01 = val_226, m11 = val_226, m21 = val_226, m31 = val_226, m02 = val_225, m12 = val_225, m22 = val_225, m32 = val_225, m03 = val_224, m13 = val_224, m23 = val_224, m33 = val_224}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_231, m10 = val_231, m20 = val_231, m30 = val_231, m01 = val_230, m11 = val_230, m21 = val_230, m31 = val_230, m02 = val_229, m12 = val_229, m22 = val_229, m32 = val_229, m03 = val_228, m13 = val_228, m23 = val_228, m33 = val_228});
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            Dest.Math.Matrix4x4ex.CreateRT(rotationOrigin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, translation:  new UnityEngine.Vector3() {x = 0f, y = 0f}, result: out  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            bool val_238 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_233, m10 = val_233, m20 = val_233, m30 = val_233, m01 = val_234, m11 = val_234, m21 = val_234, m31 = val_234, m02 = val_235, m12 = val_235, m22 = val_235, m32 = val_235, m03 = val_236, m13 = val_236, m23 = val_236, m33 = val_236}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            Dest.Math.Logger.LogInfo(value:  val_233);
            Dest.Math.Logger.LogInfo(value:  val_6);
            string val_240 = "rtOrigin: "("rtOrigin: ") + val_238.ToString();
            val_240.LogCorrectness(value:  val_238, log:  val_240);
            UnityEngine.Quaternion val_241 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_242 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_242.y;
            mem[1152921519573138648] = val_242.z;
            mem[1152921519573138640] = val_242.x;
            UnityEngine.Matrix4x4 val_243 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_241.x, y = val_241.y, z = val_241.z, w = val_241.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Quaternion val_244 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_245 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_245.y;
            mem[1152921519573138648] = val_245.z;
            mem[1152921519573138640] = val_245.x;
            UnityEngine.Matrix4x4 val_246 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_244.x, y = val_244.y, z = val_244.z, w = val_244.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_255 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_250, m10 = val_250, m20 = val_250, m30 = val_250, m01 = val_249, m11 = val_249, m21 = val_249, m31 = val_249, m02 = val_248, m12 = val_248, m22 = val_248, m32 = val_248, m03 = val_247, m13 = val_247, m23 = val_247, m33 = val_247}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_254, m10 = val_254, m20 = val_254, m30 = val_254, m01 = val_253, m11 = val_253, m21 = val_253, m31 = val_253, m02 = val_252, m12 = val_252, m22 = val_252, m32 = val_252, m03 = val_251, m13 = val_251, m23 = val_251, m33 = val_251});
            UnityEngine.Vector3 val_256 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_257 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_257.y;
            mem[1152921519573138648] = val_257.z;
            mem[1152921519573138640] = val_257.x;
            UnityEngine.Matrix4x4 val_258 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_256.x, y = val_256.y, z = val_256.z}, q:  new UnityEngine.Quaternion() {x = mem[1152921519573138680], y = mem[1152921519573138684], z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_267 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_262, m10 = val_262, m20 = val_262, m30 = val_262, m01 = val_261, m11 = val_261, m21 = val_261, m31 = val_261, m02 = val_260, m12 = val_260, m22 = val_260, m32 = val_260, m03 = val_259, m13 = val_259, m23 = val_259, m33 = val_259}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_266, m10 = val_266, m20 = val_266, m30 = val_266, m01 = val_265, m11 = val_265, m21 = val_265, m31 = val_265, m02 = val_264, m12 = val_264, m22 = val_264, m32 = val_264, m03 = val_263, m13 = val_263, m23 = val_263, m33 = val_263});
            UnityEngine.Vector3 val_268 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Quaternion val_269 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_270 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_270.y;
            mem[1152921519573138648] = val_270.z;
            mem[1152921519573138640] = val_270.x;
            UnityEngine.Matrix4x4 val_271 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_268.x, y = val_268.y, z = val_268.z}, q:  new UnityEngine.Quaternion() {x = val_269.x, y = val_269.y, z = val_269.z, w = val_269.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648]});
            UnityEngine.Matrix4x4 val_280 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_275, m10 = val_275, m20 = val_275, m30 = val_275, m01 = val_274, m11 = val_274, m21 = val_274, m31 = val_274, m02 = val_273, m12 = val_273, m22 = val_273, m32 = val_273, m03 = val_272, m13 = val_272, m23 = val_272, m33 = val_272}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_279, m10 = val_279, m20 = val_279, m30 = val_279, m01 = val_278, m11 = val_278, m21 = val_278, m31 = val_278, m02 = val_277, m12 = val_277, m22 = val_277, m32 = val_277, m03 = val_276, m13 = val_276, m23 = val_276, m33 = val_276});
            UnityEngine.Vector3 val_281 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_282 = UnityEngine.Quaternion.identity;
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            UnityEngine.Matrix4x4 val_283 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_281.x, y = val_281.y, z = val_281.z}, q:  new UnityEngine.Quaternion() {x = val_282.x, y = val_282.y, z = val_282.z, w = val_282.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f});
            UnityEngine.Matrix4x4 val_292 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_287, m10 = val_287, m20 = val_287, m30 = val_287, m01 = val_286, m11 = val_286, m21 = val_286, m31 = val_286, m02 = val_285, m12 = val_285, m22 = val_285, m32 = val_285, m03 = val_284, m13 = val_284, m23 = val_284, m33 = val_284}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_291, m10 = val_291, m20 = val_291, m30 = val_291, m01 = val_290, m11 = val_290, m21 = val_290, m31 = val_290, m02 = val_289, m12 = val_289, m22 = val_289, m32 = val_289, m03 = val_288, m13 = val_288, m23 = val_288, m33 = val_288});
            mem[1152921519573138664] = 0f;
            mem[1152921519573138648] = val_1.z;
            mem[1152921519573138652] = val_1.w;
            mem[1152921519573138656] = 0;
            mem[1152921519573138640] = mem[1152921519573138680];
            mem[1152921519573138644] = mem[1152921519573138684];
            Dest.Math.Matrix4x4ex.CreateSRT(scaling:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotationOrigin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = mem[1152921519573138640], y = mem[1152921519573138648], z = 0f, w = 0f}, translation:  new UnityEngine.Vector3() {y = mem[1152921519573138680]}, result: out  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            bool val_298 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_293, m10 = val_293, m20 = val_293, m30 = val_293, m01 = val_294, m11 = val_294, m21 = val_294, m31 = val_294, m02 = val_295, m12 = val_295, m22 = val_295, m32 = val_295, m03 = val_296, m13 = val_296, m23 = val_296, m33 = val_296}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            Dest.Math.Logger.LogInfo(value:  val_293);
            Dest.Math.Logger.LogInfo(value:  val_6);
            string val_300 = "srtOrigin: "("srtOrigin: ") + val_298.ToString();
            val_300.LogCorrectness(value:  val_298, log:  val_300);
            UnityEngine.Quaternion val_301 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_302 = UnityEngine.Vector3.one;
            mem[1152921519573138644] = val_302.y;
            mem[1152921519573138648] = val_302.z;
            mem[1152921519573138640] = val_302.x;
            UnityEngine.Matrix4x4 val_303 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_301.x, y = val_301.y, z = val_301.z, w = val_301.w}, s:  new UnityEngine.Vector3() {x = mem[1152921519573138640], y = mem[1152921519573138648], z = 0f});
            UnityEngine.Vector3 val_304 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_305 = UnityEngine.Quaternion.identity;
            mem[1152921519573138648] = 0f;
            mem[1152921519573138640] = 0;
            UnityEngine.Matrix4x4 val_306 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_304.x, y = val_304.y, z = val_304.z}, q:  new UnityEngine.Quaternion() {x = val_305.x, y = val_305.y, z = val_305.z, w = val_305.w}, s:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Matrix4x4 val_315 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_309, m10 = val_309, m20 = val_309, m30 = val_309, m01 = val_310, m11 = val_310, m21 = val_310, m31 = val_310, m02 = val_307, m12 = val_307, m22 = val_307, m32 = val_307, m03 = val_308, m13 = val_308, m23 = val_308, m33 = val_308}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_313, m10 = val_313, m20 = val_313, m30 = val_313, m01 = val_314, m11 = val_314, m21 = val_314, m31 = val_314, m02 = val_311, m12 = val_311, m22 = val_311, m32 = val_311, m03 = val_312, m13 = val_312, m23 = val_312, m33 = val_312});
            Dest.Math.Matrix4x4ex.CreateST(scaling:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, translation:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, result: out  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            bool val_321 = UnityEngine.Matrix4x4.op_Equality(lhs:  new UnityEngine.Matrix4x4() {m00 = val_316, m10 = val_316, m20 = val_316, m30 = val_316, m01 = val_317, m11 = val_317, m21 = val_317, m31 = val_317, m02 = val_318, m12 = val_318, m22 = val_318, m32 = val_318, m03 = val_319, m13 = val_319, m23 = val_319, m33 = val_319}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_6, m10 = val_6, m20 = val_6, m30 = val_6, m01 = val_7, m11 = val_7, m21 = val_7, m31 = val_7, m02 = val_4, m12 = val_4, m22 = val_4, m32 = val_4, m03 = val_5, m13 = val_5, m23 = val_5, m33 = val_5});
            mem[1152921519573138752] = val_316;
            Dest.Math.Logger.LogInfo(value:  mem[1152921519573138752]);
            mem[1152921519573138720] = val_4;
            mem[1152921519573138736] = val_5;
            mem[1152921519573138688] = val_6;
            mem[1152921519573138704] = val_7;
            Dest.Math.Logger.LogInfo(value:  mem[1152921519573138688]);
            string val_323 = "st: "("st: ") + val_321.ToString();
            val_323.LogCorrectness(value:  val_321, log:  val_323);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Matrix4x4Ex()
        {
        
        }
    
    }

}
