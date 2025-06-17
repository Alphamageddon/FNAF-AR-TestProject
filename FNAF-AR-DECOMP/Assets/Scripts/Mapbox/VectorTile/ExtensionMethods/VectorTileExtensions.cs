using UnityEngine;

namespace Mapbox.VectorTile.ExtensionMethods
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class VectorTileExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ToGeoJson(Mapbox.VectorTile.VectorTile tile, ulong zoom, ulong tileColumn, ulong tileRow, System.Nullable<uint> clipBuffer)
        {
            double val_47;
            bool val_98;
            string val_99;
            System.Collections.Generic.List<T> val_100;
            string val_101;
            string val_102;
            var val_103;
            var val_105;
            string val_106;
            var val_107;
            var val_108;
            var val_109;
            var val_110;
            System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String> val_112;
            object val_113;
            var val_115;
            System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String> val_117;
            var val_118;
            var val_119;
            System.Func<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng>, System.Collections.Generic.IEnumerable<Mapbox.VectorTile.Geometry.LatLng>> val_121;
            var val_122;
            var val_123;
            System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String> val_125;
            var val_126;
            System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String> val_128;
            var val_129;
            var val_130;
            System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String> val_132;
            var val_137;
            var val_138;
            var val_139;
            val_98 = clipBuffer.HasValue;
            val_99 = "{{\"type\":\"FeatureCollection\",\"features\":[{0}]}}";
            System.Collections.Generic.List<System.String> val_1 = null;
            val_100 = val_1;
            val_1 = new System.Collections.Generic.List<System.String>();
            val_101 = tile.LayerNames();
            System.Collections.Generic.IEnumerator<T> val_3 = val_101.GetEnumerator();
            val_102 = ",";
            val_103 = 1152921515834702288;
            goto label_3;
            label_145:
            var val_100 = 0;
            val_100 = val_100 + 1;
            val_101 = val_3.Current;
            Mapbox.VectorTile.VectorTileLayer val_6 = tile.GetLayer(layerName:  val_101);
            val_105 = 0;
            goto label_73;
            label_139:
            Mapbox.VectorTile.VectorTileFeature val_7 = val_6.GetFeature(feature:  0, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = val_98}, scale:  1f);
            if(val_7.GeometryType == 0)
            {
                goto label_13;
            }
            
            System.Collections.Generic.List<System.String> val_9 = new System.Collections.Generic.List<System.String>();
            int val_11 = val_7.Tags.Count;
            if(val_11 >= 1)
            {
                    int val_101 = 0;
                do
            {
                val_101 = val_101 + 1;
                null.Add(item:  System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  "\"{0}\":\"{1}\"", arg0:  val_6.Keys.Item[val_7.Tags.Item[0]], arg1:  val_6.Values.Item[val_7.Tags.Item[val_101]]));
                val_102 = ",";
                val_101 = val_101 + 1;
            }
            while(val_101 < val_11);
            
            }
            
            object[] val_23 = new object[4];
            val_23[0] = val_7.Id;
            val_23[1] = val_6.Name;
            val_23[2] = (null.Count > 0) ? (val_102) : "";
            val_23[3] = System.String.Join(separator:  ",", value:  null.ToArray());
            val_106 = System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  "{{\"id\":{0},\"lyr\":\"{1}\"{2}{3}}}", args:  val_23);
            val_107 = "";
            string val_32 = Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum());
            val_101 = Mapbox.VectorTile.ExtensionMethods.VectorTileFeatureExtensions.GeometryAsWgs84(feature:  val_7, zoom:  zoom, tileColumn:  tileColumn, tileRow:  tileRow, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = false});
            val_108 = 1152921519924644672;
            if(val_101.Count >= 2)
            {
                goto label_46;
            }
            
            val_98 = val_98;
            val_108 = 1152921519924644672;
            if(val_101.Count != 1)
            {
                goto label_48;
            }
            
            Mapbox.VectorTile.Geometry.GeomType val_36 = val_7.GeometryType;
            if(val_36 == 1)
            {
                goto label_50;
            }
            
            if(val_36 == 2)
            {
                goto label_51;
            }
            
            if(val_36 != 3)
            {
                goto label_94;
            }
            
            val_109 = 1152921505125855232;
            val_110 = null;
            val_110 = null;
            val_112 = VectorTileExtensions.<>c.<>9__0_1;
            if(val_112 == null)
            {
                    val_109 = 1152921505125855232;
                val_112 = null;
                val_112 = new System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String>(object:  VectorTileExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.String VectorTileExtensions.<>c::<ToGeoJson>b__0_1(Mapbox.VectorTile.Geometry.LatLng g));
                VectorTileExtensions.<>c.<>9__0_1 = val_112;
            }
            
            val_108 = "]";
            val_113 = "[" + System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_101.Item[0], selector:  null)))(System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_101.Item[0], selector:  null)))) + "]";
            goto label_129;
            label_46:
            Mapbox.VectorTile.Geometry.GeomType val_43 = val_7.GeometryType;
            if(val_43 == 1)
            {
                goto label_61;
            }
            
            if(val_43 == 2)
            {
                goto label_62;
            }
            
            if(val_43 != 3)
            {
                goto label_94;
            }
            
            System.Collections.Generic.List<System.String> val_44 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_45 = val_101.GetEnumerator();
            label_72:
            if(((-1861574944) & 1) == 0)
            {
                goto label_107;
            }
            
            val_115 = null;
            val_115 = null;
            val_117 = VectorTileExtensions.<>c.<>9__0_5;
            if(val_117 == null)
            {
                    val_117 = null;
                val_117 = new System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String>(object:  VectorTileExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.String VectorTileExtensions.<>c::<ToGeoJson>b__0_5(Mapbox.VectorTile.Geometry.LatLng g));
                VectorTileExtensions.<>c.<>9__0_5 = val_117;
            }
            
            null.Add(item:  "[" + System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_47.emailUIDataHandler, selector:  null)))(System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_47.emailUIDataHandler, selector:  null)))) + "]");
            goto label_72;
            label_48:
            val_99 = val_99;
            label_13:
            label_137:
            val_105 = 1;
            goto label_73;
            label_61:
            val_118 = 1152921505125855232;
            val_119 = null;
            val_119 = null;
            val_121 = VectorTileExtensions.<>c.<>9__0_2;
            if(val_121 == null)
            {
                    val_118 = 1152921505125855232;
                val_121 = null;
                val_121 = new System.Func<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng>, System.Collections.Generic.IEnumerable<Mapbox.VectorTile.Geometry.LatLng>>(object:  VectorTileExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Mapbox.VectorTile.Geometry.LatLng> VectorTileExtensions.<>c::<ToGeoJson>b__0_2(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng> g));
                VectorTileExtensions.<>c.<>9__0_2 = val_121;
            }
            
            val_122 = 1152921505125855232;
            val_123 = null;
            val_123 = null;
            val_125 = VectorTileExtensions.<>c.<>9__0_3;
            if(val_125 == null)
            {
                    val_122 = 1152921505125855232;
                val_125 = null;
                val_125 = new System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String>(object:  VectorTileExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.String VectorTileExtensions.<>c::<ToGeoJson>b__0_3(Mapbox.VectorTile.Geometry.LatLng g));
                VectorTileExtensions.<>c.<>9__0_3 = val_125;
            }
            
            val_108 = 1152921517553234912;
            val_113 = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng>, Mapbox.VectorTile.Geometry.LatLng>(source:  val_101, selector:  null), selector:  null)));
            goto label_129;
            label_62:
            System.Collections.Generic.List<System.String> val_60 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_61 = val_101.GetEnumerator();
            label_93:
            if(((-1861574944) & 1) == 0)
            {
                goto label_108;
            }
            
            val_126 = null;
            val_126 = null;
            val_128 = VectorTileExtensions.<>c.<>9__0_4;
            if(val_128 == null)
            {
                    val_128 = null;
                val_128 = new System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String>(object:  VectorTileExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.String VectorTileExtensions.<>c::<ToGeoJson>b__0_4(Mapbox.VectorTile.Geometry.LatLng g));
                VectorTileExtensions.<>c.<>9__0_4 = val_128;
            }
            
            null.Add(item:  "[" + System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_7.GeometryType.emailUIDataHandler, selector:  null)))(System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_7.GeometryType.emailUIDataHandler, selector:  null)))) + "]");
            goto label_93;
            label_50:
            Mapbox.VectorTile.Geometry.LatLng val_71 = val_101.Item[0].Item[0];
            Mapbox.VectorTile.Geometry.LatLng val_73 = val_101.Item[0].Item[0];
            val_47 = val_73.<Lat>k__BackingField.System.IConvertible.ToDouble(provider:  0);
            val_108 = "{0},{1}";
            val_113 = System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  "{0},{1}", arg0:  val_71.<Lat>k__BackingField, arg1:  val_47);
            goto label_129;
            label_51:
            val_129 = 1152921505125855232;
            val_130 = null;
            val_130 = null;
            val_132 = VectorTileExtensions.<>c.<>9__0_0;
            if(val_132 == null)
            {
                    val_129 = 1152921505125855232;
                val_132 = null;
                val_132 = new System.Func<Mapbox.VectorTile.Geometry.LatLng, System.String>(object:  VectorTileExtensions.<>c.__il2cppRuntimeField_static_fields, method:  System.String VectorTileExtensions.<>c::<ToGeoJson>b__0_0(Mapbox.VectorTile.Geometry.LatLng g));
                VectorTileExtensions.<>c.<>9__0_0 = val_132;
            }
            
            val_108 = 1152921517553234912;
            val_113 = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.LatLng, System.String>(source:  val_101.Item[0], selector:  null)));
            goto label_129;
            label_108:
            long val_81 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519925141216});
            if(((639 == 0) ? 639 : 639) != 639)
            {
                goto label_124;
            }
            
            if(null != null)
            {
                goto label_128;
            }
            
            goto label_126;
            label_124:
            if(null != null)
            {
                goto label_128;
            }
            
            label_126:
            label_128:
            val_108 = 1152921515834702288;
            val_113 = System.String.Join(separator:  val_102, value:  null.ToArray());
            goto label_129;
            label_107:
            long val_85 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519925141216});
            if(((0 == 0) ? 797 : 0) != 797)
            {
                goto label_131;
            }
            
            if(null != null)
            {
                goto label_135;
            }
            
            goto label_133;
            label_131:
            if(null != null)
            {
                goto label_135;
            }
            
            label_133:
            label_135:
            val_108 = "]";
            val_113 = "[" + System.String.Join(separator:  val_102, value:  null.ToArray())(System.String.Join(separator:  val_102, value:  null.ToArray())) + "]";
            label_129:
            val_106 = val_106;
            label_94:
            val_1.Add(item:  System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  "{{\"type\":\"Feature\",\"geometry\":{{\"type\":\"{0}\",\"coordinates\":[{1}]}},\"properties\":{2}}}", arg0:  "MultiLineString", arg1:  val_113, arg2:  val_106));
            goto label_137;
            label_73:
            if(val_105 < val_6.FeatureCount())
            {
                goto label_139;
            }
            
            val_100 = val_100;
            val_103 = 1152921515834702288;
            label_3:
            var val_102 = 0;
            val_102 = val_102 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_145;
            }
            
            val_137 = 0;
            val_138 = 0;
            val_139 = 1167;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_103 = 0;
                val_103 = val_103 + 1;
                val_3.Dispose();
            }
            
            if( == false)
            {
                    return (string)System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  val_99, arg0:  System.String.Join(separator:  val_102, value:  val_1.ToArray()));
            }
            
            return (string)System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  val_99, arg0:  System.String.Join(separator:  val_102, value:  val_1.ToArray()));
        }
    
    }

}
