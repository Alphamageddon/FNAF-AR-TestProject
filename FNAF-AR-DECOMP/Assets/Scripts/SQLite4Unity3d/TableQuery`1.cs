using UnityEngine;

namespace SQLite4Unity3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TableQuery<T> : BaseTableQuery, IEnumerable<T>, IEnumerable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.SQLiteConnection <Connection>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableMapping <Table>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Linq.Expressions.Expression _where;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SQLite4Unity3d.BaseTableQuery.Ordering> _orderBys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int> _limit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int> _offset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.BaseTableQuery _joinInner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Linq.Expressions.Expression _joinInnerKeySelector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.BaseTableQuery _joinOuter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Linq.Expressions.Expression _joinOuterKeySelector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Linq.Expressions.Expression _joinSelector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Linq.Expressions.Expression _selector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _deferred;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.SQLiteConnection Connection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping Table { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.SQLiteConnection get_Connection()
        {
            return (SQLite4Unity3d.SQLiteConnection)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Connection(SQLite4Unity3d.SQLiteConnection value)
        {
            mem[1152921519653907472] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableMapping get_Table()
        {
            return (SQLite4Unity3d.TableMapping)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Table(SQLite4Unity3d.TableMapping value)
        {
            mem[1152921519654139672] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TableQuery<T>(SQLite4Unity3d.SQLiteConnection conn, SQLite4Unity3d.TableMapping table)
        {
            if(this != null)
            {
                
            }
            
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TableQuery<T>(SQLite4Unity3d.SQLiteConnection conn)
        {
            if(this != null)
            {
                
            }
            
            SQLite4Unity3d.TableMapping val_2 = this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 24}), createFlags:  0);
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<U> Clone<U>()
        {
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                    mem2[0] = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            mem2[0] = this;
            if(this != null)
            {
                    mem2[0] = new System.Collections.Generic.List<Ordering>(collection:  this);
            }
            
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            mem2[0] = 1152921519654500800;
            return (SQLite4Unity3d.TableQuery<U>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> Where(System.Linq.Expressions.Expression<System.Func<T, bool>> predExpr)
        {
            if(predExpr.NodeType == 18)
            {
                    System.Linq.Expressions.Expression val_2 = predExpr.Body;
                if(this != null)
            {
                    return (SQLite4Unity3d.TableQuery<T>)this;
            }
            
                return (SQLite4Unity3d.TableQuery<T>)this;
            }
            
            System.NotSupportedException val_3 = new System.NotSupportedException(message:  "Must be a predicate");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> Take(int n)
        {
            mem[1152921519654787872] = 0;
            return (SQLite4Unity3d.TableQuery<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> Skip(int n)
        {
            mem[1152921519654899880] = 0;
            return (SQLite4Unity3d.TableQuery<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T ElementAt(int index)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> Deferred()
        {
            mem[1152921519655123936] = 1;
            return (SQLite4Unity3d.TableQuery<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> OrderBy<U>(System.Linq.Expressions.Expression<System.Func<T, U>> orderExpr)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> OrderByDescending<U>(System.Linq.Expressions.Expression<System.Func<T, U>> orderExpr)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> ThenBy<U>(System.Linq.Expressions.Expression<System.Func<T, U>> orderExpr)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<T> ThenByDescending<U>(System.Linq.Expressions.Expression<System.Func<T, U>> orderExpr)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableQuery<T> AddOrderBy<U>(System.Linq.Expressions.Expression<System.Func<T, U>> orderExpr, bool asc)
        {
            System.Collections.Generic.List<T> val_16;
            var val_17;
            var val_18;
            if(orderExpr.NodeType == 18)
            {
                    System.Linq.Expressions.Expression val_2 = orderExpr.Body;
                if((val_2 != null) && (val_2 == 10))
            {
                    System.Linq.Expressions.Expression val_3 = val_2.Operand;
            }
            else
            {
                    System.Linq.Expressions.Expression val_4 = orderExpr.Body;
            }
            
                if(val_4 != null)
            {
                    System.Linq.Expressions.Expression val_5 = val_4.Expression;
                if(val_5 == 38)
            {
                    if(val_5 == null)
            {
                    System.Collections.Generic.List<Ordering> val_6 = null;
                val_16 = val_6;
                val_6 = new System.Collections.Generic.List<Ordering>();
                mem[1152921519655777176] = val_16;
            }
            
                BaseTableQuery.Ordering val_7 = new BaseTableQuery.Ordering();
                string val_10 = this.FindColumnWithPropertyName(propertyName:  val_4.Member).Name;
                if(val_7 != null)
            {
                    val_7.ColumnName = val_10;
            }
            else
            {
                    val_7.ColumnName = val_10;
            }
            
                val_7.Ascending = asc;
                val_6.Add(item:  val_7);
                return (SQLite4Unity3d.TableQuery<T>)this;
            }
            
            }
            
                val_17 = 1152921519655748016;
                val_18 = new System.NotSupportedException(message:  "Order By does not support: "("Order By does not support: ") + orderExpr);
            }
            else
            {
                    val_17 = 1152921519655748016;
                val_18 = new System.NotSupportedException(message:  "Must be a predicate");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddWhere(System.Linq.Expressions.Expression pred)
        {
            System.Linq.Expressions.Expression val_2 = pred;
            if(!=0)
            {
                    val_2 = System.Linq.Expressions.Expression.AndAlso(left:  69746688, right:  val_2 = pred);
            }
            
            mem[1152921519655954704] = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<TResult> Join<TInner, TKey, TResult>(SQLite4Unity3d.TableQuery<TInner> inner, System.Linq.Expressions.Expression<System.Func<T, TKey>> outerKeySelector, System.Linq.Expressions.Expression<System.Func<TInner, TKey>> innerKeySelector, System.Linq.Expressions.Expression<System.Func<T, TInner, TResult>> resultSelector)
        {
            SQLite4Unity3d.TableMapping val_2 = this.GetMapping(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), createFlags:  0);
            if((__RuntimeMethodHiddenParam + 48 + 8) != 0)
            {
                    mem2[0] = this;
                mem2[0] = outerKeySelector;
                mem2[0] = inner;
                mem2[0] = innerKeySelector;
            }
            else
            {
                    mem[80] = this;
                mem[88] = outerKeySelector;
                mem[64] = inner;
                mem[72] = innerKeySelector;
            }
            
            mem2[0] = resultSelector;
            return (SQLite4Unity3d.TableQuery<TResult>)__RuntimeMethodHiddenParam + 48 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SQLite4Unity3d.TableQuery<TResult> Select<TResult>(System.Linq.Expressions.Expression<System.Func<T, TResult>> selector)
        {
            mem[1152921519656240216] = selector;
            return (SQLite4Unity3d.TableQuery<TResult>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.SQLiteCommand GenerateCommand(string selectionList)
        {
            string val_18;
            var val_19;
            System.Func<T, TResult> val_20;
            var val_21;
            object val_22;
            string val_23;
            if(true != 0)
            {
                    if(true != 0)
            {
                goto label_2;
            }
            
            }
            
            string[] val_1 = new string[5];
            val_1[0] = "select ";
            val_1[1] = selectionList;
            val_1[2] = " from \"";
            val_1[3] = this.TableName;
            val_1[4] = "\"";
            val_18 = +val_1;
            if(as. 
               
               
              
            
            
            
             != 0)
            {
                    string val_5 = val_18 + " where " + this;
                val_18 = val_5;
            }
            
            if((val_5 != null) && (val_5.Count >= 1))
            {
                    val_19 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
                if((val_19 & 1) == 0)
            {
                    val_19 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
            }
            
                val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 184 + 8];
                val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 184 + 8;
                if(val_20 == 0)
            {
                    val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
                if((val_21 & 1) == 0)
            {
                    val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
            }
            
                System.Func<Ordering, System.String> val_7 = null;
                val_20 = val_7;
                val_7 = new System.Func<Ordering, System.String>(object:  __RuntimeMethodHiddenParam + 24 + 192 + 96 + 184, method:  __RuntimeMethodHiddenParam + 24 + 192 + 104);
                mem2[0] = val_20;
            }
            
                val_18 = val_18 + " order by " + System.String.Join(separator:  ", ", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Ordering, System.String>(source:  this, selector:  val_7)))(System.String.Join(separator:  ", ", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<Ordering, System.String>(source:  this, selector:  val_7))));
            }
            
            if((1152921519656504560 & 1) != 0)
            {
                    val_18 = val_18 + " limit " + 1152921519656504560;
            }
            
            if((1152921519656504568 & 1) == 0)
            {
                    return (SQLite4Unity3d.SQLiteCommand)this.CreateCommand(cmdText:  val_23 = val_22 + " offset " + 1152921519656504568, ps:  new System.Collections.Generic.List<System.Object>().ToArray());
            }
            
            if((1152921519656504560 & 1) == 0)
            {
                    val_22 = val_18 + " limit -1 "(" limit -1 ");
            }
            
            return (SQLite4Unity3d.SQLiteCommand)this.CreateCommand(cmdText:  val_23, ps:  new System.Collections.Generic.List<System.Object>().ToArray());
            label_2:
            System.NotSupportedException val_17 = new System.NotSupportedException(message:  "Joins are not supported.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SQLite4Unity3d.TableQuery.CompileResult<T> CompileExpr(System.Linq.Expressions.Expression expr, System.Collections.Generic.List<object> queryArgs)
        {
            System.Reflection.MemberInfo val_1;
            var val_81;
            string val_82;
            var val_83;
            string val_84;
            var val_85;
            var val_86;
            System.String[] val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            string val_99;
            string val_100;
            var val_101;
            var val_102;
            var val_103;
            var val_104;
            var val_105;
            var val_106;
            object val_107;
            var val_108;
            var val_109;
            var val_110;
            var val_113;
            var val_114;
            var val_117;
            val_82 = this;
            if(expr == null)
            {
                goto label_1;
            }
            
            if(expr == null)
            {
                goto label_2;
            }
            
            val_83 = expr;
            if(val_83 == null)
            {
                goto label_3;
            }
            
            val_84 = 0;
            goto label_4;
            label_2:
            if(expr != 6)
            {
                goto label_5;
            }
            
            val_85 = expr;
            if(val_85 == null)
            {
                goto label_6;
            }
            
            val_86 = 0;
            goto label_7;
            label_3:
            val_83 = 0;
            val_84 = 1;
            label_4:
            System.Linq.Expressions.Expression val_2 = val_83.Left;
            System.Linq.Expressions.Expression val_3 = val_83.Right;
            if((System.String.op_Equality(a:  this, b:  "?")) != false)
            {
                    if(this == null)
            {
                goto label_14;
            }
            
            }
            
            if((System.String.op_Equality(a:  this, b:  "?")) != false)
            {
                    if(this == null)
            {
                goto label_18;
            }
            
            }
            
            val_87 = new string[7];
            val_87[0] = "(";
            val_87[1] = val_82;
            val_84 = " ";
            val_87[2] = val_84;
            val_87[3] = val_82;
            val_87[4] = " ";
            val_87[5] = val_82;
            val_87[6] = ")";
            goto label_44;
            label_5:
            if(expr != 9)
            {
                goto label_45;
            }
            
            val_88 = expr;
            if(val_88 == null)
            {
                goto label_46;
            }
            
            val_89 = 0;
            goto label_47;
            label_14:
            val_90 = mem[__RuntimeMethodHiddenParam + 24];
            val_90 = __RuntimeMethodHiddenParam + 24;
            val_91 = val_82;
            goto label_274;
            label_18:
            val_90 = mem[__RuntimeMethodHiddenParam + 24];
            val_90 = __RuntimeMethodHiddenParam + 24;
            val_91 = val_82;
            goto label_274;
            label_45:
            if(expr != 10)
            {
                goto label_52;
            }
            
            val_81 = null;
            if(expr == null)
            {
                goto label_53;
            }
            
            System.Linq.Expressions.Expression val_7 = expr.Operand;
            val_92 = __RuntimeMethodHiddenParam + 24 + 192 + 136;
            if(this == null)
            {
                goto label_59;
            }
            
            val_93 = val_82;
            goto label_61;
            label_6:
            val_85 = 0;
            val_86 = 1;
            label_7:
            int val_9 = val_85.Arguments.Count;
            System.Linq.Expressions.Expression val_10 = val_85.Object;
            if(val_10 != null)
            {
                    System.Linq.Expressions.Expression val_11 = val_85.Object;
                if(this != null)
            {
                goto label_68;
            }
            
            }
            
            label_68:
            val_84 = 0;
            goto label_69;
            label_77:
            System.Linq.Expressions.Expression val_13 = val_10.Arguments.Item[0];
            var val_14 = (__RuntimeMethodHiddenParam + 24 + 192 + 160) + 0;
            val_84 = 1;
            mem2[0] = val_82;
            label_69:
            if(val_84 < (__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24))
            {
                goto label_77;
            }
            
            if(((System.String.op_Equality(a:  val_85.Method, b:  "Like")) == false) || ((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24) != 2))
            {
                goto label_80;
            }
            
            val_87 = new string[5];
            val_87[0] = "(";
            val_87[1] = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 32;
            val_87[2] = " like ";
            if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 40) != 0)
            {
                goto label_116;
            }
            
            label_117:
            label_116:
            label_224:
            val_87[3] = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 40;
            val_94 = ")";
            goto label_158;
            label_80:
            if(((System.String.op_Equality(a:  val_85.Method, b:  "Contains")) == false) || ((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24) != 2))
            {
                goto label_102;
            }
            
            string[] val_20 = new string[5];
            val_20[0] = "(";
            val_20[1] = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 40;
            val_20[2] = " in ";
            if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 32) != 0)
            {
                goto label_116;
            }
            
            goto label_117;
            label_102:
            if(((System.String.op_Equality(a:  val_85.Method, b:  "Contains")) == false) || ((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24) != 1))
            {
                goto label_121;
            }
            
            if((val_85.Object == null) || ((System.Type.op_Equality(left:  val_85.Object, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false))
            {
                goto label_128;
            }
            
            val_87 = new string[5];
            val_82 = "(";
            val_87[0] = val_82;
            val_87[1] = 0;
            val_95 = " like (\'%\' || ";
            goto label_137;
            label_121:
            if(((System.String.op_Equality(a:  val_85.Method, b:  "StartsWith")) == false) || ((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24) != 1))
            {
                goto label_141;
            }
            
            val_87 = new string[5];
            val_82 = "(";
            val_87[0] = val_82;
            val_87[1] = 0;
            val_95 = " like (";
            label_137:
            val_87[2] = " like (";
            val_87[3] = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 32;
            val_94 = " || \'%\'))";
            goto label_158;
            label_141:
            if(((System.String.op_Equality(a:  val_85.Method, b:  "EndsWith")) == false) || ((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24) != 1))
            {
                goto label_162;
            }
            
            val_87 = new string[5];
            val_82 = "(";
            val_87[0] = val_82;
            val_87[1] = 0;
            val_96 = " like (\'%\' || ";
            goto label_171;
            label_52:
            if(expr != 23)
            {
                goto label_172;
            }
            
            val_97 = expr;
            if(val_97 == null)
            {
                goto label_173;
            }
            
            val_98 = 0;
            goto label_174;
            label_162:
            if(((System.String.op_Equality(a:  val_85.Method, b:  "Equals")) == false) || ((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 24) != 1))
            {
                goto label_178;
            }
            
            string[] val_36 = new string[5];
            val_87 = val_36;
            val_82 = "(";
            val_87[0] = val_82;
            val_87[1] = 0;
            val_96 = " = (";
            label_171:
            val_87[2] = " = (";
            val_87[3] = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 32;
            val_94 = "))";
            label_158:
            val_87[4] = "))";
            label_44:
            string val_37 = +val_36;
            label_274:
            if((__RuntimeMethodHiddenParam + 24 + 192 + 136) != 0)
            {
                    return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
            return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            label_46:
            val_88 = 0;
            val_89 = 1;
            label_47:
            queryArgs.Add(item:  val_88.Value);
            val_92 = __RuntimeMethodHiddenParam + 24 + 192 + 136;
            object val_39 = val_88.Value;
            label_61:
            if(val_92 != 0)
            {
                    return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
            return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            label_178:
            if((System.String.op_Equality(a:  val_85.Method, b:  "ToLower")) == false)
            {
                goto label_208;
            }
            
            val_99 = 0;
            val_100 = "(lower(";
            goto label_210;
            label_128:
            string[] val_42 = new string[5];
            val_42[0] = "(";
            val_42[1] = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 32;
            val_42[2] = " in ";
            if(0 != 0)
            {
                goto label_224;
            }
            
            goto label_224;
            label_59:
            if(val_92 != 0)
            {
                    return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
            return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            label_173:
            val_97 = 0;
            val_98 = 1;
            label_174:
            if((val_97.Expression != null) && (val_97.Expression == 38))
            {
                    string val_48 = "\"" + this.FindColumnWithPropertyName(propertyName:  val_97.Member).Name(this.FindColumnWithPropertyName(propertyName:  val_97.Member).Name) + "\"";
                if((__RuntimeMethodHiddenParam + 24 + 192 + 136) != 0)
            {
                    return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
                return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
            if(val_97.Expression == null)
            {
                goto label_240;
            }
            
            System.Linq.Expressions.Expression val_50 = val_97.Expression;
            val_82 = (val_82 == 0) ? 0 : (val_82);
            if(this == null)
            {
                goto label_325;
            }
            
            if((System.String.op_Equality(a:  val_82, b:  "?")) == false)
            {
                goto label_246;
            }
            
            if(queryArgs == null)
            {
                goto label_247;
            }
            
            val_101 = queryArgs.Count;
            goto label_248;
            label_208:
            if((System.String.op_Equality(a:  val_85.Method, b:  "ToUpper")) == false)
            {
                goto label_251;
            }
            
            val_99 = 0;
            val_100 = "(upper(";
            label_210:
            string val_55 = val_100 + val_99 + "))";
            goto label_274;
            label_240:
            val_102 = 0;
            if(val_98 != 0)
            {
                goto label_254;
            }
            
            goto label_276;
            label_251:
            val_103 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
            val_103 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
            if((val_103 & 1) == 0)
            {
                    val_103 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_103 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
            }
            
            val_104 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 184 + 16];
            val_104 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 184 + 16;
            if(val_104 == 0)
            {
                    val_105 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_105 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
                if((val_105 & 1) == 0)
            {
                    val_105 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294];
                val_105 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 294;
            }
            
                val_106 = mem[__RuntimeMethodHiddenParam + 24 + 192];
                val_106 = __RuntimeMethodHiddenParam + 24 + 192;
                if(((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 294) & 1) == 0)
            {
                    val_106 = mem[__RuntimeMethodHiddenParam + 24 + 192];
                val_106 = __RuntimeMethodHiddenParam + 24 + 192;
            }
            
                val_104 = __RuntimeMethodHiddenParam + 24 + 192 + 176;
                mem2[0] = val_104;
            }
            
            string val_60 = val_85.Method.ToLower() + "(" + System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  __RuntimeMethodHiddenParam + 24 + 192 + 160))(System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  __RuntimeMethodHiddenParam + 24 + 192 + 160))) + ")";
            goto label_274;
            label_247:
            val_101 = 0.Count;
            label_248:
            queryArgs.RemoveAt(index:  val_101 - 1);
            label_246:
            val_102 = val_82;
            if(val_98 == 0)
            {
                goto label_276;
            }
            
            label_254:
            label_276:
            System.Reflection.MemberInfo val_64 = val_97.Member;
            if(val_97.Member != 16)
            {
                goto label_279;
            }
            
            if(val_64 == null)
            {
                goto label_280;
            }
            
            val_107 = val_64;
            if(val_107 != null)
            {
                goto label_291;
            }
            
            goto label_283;
            label_279:
            System.Reflection.MemberInfo val_65 = val_97.Member;
            if(val_64 != 4)
            {
                goto label_286;
            }
            
            if(val_65 == null)
            {
                goto label_287;
            }
            
            val_107 = val_65;
            if(val_107 != null)
            {
                goto label_289;
            }
            
            goto label_290;
            label_280:
            label_283:
            val_107 = 0;
            goto label_291;
            label_287:
            label_290:
            val_107 = 0;
            label_289:
            label_291:
            if(((val_107 != 0) && (val_107 != 0)) && (val_107 == 0))
            {
                    if(val_107 == 0)
            {
                goto label_295;
            }
            
            }
            
            queryArgs.Add(item:  val_107);
            if((__RuntimeMethodHiddenParam + 24 + 192 + 136) == 0)
            {
                    return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
            return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            label_295:
            System.Text.StringBuilder val_66 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_67 = val_66.Append(value:  "(");
            val_108 = null;
            val_109 = val_107;
            if(val_109 == 0)
            {
                    val_108 = 0;
                val_109 = 0;
            }
            
            if(mem[282584257676957] == 0)
            {
                goto label_304;
            }
            
            var val_82 = mem[282584257676847];
            var val_83 = 0;
            val_82 = val_82 + 8;
            label_306:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_305;
            }
            
            val_83 = val_83 + 1;
            val_82 = val_82 + 16;
            if(val_83 < mem[282584257676957])
            {
                goto label_306;
            }
            
            label_304:
            val_108 = null;
            goto label_307;
            label_305:
            val_109 = val_109 + (((mem[282584257676847] + 8)) << 4);
            val_110 = val_109 + 296;
            label_307:
            System.Collections.IEnumerator val_68 = val_109.GetEnumerator();
            goto label_308;
            label_322:
            var val_84 = 0;
            val_84 = val_84 + 1;
            queryArgs.Add(item:  val_68.Current);
            System.Text.StringBuilder val_71 = val_66.Append(value:  "");
            System.Text.StringBuilder val_72 = val_66.Append(value:  "?");
            label_308:
            var val_85 = 0;
            val_85 = val_85 + 1;
            if(val_68.MoveNext() == true)
            {
                goto label_322;
            }
            
            val_113 = 0;
            val_114 = 1847;
            goto label_323;
            label_1:
            label_325:
            null = new System.NotSupportedException(message:  "Expression is NULL");
            label_326:
            label_53:
            label_172:
            val_1 = null;
            string val_77 = "Cannot compile: "("Cannot compile: ") + val_1.ToString();
            goto label_324;
            label_286:
            val_1 = val_65;
            label_324:
            System.NotSupportedException val_79 = new System.NotSupportedException(message:  "MemberExpr: "("MemberExpr: ") + val_1);
            goto label_326;
            label_323:
            if(val_98 == 0)
            {
                goto label_353;
            }
            
            var val_88 = 38161477;
            if(mem[1103844756835] == 0)
            {
                goto label_357;
            }
            
            var val_86 = mem[1103844756725];
            var val_87 = 0;
            val_86 = val_86 + 8;
            label_356:
            if(((mem[1103844756725] + 8) + -8) == null)
            {
                goto label_355;
            }
            
            val_87 = val_87 + 1;
            val_86 = val_86 + 16;
            if(val_87 < mem[1103844756835])
            {
                goto label_356;
            }
            
            goto label_357;
            label_355:
            val_88 = val_88 + (((mem[1103844756725] + 8)) << 4);
            val_117 = val_88 + 296;
            label_357:
            val_98.Dispose();
            label_353:
            System.Text.StringBuilder val_80 = this.Append(value:  ")");
            string val_81 = this.ToString();
            if(mem[1152921519657028248] == 0)
            {
                    return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
            }
            
            return (TableQuery.CompileResult<T>)__RuntimeMethodHiddenParam + 24 + 192 + 136;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object ConvertTo(object obj, System.Type t)
        {
            System.Type val_3 = System.Nullable.GetUnderlyingType(nullableType:  t);
            if((System.Type.op_Inequality(left:  val_3 = System.Nullable.GetUnderlyingType(nullableType:  t), right:  0)) != false)
            {
                    if(obj == null)
            {
                    return 0;
            }
            
                return System.Convert.ChangeType(value:  obj, conversionType:  val_3 = t);
            }
            
            return System.Convert.ChangeType(value:  obj, conversionType:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string CompileNullBinaryExpression(System.Linq.Expressions.BinaryExpression expression, SQLite4Unity3d.TableQuery.CompileResult<T> parameter)
        {
            string val_4;
            string val_5;
            if(expression == 13)
            {
                    val_4 = parameter;
                val_5 = " is ?)";
                return "(" + val_4 + val_5;
            }
            
            if(expression == 35)
            {
                    val_4 = parameter;
                val_5 = " is not ?)";
                return "(" + val_4 + val_5;
            }
            
            System.NotSupportedException val_3 = new System.NotSupportedException(message:  "Cannot compile Null-BinaryExpression with type "("Cannot compile Null-BinaryExpression with type ") + null.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string GetSqlName(System.Linq.Expressions.Expression expr)
        {
            var val_4;
            if(expr > 34)
            {
                goto label_2;
            }
            
            if((expr - 13) > 8)
            {
                goto label_3;
            }
            
            var val_4 = 52978824;
            val_4 = (52978824 + ((expr - 13)) << 2) + val_4;
            goto (52978824 + ((expr - 13)) << 2 + 52978824);
            label_2:
            if(expr == 35)
            {
                goto label_5;
            }
            
            if(expr == 36)
            {
                goto label_6;
            }
            
            if(expr != 37)
            {
                goto label_10;
            }
            
            val_4 = "or";
            return (string)val_4;
            label_3:
            if(expr == 2)
            {
                goto label_9;
            }
            
            if(expr != 3)
            {
                goto label_10;
            }
            
            val_4 = "and";
            return (string)val_4;
            label_5:
            val_4 = "!=";
            return (string)val_4;
            label_6:
            val_4 = "|";
            return (string)val_4;
            label_9:
            val_4 = "&";
            return (string)val_4;
            label_10:
            System.NotSupportedException val_3 = new System.NotSupportedException(message:  "Cannot get SQL for: "("Cannot get SQL for: ") + expr);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count()
        {
            if(this != null)
            {
                    return this.ExecuteScalar<System.Int32>();
            }
            
            return this.ExecuteScalar<System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count(System.Linq.Expressions.Expression<System.Func<T, bool>> predExpr)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var val_4;
            if(!=0)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 272];
                val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 272;
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 280;
            }
            else
            {
                    return (System.Collections.Generic.IEnumerator<T>);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T First()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T FirstOrDefault()
        {
            if(this == null)
            {
                
            }
        
        }
    
    }

}
