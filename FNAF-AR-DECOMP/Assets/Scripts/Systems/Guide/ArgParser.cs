using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ArgParser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const char ARG_SEPARATOR = '\x7c';
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetFloat(string[] args, int index, float fallback)
        {
            if(args == null)
            {
                goto label_1;
            }
            
            if((index & 2147483648) == 0)
            {
                goto label_2;
            }
            
            return (float)fallback;
            label_1:
            if((index & 2147483648) != 0)
            {
                    return (float)fallback;
            }
            
            label_2:
            if(args.Length <= index)
            {
                    return (float)fallback;
            }
            
            fallback = 0f;
            if((System.String.IsNullOrEmpty(value:  args[(long)index])) == false)
            {
                    return System.Convert.ToSingle(value:  args[(long)(int)(index)] + 32, provider:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            return (float)fallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetString(string[] args, int index, string fallback)
        {
            if((index & 2147483648) != 0)
            {
                    return fallback;
            }
            
            if(args.Length <= index)
            {
                    return fallback;
            }
            
            fallback = args[(long)index];
            return fallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetInt(string[] args, int index, int fallback)
        {
            if(args == null)
            {
                goto label_1;
            }
            
            if((index & 2147483648) == 0)
            {
                goto label_2;
            }
            
            return (int)fallback;
            label_1:
            if((index & 2147483648) != 0)
            {
                    return (int)fallback;
            }
            
            label_2:
            if(args.Length <= index)
            {
                    return (int)fallback;
            }
            
            if((System.String.IsNullOrEmpty(value:  args[(long)index])) == false)
            {
                    return System.Convert.ToInt32(value:  args[(long)(int)(index)] + 32, provider:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            fallback = 0;
            return (int)fallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool GetBool(string[] args, int index, bool fallback)
        {
            if(args == null)
            {
                goto label_1;
            }
            
            if((index & 2147483648) == 0)
            {
                goto label_2;
            }
            
            return (bool)fallback;
            label_1:
            if((index & 2147483648) != 0)
            {
                    return (bool)fallback;
            }
            
            label_2:
            if(args.Length <= index)
            {
                    return (bool)fallback;
            }
            
            return System.String.op_Equality(a:  args[(long)index].ToLower(), b:  "true");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string[] PrepArgs(string args)
        {
            char[] val_1 = new char[1];
            val_1[0] = 124;
            if(args != null)
            {
                    return args.Split(separator:  val_1);
            }
            
            return args.Split(separator:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetFloat(string args, int index, float fallback)
        {
            return Systems.Guide.ArgParser.GetFloat(args:  Systems.Guide.ArgParser.PrepArgs(args:  args), index:  index, fallback:  fallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetString(string args, int index, string fallback)
        {
            return Systems.Guide.ArgParser.GetString(args:  Systems.Guide.ArgParser.PrepArgs(args:  args), index:  index, fallback:  fallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int GetInt(string args, int index, int fallback)
        {
            return Systems.Guide.ArgParser.GetInt(args:  Systems.Guide.ArgParser.PrepArgs(args:  args), index:  index, fallback:  fallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool GetBool(string args, int index, bool fallback)
        {
            fallback = fallback;
            return Systems.Guide.ArgParser.GetBool(args:  Systems.Guide.ArgParser.PrepArgs(args:  args), index:  index, fallback:  fallback);
        }
    
    }

}
