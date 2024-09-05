using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YourContinentalTrack.Module.BusinessObjects;
using DevExpress.Blazor;
using DevExpress.ExpressApp.Xpo;

namespace YourContinentalTrack.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    //public partial class PopupVehicleAssigmentController : ViewController
    public partial class PopupVehicleAssigmentController : ObjectViewController<ListView, VehicleLink>
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public PopupVehicleAssigmentController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.

            TargetViewType = ViewType.DetailView;

            TargetObjectType = typeof(Driver);

            var showLinkAction = new PopupWindowShowAction(this, "ShowLinkAction", PredefinedCategory.Edit)
            {
                Caption = "Add Vehicles"
            };

            showLinkAction.CustomizePopupWindowParams += ShowLinkAction_CustomizePopupWindowParams;
        }

        private void ShowLinkAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            e.View = Application.CreateListView(typeof(VehicleLink), true);
        }

        protected override void OnActivated()
        {
            base.OnActivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }
    }
}
