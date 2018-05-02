using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Club.Model;
public partial class SJGL_STINFO : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                string id = Request.Params["id"];
                 ShowInfo(int.Parse(id));
            }
        }
    }
    /// <summary>
    /// 显示信息
    /// </summary>
    /// <param name="STBID"></param>

    private void ShowInfo(int STBID)
    {

        T_STB model = new T_STB();
        model = model.GetModel(STBID);
        if (model != null)
        {
            this.lblSTBMC.Text = model.STBMC;
            this.lblBZID.Text = model.BZID.ToString();
            this.lblCYRS.Text = model.CYRS.ToString();
            this.lblMOBILE.Text = model.MOBILE;
            this.lblSTZN.Text = model.STZN;
            this.lblBZ.Text = model.BZ;
            this.lblSTF.Text = model.STF.ToString();
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");

    }
}
