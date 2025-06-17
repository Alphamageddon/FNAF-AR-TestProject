using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GA_MiniJSON.Parser : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string WORD_BREAK = "{}[],:\"";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.IO.StringReader json;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private char PeekChar { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private char NextChar { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string NextWord { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameAnalyticsSDK.Utilities.GA_MiniJSON.Parser.TOKEN NextToken { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsWordBreak(char c)
    {
        var val_4;
        var val_5;
        if((System.Char.IsWhiteSpace(c:  c)) != false)
        {
                val_4 = 1;
            return (bool)((IndexOf(value:  c)) != 1) ? 1 : 0;
        }
        
        val_5 = "{}[],:\"";
        if(("{}[],:\"") != null)
        {
                return (bool)((IndexOf(value:  c)) != 1) ? 1 : 0;
        }
        
        val_5 = "{}[],:\"";
        return (bool)((IndexOf(value:  c)) != 1) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GA_MiniJSON.Parser(string jsonString)
    {
        this.json = new System.IO.StringReader(s:  jsonString);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static object Parse(string jsonString)
    {
        GA_MiniJSON.Parser val_1 = new GA_MiniJSON.Parser(jsonString:  jsonString);
        if(val_1 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_1.Dispose();
        }
        
        if(26 == 26)
        {
                return (object)val_1.ParseByToken(token:  val_1.NextToken);
        }
        
        if(0 == 0)
        {
                return (object)val_1.ParseByToken(token:  val_1.NextToken);
        }
        
        return (object)val_1.ParseByToken(token:  val_1.NextToken);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Dispose()
    {
        this.json.Dispose();
        this.json = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<string, object> ParseObject()
    {
        var val_7;
        System.IO.StringReader val_8;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
        val_7 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_8 = this.json;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_9:
        if(this.NextToken != 5)
        {
            goto label_7;
        }
        
        val_1.set_Item(key:  val_8, value:  this.ParseByToken(token:  this.NextToken));
        do
        {
            label_6:
            TOKEN val_5 = this.NextToken;
        }
        while(val_5 == 6);
        
        if(val_5 == 0)
        {
            goto label_7;
        }
        
        if(val_5 == 2)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_7;
        }
        
        val_8 = this.ParseString();
        if(val_8 != null)
        {
            goto label_9;
        }
        
        label_7:
        val_7 = 0;
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<object> ParseArray()
    {
        if(this.json == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object ParseValue()
    {
        return this.ParseByToken(token:  this.NextToken);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object ParseByToken(GameAnalyticsSDK.Utilities.GA_MiniJSON.Parser.TOKEN token)
    {
        var val_10 = 0;
        if((token - 1) > 9)
        {
                return (object);
        }
        
        var val_10 = 52949748 + ((token - 1)) << 2;
        val_10 = val_10 + 52949748;
        goto (52949748 + ((token - 1)) << 2 + 52949748);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string ParseString()
    {
        char val_14;
        char val_15;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        if(this.json != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_34:
        val_15 = this.NextChar;
        char val_3 = val_15 & 65535;
        if(val_3 == '\')
        {
            goto label_3;
        }
        
        if(val_3 == '"')
        {
            goto label_8;
        }
        
        label_11:
        val_14 = val_15;
        label_26:
        System.Text.StringBuilder val_4 = val_1.Append(value:  val_14);
        goto label_18;
        label_3:
        val_15 = this.json;
        if(val_15 == 1)
        {
            goto label_8;
        }
        
        char val_5 = this.NextChar;
        char val_6 = val_5 & 65535;
        if(val_6 > '\')
        {
            goto label_9;
        }
        
        val_6 = val_6 - 34;
        if(val_6 > (':'))
        {
            goto label_18;
        }
        
        val_6 = 1 << val_6;
        val_6 = val_6 & 288230376151719937;
        if(val_6 != 0)
        {
            goto label_11;
        }
        
        goto label_18;
        label_9:
        if(val_6 > 'f')
        {
            goto label_13;
        }
        
        char val_7 = val_5 & 65535;
        if(val_7 == 'b')
        {
            goto label_14;
        }
        
        if(val_7 != 'f')
        {
            goto label_18;
        }
        
        if(val_1 != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_13:
        char val_8 = val_5 & 65535;
        val_8 = val_8 - 110;
        if(val_8 > '')
        {
            goto label_18;
        }
        
        var val_14 = 52949716 + (((val_5 & 65535) - 110)) << 2;
        val_14 = val_14 + 52949716;
        goto (52949716 + (((val_5 & 65535) - 110)) << 2 + 52949716);
        label_14:
        if(val_1 != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_18:
        val_15 = this.json;
        if(val_15 != 1)
        {
            goto label_34;
        }
        
        label_8:
        if(val_1 == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object ParseNumber()
    {
        var val_7;
        var val_8;
        long val_5 = 0;
        string val_1 = this.NextWord;
        if((val_1.IndexOf(value:  '.')) != 1)
        {
                bool val_4 = System.Double.TryParse(s:  val_1, result: out  double val_3 = 1.28823590995516E-231);
            val_7 = 0;
            val_8 = null;
            return (object)0;
        }
        
        bool val_6 = System.Int64.TryParse(s:  val_1, result: out  val_5);
        val_7 = val_5;
        val_8 = null;
        return (object)0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void EatWhitespace()
    {
        do
        {
            if((System.Char.IsWhiteSpace(c:  this.PeekChar)) == false)
        {
                return;
        }
        
        }
        while(this.json != 1);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private char get_PeekChar()
    {
        return System.Convert.ToChar(value:  this.json);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private char get_NextChar()
    {
        return System.Convert.ToChar(value:  this.json);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string get_NextWord()
    {
        var val_6;
        System.Text.StringBuilder val_1 = null;
        val_6 = 0;
        val_1 = new System.Text.StringBuilder();
        label_4:
        if((GA_MiniJSON.Parser.IsWordBreak(c:  this.PeekChar)) == true)
        {
            goto label_1;
        }
        
        System.Text.StringBuilder val_5 = val_1.Append(value:  this.NextChar);
        if(this.json != 1)
        {
            goto label_4;
        }
        
        label_1:
        if(val_1 == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameAnalyticsSDK.Utilities.GA_MiniJSON.Parser.TOKEN get_NextToken()
    {
        var val_9;
        this.EatWhitespace();
        if(this.json == 1)
        {
            goto label_2;
        }
        
        char val_2 = this.PeekChar & 65535;
        if(val_2 > '[')
        {
            goto label_3;
        }
        
        if((val_2 - 34) > '')
        {
            goto label_4;
        }
        
        var val_9 = 52949616;
        val_9 = (52949616 + (((val_1 & 65535) - 34)) << 2) + val_9;
        goto (52949616 + (((val_1 & 65535) - 34)) << 2 + 52949616);
        label_2:
        val_9 = 0;
        return (TOKEN)val_9;
        label_3:
        if(val_2 == ']')
        {
            goto label_6;
        }
        
        if(val_2 == '{')
        {
                return (TOKEN)val_9;
        }
        
        if(val_2 != '}')
        {
            goto label_14;
        }
        
        if(this.json != null)
        {
                return (TOKEN)val_9;
        }
        
        return (TOKEN)val_9;
        label_6:
        if(this.json != null)
        {
                return (TOKEN)val_9;
        }
        
        return (TOKEN)val_9;
        label_4:
        if(val_2 == '[')
        {
                return (TOKEN)val_9;
        }
        
        label_14:
        string val_4 = this.NextWord;
        if((System.String.op_Equality(a:  val_4, b:  "false")) != false)
        {
                return (TOKEN)val_9;
        }
        
        if((System.String.op_Equality(a:  val_4, b:  "true")) != false)
        {
                return (TOKEN)val_9;
        }
        
        var val_8 = ((System.String.op_Equality(a:  val_4, b:  "null")) != true) ? 11 : 0;
        return (TOKEN)val_9;
    }

}
