using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxReceivers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxQuerierTester_iOS : MonoBehaviour
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TestQuerier()
        {
            UnityEngine.Input.location.Start();
            ConsoleLogger.LogError(className:  "IxQuerierTester_iOS", functionName:  "TestQuerier", logString:  "Camera permissions: "("Camera permissions: ") + (SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryCameraPermission() != true) ? "Enabled" : "Disabled"((SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryCameraPermission() != true) ? "Enabled" : "Disabled") + " Location permissions: "(" Location permissions: ") + (SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryLocationPermission() != true) ? "Enabled" : "Disabled"((SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryLocationPermission() != true) ? "Enabled" : "Disabled"));
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.QueryGoToSettingsURL();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            var val_2;
            IxQuerier_iOS.URLFound val_4;
            val_2 = null;
            val_2 = null;
            val_4 = IxQuerierTester_iOS.<>c.<>9__1_0;
            if(val_4 == null)
            {
                    IxQuerier_iOS.URLFound val_1 = null;
                val_4 = val_1;
                val_1 = new IxQuerier_iOS.URLFound(object:  IxQuerierTester_iOS.<>c.__il2cppRuntimeField_static_fields, method:  System.Void IxQuerierTester_iOS.<>c::<OnEnable>b__1_0(string s));
                IxQuerierTester_iOS.<>c.<>9__1_0 = val_4;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxQuerier_iOS.add_SettingsURLFoundEvent(value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxQuerierTester_iOS()
        {
        
        }
    
    }

}
