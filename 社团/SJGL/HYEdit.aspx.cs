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
/// 添加会员
/// </summary>
public partial class SJGL_HYEdit : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            STXX();//绑定社团列表
           
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                string id = Request.Params["id"];
                ShowInfo(int.Parse(id));
            }
           
        }
    }

    /// <summary>
    /// 社团绑定
    /// </summary>
    private void STXX()
    {
        T_STB modelList = new T_STB();
        DataTable dt = modelList.GetList("").Tables[0];
        if (dt != null && dt.Rows.Count > 0)
        {
            this.ddlST.DataTextField = "STBMC";
            this.ddlST.DataValueField = "STBID";
            this.ddlST.DataSource = dt;
            this.ddlST.DataBind();
            this.ddlST.Items.Insert(0,"");
        }
    }
    /// <summary>
    /// 会员信息显示
    /// </summary>
    /// <param name="HYID"></param>
    private void ShowInfo(int HYID)
    {

        T_HY model = new T_HY(); 
        model = model.GetModel(HYID);
        if (model != null)
        {
           
            this.txtHYXM.Text = model.HYXM;
            if (model.HYXB != null)
            {
                this.ddlXB.SelectedValue = model.HYXB.ToString();

            }
            this.txtHYZY.Text = model.HYZY;
            this.txtHYBJ.Text = model.HYBJ;
            this.txtHYSS.Text = model.HYSS;
            this.txtMOBILE.Text = model.MOBILE;
            if (model.STBID != null)
            {
                this.ddlST.SelectedValue = model.STBID.ToString();
            }
           
            this.txtZW.Text = model.ZW;
            this.txtHF.Text = model.HF.ToString();
            
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
         
        if (this.txtHYXM.Text == "")
        {
           ResponseMessage(this, "会员名称不能为空！");
        }
        if (this.txtHF.Text != "")
        {
            if (!IsPlusInt(this.txtHF.Text))
            {
                ResponseMessage(this, "会费必须输入正整数类型！");
                return;
            }
        }
        Club.Model.T_HY model = new Club.Model.T_HY();
       
        string HYXM = this.txtHYXM.Text;
        bool HYXB = false;
        if (this.ddlXB.SelectedValue == "0")
        {
            HYXB = true;
        }
        else
        {
            HYXB = false;
        }
       
        string HYZY = this.txtHYZY.Text;
        string HYBJ = this.txtHYBJ.Text;
        string HYSS = this.txtHYSS.Text;
        string MOBILE = this.txtMOBILE.Text;
        int STBID = 0;
        if (this.ddlST.SelectedValue != "")
        {
              STBID = int.Parse(this.ddlST.SelectedValue);
        }
        string ZW = this.txtZW.Text;
        int HF = 0;
        if (this.txtHF.Text != "")
        {
            HF = int.Parse(this.txtHF.Text);
        }
        

     
        model.HYXM = HYXM;
        model.HYXB = HYXB;
        model.HYZY = HYZY;
        model.HYBJ = HYBJ;
        model.HYSS = HYSS;
        model.MOBILE = MOBILE;
        model.STBID = STBID;
        model.ZW = ZW;
        model.HF = HF;
        if(Request.Params["id"]!=null &&  Request.Params["id"].Trim()!="")
        {
            //修改
            model.HYID = Convert.ToInt32(Request.Params["id"]);
            if (model.Update(model) <= 0)
            {
                ResponseMessage(this, "修改会员失败，请检查输入是否正确！");
                return;
 
            }
        }

        else  if (model.Add(model) <= 0)
        {
            //重名
            if (model.ExistsBYname(this.txtHYXM.Text))
            {
                ResponseMessage(this, "会员重名，请重新输入!");
                return;
            }
            ResponseMessage(this, "添加会员失败，请检查输入是否正确！");
            return;
        }
        if (Request.Params["t"] != null)
        {
            Response.Redirect("~/XXXG/HYXXXG.aspx");

        }
        else
        {
            Response.Redirect("HYGL.aspx");
        }
        

    }
    /// <summary>
    /// 返回列表
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btBack_Click(object sender, EventArgs e)
    {
        if (Request.Params["t"] != null)
        {
            Response.Redirect("~/XXXG/HYXXXG.aspx");

        }
        else
        {
            Response.Redirect("HYGL.aspx");
        }

    }
}
