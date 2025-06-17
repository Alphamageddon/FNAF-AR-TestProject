using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RequiredFieldAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _autoCreate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _autoSearch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _editorOnly;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutoSearch { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutoCreate { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EditorOnly { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RequiredFieldAttribute(bool autoSearch)
        {
            this._editorOnly = true;
            this._autoSearch = autoSearch;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RequiredFieldAttribute()
        {
            this._editorOnly = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AutoSearch()
        {
            return (bool)this._autoSearch;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AutoSearch(bool value)
        {
            this._autoSearch = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AutoCreate()
        {
            return (bool)this._autoCreate;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AutoCreate(bool value)
        {
            this._autoCreate = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EditorOnly()
        {
            return (bool)this._editorOnly;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EditorOnly(bool value)
        {
            this._editorOnly = value;
        }
    
    }

}
