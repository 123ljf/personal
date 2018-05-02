using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Club.Model
{
    /// <summary>
    /// 实体类T_STB 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class T_STB
    {
        public T_STB()
        { }
        #region Model
        private int _stbid;
        private string _stbmc;
        private int? _bzid;
        private int? _cyrs;
        private string _mobile;
        private string _stzn;
        private string _bz;
        private int? _stf;
        /// <summary>
        /// 社团部编号
        /// </summary>
        public int STBID
        {
            set { _stbid = value; }
            get { return _stbid; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string STBMC
        {
            set { _stbmc = value; }
            get { return _stbmc; }
        }
        /// <summary>
        /// 部长
        /// </summary>
        public int? BZID
        {
            set { _bzid = value; }
            get { return _bzid; }
        }
        /// <summary>
        /// 社团人数
        /// </summary>
        public int? CYRS
        {
            set { _cyrs = value; }
            get { return _cyrs; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string MOBILE
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 社团职责
        /// </summary>
        public string STZN
        {
            set { _stzn = value; }
            get { return _stzn; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string BZ
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 会费
        /// </summary>
        public int? STF
        {
            set { _stf = value; }
            get { return _stf; }
        }
        #endregion Model

        #region 自定义成员方法
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListINFO(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT     dbo.T_STB.*, dbo.T_HY.HYXM   FROM         dbo.T_STB LEFT OUTER JOIN "+
                          " dbo.T_HY ON dbo.T_STB.bzid = dbo.T_HY.hyid  where 1=1 "); 
            if (strWhere.Trim() != "")
            {
                strSql.Append(  strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsBYNAME(string STBMC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_STB");
            strSql.Append(" where STBMC like '%" + STBMC + "%' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }
        #endregion
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int STBID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_STB");
            strSql.Append(" where STBID=" + STBID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Club.Model.T_STB model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.STBMC != null)
            {
                strSql1.Append("STBMC,");
                strSql2.Append("'" + model.STBMC + "',");
            }
            if (model.BZID != null)
            {
                strSql1.Append("BZID,");
                strSql2.Append("" + model.BZID + ",");
            }
            if (model.CYRS != null)
            {
                strSql1.Append("CYRS,");
                strSql2.Append("" + model.CYRS + ",");
            }
            if (model.MOBILE != null)
            {
                strSql1.Append("MOBILE,");
                strSql2.Append("'" + model.MOBILE + "',");
            }
            if (model.STZN != null)
            {
                strSql1.Append("STZN,");
                strSql2.Append("'" + model.STZN + "',");
            }
            if (model.BZ != null)
            {
                strSql1.Append("BZ,");
                strSql2.Append("'" + model.BZ + "',");
            }
            if (model.STF != null)
            {
                strSql1.Append("STF,");
                strSql2.Append("" + model.STF + ",");
            }
            strSql.Append("insert into T_STB(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Club.Model.T_STB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_STB set ");
            if (model.STBMC != null)
            {
                strSql.Append("STBMC='" + model.STBMC + "',");
            }
            if (model.BZID != null)
            {
                strSql.Append("BZID=" + model.BZID + ",");
            }
            if (model.CYRS != null)
            {
                strSql.Append("CYRS=" + model.CYRS + ",");
            }
            if (model.MOBILE != null)
            {
                strSql.Append("MOBILE='" + model.MOBILE + "',");
            }
            if (model.STZN != null)
            {
                strSql.Append("STZN='" + model.STZN + "',");
            }
            if (model.BZ != null)
            {
                strSql.Append("BZ='" + model.BZ + "',");
            }
            if (model.STF != null)
            {
                strSql.Append("STF=" + model.STF + ",");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where STBID=" + model.STBID + " ");
            return DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int STBID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_STB ");
            strSql.Append(" where STBID=" + STBID + " ");
           return  DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Club.Model.T_STB GetModel(int STBID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" STBID,STBMC,BZID,CYRS,MOBILE,STZN,BZ,STF ");
            strSql.Append(" from T_STB ");
            strSql.Append(" where STBID=" + STBID + " ");
            Club.Model.T_STB model = new Club.Model.T_STB();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["STBID"].ToString() != "")
                {
                    model.STBID = int.Parse(ds.Tables[0].Rows[0]["STBID"].ToString());
                }
                model.STBMC = ds.Tables[0].Rows[0]["STBMC"].ToString();
                if (ds.Tables[0].Rows[0]["BZID"].ToString() != "")
                {
                    model.BZID = int.Parse(ds.Tables[0].Rows[0]["BZID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CYRS"].ToString() != "")
                {
                    model.CYRS = int.Parse(ds.Tables[0].Rows[0]["CYRS"].ToString());
                }
                model.MOBILE = ds.Tables[0].Rows[0]["MOBILE"].ToString();
                model.STZN = ds.Tables[0].Rows[0]["STZN"].ToString();
                model.BZ = ds.Tables[0].Rows[0]["BZ"].ToString();
                if (ds.Tables[0].Rows[0]["STF"].ToString() != "")
                {
                    model.STF = int.Parse(ds.Tables[0].Rows[0]["STF"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select STBID,STBMC,BZID,CYRS,MOBILE,STZN,BZ,STF ");
            strSql.Append(" FROM T_STB ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" STBID,STBMC,BZID,CYRS,MOBILE,STZN,BZ,STF ");
            strSql.Append(" FROM T_STB ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法

    }
}

