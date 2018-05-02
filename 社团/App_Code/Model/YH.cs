using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Club.Model
{
    /// <summary>
    /// ʵ����T_YH ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class T_YH
    {
        public T_YH()
        { }
        #region Model
        private int _yhid;
        private string _dlzh;
        private string _yhmc;
        private string _dlmm;
        /// <summary>
        /// �û����
        /// </summary>
        public int YHID
        {
            set { _yhid = value; }
            get { return _yhid; }
        }
        /// <summary>
        /// ��¼�˻�
        /// </summary>
        public string DLZH
        {
            set { _dlzh = value; }
            get { return _dlzh; }
        }
        /// <summary>
        /// �û�����
        /// </summary>
        public string YHMC
        {
            set { _yhmc = value; }
            get { return _yhmc; }
        }
        /// <summary>
        ///  ��¼����
        /// </summary>
        public string DLMM
        {
            set { _dlmm = value; }
            get { return _dlmm; }
        }
        #endregion Model

        #region �Զ��巽��

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Club.Model.T_YH GetModelByName(string DLZH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" YHID,DLZH,YHMC,DLMM ");
            strSql.Append(" from T_YH ");
            strSql.Append(" where DLZH like '%" + DLZH + "%' ");
            Club.Model.T_YH model = new Club.Model.T_YH();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["YHID"].ToString() != "")
                {
                    model.YHID = int.Parse(ds.Tables[0].Rows[0]["YHID"].ToString());
                }
                model.DLZH = ds.Tables[0].Rows[0]["DLZH"].ToString();
                model.YHMC = ds.Tables[0].Rows[0]["YHMC"].ToString();
                model.DLMM = ds.Tables[0].Rows[0]["DLMM"].ToString();
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
        public bool Exists(int YHID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_YH");
            strSql.Append(" where YHID=" + YHID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Club.Model.T_YH model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.DLZH != null)
            {
                strSql1.Append("DLZH,");
                strSql2.Append("'" + model.DLZH + "',");
            }
            if (model.YHMC != null)
            {
                strSql1.Append("YHMC,");
                strSql2.Append("'" + model.YHMC + "',");
            }
            if (model.DLMM != null)
            {
                strSql1.Append("DLMM,");
                strSql2.Append("'" + model.DLMM + "',");
            }
            strSql.Append("insert into T_YH(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Update(Club.Model.T_YH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_YH set ");
            if (model.DLZH != null)
            {
                strSql.Append("DLZH='" + model.DLZH + "',");
            }
            if (model.YHMC != null)
            {
                strSql.Append("YHMC='" + model.YHMC + "',");
            }
            if (model.DLMM != null)
            {
                strSql.Append("DLMM='" + model.DLMM + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where YHID=" + model.YHID + " ");
           return DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int YHID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_YH ");
            strSql.Append(" where YHID=" + YHID + " ");
           return DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Club.Model.T_YH GetModel(int YHID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" YHID,DLZH,YHMC,DLMM ");
            strSql.Append(" from T_YH ");
            strSql.Append(" where YHID=" + YHID + " ");
            Club.Model.T_YH model = new Club.Model.T_YH();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["YHID"].ToString() != "")
                {
                    model.YHID = int.Parse(ds.Tables[0].Rows[0]["YHID"].ToString());
                }
                model.DLZH = ds.Tables[0].Rows[0]["DLZH"].ToString();
                model.YHMC = ds.Tables[0].Rows[0]["YHMC"].ToString();
                model.DLMM = ds.Tables[0].Rows[0]["DLMM"].ToString();
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
            strSql.Append("select YHID,DLZH,YHMC,DLMM ");
            strSql.Append(" FROM T_YH  where 1=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(  strWhere);
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
            strSql.Append(" YHID,DLZH,YHMC,DLMM ");
            strSql.Append(" FROM T_YH ");
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

