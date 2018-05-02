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

public partial class SJGL_STEdit : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BZXX();
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                string id = Request.Params["id"];
                ShowInfo(int.Parse(id));
            }
           
        }

    }
    /// <summary>
    /// 绑定部长列表
    /// </summary>
    private void BZXX()
    {
        T_HY model = new T_HY();
        DataTable dt = model.GetList(" and zw like '%部长%'").Tables[0];
        if (dt != null && dt.Rows.Count > 0)
        {
            this.ddlBZ.DataTextField = "HYXM";
            this.ddlBZ.DataValueField = "HYID";
            this.ddlBZ.DataSource = dt;
            this.ddlBZ.DataBind();
            this.ddlBZ.Items.Insert(0,"");
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
            if (model.BZID != null)
            {
                this.ddlBZ.SelectedValue = model.BZID.ToString();
            } 
            this.txtCYRS.Text = model.CYRS.ToString();
            this.txtMOBILE.Text = model.MOBILE;
            this.txtSTZN.Text = model.STZN;
            this.txtBZ.Text = model.BZ;
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
        
        if (this.txtSTBMC.Text == "")
        {
            ResponseMessage(this, "社团名称不能为空！ ");
            return;
        }
        

        if(this.txtSTF.Text!="")
        {
            if (!IsPlusInt(this.txtSTF.Text))
            {
                ResponseMessage(this, "社团费用类型错误！");
                return;
            }

        }
        T_STB model = new T_STB();
       
        
        string STBMC = this.txtSTBMC.Text;
        int BZID = 0;
        if (this.ddlBZ.SelectedValue != "")
        {
            BZID = int.Parse(this.ddlBZ.SelectedValue);
 
        }
          
        int CYRS = 0;
        if (this.txtCYRS.Text != "")
        {
            CYRS = int.Parse(this.txtCYRS.Text);
        }
        
          
        string MOBILE = this.txtMOBILE.Text;
        string STZN = this.txtSTZN.Text;
        string BZ = this.txtBZ.Text;
         int STF=0;
        if (this.txtSTF.Text != "")
        {
            STF = int.Parse(this.txtSTF.Text);
        }


       
        model.STBMC = STBMC;
        model.BZID = BZID;
        model.CYRS = CYRS;
        model.MOBILE = MOBILE;
        model.STZN = STZN;
        model.BZ = BZ;
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
        else
        {
            if (model.ExistsBYNAME(this.txtSTBMC.Text))
            {
                ResponseMessage(this, "社团重名！");
                return;
            }
            //添加
            if (model.Add(model) <= 0)
            {
                ResponseMessage(this, "添加社团失败！");
                return;
            }
 
        }
        if (Request.Params["t"] != null)
        {
            Response.Redirect("~/XXXG/STXXXG.aspx");
        }
        else
        {
            Response.Redirect("STGL.aspx");
        }

    }
    /// <summary>
    /// 返回列表
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.Params["t"] != null)
        {
            Response.Redirect("~/XXXG/STXXXG.aspx");
        }
        else
        {
            Response.Redirect("STGL.aspx");
        }
    }
}
