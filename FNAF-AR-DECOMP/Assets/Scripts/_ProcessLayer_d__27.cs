using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class VectorLayerVisualizer.<ProcessLayer>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.MeshGeneration.Data.UnityTile tile;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.VectorTile.VectorTileLayer layer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizer <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Map.UnwrappedTileId tileId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> callback;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizerProperties <tempLayerProperties>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <featureCount>5__3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <i>5__4;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public VectorLayerVisualizer.<ProcessLayer>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        var val_12;
        int val_33;
        Mapbox.Unity.MeshGeneration.Data.UnityTile val_34;
        int val_35;
        var val_36;
        System.Func<Mapbox.Unity.MeshGeneration.Filters.LayerFilter, Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer> val_38;
        Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizerProperties val_39;
        int val_41;
        int val_42;
        Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria val_43;
        var val_44;
        var val_45;
        var val_46;
        Mapbox.VectorTile.VectorTileLayer val_47;
        Mapbox.Unity.MeshGeneration.Data.UnityTile val_48;
        Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizerProperties val_49;
        Mapbox.Unity.Map.FeatureProcessingStage val_50;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_60;
        }
        
        val_33 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_33;
        return (bool)val_33;
        label_2:
        this.<>1__state = 0;
        val_34 = this.tile;
        if(val_34 == 0)
        {
            goto label_60;
        }
        
        this.<tempLayerProperties>5__2 = new Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizerProperties();
        .vectorTileLayer = this.layer;
        this.<tempLayerProperties>5__2.featureProcessingStage = 0;
        val_35 = 1152921505109880832;
        val_36 = null;
        val_36 = null;
        val_38 = VectorLayerVisualizer.<>c.<>9__27_0;
        if(val_38 == null)
        {
                System.Func<Mapbox.Unity.MeshGeneration.Filters.LayerFilter, Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer> val_3 = null;
            val_38 = val_3;
            val_3 = new System.Func<Mapbox.Unity.MeshGeneration.Filters.LayerFilter, Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(object:  VectorLayerVisualizer.<>c.__il2cppRuntimeField_static_fields, method:  Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer VectorLayerVisualizer.<>c::<ProcessLayer>b__27_0(Mapbox.Unity.MeshGeneration.Filters.LayerFilter m));
            VectorLayerVisualizer.<>c.<>9__27_0 = val_38;
        }
        
        this.<tempLayerProperties>5__2.layerFeatureFilters = System.Linq.Enumerable.ToArray<Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  System.Linq.Enumerable.Select<Mapbox.Unity.MeshGeneration.Filters.LayerFilter, Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer>(source:  this.<>4__this._layerProperties.filterOptions.filters, selector:  val_3));
        this.<tempLayerProperties>5__2.layerFeatureFilterCombiner = new Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer();
        if((this.<>4__this._layerProperties.filterOptions.combinerType) == 2)
        {
            goto label_22;
        }
        
        if((this.<>4__this._layerProperties.filterOptions.combinerType) == 1)
        {
            goto label_23;
        }
        
        if((this.<>4__this._layerProperties.filterOptions.combinerType) != 0)
        {
            goto label_24;
        }
        
        val_39 = this.<tempLayerProperties>5__2;
        if(val_39 == null)
        {
            goto label_25;
        }
        
        Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer val_7 = Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer.AnyOf(filters:  this.<tempLayerProperties>5__2.layerFeatureFilters);
        goto label_29;
        label_1:
        val_41 = this.<i>5__4;
        this.<>1__state = 0;
        label_78:
        val_42 = val_41 + 1;
        mem2[0] = val_42;
        goto label_27;
        label_22:
        val_39 = this.<tempLayerProperties>5__2;
        if(val_39 == null)
        {
            goto label_28;
        }
        
        Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer val_8 = Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer.NoneOf(filters:  this.<tempLayerProperties>5__2.layerFeatureFilters);
        goto label_29;
        label_23:
        val_39 = this.<tempLayerProperties>5__2;
        if(val_39 == null)
        {
            goto label_30;
        }
        
        label_29:
        this.<tempLayerProperties>5__2.layerFeatureFilterCombiner = Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer.AllOf(filters:  this.<tempLayerProperties>5__2.layerFeatureFilters);
        label_24:
        if((this.<>4__this._layerProperties.honorBuildingIdSetting) == false)
        {
            goto label_32;
        }
        
        if((this.<tempLayerProperties>5__2) != null)
        {
            goto label_44;
        }
        
        label_45:
        label_44:
        this.<tempLayerProperties>5__2.buildingsWithUniqueIds = this.<>4__this._layerProperties.buildingsWithUniqueIds;
        List.Enumerator<T> val_10 = this.<>4__this._defaultStack.GoModifiers.GetEnumerator();
        val_35 = 1152921505108230144;
        label_43:
        if(((-2057546320) & 1) == 0)
        {
            goto label_37;
        }
        
        GameUI.EmailUIDataHandler val_13 = val_12.emailUIDataHandler;
        if((val_13 == null) || (val_13._serverGameUIDataModel == null))
        {
            goto label_43;
        }
        
        val_43 = val_13;
        if(val_43 == null)
        {
                val_43 = 0;
        }
        
        this.<>4__this.SetReplacementCriteria(criteria:  val_43);
        goto label_43;
        label_32:
        if((this.<tempLayerProperties>5__2) != null)
        {
            goto label_44;
        }
        
        goto label_45;
        label_37:
        val_44 = 0;
        val_45 = 1;
        goto label_46;
        label_25:
        Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer val_14 = Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer.AnyOf(filters:  64);
        label_28:
        Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer val_15 = Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer.NoneOf(filters:  64);
        label_30:
        Mapbox.Unity.MeshGeneration.Filters.ILayerFeatureFilterComparer val_16 = Mapbox.Unity.MeshGeneration.Filters.LayerFilterComparer.AllOf(filters:  64);
        val_46 = 0;
        val_47 = 0;
        if( != 1)
        {
            goto label_52;
        }
        
        val_44 = mem[X0];
        val_44 = ;
        val_45 = 0;
        label_46:
        long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519729169840});
        val_47 = this.<tempLayerProperties>5__2.vectorTileLayer;
        val_41 = this.<i>5__4;
        this.<featureCount>5__3 = val_47.FeatureCount();
        goto label_71;
        label_52:
        label_71:
        val_42 = 0;
        mem2[0] = 0;
        label_27:
        if(val_42 >= (this.<featureCount>5__3))
        {
            goto label_58;
        }
        
        val_48 = this.tile;
        Mapbox.Map.UnwrappedTileId val_19 = val_48.UnwrappedTileId;
        val_34 = ( & (-4294967296)) | val_42;
        if((Mapbox.Map.UnwrappedTileId.op_Inequality(a:  new Mapbox.Map.UnwrappedTileId() {Z = val_19.Z, X = val_19.X}, b:  new Mapbox.Map.UnwrappedTileId() {Z = this.tileId, X = this.tileId, Y = val_34})) == true)
        {
            goto label_60;
        }
        
        val_48 = this.tile;
        if(val_48.TileState == 0)
        {
                return (bool)val_33;
        }
        
        val_35 = mem[X27];
        val_35 = X27;
        val_48 = this.tile;
        ulong val_23 = this.layer.Extent;
        if((this.<>4__this) == null)
        {
            goto label_64;
        }
        
        bool val_24 = this.<>4__this.ProcessFeature(index:  val_35, tile:  val_48, layerProperties:  this.<tempLayerProperties>5__2, layerExtent:  (float)(double)val_23);
        goto label_65;
        label_58:
        val_49 = this.<tempLayerProperties>5__2;
        if(val_49 != null)
        {
                val_50 = this.<tempLayerProperties>5__2.featureProcessingStage;
        }
        else
        {
                val_49 = 16;
            val_50 = 11993091;
        }
        
        mem[16] = 11993092;
        if((this.<tempLayerProperties>5__2.featureProcessingStage) == 0)
        {
            goto label_71;
        }
        
        val_48 = this.<tempLayerProperties>5__2;
        if((this.<tempLayerProperties>5__2.featureProcessingStage) == 1)
        {
            goto label_71;
        }
        
        val_34 = 0;
        goto label_75;
        label_64:
        bool val_25 = 0.ProcessFeature(index:  val_35, tile:  val_48, layerProperties:  this.<tempLayerProperties>5__2, layerExtent:  (float)(double)val_23);
        label_65:
        if((((this.<>4__this._performanceOptions) == null) || ((this.<>4__this._performanceOptions.isEnabled) == false)) || ((this.<>4__this._entityInCurrentCoroutine) < (this.<>4__this._performanceOptions.entityPerCoroutine)))
        {
            goto label_78;
        }
        
        this.<>4__this._entityInCurrentCoroutine = 0;
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_33 = 1;
        return (bool)val_33;
        label_75:
        if( != 0)
        {
                if(this.tile != 0)
        {
                UnityEngine.GameObject val_29 = this.tile.gameObject;
            val_48 = this.layer.Name;
            UnityEngine.GameObject val_31 = End(tile:  this.tile, parent:  0, name:  val_48);
        }
        
        }
        
        val_33 = this.callback;
        if(val_33 == null)
        {
                return (bool)val_33;
        }
        
        val_33.Invoke(arg1:  this.tile, arg2:  this.<>4__this);
        label_60:
        val_33 = 0;
        return (bool)val_33;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
