using UnityEngine;

namespace Mapbox.Platform.Cache
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SQLiteCache : ICache, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disposed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _dbName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _dbPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.SQLiteConnection _sqlite;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly uint _maxTileCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int _pruneCacheDelta = 20;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _pruneCacheCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _lock;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint MaxCacheSize { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint PruneCacheDelta { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get_MaxCacheSize()
        {
            return (uint)this._maxTileCount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get_PruneCacheDelta()
        {
            return 20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLiteCache(System.Nullable<uint> maxTileCount, string dbName = "cache.db")
        {
            var val_4;
            this._lock = new System.Object();
            val_2 = new System.Object();
            if(((-1819127208) & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_3 = maxTileCount.HasValue.region;
            }
            else
            {
                    val_4 = 3000;
            }
            
            this._maxTileCount = 3000;
            this._dbName = val_2;
            this.init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Finalize()
        {
            this.Finalize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Dispose(bool disposeManagedResources)
        {
            if(this._disposed == true)
            {
                    return;
            }
            
            if((disposeManagedResources != false) && (this._sqlite != null))
            {
                    int val_2 = this._sqlite.Execute(query:  "VACUUM;", args:  System.Array.Empty<System.Object>());
                this._sqlite.Close();
                this._sqlite.Dispose();
                this._sqlite = 0;
            }
            
            this._disposed = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void init()
        {
            System.Object[] val_22;
            var val_23;
            int val_24;
            string val_25;
            this.openOrCreateDb(dbName:  this._dbName);
            val_22 = 1152921504624418816;
            if((this._sqlite.GetTableInfo(tableName:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Count) == 0)
            {
                    val_23 = 1152921518828526064;
                int val_5 = this._sqlite.Execute(query:  "CREATE TABLE tilesets(\nid    INTEGER PRIMARY KEY ASC AUTOINCREMENT NOT NULL UNIQUE,\nname  STRING  NOT NULL\n);", args:  System.Array.Empty<System.Object>());
                int val_7 = this._sqlite.Execute(query:  "CREATE UNIQUE INDEX idx_names ON tilesets (name ASC);", args:  System.Array.Empty<System.Object>());
            }
            
            if((this._sqlite.GetTableInfo(tableName:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Count) == 0)
            {
                    val_22 = 1152921518828526064;
                int val_12 = this._sqlite.Execute(query:  "CREATE TABLE tiles(\ntile_set     INTEGER REFERENCES tilesets (id) ON DELETE CASCADE ON UPDATE CASCADE,\nzoom_level   INTEGER NOT NULL,\ntile_column  BIGINT  NOT NULL,\ntile_row     BIGINT  NOT NULL,\ntile_data    BLOB    NOT NULL,\ntimestamp    INTEGER NOT NULL,\netag         TEXT,\nlastmodified INTEGER,\n\tPRIMARY KEY(\n\t\ttile_set ASC,\n\t\tzoom_level ASC,\n\t\ttile_column ASC,\n\t\ttile_row ASC\n\t)\n);", args:  System.Array.Empty<System.Object>());
                int val_14 = this._sqlite.Execute(query:  "CREATE INDEX idx_tileset ON tiles (tile_set ASC);", args:  System.Array.Empty<System.Object>());
                int val_16 = this._sqlite.Execute(query:  "CREATE INDEX idx_timestamp ON tiles (timestamp ASC);", args:  System.Array.Empty<System.Object>());
            }
            
            string[] val_17 = new string[4];
            val_17[0] = "PRAGMA synchronous=OFF";
            val_17[1] = "PRAGMA count_changes=OFF";
            val_17[2] = "PRAGMA journal_mode=MEMORY";
            val_24 = val_17.Length;
            val_25 = "PRAGMA temp_store=MEMORY";
            if(val_24 <= 3)
            {
                    val_24 = val_17.Length;
            }
            
            val_17[3] = val_25;
            if(val_24 < 1)
            {
                    return;
            }
            
            do
            {
                val_23 = 0;
                val_25 = val_17[val_23];
                val_22 = System.Array.Empty<System.Object>();
                int val_21 = this._sqlite.Execute(query:  val_25, args:  val_22);
            }
            while((val_23 + 1) < val_17.Length);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void openOrCreateDb(string dbName)
        {
            string val_1 = Mapbox.Platform.Cache.SQLiteCache.GetFullDbPath(dbName:  dbName);
            this._dbPath = val_1;
            this._sqlite = new SQLite4Unity3d.SQLiteConnection(databasePath:  val_1, openFlags:  6, storeDateTimeAsTicks:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReInit()
        {
            if(this._sqlite != null)
            {
                    this._sqlite.Dispose();
                this._sqlite = 0;
            }
            
            this.init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetFullDbPath(string dbName)
        {
            string val_2 = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "cache");
            if((System.IO.Directory.Exists(path:  val_2)) == true)
            {
                    return System.IO.Path.Combine(path1:  val_2, path2:  dbName);
            }
            
            System.IO.DirectoryInfo val_4 = System.IO.Directory.CreateDirectory(path:  val_2);
            return System.IO.Path.Combine(path1:  val_2, path2:  dbName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(string tilesetName, Mapbox.Map.CanonicalTileId tileId, Mapbox.Platform.Cache.CacheItem item, bool forceInsert = False)
        {
            object val_17;
            var val_18;
            var val_19;
            int val_20;
            var val_21;
            tileId.Y = tileId.Y & 4294967295;
            if((this.TileExists(tilesetName:  tilesetName, tileId:  new Mapbox.Map.CanonicalTileId() {Z = tileId.Z, X = tileId.X, Y = tileId.Y})) != false)
            {
                    if(forceInsert == false)
            {
                    return;
            }
            
            }
            
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this._lock, lockTaken: ref  val_2);
            System.Nullable<System.Int32> val_3 = this.getTilesetId(tilesetName:  tilesetName);
            if(((-1817367128) & 1) != 0)
            {
                    val_18 = 0;
                val_19 = 86;
            }
            else
            {
                    int val_4 = this.insertTileset(tilesetName:  tilesetName);
                val_18 = 0;
                val_19 = 86;
            }
            
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._lock);
            }
            
            if((1152921519969349008 & (0.region >> 31)) != 0)
            {
                    object[] val_7 = new object[2];
                val_7[0] = tilesetName;
                val_17 = tileId;
                val_7[1] = val_17;
                UnityEngine.Debug.LogErrorFormat(format:  "could not get tilesetID for [{0}] tile: {1}", args:  val_7);
                return;
            }
            
            new Mapbox.Platform.Cache.tiles() = new System.Object();
            if(new Mapbox.Platform.Cache.tiles() != null)
            {
                    .<tile_set>k__BackingField = ;
                .<zoom_level>k__BackingField = tileId.Z;
                .<tile_column>k__BackingField = tileId.Z >> 32;
            }
            else
            {
                    mem[16] = ;
                .<zoom_level>k__BackingField = tileId.Z;
                mem[24] = tileId.Z >> 32;
            }
            
            .<tile_row>k__BackingField = (long)tileId.Y;
            .<tile_data>k__BackingField = item.Data;
            System.DateTime val_11 = System.DateTime.Now;
            .<timestamp>k__BackingField = (int)Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime() {dateData = val_11.dateData});
            .<etag>k__BackingField = item.ETag;
            val_17 = this._sqlite.InsertOrReplace(obj:  new Mapbox.Platform.Cache.tiles());
            if(val_17 != 1)
            {
                goto label_25;
            }
            
            label_72:
            val_20 = this._pruneCacheCounter;
            if(forceInsert != true)
            {
                    val_20 = val_20 + 1;
                this._pruneCacheCounter = val_20;
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            this._pruneCacheCounter = 0;
            this.prune();
            return;
            label_25:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "tile [{0} / {1}] was not inserted, rows affected:{2}", arg0:  tilesetName, arg1:  tileId, arg2:  val_17));
            val_21 = new System.Exception();
            if(0 != 1)
            {
                goto label_58;
            }
            
            if((null & 1) == 0)
            {
                goto label_59;
            }
            
            object[] val_16 = new object[3];
            val_16[0] = tilesetName;
            val_16[1] = tileId;
            val_16[2] = null;
            UnityEngine.Debug.LogErrorFormat(format:  "Error inserting {0} {1} {2} ", args:  val_16);
            goto label_72;
            label_59:
            mem[8] = null;
            val_21 = 8;
            label_58:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void prune()
        {
            SQLite4Unity3d.SQLiteConnection val_5;
            long val_6;
            val_5 = this;
            val_6 = (this._sqlite.ExecuteScalar<System.Int64>(query:  "SELECT COUNT(zoom_level) FROM tiles", args:  System.Array.Empty<System.Object>())) - this._maxTileCount;
            if()
            {
                    return;
            }
            
            val_5 = this._sqlite;
            object[] val_3 = new object[1];
            val_6 = val_6;
            val_3[0] = val_6;
            int val_4 = val_5.Execute(query:  "DELETE FROM tiles WHERE rowid IN ( SELECT rowid FROM tiles ORDER BY timestamp ASC LIMIT ? );", args:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.Cache.CacheItem Get(string tilesetName, Mapbox.Map.CanonicalTileId tileId)
        {
            object val_74;
            object val_75;
            System.Reflection.MethodInfo val_76;
            System.Reflection.MethodInfo val_77;
            System.Reflection.MethodInfo val_78;
            System.Reflection.MethodInfo val_79;
            System.Reflection.MethodInfo val_80;
            var val_81;
            System.Nullable<System.DateTime> val_82;
            val_74 = this;
            .tileId = tileId;
            mem[1152921519970170792] = tileId.Y;
            val_75 = new SQLiteCache.<>c__DisplayClass22_1();
            val_75 = new System.Object();
            .CS$<>8__locals1 = new SQLiteCache.<>c__DisplayClass22_0();
            System.Nullable<System.Int32> val_3 = this.getTilesetId(tilesetName:  tilesetName);
            .tilesetId = val_3;
            if((1152921519970174880 & 1) != 0)
            {
                    System.Linq.Expressions.ParameterExpression val_6 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "t");
                val_76 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 Mapbox.Platform.Cache.tiles::get_tile_set()});
                if(val_76 != null)
            {
                    val_76 = 0;
            }
            
                val_77 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 System.Nullable<System.Int32>::get_Value()}, declaringType:  new System.RuntimeTypeHandle());
                if(val_77 != null)
            {
                    val_77 = 0;
            }
            
                val_78 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 Mapbox.Platform.Cache.tiles::get_zoom_level()});
                if(val_78 != null)
            {
                    val_78 = 0;
            }
            
                val_79 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int64 Mapbox.Platform.Cache.tiles::get_tile_column()});
                if(val_79 != null)
            {
                    val_79 = 0;
            }
            
                val_80 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int64 Mapbox.Platform.Cache.tiles::get_tile_row()});
                if(val_80 != null)
            {
                    val_80 = 0;
            }
            
                val_75 = System.Linq.Expressions.Expression.AndAlso(left:  System.Linq.Expressions.Expression.AndAlso(left:  System.Linq.Expressions.Expression.AndAlso(left:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_6, propertyAccessor:  val_76), right:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  new SQLiteCache.<>c__DisplayClass22_1(), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_1.tilesetId})), propertyAccessor:  val_77)), right:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_6, propertyAccessor:  val_78), right:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  new SQLiteCache.<>c__DisplayClass22_1(), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_1.CS$<>8__locals1})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_0.tileId})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Map.CanonicalTileId.Z})))), right:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_6, propertyAccessor:  val_79), right:  System.Linq.Expressions.Expression.Convert(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  new SQLiteCache.<>c__DisplayClass22_1(), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_1.CS$<>8__locals1})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_0.tileId})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Map.CanonicalTileId.X})), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))), right:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_6, propertyAccessor:  val_80), right:  System.Linq.Expressions.Expression.Convert(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  new SQLiteCache.<>c__DisplayClass22_1(), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_1.CS$<>8__locals1})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass22_0.tileId})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Map.CanonicalTileId.Y})), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))));
                System.Linq.Expressions.ParameterExpression[] val_66 = new System.Linq.Expressions.ParameterExpression[1];
                val_66[0] = val_6;
                val_74 = this._sqlite.Table<Mapbox.Platform.Cache.tiles>().Where(predExpr:  System.Linq.Expressions.Expression.Lambda<System.Func<Mapbox.Platform.Cache.tiles, System.Boolean>>(body:  val_75, parameters:  val_66)).FirstOrDefault();
                if(val_74 != null)
            {
                    if(((-1816593648) & 1) != 0)
            {
                    System.DateTime val_70 = Mapbox.Utils.UnixTimestampUtils.From(timestamp:  1.15292150460685E+18);
            }
            
                Mapbox.Platform.Cache.CacheItem val_71 = null;
                val_81 = val_71;
                val_71 = new Mapbox.Platform.Cache.CacheItem();
                if(val_81 != null)
            {
                    .Data = val_69.<tile_data>k__BackingField;
                .AddedToCacheTicksUtc = val_69.<timestamp>k__BackingField;
                .ETag = val_69.<etag>k__BackingField;
                val_82 = 0;
                val_74 = 0;
            }
            else
            {
                    mem[16] = val_69.<tile_data>k__BackingField;
                mem[24] = val_69.<timestamp>k__BackingField;
                mem[32] = val_69.<etag>k__BackingField;
                val_82 = 0;
                val_74 = 0;
            }
            
                .LastModified = val_82;
                mem[1152921519970412496] = val_74;
                return (Mapbox.Platform.Cache.CacheItem)val_81;
            }
            
            }
            
            val_81 = 0;
            return (Mapbox.Platform.Cache.CacheItem)val_81;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TileExists(string tilesetName, Mapbox.Map.CanonicalTileId tileId)
        {
            System.Linq.Expressions.Expression val_60;
            var val_61;
            System.Linq.Expressions.Expression val_62;
            System.Reflection.MethodInfo val_63;
            System.Reflection.MethodInfo val_64;
            System.Reflection.MethodInfo val_65;
            System.Reflection.MethodInfo val_66;
            System.Reflection.MethodInfo val_67;
            var val_68;
            val_60 = tileId.Z;
            val_61 = this;
            SQLiteCache.<>c__DisplayClass23_0 val_1 = new SQLiteCache.<>c__DisplayClass23_0();
            .tileId = tileId;
            mem[1152921519970815344] = tileId.Y;
            System.Nullable<System.Int32> val_2 = this.getTilesetId(tilesetName:  tilesetName);
            if(val_1 != null)
            {
                    val_62 = val_1;
                .tilesetId = val_2;
            }
            else
            {
                    val_62 = 16;
                mem[16] = val_2.HasValue;
            }
            
            if((val_62 & 1) != 0)
            {
                    val_62 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "t");
                val_63 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 Mapbox.Platform.Cache.tiles::get_tile_set()});
                if(val_63 != null)
            {
                    val_63 = 0;
            }
            
                val_64 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 System.Nullable<System.Int32>::get_Value()}, declaringType:  new System.RuntimeTypeHandle());
                if(val_64 != null)
            {
                    val_64 = 0;
            }
            
                val_65 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 Mapbox.Platform.Cache.tiles::get_zoom_level()});
                if(val_65 != null)
            {
                    val_65 = 0;
            }
            
                val_66 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int64 Mapbox.Platform.Cache.tiles::get_tile_column()});
                if(val_66 != null)
            {
                    val_66 = 0;
            }
            
                val_67 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int64 Mapbox.Platform.Cache.tiles::get_tile_row()});
                if(val_67 != null)
            {
                    val_67 = 0;
            }
            
                val_60 = System.Linq.Expressions.Expression.Property(expression:  val_62, propertyAccessor:  val_67);
                System.Linq.Expressions.ParameterExpression[] val_55 = new System.Linq.Expressions.ParameterExpression[1];
                val_55[0] = val_62;
                val_61 = this._sqlite.Table<Mapbox.Platform.Cache.tiles>().Where(predExpr:  System.Linq.Expressions.Expression.Lambda<System.Func<Mapbox.Platform.Cache.tiles, System.Boolean>>(body:  System.Linq.Expressions.Expression.AndAlso(left:  System.Linq.Expressions.Expression.AndAlso(left:  System.Linq.Expressions.Expression.AndAlso(left:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_62, propertyAccessor:  val_63), right:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  val_1, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass23_0.tilesetId})), propertyAccessor:  val_64)), right:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_62, propertyAccessor:  val_65), right:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  val_1, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass23_0.tileId})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Map.CanonicalTileId.Z})))), right:  System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_62, propertyAccessor:  val_66), right:  System.Linq.Expressions.Expression.Convert(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  val_1, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass23_0.tileId})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Map.CanonicalTileId.X})), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))), right:  System.Linq.Expressions.Expression.Equal(left:  val_60, right:  System.Linq.Expressions.Expression.Convert(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  val_1, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass23_0.tileId})), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Map.CanonicalTileId.Y})), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))), parameters:  val_55));
                var val_59 = (val_61.FirstOrDefault() != 0) ? 1 : 0;
                return (bool)val_68;
            }
            
            val_68 = 0;
            return (bool)val_68;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int insertTileset(string tilesetName)
        {
            var val_6;
            var val_7;
            this._sqlite.BeginTransaction(exclusive:  true);
            new Mapbox.Platform.Cache.tilesets() = new System.Object();
            .<name>k__BackingField = tilesetName;
            int val_2 = this._sqlite.Insert(obj:  new Mapbox.Platform.Cache.tilesets());
            if(val_2 != 1)
            {
                goto label_4;
            }
            
            label_26:
            label_31:
            this._sqlite.Commit();
            if(115 == 115)
            {
                    return (int)(Mapbox.Platform.Cache.tilesets)[1152921519971186736].<id>k__BackingField;
            }
            
            if(0 == 0)
            {
                    return (int)(Mapbox.Platform.Cache.tilesets)[1152921519971186736].<id>k__BackingField;
            }
            
            return (int)(Mapbox.Platform.Cache.tilesets)[1152921519971186736].<id>k__BackingField;
            label_4:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "tileset [{0}] was not inserted, rows affected:{1}", arg0:  tilesetName, arg1:  val_2));
            val_6 = 0;
            val_7 = new System.Exception();
            if(val_6 != 1)
            {
                goto label_27;
            }
            
            if((null & 1) == 0)
            {
                goto label_16;
            }
            
            object[] val_5 = new object[2];
            val_5[0] = tilesetName;
            val_5[1] = null;
            UnityEngine.Debug.LogErrorFormat(format:  "could not insert tileset [{0}]: {1}", args:  val_5);
            goto label_26;
            label_16:
            mem[8] = null;
            val_6 = 62662160;
            val_7 = 8;
            label_27:
            if( != 1)
            {
                goto label_30;
            }
            
            goto label_31;
            label_30:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int> getTilesetId(string tilesetName)
        {
            System.Reflection.MethodInfo val_21;
            System.Reflection.MethodInfo val_22;
            var val_23;
            .tilesetName = tilesetName;
            System.Linq.Expressions.ParameterExpression val_4 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "ts");
            val_21 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.String Mapbox.Platform.Cache.tilesets::get_name()});
            if(val_21 != null)
            {
                    val_21 = 0;
            }
            
            val_22 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Boolean System.String::Equals(string value)});
            System.Linq.Expressions.Expression[] val_10 = new System.Linq.Expressions.Expression[1];
            val_10[0] = System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  new SQLiteCache.<>c__DisplayClass25_0(), type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass25_0.tilesetName}));
            if(val_22 != null)
            {
                    val_22 = 0;
            }
            
            System.Linq.Expressions.ParameterExpression[] val_17 = new System.Linq.Expressions.ParameterExpression[1];
            val_17[0] = val_4;
            Mapbox.Platform.Cache.tilesets val_20 = this._sqlite.Table<Mapbox.Platform.Cache.tilesets>().Where(predExpr:  System.Linq.Expressions.Expression.Lambda<System.Func<Mapbox.Platform.Cache.tilesets, System.Boolean>>(body:  System.Linq.Expressions.Expression.Call(instance:  System.Linq.Expressions.Expression.Property(expression:  val_4, propertyAccessor:  val_21), method:  val_22, arguments:  val_10), parameters:  val_17)).FirstOrDefault();
            if(val_20 == null)
            {
                    return (System.Nullable<System.Int32>)val_20;
            }
            
            val_23 = 0;
            return (System.Nullable<System.Int32>)val_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long TileCount(string tilesetName)
        {
            var val_22;
            object val_23;
            var val_24;
            System.Reflection.MethodInfo val_25;
            System.Reflection.MethodInfo val_26;
            var val_27;
            val_22 = this;
            SQLiteCache.<>c__DisplayClass26_0 val_1 = null;
            val_23 = val_1;
            val_1 = new SQLiteCache.<>c__DisplayClass26_0();
            System.Nullable<System.Int32> val_2 = this.getTilesetId(tilesetName:  tilesetName);
            if(val_23 != null)
            {
                    val_24 = val_23;
                .tilesetId = val_2;
            }
            else
            {
                    val_24 = 16;
                mem[16] = val_2.HasValue;
            }
            
            if((val_24 & 1) != 0)
            {
                    val_22 = this._sqlite.Table<Mapbox.Platform.Cache.tiles>();
                System.Linq.Expressions.ParameterExpression val_5 = System.Linq.Expressions.Expression.Parameter(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), name:  "t");
                val_25 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 Mapbox.Platform.Cache.tiles::get_tile_set()});
                if(val_25 != null)
            {
                    val_25 = 0;
            }
            
                val_26 = System.Reflection.MethodBase.GetMethodFromHandle(handle:  new System.RuntimeMethodHandle() {value = public System.Int32 System.Nullable<System.Int32>::get_Value()}, declaringType:  new System.RuntimeTypeHandle());
                if(val_26 != null)
            {
                    val_26 = 0;
            }
            
                val_23 = System.Linq.Expressions.Expression.Equal(left:  System.Linq.Expressions.Expression.Property(expression:  val_5, propertyAccessor:  val_25), right:  System.Linq.Expressions.Expression.Property(expression:  System.Linq.Expressions.Expression.Field(expression:  System.Linq.Expressions.Expression.Constant(value:  val_1, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())), field:  System.Reflection.FieldInfo.GetFieldFromHandle(handle:  new System.RuntimeFieldHandle() {value = Mapbox.Platform.Cache.SQLiteCache.<>c__DisplayClass26_0.tilesetId})), propertyAccessor:  val_26));
                System.Linq.Expressions.ParameterExpression[] val_18 = new System.Linq.Expressions.ParameterExpression[1];
                val_18[0] = val_5;
                long val_21 = System.Linq.Enumerable.LongCount<Mapbox.Platform.Cache.tiles>(source:  val_22.Where(predExpr:  System.Linq.Expressions.Expression.Lambda<System.Func<Mapbox.Platform.Cache.tiles, System.Boolean>>(body:  val_23, parameters:  val_18)));
                return (long)val_27;
            }
            
            val_27 = 0;
            return (long)val_27;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear(string tilesetName)
        {
            System.Nullable<System.Int32> val_1 = this.getTilesetId(tilesetName:  tilesetName);
            if(((-1814876904) & 1) == 0)
            {
                    return;
            }
            
            this = this._sqlite;
            int val_2 = this.Delete<Mapbox.Platform.Cache.tilesets>(primaryKey:  val_1.HasValue);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            if(this._sqlite == null)
            {
                    return;
            }
            
            this._sqlite.Close();
            this._sqlite.Dispose();
            this._sqlite = 0;
            object[] val_1 = new object[1];
            val_1[0] = this._dbPath;
            UnityEngine.Debug.LogFormat(format:  "deleting {0}", args:  val_1);
            System.IO.File.Delete(path:  this._dbPath);
        }
    
    }

}
