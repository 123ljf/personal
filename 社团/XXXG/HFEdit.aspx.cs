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

public partial class XXXG_HFEdit   : PageBase
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
    /// 绑定社团信息
    /// </summary>
    /// <param name="STBID"></param>
    private void ShowInfo(int STBID)
    {

        T_STB model = new T_STB();
        model = model.GetModel(STBID);
        if (model != null)
        {

            this.txtSTBMC.Text = model.STBMC;
            this.txtSTF.Text = model.STF.ToString();
        }

    }
    /// <summary>
    /// 编辑社团
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        T_STB model = new T_STB();
        int STF = 0;
        if (this.txtSTF.Text != "")
        {
            STF = int.Parse(this.txtSTF.Text);
        }
        model.STF = STF;
        if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
        {
            //修改
            model.STBID = Convert.ToInt32(Request.Params["id"]);
            if (model.Update(model) <= 0)
            {
                ResponseMessage(this, "修改失败、请检查输入是否正确！");
                return;
            }
        }
        Response.Redirect("HFXXXG.aspx");


    }
    /// <summary>
    /// 返回列表
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HFXXXG.aspx");
    }
}
