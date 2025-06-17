using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class LocationPrefabCategoryOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabCategories, System.Collections.Generic.List<string>> CategoriesToMakiDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, Mapbox.Unity.Map.LocationPrefabCategories> MakiToCategoriesDictionary;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LocationPrefabCategoryOptions()
        {
            System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabCategories, System.Collections.Generic.List<System.String>> val_1 = new System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabCategories, System.Collections.Generic.List<System.String>>();
            System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
            if(val_2 != null)
            {
                    val_2.Add(item:  "art-gallery");
            }
            else
            {
                    val_2.Add(item:  "art-gallery");
            }
            
            val_2.Add(item:  "cinema");
            if(val_2 != null)
            {
                    val_2.Add(item:  "stadium");
            }
            else
            {
                    val_2.Add(item:  "stadium");
            }
            
            val_2.Add(item:  "museum");
            if(val_2 != null)
            {
                    val_2.Add(item:  "library");
            }
            else
            {
                    val_2.Add(item:  "library");
            }
            
            val_2.Add(item:  "zoo");
            if(val_2 != null)
            {
                    val_2.Add(item:  "music");
            }
            else
            {
                    val_2.Add(item:  "music");
            }
            
            val_2.Add(item:  "theatre");
            val_2.Add(item:  "amusement-park");
            val_1.Add(key:  1, value:  val_2);
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            if(val_3 != null)
            {
                    val_3.Add(item:  "cafe");
            }
            else
            {
                    val_3.Add(item:  "cafe");
            }
            
            val_3.Add(item:  "bakery");
            if(val_3 != null)
            {
                    val_3.Add(item:  "fast-food");
            }
            else
            {
                    val_3.Add(item:  "fast-food");
            }
            
            val_3.Add(item:  "grocery");
            if(val_3 != null)
            {
                    val_3.Add(item:  "ice-cream");
            }
            else
            {
                    val_3.Add(item:  "ice-cream");
            }
            
            val_3.Add(item:  "restaurant");
            val_1.Add(key:  2, value:  val_3);
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            if(val_4 != null)
            {
                    val_4.Add(item:  "bar");
            }
            else
            {
                    val_4.Add(item:  "bar");
            }
            
            val_4.Add(item:  "beer");
            val_1.Add(key:  4, value:  val_4);
            System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
            if(val_5 != null)
            {
                    val_5.Add(item:  "aquarium");
            }
            else
            {
                    val_5.Add(item:  "aquarium");
            }
            
            val_5.Add(item:  "campsite");
            if(val_5 != null)
            {
                    val_5.Add(item:  "attraction");
            }
            else
            {
                    val_5.Add(item:  "attraction");
            }
            
            val_5.Add(item:  "castle");
            if(val_5 != null)
            {
                    val_5.Add(item:  "cemetery");
            }
            else
            {
                    val_5.Add(item:  "cemetery");
            }
            
            val_5.Add(item:  "dog-park");
            if(val_5 != null)
            {
                    val_5.Add(item:  "drinking-water");
            }
            else
            {
                    val_5.Add(item:  "drinking-water");
            }
            
            val_5.Add(item:  "garden");
            if(val_5 != null)
            {
                    val_5.Add(item:  "golf");
            }
            else
            {
                    val_5.Add(item:  "golf");
            }
            
            val_5.Add(item:  "monument");
            if(val_5 != null)
            {
                    val_5.Add(item:  "park");
            }
            else
            {
                    val_5.Add(item:  "park");
            }
            
            val_5.Add(item:  "picnic-site");
            if(val_5 != null)
            {
                    val_5.Add(item:  "playground");
            }
            else
            {
                    val_5.Add(item:  "playground");
            }
            
            val_5.Add(item:  "swimming");
            val_1.Add(key:  8, value:  val_5);
            System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
            if(val_6 != null)
            {
                    val_6.Add(item:  "bank");
            }
            else
            {
                    val_6.Add(item:  "bank");
            }
            
            val_6.Add(item:  "dentist");
            if(val_6 != null)
            {
                    val_6.Add(item:  "toilet");
            }
            else
            {
                    val_6.Add(item:  "toilet");
            }
            
            val_6.Add(item:  "veterinary");
            if(val_6 != null)
            {
                    val_6.Add(item:  "pharmacy");
            }
            else
            {
                    val_6.Add(item:  "pharmacy");
            }
            
            val_6.Add(item:  "college");
            if(val_6 != null)
            {
                    val_6.Add(item:  "school");
            }
            else
            {
                    val_6.Add(item:  "school");
            }
            
            val_6.Add(item:  "hospital");
            if(val_6 != null)
            {
                    val_6.Add(item:  "place-of-worship");
            }
            else
            {
                    val_6.Add(item:  "place-of-worship");
            }
            
            val_6.Add(item:  "religious-christian");
            if(val_6 != null)
            {
                    val_6.Add(item:  "religious-jewish");
            }
            else
            {
                    val_6.Add(item:  "religious-jewish");
            }
            
            val_6.Add(item:  "religious-muslim");
            if(val_6 != null)
            {
                    val_6.Add(item:  "police");
            }
            else
            {
                    val_6.Add(item:  "police");
            }
            
            val_6.Add(item:  "post");
            if(val_6 != null)
            {
                    val_6.Add(item:  "doctor");
            }
            else
            {
                    val_6.Add(item:  "doctor");
            }
            
            val_6.Add(item:  "fire-station");
            if(val_6 != null)
            {
                    val_6.Add(item:  "information");
            }
            else
            {
                    val_6.Add(item:  "information");
            }
            
            val_6.Add(item:  "town-hall");
            if(val_6 != null)
            {
                    val_6.Add(item:  "prison");
            }
            else
            {
                    val_6.Add(item:  "prison");
            }
            
            val_6.Add(item:  "embassy");
            if(val_6 != null)
            {
                    val_6.Add(item:  "fuel");
            }
            else
            {
                    val_6.Add(item:  "fuel");
            }
            
            val_6.Add(item:  "laundry");
            val_6.Add(item:  "lodging");
            val_1.Add(key:  16, value:  val_6);
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
            if(val_7 != null)
            {
                    val_7.Add(item:  "alcohol-shop");
            }
            else
            {
                    val_7.Add(item:  "alcohol-shop");
            }
            
            val_7.Add(item:  "clothing-store");
            val_7.Add(item:  "shop");
            val_1.Add(key:  32, value:  val_7);
            System.Collections.Generic.List<System.String> val_8 = new System.Collections.Generic.List<System.String>();
            if(val_8 != null)
            {
                    val_8.Add(item:  "bus");
            }
            else
            {
                    val_8.Add(item:  "bus");
            }
            
            val_8.Add(item:  "car");
            if(val_8 != null)
            {
                    val_8.Add(item:  "bicycle-share");
            }
            else
            {
                    val_8.Add(item:  "bicycle-share");
            }
            
            val_8.Add(item:  "bicycle");
            if(val_8 != null)
            {
                    val_8.Add(item:  "airfield");
            }
            else
            {
                    val_8.Add(item:  "airfield");
            }
            
            val_8.Add(item:  "ferry");
            if(val_8 != null)
            {
                    val_8.Add(item:  "harbor");
            }
            else
            {
                    val_8.Add(item:  "harbor");
            }
            
            val_8.Add(item:  "heliport");
            val_1.Add(key:  64, value:  val_8);
            Mapbox.Unity.Map.LocationPrefabCategoryOptions.CategoriesToMakiDictionary = val_1;
            Mapbox.Unity.Map.LocationPrefabCategoryOptions.MakiToCategoriesDictionary = new System.Collections.Generic.Dictionary<System.String, Mapbox.Unity.Map.LocationPrefabCategories>();
            Mapbox.Unity.Map.LocationPrefabCategoryOptions.PopulateCategoriesToMakiDictionary();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void PopulateCategoriesToMakiDictionary()
        {
            var val_4;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = null;
            val_13 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = Mapbox.Unity.Map.LocationPrefabCategoryOptions.CategoriesToMakiDictionary.GetEnumerator();
            val_14 = 0;
            val_15 = 0;
            label_23:
            if(((-1986104432) & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
            List.Enumerator<T> val_6 = val_5.m_SubId1.GetEnumerator();
            label_14:
            if(((-1986104480) & 1) == 0)
            {
                goto label_6;
            }
            
            GameUI.EmailUIDataHandler val_7 = val_4.emailUIDataHandler;
            val_16 = null;
            val_16 = null;
            if((Mapbox.Unity.Map.LocationPrefabCategoryOptions.MakiToCategoriesDictionary.ContainsKey(key:  val_7)) == true)
            {
                goto label_14;
            }
            
            val_17 = null;
            val_17 = null;
            Mapbox.Unity.Map.LocationPrefabCategoryOptions.MakiToCategoriesDictionary.Add(key:  val_7, value:  val_5.m_SubId1.region);
            goto label_14;
            label_6:
            val_18 = val_15;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519800611680});
            if((((100 == 0) ? 100 : 100) == 100) || ( == 0))
            {
                goto label_23;
            }
            
            goto label_23;
            label_4:
            val_19 = 125;
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519800611728});
            if( == 0)
            {
                    return;
            }
            
            if(100 == 0)
            {
                    return;
            }
            
            if(100 == 125)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<string> GetMakiListFromCategory(Mapbox.Unity.Map.LocationPrefabCategories category)
        {
            var val_3;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_3 = null;
            val_3 = null;
            bool val_2 = Mapbox.Unity.Map.LocationPrefabCategoryOptions.CategoriesToMakiDictionary.TryGetValue(key:  category, value: out  val_1);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.LocationPrefabCategories GetCategoryFromMakiTag(string makiTag)
        {
            var val_4;
            Mapbox.Unity.Map.LocationPrefabCategories val_1 = 0;
            val_4 = null;
            val_4 = null;
            return (Mapbox.Unity.Map.LocationPrefabCategories)((Mapbox.Unity.Map.LocationPrefabCategoryOptions.MakiToCategoriesDictionary.TryGetValue(key:  makiTag, value: out  val_1)) != true) ? (val_1) : (!0);
        }
    
    }

}
