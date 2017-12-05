using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace tsy_ws
{
    /// <summary>
    /// Summary description for SZZCBWebService
    /// </summary>
    [WebService(Namespace = "http://www.crfsdi.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SZZCBWebService : System.Web.Services.WebService
    {
        #region 通用
        [WebMethod(Description = @" <br /><b>Description: 通用-应答</b><br />
                                    <br />@return 返回""Hello""")]
        public string Mobile_App_Hello()
        {
            return "";
        }

        [WebMethod(Description = @" <br /><b>Description: 通用-最新版本号</b><br />
                                    <br />@param[type] 0=Android, 1=iOS<br />
                                    <br />@return 返回版本号，查询iOS版本时返回""-1""")]
        public string Mobile_App_Version(int type)
        {
            return "-1";
        }

        [WebMethod(Description = @" <br /><b>Description: 通用-系统崩溃日志</b><br />
                                    <br />@param[info] 崩溃信息<br />
                                    <br />@param[ryid] 人事编码<br />
                                    <br />@param[version] 版本号<br />
                                    <br />@param[wParam] 保留参数<br />
                                    <br />@param[lParam] 保留参数<br />
                                    <br />@return<br />")]
        public void Mobile_App_Crash(string info, string ryid, string version, string wParam, string lParam)
        {
        }
        #endregion


        #region 人员管理
        [WebMethod(Description = @" <br /><b>Description: 人员-登录</b><br />
                                    <br />@param[ryid] 人事代码<br />
                                    <br />@param[pass] 密码<br />
                                    <br />@return 失败返回空, 成功返回人员姓名<br />")]
        public string Mobile_Member_Login(string ryid, string pass)
        {
            return "某某某";
        }
        #endregion

        #region 多媒体管理
        [WebMethod(Description = @" <br /><b>Description: 多媒体-历史视频</b><br />
                                    <br />@param[ryid] 人事代码<br />
                                    <br />@param[filter] 查询条件，留空查询所有<br />
                                    <br />@param[pageIndex] 当前页数<br />
                                    <br />@param[pageSize] 每页条数<br />
                                    <br />@return { ""ID"":""历史记录ID"",
                                                    ""TITLE"":""标题"",
                                                    ""LINK"":""视频链接地址"",
                                                    ""TIME"":""视频时间"" }<br />")]
        public string Mobile_Multimedia_History_List(string ryid, string filter, int pageIndex, int pageSize)
        {
            return "[{\"ID\":\"2014091500001\",\"TITLE\":\"某某视频\",\"LINK\":\"http://ip/test.mp4\",\"TIME\":\"2014-09-15\"}]";
        }

        [WebMethod(Description = @" <br /><b>Description: 多媒体-FTP信息</b><br />
                                    <br />@param[ryid] 人事编码<br />
                                    <br />@return { ""HOST"":""主机IP"",
                                                    ""PORT"":""端口号"",
                                                    ""USER"":""用户名"",
                                                    ""PASS"":""密码"",
                                                    ""PATH"":""远程文件夹"",
                                                    ""NAME"":""服务器生成的GUID""}<br />")]
        public string Mobile_Multimedia_Ftp(string ryid)
        {
            return "[{\"HOST\":\"192.10.27.56\",\"PORT\":\"21\",\"USER\":\"SZZCB\",\"PASS\":\"SZZCB\",\"PATH\":\"/Mobile/\",\"NAME\":\"4bbd36e0-4b6e-4d2a-a19d-df0e712de050\"}]";
        }

        [WebMethod(Description = @" <br /><b>Description: 多媒体-上传后记录</b><br />
                                    <br />@param[title] 标题<br />
                                    <br />@param[key] 关键字<br />
                                    <br />@param[ryid] 人事编码<br />
                                    <br />@param[fileGUID] 从'FTP信息'中获取的GUID<br />
                                    <br />@param[fileExt] 文件后缀，不含'.'<br />
                                    <br />@param[fileSize] 文件长度<br />                                    
                                    <br />@param[wParam] 保留参数<br />
                                    <br />@param[lParam] 保留参数<br />
                                    <br />@return 成功返回""1""，失败返回""0""<br />")]
        public string Mobile_Multimedia_Uploaded(string title, string key, string ryid, string fileGUID, string fileExt, string fileSize, string wParam, string lParam)
        {
            return "1";
        }
        #endregion

        #region 请假管理
        [WebMethod(Description = @" <br /><b>Description: 请假-获取请假类型</b><br />
                                    <br />@return { ""ID"":""请假类型ID"",
                                                    ""PARENT"":""0为出差，1为请假"",
                                                    ""TITLE"":""标题"" }<br />")]
        public string Mobile_Leave_Type_List()
        {
            return "[{\"ID\":\"0\",\"PARENT\":\"0\",\"TITLE\":\"出差\"},{\"ID\":\"1\",\"PARENT\":\"0\",\"TITLE\":\"派遣\"},{\"ID\":\"2\",\"PARENT\":\"1\",\"TITLE\":\"年休假\"},{\"ID\":\"3\",\"PARENT\":\"1\",\"TITLE\":\"探亲假\"},{\"ID\":\"4\",\"PARENT\":\"1\",\"TITLE\":\"事假\"},{\"ID\":\"5\",\"PARENT\":\"1\",\"TITLE\":\"病假\"},{\"ID\":\"6\",\"PARENT\":\"1\",\"TITLE\":\"丧假\"},{\"ID\":\"7\",\"PARENT\":\"1\",\"TITLE\":\"婚假\"},{\"ID\":\"8\",\"PARENT\":\"1\",\"TITLE\":\"产假\"},{\"ID\":\"9\",\"PARENT\":\"1\",\"TITLE\":\"护理假\"},{\"ID\":\"10\",\"PARENT\":\"1\",\"TITLE\":\"哺乳假\"},{\"ID\":\"11\",\"PARENT\":\"1\",\"TITLE\":\"计划生育假\"},{\"ID\":\"12\",\"PARENT\":\"1\",\"TITLE\":\"少数民族节日\"},{\"ID\":\"13\",\"PARENT\":\"1\",\"TITLE\":\"零星假\"}]";
        }

        [WebMethod(Description = @" <br /><b>Description: 请假-提交请假申请</b><br />
                                    <br />@param[title] 请假标题<br />
                                    <br />@param[typeId] 从'请假-获取请假类型'中获取<br />
                                    <br />@param[startTime] 开始时间<br />
                                    <br />@param[endTime] 结束时间<br />
                                    <br />@param[reason] 请假事由<br />
                                    <br />@param[substitute] 替代人<br />
                                    <br />@param[ryid] 人事编码<br />
                                    <br />@param[pass] 人员密码<br />
                                    <br />@param[version] 客户端版本，iOS如""iOS 1.01""，Android如""Android 1.01""<br />
                                    <br />@param[wParam] 保留参数<br />
                                    <br />@param[lParam] 保留参数<br />
                                    <br />@return 成功返回""1""，失败返回""0""<br />")]
        public string Mobile_Leave_Submit(string title, string typeId, string startTime, string endTime, string reason, string substitute, string ryid, string pass, string version, string wParam, string lParam)
        {
            return "1";
        }
        #endregion

        #region 其他
        [WebMethod(Description = @" <br /><b>Description: 其他-通讯录</b><br />
                                    <br />@param[ryid] 人事编码<br />
                                    <br />@param[filter] 查询条件，留空查询所有<br />
                                    <br />@param[pageIndex] 当前页数<br />
                                    <br />@param[pageSize] 每页条数<br />
                                    <br />@return { ""RYID"":""人事编码"",
                                                    ""NAME"":""姓名"",
                                                    ""PHONE"":""办公电话号码"",
                                                    ""MOBILE"":""手机电话号码"",
                                                    ""PDWMC"":""父单位名称"",
                                                    ""DWMC"":""单位名称"" }<br />")]
        public string Mobile_Other_Txl_List(string ryid, string filter, int pageIndex, int pageSize)
        {
            return "[{\"RYID\":\"000001\",\"NAME\":\"某某\",\"PHONE\":\"54321\",\"MOBILE\":\"15912345678\",\"PDWMC\":\"某某项目部\",\"DWMC\":\"经理\"},{\"RYID\":\"000002\",\"NAME\":\"某某\", \"PHONE\":\"12345\",\"MOBILE\":\"15987654321\",\"PDWMC\":\"安徽省综合交通研究院股份有限公司\",\"DWMC\":\"副总工\"},{\"RYID\":\"123456\",\"NAME\":\"某某\",\"PHONE\":\"\",\"MOBILE\":\"\",\"PDWMC\":\"安全监察部\",\"DWMC\":\"总经理\"}]";
        }
        #endregion
    }
}
