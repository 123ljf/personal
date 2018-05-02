using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
 

/// <summary>
///LoginUser 的摘要说明
/// </summary>
public class LoginUser
{
	public LoginUser()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 私有字段
    /// </summary> 
    private int _id;
    private string _ZH;
    private string _RealName;
    private string _Password;
    private int _JsId;
    private string _JsName;
    private string _Lx;

    /// <summary>
    /// 用户编号	  		
    /// </summary> 
    public int ID
    {
        get { return _id; }
        set { _id = value; }

    }

    /// <summary>
    /// 用户名	  		
    /// </summary> 
    public string JSNAME
    {
        get { return _JsName; }
        set { _JsName = value; }


    }
    /// <summary>
    /// 账户
    /// </summary>
    public string ZH
    {
        get { return _ZH; }
        set { _ZH = value; }
    }
    /// <summary>
    /// 角色	  		
    /// </summary> 
    public int JSID
    {
        get { return _JsId; }
        set { _JsId = value; }

    }

    /// <summary>
    /// 用户名称	  		
    /// </summary> 
    public string RealName
    {
        get { return _RealName; }
        set { _RealName = value; }


    }
    /// <summary>
    /// 类型	  		
    /// </summary> 
    public string LX
    {
        get { return _Lx; }
        set { _Lx = value; }

    }
    /// <summary>
    /// 密码	  		
    /// </summary> 
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }

    }

    
  
}
