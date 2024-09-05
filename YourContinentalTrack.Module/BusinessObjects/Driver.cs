using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace YourContinentalTrack.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Driver : BaseObject
    {
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Driver(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetPropertyValue(nameof(FirstName), ref _firstName, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetPropertyValue(nameof(LastName), ref _lastName, value); }
        }

        [Association("Drivers-ViheclesLinks")]
        public XPCollection<VehicleLink> Vehicles
        {
            get { return GetCollection<VehicleLink>(nameof(Vehicles)); }
        }
    }
}