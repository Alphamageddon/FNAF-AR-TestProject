using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SummonTutorialEncounterProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            Systems.Guide.ActionProcessors.SummonTutorialEncounterData val_7;
            .actionSharedContext = actionSharedContext;
            System.String[] val_2 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            Systems.Guide.ActionProcessors.SummonTutorialEncounterData val_5 = new Systems.Guide.ActionProcessors.SummonTutorialEncounterData();
            .isDone = false;
            .cpuId = Systems.Guide.ArgParser.GetString(args:  val_2, index:  0, fallback:  "FreddyFazbear");
            .plushSuitId = Systems.Guide.ArgParser.GetString(args:  val_2, index:  1, fallback:  "FreddyFazbear");
            .data = val_5;
            node.ActionData = val_5;
            (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data.callback = new System.Action<System.String, System.String, AnimatronicEntity.SaveGameChunk>(object:  new SummonTutorialEncounterProcessor.<>c__DisplayClass0_0(), method:  System.Void SummonTutorialEncounterProcessor.<>c__DisplayClass0_0::<StartAction>b__0(string cpuId, string plushSuitId, AnimatronicEntity.SaveGameChunk animatronicData));
            (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].actionSharedContext._masterEvents.add_AnimatronicDataSentForId(value:  (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data.callback);
            val_7 = (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data;
            if(((SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data) != null)
            {
                goto label_9;
            }
            
            val_7 = (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data;
            if(val_7 == null)
            {
                goto label_10;
            }
            
            label_9:
            (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].actionSharedContext._serverAnimatronicRequester.RequestData(cpuId:  (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data.cpuId, plushSuitId:  (SummonTutorialEncounterProcessor.<>c__DisplayClass0_0)[1152921523397771728].data.plushSuitId);
            return;
            label_10:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsActionComplete(Systems.Guide.GuideNode node)
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SpawnAnimatronic(AnimatronicEntity.SaveGameChunk animatronicData, Systems.Guide.GuideActionSharedContext actionSharedContext)
        {
            actionSharedContext._animatronicContainer.AddFakeEntity(entity:  actionSharedContext._animatronicCreator.CreateEntity(saveGameChunk:  animatronicData));
        }
    
    }

}
