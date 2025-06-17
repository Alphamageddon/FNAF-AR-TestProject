using UnityEngine;

namespace Mapbox.MapMatching
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MapMatchingResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Code;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.MapMatching.Tracepoint[] Tracepoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.MapMatching.MatchObject[] Matchings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> _requestExceptions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasMatchingError { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MatchingError { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasRequestError { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> RequestExceptions { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMatchingResponse()
        {
            this._requestExceptions = new System.Collections.Generic.List<System.Exception>().AsReadOnly();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasMatchingError()
        {
            if("ok" == null)
            {
                    "ok" = "ok";
            }
            
            bool val_1 = Equals(value:  this.Code, comparisonType:  3);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MatchingError()
        {
            var val_9;
            string val_1 = this.Code.ToLower();
            if((System.String.op_Equality(a:  val_1, b:  "ok")) != false)
            {
                    val_9 = "";
                return (string)((System.String.op_Equality(a:  val_1, b:  "nosegment")) != true) ? "Could not find a matching segment for input coordinates." : "Unexpected error: check \'message\'";
            }
            
            if((System.String.op_Equality(a:  val_1, b:  "nomatch")) != false)
            {
                    val_9 = "The input did not produce any matches. features will be an empty array.";
                return (string)((System.String.op_Equality(a:  val_1, b:  "nosegment")) != true) ? "Could not find a matching segment for input coordinates." : "Unexpected error: check \'message\'";
            }
            
            if((System.String.op_Equality(a:  val_1, b:  "toomanycoordinates")) != false)
            {
                    val_9 = "There are to many points in the request.";
                return (string)((System.String.op_Equality(a:  val_1, b:  "nosegment")) != true) ? "Could not find a matching segment for input coordinates." : "Unexpected error: check \'message\'";
            }
            
            if((System.String.op_Equality(a:  val_1, b:  "InvalidInput")) != false)
            {
                    val_9 = "Invalid input: \'message\' will hold an explanation of the invalid input.";
                return (string)((System.String.op_Equality(a:  val_1, b:  "nosegment")) != true) ? "Could not find a matching segment for input coordinates." : "Unexpected error: check \'message\'";
            }
            
            if((System.String.op_Equality(a:  val_1, b:  "ProfileNotFound")) == false)
            {
                    return (string)((System.String.op_Equality(a:  val_1, b:  "nosegment")) != true) ? "Could not find a matching segment for input coordinates." : "Unexpected error: check \'message\'";
            }
            
            val_9 = "Invalid profile.";
            return (string)((System.String.op_Equality(a:  val_1, b:  "nosegment")) != true) ? "Could not find a matching segment for input coordinates." : "Unexpected error: check \'message\'";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasRequestError()
        {
            return (bool)(this._requestExceptions.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> get_RequestExceptions()
        {
            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>)this._requestExceptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetRequestExceptions(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> exceptions)
        {
            this._requestExceptions = exceptions;
        }
    
    }

}
