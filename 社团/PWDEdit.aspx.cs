using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
 

/// <summary>
/// 密码修改
/// </summary>
public partial class ADMIN_PWDEdit:PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["admin"] == null)
            {
                ResponseMessage(this, "请您重新登录！");
                return;
            }

            this.lblName.Text = ((LoginUser)Session["admin"]).ZH;
        }
    }

     

   
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //校验阶段
        if (this.txtOldPassword.Text != UserInfo.Password)
        {
       
            ResponseMessage(this,"旧密码输入错误！");
            return;
        }
        if (this.txtPassword.Text == "")
        {
            ResponseMessage(this, "新密码不能为空！");
            
            return;
        }
        if (this.txtPassword1.Text == "")
        {
            ResponseMessage(this, "二次输入密码不能为空！");  
            return;
        }
        if (this.txtPassword.Text != this.txtPassword1.Text)
        {
            ResponseMessage(this, "两次输入的密码不一致！");
            return;
          
        }

        //ADMIN admin = new ADMIN();
        //admin.ADMINNAME = ((LoginUser)Session["admin"]).ZH;
        //admin.PWD = this.txtPassword.Text;
        //if (admin.Update() <= 0)
        //{
        //    ResponseMessage(this.Page, "密码修改失败！");
        //    return;
        //}
        //else
        //{
        //    ResponseMessage(this.Page, "修改成功，重新登录即可生效！");
        //    return;
        //}

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}
