using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors;
using YourContinentalTrack.Module.BusinessObjects;

namespace YourContinentalTrack.Module.Controllers
{
    public partial class VehicleLinkController : ObjectViewController<DetailView, VehicleLink>
    {
        public VehicleLinkController()
        {
            InitializeComponent();
        }
        protected override void OnActivated()
        {
            base.OnActivated();

            View.CustomizeViewItemControl<DateTimePropertyEditor>(this, SetCalendarView, nameof(VehicleLink.EndDate));
        }

        private void SetCalendarView(DateTimePropertyEditor propertyEditor)
        {
            propertyEditor.ComponentModel.CustomDisabledDate += (e) =>
            {
                if (e.Date < DateTime.Today 
                || e.Date.DayOfWeek == DayOfWeek.Saturday 
                || e.Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    e.IsDisabled = true;
                }
            };
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
        }
    }
}