using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace YourContinentalTrack.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Vehicle : BaseObject
    {
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Vehicle(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private VehicleType _vehicleType;
        public VehicleType VehicleType
        {
            get { return _vehicleType; }
            set { SetPropertyValue(nameof(VehicleType), ref _vehicleType, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetPropertyValue(nameof(Name), ref _name, value); }
        }
    }
}