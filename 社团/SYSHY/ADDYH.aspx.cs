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

/// <summary>
/// 添加用户
/// </summary>
public partial class SYSHY_ADDYH : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (UserInfo == null)
            {
                ResponseMessage(this, "请登录！");
                return;
            }
           
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                string id = Request.Params["id"];
                ShowInfo(int.Parse(id));
            }
        }

    }
    /// <summary>
    /// 用户列表
    /// </summary>
    /// <param name="YHID"></param>
    private void ShowInfo(int YHID)
    {
        T_YH model = new T_YH();
        model = model.GetModel(YHID);
        if (model != null)
        {
             
            this.txtDLZH.Text = model.DLZH;
            this.txtYHMC.Text = model.YHMC;
            this.txtDLMM.Text = model.DLMM;
        }

    }
    /// <summary>
    /// 添加用户
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string strErr = "";
        if (this.txtDLZH.Text == "")
        {
            strErr += "登录账户不能为空！\\n";
        }
        if (this.txtYHMC.Text == "")
        {
            strErr += "会员名称不能为空！\\n";
        }
        if (this.txtDLMM.Text == "")
        {
            strErr += "登录密码不能为空！\\n";
        }

        if (strErr != "")
        {
            ResponseMessage(this, strErr);
            return;
        }
        string DLZH = this.txtDLZH.Text;
        string YHMC = this.txtYHMC.Text;
        string DLMM = this.txtDLMM.Text;

        T_YH model = new T_YH();
        model.DLZH = DLZH;
        model.YHMC = YHMC;
        model.DLMM = DLMM;
        if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
        {
            //修改 
            model.YHID = Convert.ToInt32(Request.Params["id"]);
            if (model.Update(model) <= 0)
            {
                ResponseMessage(this, "修改失败，系统错误！");
                return;
            }
        }
        else
        {
            if (model.Add(model) <= 0)
            {
                ResponseMessage(this, "添加用户失败，系统错误！");
                return;
            }
 
        }
        Response.Redirect("YHGL.aspx");
   

    }
}
