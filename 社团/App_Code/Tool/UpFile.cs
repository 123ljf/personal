using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
 
 
/// <summary>
/// UpFile 的摘要说明  
/// </summary>

public class UpFile : System.Web.UI.Page
{
    /// <summary>
    /// 上传附件
    /// </summary>
    /// <param name="FileUpload"></param>
    /// <param name="tableName"></param>
    /// <param name="Id"></param>
    /// <returns></returns>
    public static string SaveAnnex(System.Web.UI.WebControls.FileUpload FileUpload, string tableName, string Id)
    {

        if (((System.Web.UI.WebControls.FileUpload)FileUpload).HasFile)
        {
            //判断是否允许上传类型
            string FileExt = System.IO.Path.GetExtension(FileUpload.FileName);
            FileExt = FileExt.ToLower();
            if (FileExt.Length < 1)
            {
                return "";
            }
            string FileType = System.Configuration.ConfigurationManager.AppSettings["FileType1"];

            if (FileType.IndexOf(FileExt) == -1)
            {
               
                return FileUpload.PostedFile.FileName + "  该文件类型不支持上传！";
            }

            //判断文件大小是否可以上传
            string strFileSize = System.Configuration.ConfigurationManager.AppSettings["FileSize1"];
            int FileSize = FileUpload.PostedFile.ContentLength;
            if (FileSize > int.Parse(strFileSize))
            {
                
                return "文件太大，不允许上传！";
            }

            //计算出文件名 为时间的年月日时分秒+3位的随机数 
            Random rand = new Random();
            DateTime time = new DateTime();

            string filename = time.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond.ToString() + rand.Next(999).ToString() + FileUpload.ID.Substring(4, 1);

            //上传文件
            string strpath = System.Configuration.ConfigurationManager.AppSettings["FileSavePath"] + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MM") + "\\" + filename + FileExt;
            FileUpload.SaveAs(strpath);

        }

        return "";
    }

    /// <summary>
    ///  功能：根据消息ID，返回附件保存路径 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="table"></param>
    /// <returns></returns>
    public static DataTable GetMsgAnnex(string id)
    {
        DataTable dt = new DataTable();

        string strSql = "SELECT * FROM BUGXX WHERE  BUGID=" + id + "";
        DataSet ds = DbHelperSQL.Query(strSql.ToString());
        if (ds != null && ds.Tables.Count > 0)
        {
            dt = ds.Tables[0];
        }
        return dt;
    }
}

