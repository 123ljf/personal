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
using System.Text.RegularExpressions;

/// <summary>
///PageBase 的摘要说明
/// </summary>
public class PageBase : Page
{
    public PageBase()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    #region 窗口的弹出
    /// <summary>
    /// 打开窗口
    /// 修改目的:	新开页面去掉ie的菜单。。。						*/
    /// </summary>
    /// <param name="url"></param>
    public static void OpenWebForm(string url)
    {
        HttpContext.Current.Response.Redirect(url);
    }





    #endregion

    #region 消息提示
    /// <summary>
    /// 弹出JavaScript小窗口
    /// </summary>
    /// <param name="js">窗口信息</param>
    public static void Alert(string message)
    {
        message = DeleteUnVisibleChar(message);
        string js = @"<Script language='JavaScript'>
                    alert('" + message + "');</Script>";
        HttpContext.Current.Response.Write(js);
    }

    /// <summary>
    /// 显示错误信息 
    /// </summary>
    /// <param name="page">页面</param>
    /// <param name="strMessage">信息</param>
    public static void ResponseMessage(System.Web.UI.Page page, string strMessage)
    {

        strMessage = strMessage.Replace("'", "").Replace("\"", "").Replace("\r\n", "");
        page.ClientScript.RegisterStartupScript(page.GetType(), "ErrorMessage", "<script language='javascript' defer>window.alert('" + strMessage + "');</script>");

    }

    /// <summary>
    /// 显示错误信息 
    /// </summary>
    /// <param name="page">页面</param>
    /// <param name="strMessage">信息</param>
    public static void ResponseMessageToUrl(System.Web.UI.Page page, string strMessage, string toUrl)
    {

        strMessage = strMessage.Replace("'", "").Replace("\"", "").Replace("\r\n", "");
        page.ClientScript.RegisterStartupScript(page.GetType(), "ErrorMessage", "<script language='javascript' defer>window.alert('" + strMessage + "');window.location.href='" + toUrl + "' </script>");

    }

    #endregion

    #region 工具
    /// <summary>
    /// 删除不可见字符
    /// </summary>
    /// <param name="sourceString"></param>
    /// <returns></returns>
    public static string DeleteUnVisibleChar(string sourceString)
    {
        System.Text.StringBuilder sBuilder = new System.Text.StringBuilder(131);
        for (int i = 0; i < sourceString.Length; i++)
        {
            int Unicode = sourceString[i];
            if (Unicode >= 16)
            {
                sBuilder.Append(sourceString[i].ToString());
            }
        }
        return sBuilder.ToString();
    }

    /// <summary>
    /// 星期转换
    /// </summary>
    /// <param name="week"></param>
    /// <returns></returns>
    public static string GetWeedNumber(string week)
    {
        string weeknumber = string.Empty;
        switch (week)
        {
            case "Monday":
                weeknumber = "一";
                break;
            case "Tuesday":
                weeknumber = "二";
                break;
            case "Wednesday":
                weeknumber = "三";
                break;
            case "Thursday":
                weeknumber = "四";
                break;
            case "Friday":
                weeknumber = "五";
                break;
            case "Saturday":
                weeknumber = "六";
                break;
            case "Sunday":
                weeknumber = "日";
                break;

        }
        return weeknumber;
    }

    public void DownUrl(string strUrl)
    {
        string path = strUrl;
        string name = "FileName";
        System.IO.FileInfo file = new System.IO.FileInfo(path);
        if (file.Exists)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(System.Text.UTF8Encoding.UTF8.GetBytes(name)));
            Response.AddHeader("Content-Length", file.Length.ToString());

            Response.ContentType = "application/octet-stream";
            Response.Filter.Close();

            Response.WriteFile(file.FullName);
            Response.End();
        }
        else
        {
            ResponseMessage(this, "文件不存在！");
        }
    }
    #endregion

    /// </value>>
    /// 用户信息
    /// </value>>
    public LoginUser UserInfo
    {
        get
        {
            try
            {
                return (LoginUser)Session["LoginUser"];

            }
            catch
            {
                return (null);
            }
        }
        set
        {
            if (null == value)
            {
                Session.Remove("LoginUser");

            }
            else
            {

                Session["LoginUser"] = value;
            }
        }
    }



    #region 常用验证

    /// 
    /// 判断字符串是否与指定正则表达式匹配
    /// 
    /// 要验证的字符串
    /// 正则表达式
    /// 验证通过返回true
    public static bool IsMatch(string input, string regularExp)
    {
        return Regex.IsMatch(input, regularExp);
    }
    /// 
    /// 验证非负整数（正整数 + 0）
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsUnMinusInt(string input)
    {
        return Regex.IsMatch(input, RegularExp.UnMinusInteger);
    }
    /// 
    /// 验证正整数
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsPlusInt(string input)
    {
        return Regex.IsMatch(input, RegularExp.PlusInteger);
    }
    /// 
    /// 验证非正整数（负整数 + 0） 
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsUnPlusInt(string input)
    {
        return Regex.IsMatch(input, RegularExp.UnPlusInteger);
    }
    /// 
    /// 验证负整数
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsMinusInt(string input)
    {
        return Regex.IsMatch(input, RegularExp.MinusInteger);
    }
    /// 
    /// 验证整数
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsInt(string input)
    {
        return Regex.IsMatch(input, RegularExp.Integer);
    }
    /// 
    /// 验证非负浮点数（正浮点数 + 0）
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsUnMinusFloat(string input)
    {
        return Regex.IsMatch(input, RegularExp.UnMinusFloat);
    }
    /// 
    /// 验证正浮点数
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsPlusFloat(string input)
    {
        return Regex.IsMatch(input, RegularExp.PlusFloat);
    }
    /// 
    /// 验证非正浮点数（负浮点数 + 0）
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsUnPlusFloat(string input)
    {
        return Regex.IsMatch(input, RegularExp.UnPlusFloat);
    }
    /// 
    /// 验证负浮点数
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsMinusFloat(string input)
    {
        return Regex.IsMatch(input, RegularExp.MinusFloat);
    }
    /// 
    /// 验证浮点数
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsFloat(string input)
    {
        return Regex.IsMatch(input, RegularExp.Float);
    }
    /// 
    /// 验证由26个英文字母组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsLetter(string input)
    {
        return Regex.IsMatch(input, RegularExp.Letter);
    }
    /// 
    /// 验证由中文组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsChinese(string input)
    {
        return Regex.IsMatch(input, RegularExp.Chinese);
    }
    /// 
    /// 验证由26个英文字母的大写组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsUpperLetter(string input)
    {
        return Regex.IsMatch(input, RegularExp.UpperLetter);
    }
    /// 
    /// 验证由26个英文字母的小写组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsLowerLetter(string input)
    {
        return Regex.IsMatch(input, RegularExp.LowerLetter);
    }
    /// 
    /// 验证由数字和26个英文字母组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsNumericOrLetter(string input)
    {
        return Regex.IsMatch(input, RegularExp.NumericOrLetter);
    }
    /// 
    /// 验证由数字组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsNumeric(string input)
    {
        return Regex.IsMatch(input, RegularExp.Numeric);
    }
    /// 
    /// 验证由数字和26个英文字母或中文组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsNumericOrLetterOrChinese(string input)
    {
        return Regex.IsMatch(input, RegularExp.NumbericOrLetterOrChinese);
    }
    /// 
    /// 验证由数字、26个英文字母或者下划线组成的字符串
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsNumericOrLetterOrUnderline(string input)
    {
        return Regex.IsMatch(input, RegularExp.NumericOrLetterOrUnderline);
    }
    /// 
    /// 验证email地址
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsEmail(string input)
    {
        return Regex.IsMatch(input, RegularExp.Email);
    }
    /// 
    /// 验证URL
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsUrl(string input)
    {
        return Regex.IsMatch(input, RegularExp.Url);
    }
    /// 
    /// 验证电话号码
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsTelephone(string input)
    {
        return Regex.IsMatch(input, RegularExp.Telephone);
    }
    /// 
    /// 验证手机号码
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsMobile(string input)
    {
        return Regex.IsMatch(input, RegularExp.Mobile);
    }
    /// 
    /// 通过文件扩展名验证图像格式
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsImageFormat(string input)
    {
        return Regex.IsMatch(input, RegularExp.ImageFormat);
    }
    /// 
    /// 验证IP
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsIP(string input)
    {
        return Regex.IsMatch(input, RegularExp.IP);
    }
    /// 
    /// 验证日期（YYYY-MM-DD）
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsDate(string input)
    {
        return Regex.IsMatch(input, RegularExp.Date);
    }
    /// 
    /// 验证日期和时间（YYYY-MM-DD HH:MM:SS）
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsDateTime(string input)
    {
        return Regex.IsMatch(input, RegularExp.DateTime);
    }
    /// 
    /// 验证颜色（#ff0000）
    /// 
    /// 要验证的字符串
    /// 验证通过返回true
    public static bool IsColor(string input)
    {
        return Regex.IsMatch(input, RegularExp.Color);
    }





    public struct RegularExp
    {
        public const string Chinese = @"^[\u4E00-\u9FA5\uF900-\uFA2D]+$";
        public const string Color = "^#[a-fA-F0-9]{6}";
        public const string Date = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$";
        public const string DateTime = @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d$";
        public const string Email = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
        public const string Float = @"^(-?\d+)(\.\d+)?$";
        public const string ImageFormat = @"\.(?i:jpg|bmp|gif|ico|pcx|jpeg|tif|png|raw|tga)$";
        public const string Integer = @"^-?\d+$";
        public const string IP = @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$";
        public const string Letter = "^[A-Za-z]+$";
        public const string LowerLetter = "^[a-z]+$";
        public const string MinusFloat = @"^(-(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*)))$";
        public const string MinusInteger = "^-[0-9]*[1-9][0-9]*$";
        public const string Mobile = "^0{0,1}13[0-9]{9}$";
        public const string NumbericOrLetterOrChinese = @"^[A-Za-z0-9\u4E00-\u9FA5\uF900-\uFA2D]+$";
        public const string Numeric = "^[0-9]+$";
        public const string NumericOrLetter = "^[A-Za-z0-9]+$";
        public const string NumericOrLetterOrUnderline = @"^\w+$";
        public const string PlusFloat = @"^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$";
        public const string PlusInteger = "^[0-9]*[1-9][0-9]*$";
        public const string Telephone = @"(\d+-)?(\d{4}-?\d{7}|\d{3}-?\d{8}|^\d{7,8})(-\d+)?";
        public const string UnMinusFloat = @"^\d+(\.\d+)?$";
        public const string UnMinusInteger = @"\d+$";
        public const string UnPlusFloat = @"^((-\d+(\.\d+)?)|(0+(\.0+)?))$";
        public const string UnPlusInteger = @"^((-\d+)|(0+))$";
        public const string UpperLetter = "^[A-Z]+$";
        public const string Url = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
    }
    #endregion



}
 
