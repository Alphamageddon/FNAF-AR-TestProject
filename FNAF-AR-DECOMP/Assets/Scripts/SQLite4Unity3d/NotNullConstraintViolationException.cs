using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NotNullConstraintViolationException : SQLiteException
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.IEnumerable<SQLite4Unity3d.TableMapping.Column> <Columns>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<SQLite4Unity3d.TableMapping.Column> Columns { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<SQLite4Unity3d.TableMapping.Column> get_Columns()
        {
            return (System.Collections.Generic.IEnumerable<Column>)this.<Columns>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_Columns(System.Collections.Generic.IEnumerable<SQLite4Unity3d.TableMapping.Column> value)
        {
            this.<Columns>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected NotNullConstraintViolationException(SQLite4Unity3d.SQLite3.Result r, string message)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected NotNullConstraintViolationException(SQLite4Unity3d.SQLite3.Result r, string message, SQLite4Unity3d.TableMapping mapping, object obj)
        {
            .obj = obj;
            if(mapping == null)
            {
                    return;
            }
            
            if(((NotNullConstraintViolationException.<>c__DisplayClass5_0)[1152921519616834992].obj) == null)
            {
                    return;
            }
            
            this.<Columns>k__BackingField = System.Linq.Enumerable.Where<Column>(source:  mapping.<Columns>k__BackingField, predicate:  new System.Func<Column, System.Boolean>(object:  new NotNullConstraintViolationException.<>c__DisplayClass5_0(), method:  System.Boolean NotNullConstraintViolationException.<>c__DisplayClass5_0::<.ctor>b__0(SQLite4Unity3d.TableMapping.Column c)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SQLite4Unity3d.NotNullConstraintViolationException New(SQLite4Unity3d.SQLite3.Result r, string message)
        {
            return (SQLite4Unity3d.NotNullConstraintViolationException)new SQLite4Unity3d.NotNullConstraintViolationException(r:  r, message:  message, mapping:  0, obj:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SQLite4Unity3d.NotNullConstraintViolationException New(SQLite4Unity3d.SQLite3.Result r, string message, SQLite4Unity3d.TableMapping mapping, object obj)
        {
            return (SQLite4Unity3d.NotNullConstraintViolationException)new SQLite4Unity3d.NotNullConstraintViolationException(r:  r, message:  message, mapping:  mapping, obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SQLite4Unity3d.NotNullConstraintViolationException New(SQLite4Unity3d.SQLiteException exception, SQLite4Unity3d.TableMapping mapping, object obj)
        {
            Result val_3;
            if(exception != null)
            {
                    val_3 = exception.<Result>k__BackingField;
                return (SQLite4Unity3d.NotNullConstraintViolationException)new SQLite4Unity3d.NotNullConstraintViolationException(r:  val_3 = 62656512, message:  exception.Message, mapping:  mapping, obj:  obj);
            }
            
            return (SQLite4Unity3d.NotNullConstraintViolationException)new SQLite4Unity3d.NotNullConstraintViolationException(r:  val_3, message:  exception.Message, mapping:  mapping, obj:  obj);
        }
    
    }

}
