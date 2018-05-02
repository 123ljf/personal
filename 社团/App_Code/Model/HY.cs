using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Club.Model
{
    /// <summary>
    /// ʵ����T_HY ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class T_HY
    {
        public T_HY()
        { }
        #region Model
        private int _hyid;
        private string _hyxm;
        private bool _hyxb;
        private string _hyzy;
        private string _hybj;
        private string _hyss;
        private string _mobile;
        private int? _stbid;
        private string _zw;
        private int? _hf;
        private string _hyyear;
        private string _hyyue;
        private string _hyday;
        /// <summary>
        /// ��Ա���
        /// </summary>
        public int HYID
        {
            set { _hyid = value; }
            get { return _hyid; }
        }
        /// <summary>
        /// ��Ա����
        /// </summary>
        public string HYXM
        {
            set { _hyxm = value; }
            get { return _hyxm; }
        }
        /// <summary>
        /// ��Ա�Ա�
        /// </summary>
        public bool HYXB
        {
            set { _hyxb = value; }
            get { return _hyxb; }
        }
        /// <summary>
        /// רҵ
        /// </summary>
        public string HYZY
        {
            set { _hyzy = value; }
            get { return _hyzy; }
        }
        /// <summary>
        /// �༶
        /// </summary>
        public string HYBJ
        {
            set { _hybj = value; }
            get { return _hybj; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string HYSS
        {
            set { _hyss = value; }
            get { return _hyss; }
        }
        /// <summary>
        /// �ֻ�����
        /// </summary>
        public string MOBILE
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int? STBID
        {
            set { _stbid = value; }
            get { return _stbid; }
        }
        /// <summary>
        /// ְλ
        /// </summary>
        public string ZW
        {
            set { _zw = value; }
            get { return _zw; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public int? HF
        {
            set { _hf = value; }
            get { return _hf; }
        }
        /// <summary>
        /// ��
        /// </summary>
        public string HYYEAR
        {
            set { _hyyear = value; }
            get { return _hyyear; }
        }
        /// <summary>
        /// ��
        /// </summary>
        public string HYYUE
        {
            set { _hyyue = value; }
            get { return _hyyue; }
        }
        /// <summary>
        /// ��
        /// </summary>
        public string HYDAY
        {
            set { _hyday = value; }
            get { return _hyday; }
        }
        #endregion Model

        #region �Զ��巽��
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetListINFO(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT     s.STBMC, h.[HYID],h.[HYXM], case h.[HYXB] when '0' then '��' else 'Ů' end as HYXB,h.[HYZY],h.[HYBJ],h.[HYSS],h.[MOBILE],h.[STBID],h.[ZW],h.[HF] "+
                           " FROM   dbo.T_HY  h LEFT OUTER JOIN " +
                          " dbo.T_STB s ON s.STBID = h.STBID  where 1=1 "); 
            if (strWhere.Trim() != "")
            {
                strSql.Append( strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsBYname(string HYXM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_HY");
            strSql.Append(" where HYXM  like '%" + HYXM + "%' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }
        #endregion

        #region  ��Ա����

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int HYID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_HY");
            strSql.Append(" where HYID=" + HYID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Club.Model.T_HY model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.HYXM != null)
            {
                strSql1.Append("HYXM,");
                strSql2.Append("'" + model.HYXM + "',");
            }
            if (model.HYXB != null)
            {
                strSql1.Append("HYXB,");
                strSql2.Append("" + (model.HYXB ? 1 : 0) + ",");
            }
            if (model.HYZY != null)
            {
                strSql1.Append("HYZY,");
                strSql2.Append("'" + model.HYZY + "',");
            }
            if (model.HYBJ != null)
            {
                strSql1.Append("HYBJ,");
                strSql2.Append("'" + model.HYBJ + "',");
            }
            if (model.HYSS != null)
            {
                strSql1.Append("HYSS,");
                strSql2.Append("'" + model.HYSS + "',");
            }
            if (model.MOBILE != null)
            {
                strSql1.Append("MOBILE,");
                strSql2.Append("'" + model.MOBILE + "',");
            }
            if (model.STBID != null)
            {
                strSql1.Append("STBID,");
                strSql2.Append("" + model.STBID + ",");
            }
            if (model.ZW != null)
            {
                strSql1.Append("ZW,");
                strSql2.Append("'" + model.ZW + "',");
            }
            if (model.HF != null)
            {
                strSql1.Append("HF,");
                strSql2.Append("" + model.HF + ",");
            }
            if (model.HYYEAR != null)
            {
                strSql1.Append("HYYEAR,");
                strSql2.Append("'" + model.HYYEAR + "',");
            }
            if (model.HYYUE != null)
            {
                strSql1.Append("HYYUE,");
                strSql2.Append("'" + model.HYYUE + "',");
            }
            if (model.HYDAY != null)
            {
                strSql1.Append("HYDAY,");
                strSql2.Append("'" + model.HYDAY + "',");
            }
            strSql.Append("insert into T_HY(");
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
        public int Update(Club.Model.T_HY model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_HY set ");
            if (model.HYXM != null)
            {
                strSql.Append("HYXM='" + model.HYXM + "',");
            }
            if (model.HYXB != null)
            {
                strSql.Append("HYXB=" + (model.HYXB ? 1 : 0) + ",");
            }
            if (model.HYZY != null)
            {
                strSql.Append("HYZY='" + model.HYZY + "',");
            }
            if (model.HYBJ != null)
            {
                strSql.Append("HYBJ='" + model.HYBJ + "',");
            }
            if (model.HYSS != null)
            {
                strSql.Append("HYSS='" + model.HYSS + "',");
            }
            if (model.MOBILE != null)
            {
                strSql.Append("MOBILE='" + model.MOBILE + "',");
            }
            if (model.STBID != null)
            {
                strSql.Append("STBID=" + model.STBID + ",");
            }
            if (model.ZW != null)
            {
                strSql.Append("ZW='" + model.ZW + "',");
            }
            if (model.HF != null)
            {
                strSql.Append("HF=" + model.HF + ",");
            }
            if (model.HYYEAR != null)
            {
                strSql.Append("HYYEAR='" + model.HYYEAR + "',");
            }
            if (model.HYYUE != null)
            {
                strSql.Append("HYYUE='" + model.HYYUE + "',");
            }
            if (model.HYDAY != null)
            {
                strSql.Append("HYDAY='" + model.HYDAY + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where HYID=" + model.HYID + " ");
           return DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int HYID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_HY ");
            strSql.Append(" where HYID=" + HYID + " ");
           return  DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Club.Model.T_HY GetModel(int HYID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" HYID,HYXM,HYXB,HYZY,HYBJ,HYSS,MOBILE,STBID,ZW,HF,HYYEAR,HYYUE,HYDAY ");
            strSql.Append(" from T_HY ");
            strSql.Append(" where HYID=" + HYID + " ");
            Club.Model.T_HY model = new Club.Model.T_HY();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["HYID"].ToString() != "")
                {
                    model.HYID = int.Parse(ds.Tables[0].Rows[0]["HYID"].ToString());
                }
                model.HYXM = ds.Tables[0].Rows[0]["HYXM"].ToString();
                if (ds.Tables[0].Rows[0]["HYXB"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["HYXB"].ToString() == "1") || (ds.Tables[0].Rows[0]["HYXB"].ToString().ToLower() == "true"))
                    {
                        model.HYXB = true;
                    }
                    else
                    {
                        model.HYXB = false;
                    }
                }
                model.HYZY = ds.Tables[0].Rows[0]["HYZY"].ToString();
                model.HYBJ = ds.Tables[0].Rows[0]["HYBJ"].ToString();
                model.HYSS = ds.Tables[0].Rows[0]["HYSS"].ToString();
                model.MOBILE = ds.Tables[0].Rows[0]["MOBILE"].ToString();
                if (ds.Tables[0].Rows[0]["STBID"].ToString() != "")
                {
                    model.STBID = int.Parse(ds.Tables[0].Rows[0]["STBID"].ToString());
                }
                model.ZW = ds.Tables[0].Rows[0]["ZW"].ToString();
                if (ds.Tables[0].Rows[0]["HF"].ToString() != "")
                {
                    model.HF = int.Parse(ds.Tables[0].Rows[0]["HF"].ToString());
                }
                model.HYYEAR = ds.Tables[0].Rows[0]["HYYEAR"].ToString();
                model.HYYUE = ds.Tables[0].Rows[0]["HYYUE"].ToString();
                model.HYDAY = ds.Tables[0].Rows[0]["HYDAY"].ToString();
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
            strSql.Append("select HYID,HYXM,HYXB,HYZY,HYBJ,HYSS,MOBILE,STBID,ZW,HF,HYYEAR,HYYUE,HYDAY ");
            strSql.Append(" FROM T_HY where 1=1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append( strWhere);
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
            strSql.Append(" HYID,HYXM,HYXB,HYZY,HYBJ,HYSS,MOBILE,STBID,ZW,HF,HYYEAR,HYYUE,HYDAY ");
            strSql.Append(" FROM T_HY ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion
    }
}

