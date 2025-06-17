using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhaseChooser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess _blackboard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _readyForCleanupCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase, Game.AttackSequence.Animatronic.PhaseManagement.Phase> _phaseLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phase _currentPhase;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase Phase { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase get_Phase()
        {
            if(this._currentPhase == null)
            {
                    return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)this._currentPhase;
            }
            
            goto typeof(Game.AttackSequence.Animatronic.PhaseManagement.Phase).__il2cppRuntimeField_168;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase val_1;
            if(this._currentPhase != null)
            {
                    val_1 = this._currentPhase;
            }
            else
            {
                    val_1 = 0;
            }
            
            this.SetPhase(newPhase:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EncounterEnded()
        {
            this.SetPhase(newPhase:  11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetPhase(Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase newPhase)
        {
            Game.AttackSequence.Animatronic.PhaseManagement.Phase val_10;
            if(newPhase == 0)
            {
                    return;
            }
            
            if(this._currentPhase != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_2 = this._blackboard.AttackProfile;
                if((val_2.EncounterType - 1) <= 1)
            {
                    this._masterEventExposer.OnPhaseCompleted(phase:  this._currentPhase);
            }
            
                val_10 = this._currentPhase;
                val_10.Exit();
            }
            
            if(newPhase == 1)
            {
                    if(this._readyForCleanupCallback == null)
            {
                    return;
            }
            
                this._readyForCleanupCallback.Invoke();
                return;
            }
            
            val_10 = this._phaseLookup;
            Game.AttackSequence.Animatronic.PhaseManagement.Phase val_4 = val_10.Item[newPhase];
            this._currentPhase = val_4;
            if(val_4 == null)
            {
                    return;
            }
            
            this = ???;
            val_10 = ???;
            goto typeof(Game.AttackSequence.Animatronic.PhaseManagement.Phase).__il2cppRuntimeField_178;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhaseChooser(Master.EventExposer masterEventExposer, System.Action readyForCleanupCallback)
        {
            this._masterEventExposer = masterEventExposer;
            this._readyForCleanupCallback = readyForCleanupCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            this._blackboard = blackboard;
            var val_3 = 0;
            val_3 = val_3 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_2 = blackboard.AttackProfile;
            this.CreatePhaseLookup(encounterType:  val_2.EncounterType);
            this.SetPhase(newPhase:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreatePhaseLookup(Game.ItemDefinition.Data.DataDefinitions.EncounterType encounterType)
        {
            this._phaseLookup = new System.Collections.Generic.Dictionary<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase, Game.AttackSequence.Animatronic.PhaseManagement.Phase>();
            if(encounterType <= 3)
            {
                    var val_2 = 52950260 + (encounterType) << 2;
                val_2 = val_2 + 52950260;
            }
            else
            {
                    this._currentPhase = 0;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateStandardPhaseLookup()
        {
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.WaitForCamera>(phase:  2);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.InitialPause>(phase:  3);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Circle>(phase:  4);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Pause>(phase:  5);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Glimpse>(phase:  6);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Charge>(phase:  7);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Haywire>(phase:  8);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Jumpscare>(phase:  9);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Shutdown>(phase:  10);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Results>(phase:  11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateTutorialPhaseLookup()
        {
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Tutorial.TutorialWaitForCamera>(phase:  2);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Tutorial.TutorialCharge>(phase:  7);
            this.CreateStandardPhaseLookup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateTutorialAutoWinPhaseLookup()
        {
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.TutorialAutoWin.TutorialAutoWinJumpscare>(phase:  9);
            this.CreateTutorialPhaseLookup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreatePhantomPhaseLookup()
        {
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.WaitForCamera>(phase:  2);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomInitialPause>(phase:  3);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomWalk>(phase:  12);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomOverload>(phase:  13);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomPause>(phase:  5);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomJumpscare>(phase:  9);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomShutdown>(phase:  10);
            this.CreateAndAddPhase<Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard.Results>(phase:  11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateAndAddPhase<T>(Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase phase)
        {
            if((this._phaseLookup.ContainsKey(key:  phase)) != false)
            {
                    return;
            }
            
            __RuntimeMethodHiddenParam + 48.Setup(blackboard:  this._blackboard);
            this._phaseLookup.Add(key:  phase, value:  __RuntimeMethodHiddenParam + 48);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestDestruction()
        {
            this.SetPhase(newPhase:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            var val_5;
            var val_6;
            this._currentPhase = 0;
            if(this._phaseLookup == null)
            {
                goto label_1;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._phaseLookup.Values.GetEnumerator();
            goto label_3;
            label_5:
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            val_3._masterDomain = 0;
            val_3._serverGameUIDataModel = 0;
            label_3:
            if(((-615993048) & 1) != 0)
            {
                goto label_5;
            }
            
            val_5 = 0;
            val_6 = 1;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525465690408});
            this._phaseLookup.Clear();
            label_1:
            this._masterEventExposer = 0;
            this._readyForCleanupCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PhaseChooser()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.PhaseChooser.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
