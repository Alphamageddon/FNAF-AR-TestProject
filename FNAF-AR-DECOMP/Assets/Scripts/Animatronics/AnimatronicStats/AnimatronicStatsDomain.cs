using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicStatsDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.Container <container>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.Loader <loader>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.Saver <saver>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.Getter <getter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.AnimatronicStats.Setter <setter>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Container container { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Loader loader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Saver saver { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Getter getter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Setter setter { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Container get_container()
        {
            return (Animatronics.AnimatronicStats.Container)this.<container>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Loader get_loader()
        {
            return (Animatronics.AnimatronicStats.Loader)this.<loader>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Saver get_saver()
        {
            return (Animatronics.AnimatronicStats.Saver)this.<saver>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Getter get_getter()
        {
            return (Animatronics.AnimatronicStats.Getter)this.<getter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.Setter get_setter()
        {
            return (Animatronics.AnimatronicStats.Setter)this.<setter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicStatsDomain()
        {
            this.<container>k__BackingField = new Animatronics.AnimatronicStats.Container(animatronicStatsDomain:  this);
            ._animatronicStatsDomain = this;
            this.<loader>k__BackingField = new Animatronics.AnimatronicStats.Loader();
            ._animatronicStatsDomain = this;
            this.<saver>k__BackingField = new Animatronics.AnimatronicStats.Saver();
            ._animatronicStatsDomain = this;
            this.<getter>k__BackingField = new Animatronics.AnimatronicStats.Getter();
            ._animatronicStatsDomain = this;
            this.<setter>k__BackingField = new Animatronics.AnimatronicStats.Setter();
        }
    
    }

}
