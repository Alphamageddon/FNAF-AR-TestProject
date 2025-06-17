using UnityEngine;

namespace Game.Server.Errors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ServerErrorLogger
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Errors.ILoggingProcessor _processor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.Server.Errors.IErrorFilter> _filters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Errors.ErrorFilters.FallbackErrorFilter _fallbackFilter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerErrorLogger(Game.Server.Errors.ILoggingProcessor processor)
        {
            this._processor = processor;
            this.GenerateFilterMap();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string HandleServerError(Systems.Server.ServerData data)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return this.SelectAppropriateFilter(json:  data.JSON).Log(processor:  this._processor, data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Errors.IErrorFilter SelectAppropriateFilter(string json)
        {
            string val_8;
            var val_9;
            val_8 = this._filters.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = val_8.GetEnumerator();
            label_5:
            if(((-862836360) & 1) == 0)
            {
                goto label_3;
            }
            
            val_8 = 0.emailUIDataHandler;
            if((json.Contains(value:  val_8)) == false)
            {
                goto label_5;
            }
            
            val_9 = this._filters.Item[val_8];
            goto label_7;
            label_3:
            val_9 = this._fallbackFilter;
            label_7:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525218847096});
            return (Game.Server.Errors.IErrorFilter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateFilterMap()
        {
            this._fallbackFilter = new Game.Server.Errors.ErrorFilters.FallbackErrorFilter();
            this._filters = new System.Collections.Generic.Dictionary<System.String, Game.Server.Errors.IErrorFilter>();
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.SSLConnectionErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.JavascriptExceptionErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.NotAuthenticatedErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.UnknownErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.RequestTimeoutErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.DestinationHostConnectErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.DestinationHostResolveErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.CloudScriptAPIErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.NoInternetConnectionErrorFilter());
            this.AddFilterToMap(filter:  new Game.Server.Errors.ErrorFilters.InternalServerErrorFilter());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddFilterToMap(Game.Server.Errors.IErrorFilter filter)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._filters.Add(key:  filter.ErrorString, value:  filter);
        }
    
    }

}
