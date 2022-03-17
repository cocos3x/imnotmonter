using UnityEngine;
private sealed class Json.Parser : IDisposable
{
    // Fields
    private const string WHITE_SPACE = " \t\n\r";
    private const string WORD_BREAK = " \t\n\r{}[],:\"";
    private System.IO.StringReader json;
    
    // Properties
    private char PeekChar { get; }
    private char NextChar { get; }
    private string NextWord { get; }
    private AmplitudeNS.MiniJSON.Json.Parser.TOKEN NextToken { get; }
    
    // Methods
    private Json.Parser(string jsonString)
    {
        System.IO.StringReader val_1 = 536894681;
        val_1 = new System.IO.StringReader(s:  jsonString);
        this.json = val_1;
    }
    public static object Parse(string jsonString)
    {
        var val_5;
        var val_6;
        Json.Parser val_1 = 536899471;
        val_1 = new Json.Parser(jsonString:  jsonString);
        Json.Parser.TOKEN val_2 = this.NextToken;
        object val_3 = this.ParseByToken(token:  536899471);
        if(val_1 == 0)
        {
            goto label_2;
        }
        
        var val_7 = mem[536899471];
        if((mem[536899471] + 178) == 0)
        {
            goto label_3;
        }
        
        var val_6 = 0;
        label_5:
        val_5 = 0;
        if((mem[536899471] + 88 + 0) == 536888187)
        {
            goto label_4;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < (mem[536899471] + 178))
        {
            goto label_5;
        }
        
        label_3:
        val_6 = val_1;
        goto label_6;
        label_4:
        var val_4 = (mem[536899471] + 88) + 0;
        val_7 = val_7 + (((mem[536899471] + 88 + 0) + 4) << 3);
        val_6 = val_7 + 188;
        label_6:
        label_2:
        if(1 == 0)
        {
                return;
        }
        
        var val_5 = 1 - 1;
    }
    public void Dispose()
    {
        this.json.Dispose();
        this.json = 0;
    }
    private System.Collections.Generic.Dictionary<string, object> ParseObject()
    {
        System.IO.StringReader val_7;
        var val_8;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        val_7 = this.json;
        if(val_7 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_9:
        val_7 = val_7;
        Json.Parser.TOKEN val_2 = this.NextToken;
        if(this != 5)
        {
                return;
        }
        
        Json.Parser.TOKEN val_3 = this.NextToken;
        object val_4 = this.ParseByToken(token:  1157103216);
        536874379.set_Item(key:  val_7, value:  1157103216);
        do
        {
            label_6:
            Json.Parser.TOKEN val_5 = this.NextToken;
        }
        while(this == 6);
        
        val_8 = 0;
        if(this == 0)
        {
                return;
        }
        
        if(this == 2)
        {
            goto label_8;
        }
        
        string val_6 = this.ParseString();
        if(this != 0)
        {
            goto label_9;
        }
        
        return;
        label_8:
        val_8 = 536874379;
    }
    private System.Collections.Generic.List<object> ParseArray()
    {
        System.IO.StringReader val_4;
        536878111 = new System.Collections.Generic.List<Page>();
        val_4 = this.json;
        if(val_4 == 0)
        {
            
        }
    
    }
    private object ParseValue()
    {
        Json.Parser.TOKEN val_1 = this.NextToken;
        return this.ParseByToken(token:  1157343600);
    }
    private object ParseByToken(AmplitudeNS.MiniJSON.Json.Parser.TOKEN token)
    {
        token = token - 1;
        if(token <= 9)
        {
                var val_1 = 17728908 + (17728908 + ((token - 1)) << 2);
            if(token == 9)
        {
                0 = 0 & ((R8) >> 32);
            0 = 0 * 0;
            0 = 0 & (this >> 0);
            0 = 0 * 0;
            0 = 0 * 0;
            0 = 0 * 0;
            0 = 0 & (0 >> 32);
            0 = 0 & (((int)IP) >> 32);
            0 = 0 & (((int)IP) >> ((((((((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32))) * (((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32)))) * ((((0 & (R);
            0 = 0 & (((this) << (32-(((((((((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32))) * (((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32)))) * ((((0 & ()) | ((this) << (((((((((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32))) * (((0 & (R8) >> 32) * (0 & (R8) >> 32)) & (this) >> ((0 & (R8) >> 32) * (0 & (R8) >> 32)))) * ((((0 & ());
        }
        
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this.ParseObject();
        }
        
        var val_5 = FP - 16;
    }
    private string ParseString()
    {
        var val_6;
        System.Text.StringBuilder val_1 = 536894635;
        val_1 = new System.Text.StringBuilder();
        label_18:
        if(this.json == 1)
        {
            goto label_8;
        }
        
        char val_2 = this.NextChar;
        if(val_2 == '\')
        {
            goto label_4;
        }
        
        val_6 = val_2;
        if(val_2 != '"')
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(this.json == 1)
        {
            goto label_8;
        }
        
        char val_3 = this.NextChar;
        if(val_3 > '\')
        {
            goto label_9;
        }
        
        if(val_3 != ('/'))
        {
            goto label_10;
        }
        
        label_5:
        label_17:
        System.Text.StringBuilder val_4 = val_1.Append(value:  val_3);
        goto label_18;
        label_9:
        if(val_3 > 'f')
        {
            goto label_13;
        }
        
        if(val_3 == 'b')
        {
            goto label_14;
        }
        
        if(val_3 != 'f')
        {
            goto label_18;
        }
        
        if(val_1 != 0)
        {
            goto label_17;
        }
        
        goto label_17;
        label_13:
        val_3 = val_3 - 110;
        if(val_3 > '')
        {
            goto label_18;
        }
        
        var val_5 = 17728156 + (17728156 + ((val_3 - 110)) << 2);
        if(val_3 == '')
        {
                17728156 + ((val_3 - 110)) << 2 = (17728156 + ((val_3 - 110)) << 2) & ((17728156 + ((val_3 - 110)) << 2) >> 32);
        }
    
    }
    private object ParseNumber()
    {
        var val_5;
        var val_6;
        var val_7;
        string val_1 = this.NextWord;
        if((this.IndexOf(value:  '.')) != 1)
        {
                val_5 = this;
            val_6 = 0;
            double val_3 = System.Double.Parse(s:  1157712368);
            val_7 = 536886067;
        }
        else
        {
                val_6 = 0;
            long val_4 = System.Int64.Parse(s:  1157712368);
            val_7 = 536889041;
        }
    
    }
    private void EatWhitespace()
    {
        do
        {
            if((-1610612559.IndexOf(value:  this.PeekChar)) == 1)
        {
                return;
        }
        
        }
        while(this.json != 1);
    
    }
    private char get_PeekChar()
    {
        if((mem[536885524] & true) != 0)
        {
                return System.Convert.ToChar(value:  this.json);
        }
        
        if(mem[536885453] != 0)
        {
                return System.Convert.ToChar(value:  this.json);
        }
        
        return System.Convert.ToChar(value:  this.json);
    }
    private char get_NextChar()
    {
        if((mem[536885524] & true) != 0)
        {
                return System.Convert.ToChar(value:  this.json);
        }
        
        if(mem[536885453] != 0)
        {
                return System.Convert.ToChar(value:  this.json);
        }
        
        return System.Convert.ToChar(value:  this.json);
    }
    private string get_NextWord()
    {
        char val_6;
        System.Text.StringBuilder val_1 = 536894635;
        val_1 = new System.Text.StringBuilder();
        label_5:
        val_6 = this.PeekChar;
        if((-1610612557.IndexOf(value:  val_6)) != 1)
        {
            goto label_2;
        }
        
        System.Text.StringBuilder val_5 = val_1.Append(value:  this.NextChar);
        val_6 = this.json;
        if(val_6 != 1)
        {
            goto label_5;
        }
        
        label_2:
        if(val_1 == 0)
        {
            
        }
    
    }
    private AmplitudeNS.MiniJSON.Json.Parser.TOKEN get_NextToken()
    {
        this.EatWhitespace();
        if(this.json == 1)
        {
                return;
        }
        
        char val_1 = this.PeekChar;
        if(val_1 > '[')
        {
            goto label_3;
        }
        
        char val_2 = val_1 - 34;
        if(val_2 > '')
        {
            goto label_4;
        }
        
        var val_3 = 17727284 + (17727284 + ((val_1 - 34)) << 2);
        if(val_2 == '')
        {
                5 = 5 & ((IP) << 3);
            mem2[0] = (5 & (IP) << 3) + this;
            mem2[0] = (5 & (IP) << 3) + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this + this + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this + this + this + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this + this + this + this + this + this;
            mem2[0] = (5 & (IP) << 3) + this + this + this + this + this + this + this + this + this;
            this * (17727284 + ((val_1 - 34)) << 2) = (this * (17727284 + ((val_1 - 34)) << 2)) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            mem2[0] = ((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this;
            mem2[0] = ((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this;
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            (((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) = ((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) & (((((this * 17727284 + ((val_1 - 34)) << 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) + this + this) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ))) << 3);
        }
        
        return;
        label_3:
        if(val_1 == ']')
        {
            goto label_5;
        }
        
        if(val_1 == '{')
        {
                return;
        }
        
        if(val_1 != '}')
        {
            goto label_10;
        }
        
        if(this.json != 0)
        {
                return;
        }
        
        return;
        label_5:
        if(this.json != 0)
        {
                return;
        }
        
        return;
        label_4:
        if(val_1 == '[')
        {
                return;
        }
        
        label_10:
        string val_4 = this.NextWord;
        if(this == 0)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  1158325616, b:  -1610600563)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  1158325616, b:  -1610597659)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  1158325616, b:  -1610599037)) == false)
        {
                return;
        }
    
    }

}
