using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace YourContinentalTrack.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class VehicleLink : Vehicle
    {
        public VehicleLink(Session session) : base(session)
        {
        }

        private DateTime _endDate;
        [RuleRequiredField]
        public DateTime EndDate
        {
            get { return _endDate; }
            set { SetPropertyValue(nameof(EndDate), ref _endDate, value); }
        }

        [Association("Drivers-ViheclesLinks")]
        //[VisibleInDetailView(false)]
        public XPCollection<Driver> Drivers
        {
            get { return GetCollection<Driver>(nameof(Drivers)); }
        }
    }
}