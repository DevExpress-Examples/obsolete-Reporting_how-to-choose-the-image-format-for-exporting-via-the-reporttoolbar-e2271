using System;
using DevExpress.XtraReports.Web;
// ...

namespace ImageExportReportToolbar {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ReportToolbar1_Init(object sender, EventArgs e) {

            ReportToolbarComboBox myItem = (ReportToolbarComboBox)this.ReportToolbar1.Items[16];

            myItem.Elements[7].Text = "PNG Image";

            myItem.Elements.Add(new ListElement("bmp"));
            myItem.Elements[8].Text = "BMP Image";

            myItem.Elements.Add(new ListElement("gif"));
            myItem.Elements[9].Text = "GIF Image";

            myItem.Elements.Add(new ListElement("jpg"));
            myItem.Elements[10].Text = "JPG Image";

            myItem.Elements.Add(new ListElement("tiff"));
            myItem.Elements[11].Text = "TIFF Image";
        }
    }
}
