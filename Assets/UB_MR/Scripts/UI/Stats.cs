using UnityEngine;
using TMPro;
using CAVAS.UB_MR.DT;

namespace CAVAS.UB_MR.UI
{
    public class Stats : MonoBehaviour
    {
        [SerializeField] AutonomousVehicle mDigitalTwin;
        [Space]
        [SerializeField] TextMeshProUGUI mLinearVelocityText;
        [SerializeField] TextMeshProUGUI mAngularVelocityText;

        void Update()
        {
            UpdateLinearVelocityDisplay();
            UpdateAngularVelocityDisplay();
        }

        void UpdateLinearVelocityDisplay()
        {
            if (this.mDigitalTwin == null)
                return;

            Vector3 linear = this.mDigitalTwin.GetLinearVelocity();
            string display = string.Format("Linear: ({0:0.00}, {1:0.00}, {2:0.00})m/s", linear.x, linear.y, linear.z);
            this.mLinearVelocityText.text = display;
        }

        void UpdateAngularVelocityDisplay()
        {
            if (this.mDigitalTwin == null)
                return;

            Vector3 angular = this.mDigitalTwin.GetAngularVelocity();
            string display = string.Format("Angular: ({0:0.00}, {1:0.00}, {2:0.00})rad/s", angular.x, angular.y, angular.z);
            this.mAngularVelocityText.text = display;
        }
    }
}
