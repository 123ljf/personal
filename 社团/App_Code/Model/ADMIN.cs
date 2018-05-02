using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Club.Model
{
    /// <summary>
    /// ʵ����T_ADMIN ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class T_ADMIN
    {
        public T_ADMIN()
        { }
        #region Model
        private int _adminid;
        private string _adminzh;
        private string _adminmm;
        /// <summary>
        /// ����Ա���
        /// </summary>
        public int ADMINID
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// ����Ա�˻�
        /// </summary>
        public string ADMINZH
        {
            set { _adminzh = value; }
            get { return _adminzh; }
        }
        /// <summary>
        /// ����Ա����
        /// </summary>
        public string ADMINMM
        {
            set { _adminmm = value; }
            get { return _adminmm; }
        }
        #endregion Model

        #region �Զ��庯��

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Club.Model.T_ADMIN GetModelByName(string ADMINZH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ADMINID,ADMINZH,ADMINMM ");
            strSql.Append(" from T_ADMIN ");
            strSql.Append(" where ADMINZH like '%" + ADMINZH + "%' ");
            Club.Model.T_ADMIN model = new Club.Model.T_ADMIN();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ADMINID"].ToString() != "")
                {
                    model.ADMINID = int.Parse(ds.Tables[0].Rows[0]["ADMINID"].ToString());
                }
                model.ADMINZH = ds.Tables[0].Rows[0]["ADMINZH"].ToString();
                model.ADMINMM = ds.Tables[0].Rows[0]["ADMINMM"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region  ��Ա����

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ADMINID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_ADMIN");
            strSql.Append(" where ADMINID=" + ADMINID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Club.Model.T_ADMIN model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.ADMINZH != null)
            {
                strSql1.Append("ADMINZH,");
                strSql2.Append("'" + model.ADMINZH + "',");
            }
            if (model.ADMINMM != null)
            {
                strSql1.Append("ADMINMM,");
                strSql2.Append("'" + model.ADMINMM + "',");
            }
            strSql.Append("insert into T_ADMIN(");
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
        /// ����һ������
        /// </summary>
        public void Update(Club.Model.T_ADMIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_ADMIN set ");
            if (model.ADMINZH != null)
            {
                strSql.Append("ADMINZH='" + model.ADMINZH + "',");
            }
            if (model.ADMINMM != null)
            {
                strSql.Append("ADMINMM='" + model.ADMINMM + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where ADMINID=" + model.ADMINID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int ADMINID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_ADMIN ");
            strSql.Append(" where ADMINID=" + ADMINID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Club.Model.T_ADMIN GetModel(int ADMINID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" ADMINID,ADMINZH,ADMINMM ");
            strSql.Append(" from T_ADMIN ");
            strSql.Append(" where ADMINID=" + ADMINID + " ");
            Club.Model.T_ADMIN model = new Club.Model.T_ADMIN();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ADMINID"].ToString() != "")
                {
                    model.ADMINID = int.Parse(ds.Tables[0].Rows[0]["ADMINID"].ToString());
                }
                model.ADMINZH = ds.Tables[0].Rows[0]["ADMINZH"].ToString();
                model.ADMINMM = ds.Tables[0].Rows[0]["ADMINMM"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ADMINID,ADMINZH,ADMINMM ");
            strSql.Append(" FROM T_ADMIN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ADMINID,ADMINZH,ADMINMM ");
            strSql.Append(" FROM T_ADMIN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

       

        #endregion  ��Ա����

    }
}

