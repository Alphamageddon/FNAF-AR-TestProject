using UnityEngine;

namespace Alerts.Evaluate.Preconditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreconditionDateRange : Precondition
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PreconditionDateRange()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreconditionDateRange(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            val_1 = new System.Object();
            mem[1152921525118026288] = domain;
            mem[1152921525118026296] = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool MeetsPrecondition()
        {
            var val_6;
            if(this.HasDatePreconditions() != false)
            {
                    if(this.HasStartDatePrecondition() != false)
            {
                    if(this.MeetsStartDatePrecondition() == false)
            {
                goto label_4;
            }
            
            }
            
                if(this.HasEndDatePrecondition() != false)
            {
                    if(this.MeetsEndDatePrecondition() == false)
            {
                goto label_4;
            }
            
            }
            
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_4:
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasDatePreconditions()
        {
            if(X20.Preconditions.PreconditionRequirements == null)
            {
                    return (bool)(this.DateTimeRange != 0) ? 1 : 0;
            }
            
            this = this.Preconditions.PreconditionRequirements;
            return (bool)(this.DateTimeRange != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasStartDatePrecondition()
        {
            return (bool)(X19.Preconditions.PreconditionRequirements.DateTimeRange.PreconditionReqStartDateTime != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasEndDatePrecondition()
        {
            return (bool)(X19.Preconditions.PreconditionRequirements.DateTimeRange.PreconditionReqEndDateTime != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool MeetsStartDatePrecondition()
        {
            System.DateTimeOffset val_1 = DateTimeOffsetToUse;
            System.DateTimeOffset val_6 = X21.Preconditions.PreconditionRequirements.DateTimeRange.PreconditionReqStartDateTime.ToDateTimeOffset();
            return System.DateTimeOffset.op_GreaterThanOrEqual(left:  new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_1.m_dateTime.dateData}, m_offsetMinutes = val_1.m_offsetMinutes}, right:  new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_6.m_dateTime.dateData}, m_offsetMinutes = val_6.m_offsetMinutes});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool MeetsEndDatePrecondition()
        {
            System.DateTimeOffset val_1 = DateTimeOffsetToUse;
            System.DateTimeOffset val_6 = X21.Preconditions.PreconditionRequirements.DateTimeRange.PreconditionReqEndDateTime.ToDateTimeOffset();
            return System.DateTimeOffset.op_LessThanOrEqual(left:  new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_1.m_dateTime.dateData}, m_offsetMinutes = val_1.m_offsetMinutes}, right:  new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_6.m_dateTime.dateData}, m_offsetMinutes = val_6.m_offsetMinutes});
        }
    
    }

}
