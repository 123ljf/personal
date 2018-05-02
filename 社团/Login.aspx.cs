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
using Club.Model;

/// <summary>
/// 登录页面
/// </summary>
public partial class login :PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    { 
    }

    /// <summary>
    /// 登录功能
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void IbtDL_Click(object sender, ImageClickEventArgs e)
    {

        LoginUser dlUser = new LoginUser();
      

        //校验
        if (this.txtUser.Text == "")
        {
            Alert("账户不能为空!"); 
            return;
        }
        if (this.txtPwd.Text == "")
        {
           Alert("密码不能为空！");
            return;
        }
        if (this.dlType.SelectedValue.Trim() == "管理")
        {
            T_ADMIN model = new T_ADMIN();
            model = model.GetModelByName(this.txtUser.Text);
            if (model == null)
            {
                ResponseMessage(this, "账户不存在！");
                return;
            }

            if (model.ADMINMM != txtPwd.Text)
            {
                ResponseMessage(this, "密码错误，请查证后重新输入！");
                return;
 
            }

            dlUser.JSID = 1;
            dlUser.JSNAME = "超级管理员";
            dlUser.Password = txtPwd.Text;
            dlUser.ZH = txtUser.Text;
            dlUser.ID = model.ADMINID;
            dlUser.RealName = "超级管理员";
           
                 
        }
        else if (dlType.SelectedValue.Trim() == "用户")
        {
            T_YH model = new T_YH();
            model = model.GetModelByName(txtUser.Text);
            if (model == null)
            {
                ResponseMessage(this, "账户不存在！");
                return;

            }

            if (model.DLMM != txtPwd.Text)
            {
                ResponseMessage(this, "密码错误，请查证后重新输入！");
                return;

            }

            dlUser.JSID = 2;
            dlUser.JSNAME = "用户";
            dlUser.Password = txtPwd.Text;
            dlUser.ZH = txtUser.Text;
            dlUser.ID = model.YHID;
            dlUser.RealName = model.YHMC;
        }
        else
        {
            ResponseMessage(this, "登录类型错误！");
            return;
 
        }


        
        Session["LoginUser"] = dlUser;

        Response.Redirect("index.aspx");

        
    }
}
