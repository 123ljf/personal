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

public partial class SJGL_HYINFO : System.Web.UI.Page
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
    /// 显示
    /// </summary>
    /// <param name="HYID"></param>
    private void ShowInfo(int HYID)
    {

        T_HY model = new T_HY();
        model = model.GetModel(HYID);
        if (model != null)
        {

            this.lblHYXM.Text = model.HYXM;
            if (model.HYXB)
            {
                lab_sex.Text = "男";
            }
            else
            {
                lab_sex.Text = "女";
            }
            this.lblHYZY.Text = model.HYZY;
            this.lblHYBJ.Text = model.HYBJ;
            this.lblHYSS.Text = model.HYSS;
            this.lblMOBILE.Text = model.MOBILE;
            this.lblSTBID.Text = model.STBID.ToString();
            this.lblZW.Text = model.ZW;
            this.lblHF.Text = model.HF.ToString();
             
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");

    }
}
