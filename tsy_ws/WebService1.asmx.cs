using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace tsy_ws
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.crfsdi.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        #region 通用-应答
        [WebMethod(Description = @"<br />【通用-应答】
<br /><br />return: Hello")]
        public string Mobile_App_Hello()
        {
            return "Hello";
        }
        #endregion

        #region 通用-人员登录
        [WebMethod(Description = @"<br />【通用-人员登录】
                       <br /><br />return: 0=失败, 人员姓名=成功")]
        public string Mobile_App_Member_Login(string ryid, string pass)
        {
            return "赵建明";
        }
        #endregion

        #region 通用-首页
        //[WebMethod(Description = @"<br />【首页-待办】")]
        //public string Mobile_Index_List(string ryid)
        //{
        //    return "[{\"ID\":\"\",\"KID\":\"ZTZ-BG\",\"PID\":\"ZTZ\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"总体组变更\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-12 19:47\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GCGL-SEALSQ\",\"PID\":\"GCGL\",\"LEVEL\":\"1\",\"COUNT\":\"4\",\"TITLE\":\"过程管理-成果提交申请\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-12 19:47\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070324\",\"KID\":\"1\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070324】mobile\",\"C_USER\":\"黄丽娟\",\"C_TIME\":\"2014-07-08 14:40\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070321\",\"KID\":\"2\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070321】说明文件（图文中心）\",\"C_USER\":\"谢首祥\",\"C_TIME\":\"2014-07-07 14:43\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070320\",\"KID\":\"3\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070320】九景衢（江西段）系统集成实施技术方案-信号\",\"C_USER\":\"温继常\",\"C_TIME\":\"2014-07-07 14:25\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10000000000000120897\",\"KID\":\"0\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"郑州至万州铁路项目 总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-07-07 11:49\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070315\",\"KID\":\"4\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070315】河南省郑州市南三环上跨京广铁路立交工程站后施工图\",\"C_USER\":\"钟昌卫\",\"C_TIME\":\"2014-07-07 11:31\",\"WPARAM\":\"\",\"LPARAM\":\"\"}]";
        //}
        [WebMethod(Description = @"<br />【通用-首页】")]
        public string Mobile_App_Index_List(string ryid)
        {
            return "[{\"ID\":\"\",\"KID\":\"ZTZ-BG\",\"PID\":\"ZTZ\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"总体组变更\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-12 19:47\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GCGL-SEALSQ\",\"PID\":\"GCGL\",\"LEVEL\":\"1\",\"COUNT\":\"4\",\"TITLE\":\"过程管理-成果提交申请\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-12 19:47\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070324\",\"KID\":\"1\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070324】mobile\",\"C_USER\":\"黄丽娟\",\"C_TIME\":\"2014-07-08 14:40\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070321\",\"KID\":\"2\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070321】说明文件（图文中心）\",\"C_USER\":\"谢首祥\",\"C_TIME\":\"2014-07-07 14:43\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070320\",\"KID\":\"3\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070320】九景衢（江西段）系统集成实施技术方案-信号\",\"C_USER\":\"温继常\",\"C_TIME\":\"2014-07-07 14:25\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10000000000000120897\",\"KID\":\"0\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"郑州至万州铁路项目 总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-07-07 11:49\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070315\",\"KID\":\"4\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070315】河南省郑州市南三环上跨京广铁路立交工程站后施工图\",\"C_USER\":\"钟昌卫\",\"C_TIME\":\"2014-07-07 11:31\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"ZTZ-BG\",\"PID\":\"ZTZ\",\"LEVEL\":\"1\",\"COUNT\":\"2\",\"TITLE\":\"总体组变更\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GZLSB-TZD\",\"PID\":\"GZLSB\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"工作量申报-勘察设计工作量申报\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"WWSQ\",\"PID\":\"WWSBSP\",\"LEVEL\":\"1\",\"COUNT\":\"2\",\"TITLE\":\"委外申报审批-委外申请\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"WWHT\",\"PID\":\"WWSBSP\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"委外申报审批-委外合同\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GCGL-JFTZ\",\"PID\":\"GCGL\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"过程管理-积分调整\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"13598\",\"KID\":\"3\",\"PID\":\"WWSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：杭长客运专线公路改移（茅湄线下穿杭长高铁段路面降坡方案设计）】mobile\",\"C_USER\":\"冯悟传\",\"C_TIME\":\"2014-07-14 14:58\",\"WPARAM\":\"13598\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"7\",\"PID\":\"RGSWeb-CCSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"出差相关准备工作\",\"C_USER\":\"李康\",\"C_TIME\":\"2014-07-14 08:55\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"13596\",\"KID\":\"4\",\"PID\":\"WWSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：滁淮高速下穿合蚌高铁可研】mobile\",\"C_USER\":\"冯悟传\",\"C_TIME\":\"2014-07-09 14:59\",\"WPARAM\":\"13596\",\"LPARAM\":\"\"},{\"ID\":\"00000000000000003216\",\"KID\":\"6\",\"PID\":\"GCGL-JFTZ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"弋江站10kV电源线Ⅰ类变更设计——说明书送印[最终成果任务]\",\"C_USER\":\"靖凤鸣\",\"C_TIME\":\"2014-07-07 09:16\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10000000000000141387\",\"KID\":\"0\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"十三五铁路发展规划课题研究项目 铁路客货运需求、客运网络能力研究、重大项目建设必要性和建设时机、深化建设项目运输需求分析、中长期铁路网规划实施情况评估总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-06-30 10:11\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10231,2061\",\"KID\":\"5\",\"PID\":\"WWHT\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：珠海市区至珠海机场城际铁路】二期规划选址\",\"C_USER\":\"冯悟传\",\"C_TIME\":\"2014-06-24 14:53\",\"WPARAM\":\"10231\",\"LPARAM\":\"2061\"},{\"ID\":\"10000000000000120814\",\"KID\":\"1\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"九景衢铁路项目  总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-06-11 21:33\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"TZD_20140710000001\",\"KID\":\"2\",\"PID\":\"GZLSB-TZD\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：海南岛东环快速城际铁路】mobile\",\"C_USER\":\"杨毅\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"WWFK\",\"PID\":\"WWSBSP\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"委外申报审批-委外付款\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:24\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"21396\",\"KID\":\"0\",\"PID\":\"WWFK\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：南三龙铁路】地质钻探\",\"C_USER\":\"曾德辉\",\"C_TIME\":\"2014-07-08 17:20\",\"WPARAM\":\"otal/PayFlow/AuditingOrder.aspx?Uid=21396\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"ZTZ-BG\",\"PID\":\"ZTZ\",\"LEVEL\":\"1\",\"COUNT\":\"2\",\"TITLE\":\"总体组变更\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GZLSB-TZD\",\"PID\":\"GZLSB\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"工作量申报-勘察设计工作量申报\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"WWSQ\",\"PID\":\"WWSBSP\",\"LEVEL\":\"1\",\"COUNT\":\"2\",\"TITLE\":\"委外申报审批-委外申请\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"WWHT\",\"PID\":\"WWSBSP\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"委外申报审批-委外合同\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GCGL-JFTZ\",\"PID\":\"GCGL\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"过程管理-积分调整\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:21\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"13598\",\"KID\":\"3\",\"PID\":\"WWSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：杭长客运专线公路改移（茅湄线下穿杭长高铁段路面降坡方案设计）】mobile\",\"C_USER\":\"冯悟传\",\"C_TIME\":\"2014-07-14 14:58\",\"WPARAM\":\"13598\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"7\",\"PID\":\"RGSWeb-CCSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"出差相关准备工作\",\"C_USER\":\"李康\",\"C_TIME\":\"2014-07-14 08:55\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"13596\",\"KID\":\"4\",\"PID\":\"WWSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：滁淮高速下穿合蚌高铁可研】mobile\",\"C_USER\":\"冯悟传\",\"C_TIME\":\"2014-07-09 14:59\",\"WPARAM\":\"13596\",\"LPARAM\":\"\"},{\"ID\":\"00000000000000003216\",\"KID\":\"6\",\"PID\":\"GCGL-JFTZ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"弋江站10kV电源线Ⅰ类变更设计——说明书送印[最终成果任务]\",\"C_USER\":\"靖凤鸣\",\"C_TIME\":\"2014-07-07 09:16\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10000000000000141387\",\"KID\":\"0\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"十三五铁路发展规划课题研究项目 铁路客货运需求、客运网络能力研究、重大项目建设必要性和建设时机、深化建设项目运输需求分析、中长期铁路网规划实施情况评估总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-06-30 10:11\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10231,2061\",\"KID\":\"5\",\"PID\":\"WWHT\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：珠海市区至珠海机场城际铁路】二期规划选址\",\"C_USER\":\"冯悟传\",\"C_TIME\":\"2014-06-24 14:53\",\"WPARAM\":\"10231\",\"LPARAM\":\"2061\"},{\"ID\":\"10000000000000120814\",\"KID\":\"1\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"九景衢铁路项目  总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-06-11 21:33\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"TZD_20140710000001\",\"KID\":\"2\",\"PID\":\"GZLSB-TZD\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：海南岛东环快速城际铁路】mobile\",\"C_USER\":\"杨毅\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"WWFK\",\"PID\":\"WWSBSP\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"委外申报审批-委外付款\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:24\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"21396\",\"KID\":\"0\",\"PID\":\"WWFK\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：南三龙铁路】地质钻探\",\"C_USER\":\"曾德辉\",\"C_TIME\":\"2014-07-08 17:20\",\"WPARAM\":\"otal/PayFlow/AuditingOrder.aspx?Uid=21396\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"JBXX-DSZZGCZ-YK\",\"PID\":\"JBXX-DSZZGCZ\",\"LEVEL\":\"1\",\"COUNT\":\"3\",\"TITLE\":\"基本信息-未设置的院控项目\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:28\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"JBXX-DSZZGCZ-ZL\",\"PID\":\"JBXX-DSZZGCZ\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"基本信息-未设置的自揽项目\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:28\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GZLSB-TZD\",\"PID\":\"GZLSB\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"工作量申报-勘察设计工作量申报\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:28\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GZLSB-RWS\",\"PID\":\"GZLSB\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"工作量申报-勘测任务书申报\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:28\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"RWS_20140715000001\",\"KID\":\"5\",\"PID\":\"GZLSB-RWS\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：武汉至黄冈城际铁路】mobile\",\"C_USER\":\"黄云\",\"C_TIME\":\"2014-07-15 15:34\",\"WPARAM\":\"RWS_20140715000001\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"0\",\"PID\":\"JBXX-DSZZGCZ-YK\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"镇江有轨电车1号线\",\"C_USER\":\"\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"1\",\"PID\":\"JBXX-DSZZGCZ-YK\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"十三华中及华南地区铁路网规划方案研究\",\"C_USER\":\"\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"2\",\"PID\":\"JBXX-DSZZGCZ-YK\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"南京至盐城城际铁路\",\"C_USER\":\"\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"3\",\"PID\":\"JBXX-DSZZGCZ-ZL\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"咸宁梓山湖(贺胜)新城站前大道下穿既有京广铁路工程可行性研究\",\"C_USER\":\"\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"TZD_20140715000001\",\"KID\":\"4\",\"PID\":\"GZLSB-TZD\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：武汉至黄冈城际铁路】mobile\",\"C_USER\":\"黄云\",\"C_TIME\":\"\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GZLSB-Jhzyb\",\"PID\":\"GZLSB\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"工作量申报-计划作业表申报\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-15 16:29\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"ZYB_20140715000001\",\"KID\":\"0\",\"PID\":\"GZLSB-Jhzyb\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：武汉至黄冈城际铁路】（专业：经调）mobile\",\"C_USER\":\"黄云\",\"C_TIME\":\"2014-07-15 16:10\",\"WPARAM\":\"\",\"LPARAM\":\"\"}]";
        }

        [WebMethod(Description = @"<br />【首页-协管】")]
        public string Mobile_Index_AssistList(string rys)
        {
            return "[{\"ID\":\"\",\"KID\":\"ZTZ-BG\",\"PID\":\"ZTZ\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"总体组变更\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-12 19:47\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"\",\"KID\":\"GCGL-SEALSQ\",\"PID\":\"GCGL\",\"LEVEL\":\"1\",\"COUNT\":\"4\",\"TITLE\":\"过程管理-成果提交申请\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-12 19:47\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070324\",\"KID\":\"1\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070324】mobile\",\"C_USER\":\"黄丽娟\",\"C_TIME\":\"2014-07-08 14:40\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070321\",\"KID\":\"2\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070321】说明文件（图文中心）\",\"C_USER\":\"谢首祥\",\"C_TIME\":\"2014-07-07 14:43\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070320\",\"KID\":\"3\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070320】九景衢（江西段）系统集成实施技术方案-信号\",\"C_USER\":\"温继常\",\"C_TIME\":\"2014-07-07 14:25\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"10000000000000120897\",\"KID\":\"0\",\"PID\":\"ZTZ-BG\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"郑州至万州铁路项目 总体组\",\"C_USER\":\"孙雪松\",\"C_TIME\":\"2014-07-07 11:49\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"14070315\",\"KID\":\"4\",\"PID\":\"GCGL-SEALSQ\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【14070315】河南省郑州市南三环上跨京广铁路立交工程站后施工图\",\"C_USER\":\"钟昌卫\",\"C_TIME\":\"2014-07-07 11:31\",\"WPARAM\":\"\",\"LPARAM\":\"\"}]";
        }
        #endregion

        [WebMethod(Description = @"<br />【通用-获取项目经理】
                               <br /><br />type: 0=项目经理")]
        public string Mobile_App_Member_List(int type)
        {
            return "[{\"ID\":\"\",\"KID\":\"JHGL-TZD\",\"PID\":\"JHGL\",\"LEVEL\":\"1\",\"COUNT\":\"1\",\"TITLE\":\"计划管理-通知单\",\"C_USER\":\"\",\"C_TIME\":\"2014-07-17 16:09\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"ID\":\"00000000000000145194\",\"KID\":\"0\",\"PID\":\"JHGL-TZD\",\"LEVEL\":\"2\",\"COUNT\":\"0\",\"TITLE\":\"【项目名称：荆门至岳阳铁路】mobile\",\"C_USER\":\"谢其刚\",\"C_TIME\":\"2014-07-17 15:36\",\"WPARAM\":\"\",\"LPARAM\":\"\"},{\"RYID\":\"003635\",\"XM\":\"曹言坤\"},{\"RYID\":\"004000\",\"XM\":\"舒玲霞\"},{\"RYID\":\"003143\",\"XM\":\"宋朝阳\"},{\"RYID\":\"003331\",\"XM\":\"王培峰\"},{\"RYID\":\"003387\",\"XM\":\"谢其刚\"},{\"RYID\":\"002709\",\"XM\":\"晏锐\"},{\"RYID\":\"003418\",\"XM\":\"袁科\"}]";
        }

        #region 过程管理-最终成果任务
        [WebMethod(Description = @"<br />【过程管理-最终成果任务】
                               <br /><br />return: [待办, 已办, 全部, 进度]")]
        public string Mobile_Gcgl_Zzcgrw_Radio(string ryid)
        {
            return "1111";
        }

        [WebMethod(Description = @"<br />【过程管理-最终成果任务】
                               <br /><br />type：0=我的待办, 1=我的已办, 2=全部待办, 3=进度")]
        public string Mobile_Gcgl_Zzcgrw_List(int type, string ryid, string xmmc, string wjmc, string startDate, string endDate, string pageIndex, string pageSize)
        {
            return "[{\"BDBM\":\"14070324\",\"TITLE\":\"mobile\",\"TIME\":\"2014-07-08 14:40\"},{\"BDBM\":\"14070321\",\"TITLE\":\"说明文件（图文中心）\",\"TIME\":\"2014-07-07 14:43\"},{\"BDBM\":\"14070320\",\"TITLE\":\"九景衢（江西段）系统集成实施技术方案-信号\",\"TIME\":\"2014-07-07 14:25\"},{\"BDBM\":\"14070315\",\"TITLE\":\"河南省郑州市南三环上跨京广铁路立交工程站后施工图\",\"TIME\":\"2014-07-07 11:31\"}]";
        }

        [WebMethod(Description = @"<br />【过程管理-最终成果任务】")]
        public string Mobile_Gcgl_Zzcgrw_Detail(string bdbm)
        {
            return "[{\"ID\":15181,\"LY\":\"生产管理系统\",\"SealSQBM\":\"14070324\",\"YTHXMBM\":\"\",\"YTHJHID\":0,\"GZLSBBDBM\":\"\",\"GZLZYBID\":\"-1\",\"JHGLBDBM\":\"\",\"JHGLZYBID\":\"-1\",\"XMBM12\":\"CX300104SS04\",\"XMBM8\":\"CX300104\",\"WJMC\":\"mobile\",\"XMMC\":\"淮北矿区小湖集车站改扩建工程\",\"GZNR\":\"淮北矿业集团小湖集车站改建工程\",\"DJH\":\"YMXZT(14)0146\",\"TJSM\":\"mobile\",\"ZY\":\"\",\"SCTJSJ\":\"2014-07-08 14:40:53\",\"SQRQ\":\"2014-07-08\",\"RKMCSJ\":null,\"JHWCSJ\":\"2014-10-15\",\"SQR\":\"003236\",\"SQRXM\":\"黄丽娟\",\"SQRDWDM\":\"0034000453\",\"SQRDWMC\":\"建筑院\",\"SQRPHONE\":\"56152、13476100290\",\"SDR\":\"001684\",\"SDRXM\":\"陈泽建\",\"WJJSDW\":\"\",\"Contact\":\"\",\"ContactPhone\":\"\",\"SHR\":\"      \",\"SHRXM\":\"\",\"SealTypeID\":\"\",\"SealTypeMC\":\"\",\"XMLX\":\"ZLXM\",\"SEALXMLX\":\"自揽项目\",\"IsGZ\":\" \",\"SPYJ\":\"\",\"CURCLR\":\"000735\",\"CURCLRXM\":\"赵建明\",\"CLNR\":\"\r\n--------------------------------------------------------------\r\n黄丽娟 2014-07-08 14:40:53 提交了成果提交申请\",\"AlrClr\":\",003236\",\"LastLCZT\":\"0\",\"LCZT\":\"18\",\"LCZTMC\":\"总调度长审核\",\"DelFlag\":\"1\",\"ZRDW\":\"线站处\",\"XGXMJLRYID\":\"003143\",\"SEALSQBM1\":\"14070324\",\"CGTGFS\":\"1\",\"CGTGFSMC\":\"纸质版\",\"FILENAME\":\"mobile\",\"ZZBWJYQWCSJ\":\"2014-07-09\",\"ZZBTZYQWCSJ\":\"2014-07-16\",\"ZZBWJSealTypeID\":\"1&2\",\"ZZBWJSealTypeMC\":\"行政印章、董事长章\",\"ZZBType\":\"0&1\",\"SealTypeMS\":\"\"}]";
        }

        [WebMethod(Description = @"<br />【过程管理-最终成果任务】
                               <br /><br />type: 0=图纸")]
        public string Mobile_Gcgl_Zzcgrw_Detail_Ext(int type, string bdbm)
        {
            return "[{\"XH\":1,\"BluePrintSQID\":109736,\"SealSQBM\":\"14070324\",\"DrawingsName\":\"9\",\"DrawingsBH\":\"9\",\"DTZS\":9,\"LTFS\":9,\"CPYQ\":\"0\",\"CPYQMC\":\"装订成册\",\"SealTypeID\":\"5\",\"SealTypeMC\":\"出图专用章\"}]";
        }

        [WebMethod(Description = @"<br />【过程管理-最终成果任务】
                               <br /><br />return: 0=无权限, 1=【同意】【退回】, 2=【提交】[暂不处理], 3=【提交图文中心】【提交集团公司办公室】【退回】")]
        public string Mobile_Gcgl_Zzcgrw_Submit_Right(string ryid, string id)
        {
            return "3";
        }

        [WebMethod(Description = @"<br />【过程管理-最终成果任务】
                               <br /><br />type：0=表示退回, 1=表示同意, 20=表示同意提交图文中心, 30=表示同意提交集团公司办公室
                               <br /><br />return：0=执行失败, 1=执行成功")]
        public string Mobile_Gcgl_Zzcgrw_Submit(int type, string id, string ryid, string ryxm, string yj, string wParam, string lParam)
        {
            //"gcglzzcgrw", wParam, lParam, type, ryid, bdbm, Now(), ext=rys+"&"+yj
            return "1";
        }
        #endregion

        #region 其他-通讯录
        [WebMethod(Description = @"<br />【其他-通讯录】")]
        public string Mobile_Other_Txl_List(string ryid, int pageIndex, int pageSize, string filter)
        {
            return "[{\"RYID\":\"001818\",\"NAME\":\"王安时\",\"PHONE\":\"56392\",\"MOBILE\":\"13907162084\"},{\"RYID\":\"002597\",\"NAME\":\"肖少军\",\"PHONE\":\"84464\",\"MOBILE\":\"13707104774\"},{\"RYID\":\"001357\",\"NAME\":\"张新安\",\"PHONE\":\"\",\"MOBILE\":\"\"},{\"RYID\":\"000962\",\"NAME\":\"钟家宝\",\"PHONE\":\"\",\"MOBILE\":\"\"},{\"RYID\":\"801140\",\"NAME\":\"鲍万水\",\"PHONE\":\"\",\"MOBILE\":\"\"},{\"RYID\":\"003087\",\"NAME\":\"蔡小利\",\"PHONE\":\"\",\"MOBILE\":\"\"},{\"RYID\":\"002512\",\"NAME\":\"车青松\",\"PHONE\":\"55729\",\"MOBILE\":\"13995517496\"},{\"RYID\":\"002510\",\"NAME\":\"陈兴旺\",\"PHONE\":\"85204\",\"MOBILE\":\"13971532895\"},{\"RYID\":\"803425\",\"NAME\":\"陈志诚\",\"PHONE\":\"\",\"MOBILE\":\"\"},{\"RYID\":\"002599\",\"NAME\":\"杜芳\",\"PHONE\":\"55657\",\"MOBILE\":\"13808636322\"}]";
        }
        #endregion

        #region 其他-经济部值班安排
        [WebMethod(Description = @"<br />【其他-经计部值班安排】")]
        public string Mobile_Other_Jjbzb_List()
        {
            return "[{\"ID\":\"10\",\"WEEK\":\"周一\",\"LEADER\":\"陈文科\",\"LEADER_PHONE\":\"55659\",\"DEALER\":\"曹言坤\",\"DEALER_PHONE\":\"86466\"},{\"ID\":\"20\",\"WEEK\":\"周二\",\"LEADER\":\"方红\",\"LEADER_PHONE\":\"56104\",\"DEALER\":\"袁科\",\"DEALER_PHONE\":\"56239\"},{\"ID\":\"30\",\"WEEK\":\"周三\",\"LEADER\":\"肖军\",\"LEADER_PHONE\":\"56171\",\"DEALER\":\"谢其刚\",\"DEALER_PHONE\":\"56114\"},{\"ID\":\"40\",\"WEEK\":\"周四\",\"LEADER\":\"方红\",\"LEADER_PHONE\":\"56104\",\"DEALER\":\"赵建明,王培峰\",\"DEALER_PHONE\":\"55841,55105\"},{\"ID\":\"50\",\"WEEK\":\"周五\",\"LEADER\":\"陈文科\",\"LEADER_PHONE\":\"55659\",\"DEALER\":\"宋朝阳\",\"DEALER_PHONE\":\"86386\"},{\"ID\":\"60\",\"WEEK\":\"周六上\",\"LEADER\":\"光振雄\",\"LEADER_PHONE\":\"56551\",\"DEALER\":\"陈臣\",\"DEALER_PHONE\":\"84088\"},{\"ID\":\"61\",\"WEEK\":\"周六下\",\"LEADER\":\"陈文科\",\"LEADER_PHONE\":\"55659\",\"DEALER\":\"陈军\",\"DEALER_PHONE\":\"55361\"},{\"ID\":\"70\",\"WEEK\":\"周日上\",\"LEADER\":\"光振雄\",\"LEADER_PHONE\":\"56551\",\"DEALER\":\"晏锐\",\"DEALER_PHONE\":\"55891\"},{\"ID\":\"71\",\"WEEK\":\"周日下\",\"LEADER\":\"方红\",\"LEADER_PHONE\":\"56104\",\"DEALER\":\"舒玲霞\",\"DEALER_PHONE\":\"56704\"}]";
        }
        #endregion

        #region 委外

        #region 委外-申请
        [WebMethod(Description = @"<br />【委外-申请】
                               <br /><br />[待办, 已办]")]
        public string Mobile_Ww_Sq_Radio(string ryid)
        {
            return "11";
        }

        [WebMethod(Description = @"<br />【委外-申请】
                               <br /><br />type: 0=待办, 1=已办")]
        public string Mobile_Ww_Sq_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
        {
            return "[{\"OrderID\":\"13596\",\"TITLE\":\"【滁淮高速下穿合蚌高铁可研】mobile\"},{\"OrderID\":\"13598\",\"TITLE\":\"【杭长客运专线公路改移（茅湄线下穿杭长高铁段路面降坡方案设计）】mobile\"}]";
        }

        [WebMethod(Description = @"<br />【委外-申请】
                               <br /><br />return: value=btnType,jumpType,listId,qzbm
                               <br /><br />btnType: 2=提交, 3=退回(不选人), -1=暂不处理")]
        public string Mobile_Ww_Sq_Submit_Btn(string orderId, string ryid)
        {
            return "[{\"text\":\"同意\",\"value\":\"2,0,97,0025\"},{\"text\":\"退回\",\"value\":\"3,0,0,0\"}]";
        }

        [WebMethod(Description = @"<br />【委外-申请】")]
        public string Mobile_Ww_Sq_Detail(string orderId)
        {
            return "[{\"LSH\":\"2014-0724\",\"WorkName\":\"mobile\",\"ProjectTypeName\":\"自揽项目\",\"ProjectName\":\"自揽院审C类所有项目\",\"TaskUnit\":\"01\",\"TaskUnitAptitude\":\"1\",\"ExpectRate\":\"9.0000\",\"OutlaySource\":\"处经费\",\"DeliverTime\":\"2014-07-09\",\"CreateUserXM\":\"冯悟传\",\"BGSPhone\":\"55083\",\"CreateUserPhone\":\"13667137121\",\"HireOfWorkInfo\":\"暂无承揽合同\",\"WorkMemo\":\"mobile\"}]";
        }

        [WebMethod(Description = @"<br />【委外-申请】")]
        public string Mobile_Ww_Sq_Submit_Rys(string listId, string orderId, string qzbm, string ryid)
        {
            return "[{\"ryid\":\"001901\",\"text\":\"窦文霞[001901]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"001341\",\"text\":\"李伟[001341]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"001651\",\"text\":\"刘敬军[001651]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"002757\",\"text\":\"刘振[002757]\",\"check\":\"0\",\"value\":\"\"}]";
        }

        [WebMethod(Description = @"<br />【委外-申请】
                                <br /><br />rys: ','分隔")]
        public int Mobile_Ww_Sq_Submit(int type, string orderId, string rys, string yj, string ryid, string jumpType, string listId, string wParam, string lParam)
        {
            return 1;
        }
        #endregion

        #region 委外-合同
        [WebMethod(Description = @"<br />【委外-合同】
                               <br /><br />[待办, 已办, 完成]")]
        public string Mobile_Ww_Ht_Radio(string ryid)
        {
            return "111";
        }

        [WebMethod(Description = @"<br />【委外-合同】
                               <br /><br />type: 0=待办, 1=已办, 2=完成")]
        public string Mobile_Ww_Ht_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
        {
            return "[{\"OrderID\":\"10231\",\"ContractID\":\"2061\",\"TITLE\":\"【珠海市区至珠海机场城际铁路】二期规划选址\"}]";
        }
        [WebMethod(Description = @"<br />【委外-合同】
                               <br /><br />return: value=btnType,tjyld
                               <br /><br />btnType: 2=提交, 1=退回(不选人), -1=暂不处理")]
        public string Mobile_Ww_Ht_Submit_Btn(string orderId, string ryid)
        {
            return "[{\"text\":\"同意\",\"value\":\"2,0\"},{\"text\":\"退回\",\"value\":\"1,0\"}]";
        }

        [WebMethod(Description = @"<br />【委外-合同】")]
        public string Mobile_Ww_Ht_Detail(string orderId, string conId)
        {
            return "[{\"LSH\":\"2014-0110\",\"XMMC\":\"无锡市轨道交通2号线工程系统设计GD02SJZB1002-XTSJ03标梅园、荣巷、张巷车站暖通空调、给排水及消防系统招标图、施工图设计及配合施工\",\"BMMC\":\"城地院                                  \",\"ND\":\"14\",\"YWLB\":\"设计\",\"ContractCode\":\"YMXZW14232CT804201S\",\"YFXX\":\"江苏省交通科学研究院股份有限公司\",\"ContractType\":\"总价合同\",\"PayPrice\":\"30\",\"WWSQName\":\"无锡市轨道交通2号线工程系统设计GD02SJZB1002-XTSJ03标梅园、荣巷、张巷车站暖通空调、给排水及消防系统招标图、施工图设计及配合施工\",\"ExpectRate\":\"30\",\"AllPrice\":\"0\",\"HTGS\":\"委托方（甲方）：中铁第四勘察设计院集团有限公司&nbsp;&nbsp;<br>受托方（乙方）：广东省建筑设计研究院&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>本合同甲方委托乙方就&nbsp;&nbsp;珠海长隆至珠海机场轨道交通项目规划选址评估&nbsp;&nbsp;项目进行技术咨询，并支付咨询报酬。双方经过平等协商，在真实、充分地表达各自意愿的基础上，根据《中华人民共和国合同法》的规定，达成如下协议，并由双方共同恪守。\",\"DYJS\":\"无\",\"HEYJ\":\"合同申请上级部门意见批准。\",\"HTZC\":\"无\",\"GZMC\":\"珠海长隆至珠海机场轨道交通项目规划选址评估。&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>\",\"GZFW\":\"乙方进行技术咨询的内容、要求和方式：<br>1．咨询内容：&nbsp;&nbsp;编制珠海长隆至珠海机场轨道交通项目的《建设项目选址意见申请书》及《建设项目规划选址评估报告》，协助建设单位向广东省住房和城乡建设厅申请《建设项目选址意见书》，工作内容和成果详见附件。&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>2．咨询要求：&nbsp;&nbsp;完成《建设项目选址意见申请书》及《建设项目规划选址评估报告》的编制，并满足中国国家有关法律、法规规定，满足广东省住房和城乡建设厅核发《建设项目选址意见书》的要求。&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>3．咨询方式：&nbsp;&nbsp;编制《建设项目选址意见申请书》及《建设项目规划选址评估报告》。&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>第二条：乙方应当按照下列进度要求进行本合同项目的技术咨询工作：&nbsp;&nbsp;于合同签订且收到甲方支付的首期经费后和相关规划资料后一个月内提交《建设项目规划选址评估报告》初稿给甲方，其后乙方依据甲方意见进行修改完善，编制《建设项目规划选址评估报告》正式稿及《建设项目选址意见申请书》，并协助甲方开展申报工作。&nbsp;&nbsp;&nbsp;&nbsp;<br>\",\"HTZL\":\"第三条：为保证乙方有效进行技术咨询工作，甲方应当向乙方提供下列协作事项：<br>1．提供技术资料并对资料可靠性负责：&nbsp;&nbsp;&nbsp;1）项目的建设背景、项目选址文件、可行性研究报告以及其他相关资料；2）项目的环境影响评价分析材料；3）有关生态环境保护、地质灾害、水土保持等方面的资料。&nbsp;&nbsp;&nbsp;<br>2．提供工作条件：无&nbsp;。<br>3．其他：无&nbsp;&nbsp;。<br>甲方提供上述协作事项的时间及方式：&nbsp;&nbsp;自规划工作正式开展后&nbsp;。&nbsp;&nbsp;<br>\",\"LXDD\":\"&nbsp;广州市\",\"FYBZ\":\"第四条：甲方向乙方支付技术咨询报酬及支付方式为：<br>1．技术咨询报酬总额为：人民币叁拾万元整（￥30.0万元）。&nbsp;<br>2．技术咨询报酬由甲方&nbsp;&nbsp;&nbsp;&nbsp;分期&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;（一次或分期）支付乙方。<br>具体支付方式和时间如下：<br>（1）本合同签订后七日内，甲方支付技术咨询费的40%即人民币壹拾贰万元整（￥12.0万元）给乙方作为定金。<br>（2）乙方提供《建设项目规划选址评估报告》及《建设项目选址意见申请书》七日内，甲方支付技术咨询费的30%即人民币玖万元整（￥9.0万元）给乙方。<br>（3）甲方取得广东省住房和城乡建设厅核发的《建设项目选址意见书》七日内，甲方支付剩余的30%技术咨询费即人民币玖万元整（￥9.0万元）给乙方。<br><br>乙方帐户名、开户银行名称、地址和帐号为：<br>帐户名：&nbsp;&nbsp;&nbsp;广东省建筑设计研究院&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>开户银行：中国建设银行股份有限公司广州流花支行&nbsp;&nbsp;&nbsp;&nbsp;<br>地址：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;广州市流花路97号&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>帐号：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;44001453102050286103&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>\",\"ZRYW\":\"第九条：双方确定：<br>1．在本合同有效期内，乙方利用甲方提供的技术资料和工作条件所完成的本项目合同成果，归&nbsp;&nbsp;&nbsp;甲&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;（乙、双）方所有。<br>第十条：双方确定，在本合同有效期内，甲方指定&nbsp;&nbsp;&nbsp;&nbsp;刘博&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;为甲方项目联系人，乙方指定&nbsp;&nbsp;王登嵘/张铭浩&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;为乙方项目联系人。项目联系人承担以下责任：<br>1、负责双方联系工作&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>2、负责双方协调工作&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>3、甲乙双方就对本项目各自工作人员具有调配能力&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;。<br>一方变更项目联系人的，应当及时以书面形式通知另一方。未及时通知并影响本合同履行或造成损失的，应承担相应的责任。<br>\",\"ZLBZ\":\"第七条：双方确定，按以下标准和方式对乙方提交的技术咨询工作成果进行验收：<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1．乙方提交技术咨询工作成果的形式：&nbsp;&nbsp;由乙方送至甲方处&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;。<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2．技术咨询工作成果的验收标准：&nbsp;符合国家和地方政府行业标准及规范。<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3．技术咨询工作成果的验收方法：&nbsp;&nbsp;广东省住房和城乡建设厅认可&nbsp;&nbsp;&nbsp;。<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;4．乙方提交技术咨询工作成果的数量：最终成果提供《建设项目选址意见申请书》、《建设项目规划选址评估报告》各八套、word版电子文件光盘一份。<br>\",\"SYQ\":\"双方确定因履行本合同应遵守的保密义务如下：<br>甲方：<br>1、保密内容（包括技术信息和经营信息）：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;各阶段技术成果&nbsp;&nbsp;&nbsp;；<br>2、涉密人员范围：&nbsp;&nbsp;有关工作人员&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>3、保密期限：&nbsp;合同有效期内&nbsp;；<br>4、泄密责任：&nbsp;违约责任&nbsp;。&nbsp;<br>乙方：<br>1、保密内容（包括技术信息和经营信息）：&nbsp;甲方提供的技术资料、数据和各阶段成果&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>2、涉密人员范围：&nbsp;有关设计人员&nbsp;；<br>3、保密期限：&nbsp;合同有效期内&nbsp;；<br>4、泄密责任：&nbsp;违约责任&nbsp;。<br>\",\"WYZR\":\"第八条：双方确定，按以下约定承担各自的违约责任：<br>1、&nbsp;&nbsp;&nbsp;甲&nbsp;&nbsp;&nbsp;方违反本合同第&nbsp;&nbsp;四&nbsp;&nbsp;条约定，应当&nbsp;&nbsp;按每延期一天支付合同总金额的1‰的违约金给乙方。<br>2．&nbsp;甲&nbsp;方需中途终止合同，应书面通知乙方，并阐明理由。已签订合同，但乙方尚未开展工作，甲方所支付的定金乙方不予退还；若乙方已开展工作，工作量未超过一半时，甲方应支付总技术咨询费的50%给乙方；工作量已超过一半时，甲方应支付总技术咨询费的100%给乙方。<br>3．&nbsp;乙&nbsp;方违反本合同第&nbsp;&nbsp;二、七&nbsp;&nbsp;条约定，应当&nbsp;承担相应责任。由于乙方所提交的文件不能满足合同约定的内容要求而造成的返工或修改，返工或修改由乙方承担；如由于乙方修改不及时导致修改工作延误，每延期一天，支付该阶段合同金额的1‰的违约金给甲方。<br>4．&nbsp;乙&nbsp;方如因自身原因需中途终止合同，应书面通知&nbsp;甲&nbsp;方，并阐明理由。已签订合同，但乙方尚未开展工作，甲方所支付的定金乙方应双倍退还；若乙方已开展工作，不论工作量是否超过一半，甲方无需支付任何费用给乙方。<br>\",\"FLSY\":\"第十二条：双方因履行本合同而发生的争议，应协商、调解解决。协商、调解不成的，确定按以下第&nbsp;&nbsp;1&nbsp;&nbsp;&nbsp;&nbsp;种方式处理：<br>1、提交&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;长沙&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;仲裁委员会仲裁；<br>2、依法向人民法院起诉。<br>第十三条：双方确定：本合同及相关附件中所涉及的有关名词和技术术语，其定义和解释如下：&nbsp;&nbsp;&nbsp;无&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;。<br>第十四条：与履行本合同有关的下列技术文件，经双方确认后，&nbsp;&nbsp;附件&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;为本合同的组成部分：<br>第十五条：双方约定本合同其他相关事项为：未尽事项，由甲乙双方自行协商确定。<br>\",\"HTSX\":\"第六条：本合同的变更必须由双方协商一致，并以书面形式确定。但有下列情形之一的，一方可以向另一方提出变更合同权利与义务的请求，另一方应当在七&nbsp;日内予以答复；逾期未予答复的，视为同意：<br>1、因甲方原因引起的重大修改或重做&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>2、规划范围发生变化或甲方要求做合同以外的工作内容&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;。<br>\",\"BKKL\":\"第十一条：双方确定，出现下列情形，致使本合同的履行成为不必要或不可能的，可以解除本合同：<br>1、发生不可抗力&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>2、甲方所在地规划发生重大变化&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;；<br>3、乙方提交各阶段成果一个月内，甲方没有提出反馈意见而导致规划无法继续进行的。<br>\",\"TZTK\":\"第十六条：本合同一式&nbsp;&nbsp;八&nbsp;份，甲乙双方各持四份，具有同等法律效力。<br>\",\"QT\":\"第十七条：本合同经双方签字盖章后生效。<br>\"}]";
        }

        [WebMethod(Description = @"<br />【委外-合同】")]
        public string Mobile_Ww_Ht_Submit_Rys(string orderId, string ryid)
        {
            return "[{\"ryid\":\"003635\",\"text\":\"曹言坤[003635]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"004000\",\"text\":\"舒玲霞[004000]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"003143\",\"text\":\"宋朝阳[003143]\",\"check\":\"1\",\"value\":\"\"},{\"ryid\":\"003331\",\"text\":\"王培峰[003331]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"003387\",\"text\":\"谢其刚[003387]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"002709\",\"text\":\"晏锐[002709]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"003418\",\"text\":\"袁科[003418]\",\"check\":\"0\",\"value\":\"\"}]";
        }

        [WebMethod(Description = @"<br />【委外-合同】
                               <br /><br />rys: ','分隔")]
        public int Mobile_Ww_Ht_Submit(int type, string orderId, string yj, string ryid, string rys, string tjyld, string wParam, string lParam)
        {
            return 1;
        }
        #endregion
        #region 委外-付款
        [WebMethod(Description = @"<br />【委外-付款】
                               <br /><br />[待办, 已办]")]
        public string Mobile_Ww_Fk_Radio(string ryid)
        {
            return "11";
        }

        [WebMethod(Description = @"<br />【委外-付款】
                               <br /><br />type: 0=待办, 1=已办")]
        public string Mobile_Ww_Fk_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
        {
            return "[{\"OrderID\":\"21396\",\"ContractID\":\"202\",\"TITLE\":\"南三龙铁路\"}]";
        }

        [WebMethod(Description = @"<br />【委外-付款】
                               <br /><br />return: value=btnType,listId
                               <br /><br />btnType: 2=提交, 3=退回(不选人), -1=暂不处理")]
        public string Mobile_Ww_Fk_Submit_Btn(string orderId, string ryid)
        {
            return "[{\"text\":\"提交\",\"value\":\"2,4\"},{\"text\":\"退回\",\"value\":\"3,0\"}]";
        }

        [WebMethod(Description = @"<br />【委外-付款】")]
        public string Mobile_Ww_Fk_Detail(string orderId)
        {
            return "[{\"XMMC\":\"南三龙铁路\",\"ContractCode\":\"YMDLW10282CT302701K\",\"ContractType\":\"单价合同\",\"AssumeUnit\":\"北京中核大地矿业勘查开发有限公司南昌分公司\",\"AccountBank\":\"建行南昌支行\",\"AccountNum\":\"36001053000052505680\",\"AllPrice\":\"308.6022\",\"AllPay\":\"0\",\"RunPrice\":\"0\",\"IsPayEnd\":\"否\",\"PayPrice\":\"9\",\"FactPrice\":\"0\",\"Sake\":\"mobile\"}]";
        }

        [WebMethod(Description = @"<br />【委外-付款】
​​​​​​​​<br /><br />btnIndex: 点击的按钮索引，从0开始")]
        public string Mobile_Ww_Fk_Submit_Rys(string orderId, string ryid, int btnIndex)
        {
            return "[{\"ryid\":\"002820\",\"text\":\"邓振林[002820]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"001385\",\"text\":\"李朝锋[001385]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"001236\",\"text\":\"马驹[001236]\",\"check\":\"0\",\"value\":\"\"},{\"ryid\":\"003205\",\"text\":\"黄俊[003205]\",\"check\":\"0\",\"value\":\"\"}]";
        }

        [WebMethod(Description = @"<br />【委外-付款】
                               <br /><br />rys: ','分隔")]
        public int Mobile_Ww_Fk_Submit(int type, string orderId, string ryid, string rys, string yj, string listId, string wParam, string lParam)
        {
            return 1;
        }
        #endregion

        #endregion

       #region 工作量申报-通知单
       [WebMethod(Description = @"<br />【工作量申报-通知单】
                               <br /><br />return: [待办, 已办, 暂缓, 进度, 我保存的, 我发起的, 本处未完成, 本处, 本科室未完成, 本科室, 院总任务]")]
       public string Mobile_Gzlsb_Tzd_Radio(string ryid)
       {
           return " 11111111111";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-通知单】
                               <br /><br />type: 0=待办, 1=已办, 2=暂缓, 3=进度, 4=我保存的, 5=我发起的工作量, 6=本处未完成, 7=本处, 8=本科室未完成, 9=本科室, 10=院总任务")]
       public string Mobile_Gzlsb_Tzd_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
       {
           return "[{\"ID\":\"7021\",\"BDBM\":\"TZD_20140715000001\",\"TITLE\":\"武汉至黄冈城际铁路\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-通知单】")]
       public string Mobile_Gzlsb_Tzd_Detail(string bdbm)
       {
           return "[{\"ID\":\"7021\",\"XMBM\":\"CT603401\",\"XMMC\":\"武汉至黄冈城际铁路\",\"XMGZNR\":\"mobile\",\"YWLB\":\"项目管理\",\"KSJD\":\"[Z]施工准备\",\"ZTZY\":\"线站处[总体、站场]\",\"CYZY\":\"线站处[站场]，建筑院[结构]\",\"GZNR\":\"mobile\",\"YQ\":\"mobile\",\"KSSJ\":\"2014-07-15\",\"JSSJ\":\"2014-07-18\",\"RWYJ\":\"nasmpath;\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-通知单】
​​​​​​​​<br /><br />value:btnId")]
       public string Mobile_Gzlsb_Tzd_Submit_Btn(string bdbm, string ryid)
       {
           return "[{\"text\":\"提交处长\",\"value\":\"779\"},{\"text\":\"退回总体\",\"value\":\"783\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-通知单】
                               <br /><br />return: value=ryid$ryxm,enable")]
       public string Mobile_Gzlsb_Tzd_Submit_Rys(string bdbm, string ryid,string btnId)
       {
           return "[{\"ryid\":\"002820\",\"text\":\"(002820)邓振林\",\"check\":\"False\",\"value\":\"002820$邓振林,True\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-通知单】
                               <br /><br />rys: ryid$ryxm#ryid$ryxm")]
       public int Mobile_Gzlsb_Tzd_Submit(string bdbm, string ryid, string rys, string btnId, string yj, string wParam, string lParam)
       {
           return 1;
       }
 
       #endregion
 
 
       #region 工作量申报-任务书
       [WebMethod(Description = @"<br />【工作量申报-任务书】
                               <br /><br />return: [待办, 已办, 我保存的, 我发布的, 本处未完成, 本处, 进度, 本科室未完成, 本科室, 院总]")]
       public string Mobile_Gzlsb_Rws_Radio(string ryid)
       {
           return " 1111111111";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-任务书】
                               <br /><br />type: 0=待办, 1=已办, 2=我保存的, 3=我发布的, 4=本处未完成, 5=本处, 6=进度, 7=本科室未完成, 8=本科室, 9=院总")]
       public string Mobile_Gzlsb_Rws_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
       {
           return " [{\"ID\":\"539\",\"BDBM\":\"RWS_20140715000001\",\"TITLE\":\"武汉至黄冈城际铁路\",\"TIME\":\"2014-07-15 15:34\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-任务书】")]
       public string Mobile_Gzlsb_Rws_Detail(string bdbm)
       {
           return " [{\"ID\":\"539\",\"XMBM\":\"CT603401\",\"XMMC\":\"武汉至黄冈城际铁路\",\"DXDJ_NB\":\"Ⅲ.0\",\"XMGZNR\":\"mobile\",\"YWLB\":\"勘察\",\"KSJD\":\"草测\",\"PQZY\":\"线站处[总体、站场]\",\"CCZY\":\"建筑院[结构]，电化处[电力]\",\"WYCLDW\":\"建筑院[暖通]，道路院[总体]\",\"KTDW\":\"建筑院[暖通]，道路院[总体]\",\"KSSJ\":\"2014-07-15\",\"JSSJ\":\"2014-07-18\",\"KSLC\":\"90\",\"JSLC\":\"90\",\"XLCD\":\"90\",\"StationNum\":\"\",\"QLZYM\":\"9-\",\"TunnelZYM\":\"-\",\"ZTKYM\":\"9-\",\"ZYGCNR\":\"mobile\",\"SMYQ\":\"mobile\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-任务书】")]
       public string Mobile_Gzlsb_Rws_Submit_Btn(string bdbm, string ryid)
       {
           return "[{\"text\":\"确认通过\",\"value\":\"800\"},{\"text\":\"退回专册\",\"value\":\"801\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-任务书】
                               <br /><br />return: value=ryid$ryxm,enable")]
       public string Mobile_Gzlsb_Rws_Submit_Rys(string bdbm, string ryid, string btnId)
       {
           return "[{\"ryid\":\"000719\",\"text\":\"(000719)黄云\",\"check\":\"False\",\"value\":\"000719$黄云,True\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-任务书】
                               <br /><br />rys: ryid$ryxm#ryid$ryxm")]
       public int Mobile_Gzlsb_Rws_Submit(string bdbm, string ryid, string rys, string btnId, string yj, string wParam, string lParam)
       {
          return 1; 
       }
 
       #endregion
 
 
       #region 工作量申报-作业表
       [WebMethod(Description = @"<br />【工作量申报-作业表】
                               <br /><br />return: [待办, 已办, 我保存的, 我发布的, 本处未完成, 本处, 进度, 本科室未完成, 本科室, 院总]")]
       public string Mobile_Gzlsb_Zyb_Radio(string ryid)
       {
           return " 1111111111";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-作业表】
                               <br /><br />type: 0=待办, 1=已办, 2=我保存的, 3=我发布的, 4=本处未完成, 5=本处进度, 6=进度, 7=本科室未完成, 8=本科室进度, 9=院总任务")]
       public string Mobile_Gzlsb_Zyb_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
       {
           return "[{\"ID\":\"1353\",\"BDBM\":\"ZYB_20140715000001\",\"TITLE\":\"武汉至黄冈城际铁路\",\"TIME\":\"2014-07-15 00:00\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-作业表】")]
       public string Mobile_Gzlsb_Zyb_Detail(string bdbm)
       {
           return "[{\"ID\":1353,\"GLZSBJYZYBBM\":\"ZYB_20140715000001\",\"XMMC\":\"武汉至黄冈城际铁路\",\"XMBM\":\"CT603401\",\"JHZYBBDBM\":\"\",\"JHZYBBH\":\"mobile\",\"YWLB\":\"设计\",\"KSJD\":\"预可研\",\"KSSJ\":\"2014-07-15T00:00:00\",\"JSSJ\":\"2014-07-18T00:00:00\",\"DESC\":\"mobile\",\"WCBJ\":\"0\",\"SCBJ\":\"1\",\"FBBJ\":\"1\",\"TBRXM\":\"黄云\",\"TBRID\":\"000719\",\"TBSJ\":\"2014-07-15T16:10:21.95\",\"ZTZBM\":\"10000000000000120740\",\"CYZY\":\"线站处[总体、经调、站场]，桥梁处[桥梁]，地路处[地路]，设备处[机辆]，工经处[工经]\",\"CYZYBM\":\"1057,1210,1063,1045,1203,1206,1035\",\"FBTime\":\"2014-07-15T16:11:34.33\",\"DDTime\":null,\"IsNeedSynYTH\":\"否\",\"SynYTHTime\":null,\"IsNeedSynRGS\":\"是\",\"SynRGSTime\":null}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-作业表】")]
       public string Mobile_Gzlsb_Zyb_Submit_Btn(string bdbm, string ryid)
       {
           return "[{\"text\":\"确认并提交总体\",\"value\":\"814\"},{\"text\":\"确认并提交处长\",\"value\":\"828\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-作业表】
                               <br /><br />return: value=ryid$ryxm,enable")]
       public string Mobile_Gzlsb_Zyb_Submit_Rys(string bdbm, string ryid, string btnId)
       {
           return "[{\"ryid\":\"000719\",\"text\":\"(000719)黄云\",\"check\":\"False\",\"value\":\"000719$黄云,True\"}]";
       }
 
       [WebMethod(Description = @"<br />【工作量申报-作业表】
                               <br /><br />rys: ryid$ryxm#ryid$ryxm")]
       public int Mobile_Gzlsb_Zyb_Submit(string bdbm, string ryid, string rys, string btnId, string yj, string wParam, string lParam)
       {
          return 1; 
       }
 
       #endregion
    
    #region 计划管理
 
       #region 计划管理-通知单
       [WebMethod(Description = @"<br />【计划管理-通知单】
                               <br /><br />return: [待办(院控), 已办(院控), 已批准(院控), 待办(自揽), 已办(自揽), 已批准(自揽)]")]
       public string Mobile_Jhgl_Tzd_Radio(string ryid)
       {
           return "111111";
       }
 
       [WebMethod(Description = @"<br />【计划管理-通知单】
                               <br /><br />type: 0=待办(院控), 1=已办(院控), 2=已批准(院控), 3=待办(自揽), 4=已办(自揽), 5=已批准(自揽)")]
       public string Mobile_Jhgl_Tzd_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
       {
           return "[{\"BDBM\":\"00000000000000145193\",\"TITLE\":\"武汉至咸宁城际铁路\",\"TIME\":\"2014-07-17 15:31\"}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-通知单】")]
       public string Mobile_Jhgl_Tzd_Detail(string bdbm)
       {
           return "[{\"ID\":78255,\"BDBM\":\"00000000000000145193\",\"NF\":\"14\",\"LSH\":\"\",\"ZSDW\":\"技术中心、线站处、项目总体\",\"CSDW\":\"集团公司办公室、财务部、信息中心、图文中心、技术中心\",\"XMBM\":\"CT701601\",\"XMMC\":\"武汉至咸宁城际铁路\",\"GZYJ\":\"bug\",\"JHSJ1\":\"2014-07-17\",\"JHSJ2\":\"2014-07-24\",\"YWLB\":\"B\",\"KSJD\":\"施工准备\",\"GZNR1\":\"mobile\",\"GZNR2\":\"mobile\",\"WCSJ\":\"\",\"ZZWCSJ\":\"1900-01-01T00:00:00\",\"ZTZY\":\"技术中心[总体]，线站处[站场]\",\"CYZY\":\"技术中心[总体]\",\"YQ\":\"mobile\",\"ZLGD\":\"按集团公司有关规定办理。\",\"PZR\":\"陈文科\",\"BZR\":\"谢其刚\",\"BZRRYID\":\"003387\",\"XDBM\":\"经营计划部\",\"XDRQ\":\"2014-07-17\",\"XMSH\":\"\",\"KSJDDM\":\"Z\",\"XMBM12\":\"CT701601BZ\",\"ZTBZ\":\"0\",\"QTZYBM\":\"1087,1063\",\"CYZYBM\":\"1087\",\"YWLBMC\":\"项目管理\",\"CLJL\":\"\",\"CURCLR\":\"003387\",\"YCLR\":\"003387\",\"BZRRYID1\":\"003387\",\"PZRRYID\":\"001915\",\"ZTZBM\":\"10000000000000120916\",\"ZTZQC\":\"武汉至咸宁城际铁路 总体组\",\"GSSJ1\":null,\"GSSJ2\":null,\"TZDBZ\":\"YMJJT\",\"XMLX\":\"YKXM\",\"IsNeedSynRGS\":\"是\",\"IsNeedSynYTH\":\"\",\"IsNeedSynYTH_SC\":\"是\",\"JJBHQYJ\":null,\"GZLBDBM\":null,\"GZLTBRXM\":null,\"GSZTZBM\":\"10000000000000120916,\",\"GSZTZMC\":\"武汉至咸宁城际铁路 总体组 ,\",\"SynYTHTime\":null}]";
       }
 
 
 
       [WebMethod(Description = @"<br />【计划管理-通知单】
                               <br /><br />type: 0=主要时间节点")]
       public string Mobile_Jhgl_Tzd_Detail_Ext(int type, string bdbm)
       {
           return "[{\"ID\":157533,\"TZDBM\":\"00000000000000145193\",\"ZYMC\":\"技术中心[总体]\",\"ZYBM\":\"1087\",\"NR\":\"mobile\",\"WCSJ\":\"2014-07-17\",\"JSZYDW\":\"mobile\",\"JSZYDWBM\":\"\",\"RWLB\":8,\"NOTE\":\"\",\"RWLBMC\":\"最终成果任务\",\"PXM\":87.0,\"TZBGBJ\":null,\"TZBGCreateID\":null,\"DWDM\":\"0034000006\",\"DWMC\":\"技术中心\",\"XH\":\"1.\",\"TZBGBDBM\":null}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-通知单】
                               <br /><br />return: -2=失败, -1=不能操作, 0=(提交至批准人, 转其它人会签, 退回至发起人, 终止申报), 1=(同意下达, 退回, 转其它人会签, 退回至发起人, 终止申报), 2=会签")]
       public int Mobile_Jhgl_Tzd_Submit_Right(string bdbm, string ryid)
       {
           return 0;
       }
 
       [WebMethod(Description = @"<br />【计划管理-通知单】
                               <br /><br />type: 0=转会签")]
       public string Mobile_Jhgl_Tzd_Submit_Rys(int type, string bdbm, string ryid)
       {
           return "[{\"ryid\":\"002043\",\"text\":\"谌启发[002043]\",\"value\":\"\"},{\"ryid\":\"003747\",\"text\":\"段国华[003747]\",\"value\":\"\"},{\"ryid\":\"003010\",\"text\":\"高哲凝[003010]\",\"value\":\"\"},{\"ryid\":\"003017\",\"text\":\"胡栩彬[003017]\",\"value\":\"\"},{\"ryid\":\"002869\",\"text\":\"黄敏建[002869]\",\"value\":\"\"},{\"ryid\":\"002962\",\"text\":\"黄仁波[002962]\",\"value\":\"\"},{\"ryid\":\"001165\",\"text\":\"江立新[001165]\",\"value\":\"\"},{\"ryid\":\"002560\",\"text\":\"雷鸣[002560]\",\"value\":\"\"},{\"ryid\":\"000917\",\"text\":\"李国华[000917]\",\"value\":\"\"},{\"ryid\":\"003960\",\"text\":\"李天降[003960]\",\"value\":\"\"},{\"ryid\":\"003441\",\"text\":\"李艳[003441]\",\"value\":\"\"},{\"ryid\":\"004378\",\"text\":\"李雁艳[004378]\",\"value\":\"\"},{\"ryid\":\"003315\",\"text\":\"刘锋[003315]\",\"value\":\"\"},{\"ryid\":\"004392\",\"text\":\"刘锋[004392]\",\"value\":\"\"},{\"ryid\":\"002888\",\"text\":\"罗来前[002888]\",\"value\":\"\"},{\"ryid\":\"003977\",\"text\":\"马建文[003977]\",\"value\":\"\"},{\"ryid\":\"002756\",\"text\":\"彭瑞华[002756]\",\"value\":\"\"},{\"ryid\":\"003215\",\"text\":\"任前程[003215]\",\"value\":\"\"},{\"ryid\":\"003412\",\"text\":\"沈宏山[003412]\",\"value\":\"\"},{\"ryid\":\"002678\",\"text\":\"唐健[002678]\",\"value\":\"\"},{\"ryid\":\"003819\",\"text\":\"滕飞[003819]\",\"value\":\"\"},{\"ryid\":\"000786\",\"text\":\"王连群[000786]\",\"value\":\"\"},{\"ryid\":\"002656\",\"text\":\"吴刚[002656]\",\"value\":\"\"},{\"ryid\":\"003519\",\"text\":\"辛念[003519]\",\"value\":\"\"},{\"ryid\":\"003378\",\"text\":\"徐少颖[003378]\",\"value\":\"\"},{\"ryid\":\"002519\",\"text\":\"张孝雨[002519]\",\"value\":\"\"},{\"ryid\":\"002248\",\"text\":\"张在保[002248]\",\"value\":\"\"},{\"ryid\":\"002575\",\"text\":\"张志华[002575]\",\"value\":\"\"},{\"ryid\":\"002219\",\"text\":\"章涛松[002219]\",\"value\":\"\"},{\"ryid\":\"092279\",\"text\":\"王喆鹏[092279]\",\"value\":\"\"},{\"ryid\":\"002895\",\"text\":\"杜子荣[002895]\",\"value\":\"\"},{\"ryid\":\"002797\",\"text\":\"何晓春[002797]\",\"value\":\"\"},{\"ryid\":\"002460\",\"text\":\"周德宏[002460]\",\"value\":\"\"},{\"ryid\":\"003805\",\"text\":\"马涛[003805]\",\"value\":\"\"}]";
       }
 
       //[WebMethod(Description = @"<br />【计划管理-通知单】")]
       //public string Mobile_Jhgl_Tzd_Submit_Ext(int type, string bdbm, string ryid)
       //{
       //    return TDataTable.Dt2Str(JhglFacade.GetJhglTzdSubmitExt(type, bdbm, ryid));
       //}
 
       [WebMethod(Description = @"<br />【计划管理-通知单】
                               <br /><br />type: 0=同意, 1=退回, 2=转其它人会签, 3=退回至发起人, 4=终止申报, 5=提交至批准人, 6=会签")]
       public int Mobile_Jhgl_Tzd_Submit(int type, string bdbm, string ryid, string rys, string yj, string wParam, string lParam)
       {
           return 1;
       }
       #endregion
 
 
       #region 计划管理-任务书
       [WebMethod(Description = @"<br />【计划管理-任务书】
                               <br /><br />return: [待办、已办、已批准]")]
       public string Mobile_Jhgl_Rws_Radio(string ryid)
       {
           return "111";
       }
 
       [WebMethod(Description = @"<br />【计划管理-任务书】
                               <br /><br />type: 0=待办、1=已办、2=已批准")]
       public string Mobile_Jhgl_Rws_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
       {
           return "[{\"BDBM\":\"00000000000000126099\",\"TITLE\":\"武汉至十堰城际铁路\",\"TIME\":\"2014-07-11 10:52\"}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-任务书】")]
       public string Mobile_Jhgl_Rws_Detail(string bdbm)
       {
           return "[{\"NF\":\"14\",\"XMBM\":\"CT404601\",\"XMMC\":\"武汉至十堰城际铁路\",\"GZNR\":\"孝感至朋兴先行开工段定测\",\"YWLBMC\":\"勘察\",\"GZJDMC\":\"定测\",\"JHSJ1\":\"2014-07-15\",\"JHSJ2\":\"2014-07-25\",\"ZTZQC\":\"武汉至十堰城际铁路总体组\",\"CYZY\":\"线站处[总体、线路、站场]，桥梁处[桥梁]，地路处[地路]，建筑院[建筑、结构]，电化处[电力、供变电、通信防护]，环工处[给水排水]，工经处[工经]，\",\"PQZY\":\"线站处[总体、线路、站场]，桥梁处[桥梁]，地路处[地路]，建筑院[建筑、结构]，电化处[电力、供变电、通信防护]，环工处[给水排水]，工经处[工经]\",\"CCZY\":\"\",\"WYCLDW\":\"工勘院\",\"KTDW\":\"地路处\",\"KSLC\":\"CK47+400\",\"JSLC\":\"CK56+500\",\"QLZYM\":\"1-7400\",\"ZTKYM\":\"235-10073\",\"XLCD\":\"9.100\",\"DXDJ_NB\":\"Ⅲ.5\",\"StationNum\":\"2\",\"TunnelZYM\":\"0-0\",\"ZYGCNR\":\"1、根据7月3提计划处与汉十公司商定，孝感东至朋兴站（含）定测，作为第二个先行开工段，朋兴站按2台四线上到位，孝感东站站台及雨棚不接长，请站场、房建专业注意与汉孝城际的衔接。\r\n2、站后专业自己根据需要报工作量及出外业。\",\"SMYQ\":\"无\",\"CarServiceDeptName\":\"\",\"XMSH\":\"\",\"CJRID\":\"003418\",\"CJRXM\":\"袁科\",\"CJRQ\":\"2014-07-11\",\"PZR\":\"陈文科\",\"IsNeedSynRGS\":\"是\",\"CZYJ\":\"\r\n--------------------------------------------------------------\r\n工经处：宋昱 于 2014/7/4 8:38:34完成操作：\r\n--------------------------------------------------------------\r\n电化处：张育明 于 2014/7/4 10:01:57完成操作：\r\n--------------------------------------------------------------\r\n桥梁处：王新国 于 2014/7/4 10:05:37完成操作：\r\n--------------------------------------------------------------\r\n线站处：周天杰 于 2014/7/4 11:57:06完成操作：\r\n--------------------------------------------------------------\r\n建筑院：杨劲 于 2014/7/4 16:47:34完成操作：\r\n--------------------------------------------------------------\r\n地路处：刘坡拉 于 2014/7/4 17:15:56完成操作：\r\n--------------------------------------------------------------\r\n线站处：周天杰 于 2014/7/5 9:52:58完成操作：\r\n--------------------------------------------------------------\r\n线站处：周天杰 于 2014/7/5 9:53:28完成操作：\r\n--------------------------------------------------------------\r\n线站处：周天杰 于 2014/7/5 9:53:28完成操作：\r\n--------------------------------------------------------------\r\n环工处：王松林 于 2014/7/5 11:32:35完成操作：\r\n--------------------------------------------------------------\r\n电化处：管亚敏 于 2014/7/5 20:10:13完成操作：\r\n--------------------------------------------------------------\r\n建筑院：陈学民 于 2014/7/6 17:27:07完成操作：\r\n--------------------------------------------------------------\r\n电化处：温建民 于 2014/7/8 10:36:12完成操作：\r\n--------------------------------------------------------------\r\n\",\"JJBHQYJ\":\"\"}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-任务书】
​​​​​​​​<br /><br />type: 0=额外列表1")]
       public string Mobile_Jhgl_Rws_Detail_Ext(int type, string bdbm)
       {
           return " [{\"BDBM\":\"00000000000000126099\",\"CDBM\":\"CD_20140703000008\",\"CDMC\":\"第一测段\",\"FAMC\":\"孝感东至朋兴先行开工段定测\",\"XLLB\":\"新线\",\"KSLC\":\"CK47+400.00\",\"JSLC\":\"CK56+500.00\",\"XLCD\":\"9.10\",\"KSJD\":\"定测\",\"JLDW\":\"KM\",\"CDFAID\":10656,\"CDPXM\":1.0,\"KSLCDW\":\"CK\",\"JSLCDW\":\"CK\",\"KSLC1\":\"47\",\"KSLC2\":\"400.00\",\"JSLC1\":\"56\",\"JSLC2\":\"500.00\"}]";
       }
 
 
       [WebMethod(Description = @"<br />【计划管理-任务书】
<br /><br />//return: -2=失败、-1=不能操作、0=(提交至批准人、转其它人会签、退回至发起人、终止申报)、1=(同意下达、退回、转其它人会签、退回至发起人、终止申报)、2=会签")]
       public int Mobile_Jhgl_Rws_Submit_Right(string bdbm, string ryid)
       {
           return 0;
       }
 
       [WebMethod(Description = @"<br />【计划管理-任务书】
                               <br /><br />type: 0=转会签")]
       public string Mobile_Jhgl_Rws_Submit_Rys(int type, string bdbm, string ryid)
       {
           return "[{\"ryid\":\"002043\",\"text\":\"谌启发[002043]\",\"value\":\"\"},{\"ryid\":\"003747\",\"text\":\"段国华[003747]\",\"value\":\"\"},{\"ryid\":\"003010\",\"text\":\"高哲凝[003010]\",\"value\":\"\"},{\"ryid\":\"003017\",\"text\":\"胡栩彬[003017]\",\"value\":\"\"},{\"ryid\":\"002869\",\"text\":\"黄敏建[002869]\",\"value\":\"\"},{\"ryid\":\"002962\",\"text\":\"黄仁波[002962]\",\"value\":\"\"},{\"ryid\":\"001165\",\"text\":\"江立新[001165]\",\"value\":\"\"},{\"ryid\":\"002560\",\"text\":\"雷鸣[002560]\",\"value\":\"\"},{\"ryid\":\"000917\",\"text\":\"李国华[000917]\",\"value\":\"\"},{\"ryid\":\"003960\",\"text\":\"李天降[003960]\",\"value\":\"\"},{\"ryid\":\"003441\",\"text\":\"李艳[003441]\",\"value\":\"\"},{\"ryid\":\"004378\",\"text\":\"李雁艳[004378]\",\"value\":\"\"},{\"ryid\":\"003315\",\"text\":\"刘锋[003315]\",\"value\":\"\"},{\"ryid\":\"004392\",\"text\":\"刘锋[004392]\",\"value\":\"\"},{\"ryid\":\"002888\",\"text\":\"罗来前[002888]\",\"value\":\"\"},{\"ryid\":\"003977\",\"text\":\"马建文[003977]\",\"value\":\"\"},{\"ryid\":\"002756\",\"text\":\"彭瑞华[002756]\",\"value\":\"\"},{\"ryid\":\"003215\",\"text\":\"任前程[003215]\",\"value\":\"\"},{\"ryid\":\"003412\",\"text\":\"沈宏山[003412]\",\"value\":\"\"},{\"ryid\":\"002678\",\"text\":\"唐健[002678]\",\"value\":\"\"},{\"ryid\":\"003819\",\"text\":\"滕飞[003819]\",\"value\":\"\"},{\"ryid\":\"000786\",\"text\":\"王连群[000786]\",\"value\":\"\"},{\"ryid\":\"002656\",\"text\":\"吴刚[002656]\",\"value\":\"\"},{\"ryid\":\"003519\",\"text\":\"辛念[003519]\",\"value\":\"\"},{\"ryid\":\"003378\",\"text\":\"徐少颖[003378]\",\"value\":\"\"},{\"ryid\":\"002519\",\"text\":\"张孝雨[002519]\",\"value\":\"\"},{\"ryid\":\"002248\",\"text\":\"张在保[002248]\",\"value\":\"\"},{\"ryid\":\"002575\",\"text\":\"张志华[002575]\",\"value\":\"\"},{\"ryid\":\"002219\",\"text\":\"章涛松[002219]\",\"value\":\"\"},{\"ryid\":\"092279\",\"text\":\"王喆鹏[092279]\",\"value\":\"\"},{\"ryid\":\"002895\",\"text\":\"杜子荣[002895]\",\"value\":\"\"},{\"ryid\":\"002797\",\"text\":\"何晓春[002797]\",\"value\":\"\"},{\"ryid\":\"002460\",\"text\":\"周德宏[002460]\",\"value\":\"\"},{\"ryid\":\"003805\",\"text\":\"马涛[003805]\",\"value\":\"\"}]";
       }
 
       //[WebMethod(Description = @"<br />【计划管理-任务书】")]
       //public string Mobile_Jhgl_Rws_Submit_Ext(int type, string bdbm, string ryid)
       //{
       //    return TDataTable.Dt2Str(JhglFacade.GetJhglRwsSubmitExt(type, bdbm, ryid));
       //}
 
       [WebMethod(Description = @"<br />【计划管理-任务书】")]
       public int Mobile_Jhgl_Rws_Submit(int type, string bdbm, string ryid, string rys, string yj, string wParam, string lParam)
       {
           return 1;
       }
       #endregion
 
 
       #region 计划管理-作业表
       [WebMethod(Description = @"<br />【计划管理-作业表】
                               <br /><br />return: [待办, 已办, 已批准]")]
       public string Mobile_Jhgl_Zyb_Radio(string ryid)
       {
           return "111";
       }
 
       [WebMethod(Description = @"<br />【计划管理-作业表】
                               <br /><br />type: 0=待办, 1=已办, 2=已批准")]
       public string Mobile_Jhgl_Zyb_List(int type, string ryid, string xmmc, string startDate, string endDate, int pageIndex, int pageSize)
       {
           return "[{\"BDBM\":\"00000000000000035768\",\"TITLE\":\"武汉市轨道交通七号线一期工程土建工点\",\"TIME\":\"2014-07-14 18:13\"}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-作业表】")]
       public string Mobile_Jhgl_Zyb_Detail(string bdbm)
       {
           return "[{\"ID\":19817,\"BDBM\":\"00000000000000035768\",\"XMBM\":\"CGWUH064\",\"XMMC\":\"武汉市轨道交通七号线一期工程土建工点\",\"GZNR\":\"完成湖北大学站围护施工图\",\"YWLB\":\"S\",\"YWLBMC\":\"设计\",\"GZJD\":\"S\",\"GZJDMC\":\"施工图\",\"XMSH\":\"\",\"CJRXM\":\" \",\"CJSJ\":\"2014-07-14T18:13:26\",\"XMBM12\":\"CGWUH064SS\",\"ZTBZ\":\"0\",\"NF\":\"14\",\"LSH\":\"\",\"XMLSH\":\"YMJJR14\",\"JHSJ1\":\"2014-07-14\",\"JHSJ2\":\"2014-11-30\",\"CYZY\":\"城地院[总体、建筑、结构、暖通、隧道]，电化处[电力]\",\"CYZYBM\":\"1001,1005,1006,1007,1008,1204\",\"CJRQ\":\"2014-07-14\",\"PZR\":null,\"PZRRYID\":null,\"CJRID\":\"\",\"CLJL\":\"\r\n--------------------------------------------------------------\r\n总体：王文辉 于 2014/7/14 18:13:49完成操作:总体发布计表  意见/处理记录：总体给专册确认\r\n--------------------------------------------------------------\r\n城地院[总体]：李坤 于 2014/7/15 8:26:56完成操作:专册确认  意见/处理记录：\r\n--------------------------------------------------------------\r\n城地院[建筑]：范理纯 于 2014/7/15 9:57:20完成操作:专册确认  意见/处理记录：\r\n--------------------------------------------------------------\r\n城地院[结构]：李坤 于 2014/7/15 8:27:49完成操作:专册确认  意见/处理记录：\r\n--------------------------------------------------------------\r\n城地院[暖通]：王鑫 于 2014/7/14 19:07:48完成操作:专册确认  意见/处理记录：无意见\r\n--------------------------------------------------------------\r\n城地院[隧道]：孙雪兵 于 2014/7/14 20:55:55完成操作:专册确认  意见/处理记录：\r\n--------------------------------------------------------------\r\n电化处[电力]：马文芳 于 2014/7/14 18:44:00完成操作:专册确认  意见/处理记录：同意\r\n--------------------------------------------------------------\r\n总体：王文辉 于 2014/7/15 14:23:59完成操作:总体汇总  意见/处理记录：\r\n--------------------------------------------------------------\r\n技术中心：王华成 于 2014/7/15 16:28:18完成操作:技术中心审核  意见/处理记录：\r\n--------------------------------------------------------------\r\n院总：熊朝辉 于 完成操作:院总审核  意见/处理记录：院总审核\r\n--------------------------------------------------------------\r\n院总 ：熊朝辉 于2014-07-16 08:28:18 同意 处理意见：无\",\"CURCLR\":\"003418,003387,\",\"YCLR\":null,\"ZTZBM\":\"10000000000000122995\",\"SM\":\"1、本次计表我院独立完成7号线一期工程湖北大学站施工图内容。湖北大学站按与湖北大学地道分离方案设计围护施工图，预留今后湖北大学地道实施条件，但不考虑两者围护合建。徐家棚站按照自己车站本身的设计要求进行车站宽度、长度设计。设计内容及范围包括：湖北学站主体围护施工图；车站配合围护建筑图。参与专业：建筑、结构、通风空调、给排水与消防、电力、区间隧道等专业。\r\n2、本次设计时间紧、任务重，业主要求水平高，望各专业积极主动，保质保量按时完成设计任务。\r\n3、设计牵涉专业多，请各专业充分研究方案，及时沟通，防止因局部变化引起多专业的修改，并请各专业主动与总包总体、各系统专业沟通，确保设计的稳定。\r\n4、相邻区间隧道专业及湖北大学站附属相关计表另行启动。隧道专业负责协调车站外我院区间隧道接入条件，保证车站的稳定。\r\n5、设计过程中涉及与各系统单位接口，需要相关专业设计应以纸质联系单形式提交工点外系统，并督促外专业反馈资料，尽早封闭设计接口。\r\n6、设计过程中需完成初步设计及咨询单位专家审查意见回复及落实。设计过程中一方面要积极对外协调，一方面要全面考虑以减小返工量。\r\n7、车站主体施工图送审应按照咨询单位对送审文件的要进行，完成必要的会签程序，同时注意车站建筑送咨询应在车站主体结构送咨询之前或同时进行。\r\n8、作业表未尽事宜，请各专业之间及与总体相互协商，密切配合，按期完成任务。\",\"IsNeedSynRGS\":\"是\",\"ZTZBM1\":\"10000000000000122995\",\"ZTZQC\":\"武汉市轨道交通七号线一期工程土建工点总体组\",\"GSSJ1\":null,\"GSSJ2\":null,\"XMLX\":\"YKXM\",\"JJBHQYJ\":null,\"GZLBDBM\":\"ZYB_20140714000003\",\"GZLTBRXM\":\"王文辉\",\"GSZTZBM\":null,\"GSZTZMC\":null,\"SynYTHTime\":null}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-作业表】")]
       public string Mobile_Jhgl_Zyb_Detail_Ext(int type, string bdbm)
       {
           return "[{\"ID\":120637,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[建筑]\",\"ZYDM\":\"1005\",\"WJMC\":\"主体建筑图纸总图、平剖面资料（围护用初提）\",\"SJJFRQ\":\"2014-07-16\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[总体、结构、暖通、隧道]，电化处[电力]\",\"AcceptZYMBS\":\"1001,1006,1007,1008,1204\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4005.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":1,\"TZBGBDBM\":null},{\"ID\":120638,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[建筑]\",\"ZYDM\":\"1005\",\"WJMC\":\"主体建筑图纸总图、平剖面资料（围护用终提）\",\"SJJFRQ\":\"2014-07-25\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[总体、结构、暖通、隧道]，电化处[电力]\",\"AcceptZYMBS\":\"1001,1006,1007,1008,1204\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4005.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":2,\"TZBGBDBM\":null},{\"ID\":120639,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[建筑]\",\"ZYDM\":\"1005\",\"WJMC\":\"主体建筑图纸文件交付总体组会签\",\"SJJFRQ\":\"2014-07-31\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[总体]\",\"AcceptZYMBS\":\"1001\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4005.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":3,\"TZBGBDBM\":null},{\"ID\":120640,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[结构]\",\"ZYDM\":\"1006\",\"WJMC\":\"主体建筑图纸针对初提资料提出意见\",\"SJJFRQ\":\"2014-07-18\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[建筑]\",\"AcceptZYMBS\":\"1005\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4006.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":1,\"TZBGBDBM\":null},{\"ID\":120641,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[结构]\",\"ZYDM\":\"1006\",\"WJMC\":\"围护结构总体组会签\",\"SJJFRQ\":\"2014-08-04\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[总体]\",\"AcceptZYMBS\":\"1001\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4006.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":2,\"TZBGBDBM\":null},{\"ID\":120642,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[结构]\",\"ZYDM\":\"1006\",\"WJMC\":\"围护结构施工图\",\"SJJFRQ\":\"2014-08-11\",\"ActualDate\":null,\"AcceptZYS\":\"广州院咨询\",\"AcceptZYMBS\":\"\",\"NOTE\":\"\",\"RWLB\":8,\"RWLBMC\":\"最终成果任务\",\"PXM\":4006.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":3,\"TZBGBDBM\":null},{\"ID\":120643,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[暖通]\",\"ZYDM\":\"1007\",\"WJMC\":\"主体建筑图纸针对初提资料提出意见\",\"SJJFRQ\":\"2014-07-18\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[建筑]\",\"AcceptZYMBS\":\"1005\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4007.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":1,\"TZBGBDBM\":null},{\"ID\":120644,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"城地院[隧道]\",\"ZYDM\":\"1008\",\"WJMC\":\"主体建筑图纸针对初提资料提出意见\",\"SJJFRQ\":\"2014-07-18\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[建筑]\",\"AcceptZYMBS\":\"1005\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":4008.0,\"DWDM\":\"0034000459\",\"DWMC\":\"城地院\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":1,\"TZBGBDBM\":null},{\"ID\":120645,\"BDBM\":\"00000000000000035768\",\"ZYMC\":\"电化处[电力]\",\"ZYDM\":\"1204\",\"WJMC\":\"主体建筑图纸针对初提资料提出意见\",\"SJJFRQ\":\"2014-07-18\",\"ActualDate\":null,\"AcceptZYS\":\"城地院[建筑]\",\"AcceptZYMBS\":\"1005\",\"NOTE\":\"\",\"RWLB\":0,\"RWLBMC\":\"提交资料任务\",\"PXM\":7025.0,\"DWDM\":\"0034000014\",\"DWMC\":\"电化处\",\"TZBGBJ\":null,\"TZBGCreateID\":null,\"XH\":1,\"TZBGBDBM\":null}]";
       }
 
       [WebMethod(Description = @"<br />【计划管理-作业表】
<br /><br />return: -2=失败、-1=不能操作、0=(提交至批准人、转其它人会签、退回至发起人、终止申报)、1=(同意下达、退回、转其它人会签、退回至发起人、终止申报)、2=会签")]
       public int Mobile_Jhgl_Zyb_Submit_Right(string bdbm, string ryid)
       {
           return 0;
       }
 
       [WebMethod(Description = @"<br />【计划管理-作业表】
                               <br /><br />type: 0=转会签")]
       public string Mobile_Jhgl_Zyb_Submit_Rys(int type, string bdbm, string ryid)
       {
           return "[{\"ryid\":\"002043\",\"text\":\"谌启发[002043]\",\"value\":\"\"},{\"ryid\":\"003747\",\"text\":\"段国华[003747]\",\"value\":\"\"},{\"ryid\":\"003010\",\"text\":\"高哲凝[003010]\",\"value\":\"\"},{\"ryid\":\"003017\",\"text\":\"胡栩彬[003017]\",\"value\":\"\"},{\"ryid\":\"002869\",\"text\":\"黄敏建[002869]\",\"value\":\"\"},{\"ryid\":\"002962\",\"text\":\"黄仁波[002962]\",\"value\":\"\"},{\"ryid\":\"001165\",\"text\":\"江立新[001165]\",\"value\":\"\"},{\"ryid\":\"002560\",\"text\":\"雷鸣[002560]\",\"value\":\"\"},{\"ryid\":\"000917\",\"text\":\"李国华[000917]\",\"value\":\"\"},{\"ryid\":\"003960\",\"text\":\"李天降[003960]\",\"value\":\"\"},{\"ryid\":\"003441\",\"text\":\"李艳[003441]\",\"value\":\"\"},{\"ryid\":\"004378\",\"text\":\"李雁艳[004378]\",\"value\":\"\"},{\"ryid\":\"003315\",\"text\":\"刘锋[003315]\",\"value\":\"\"},{\"ryid\":\"004392\",\"text\":\"刘锋[004392]\",\"value\":\"\"},{\"ryid\":\"002888\",\"text\":\"罗来前[002888]\",\"value\":\"\"},{\"ryid\":\"003977\",\"text\":\"马建文[003977]\",\"value\":\"\"},{\"ryid\":\"002756\",\"text\":\"彭瑞华[002756]\",\"value\":\"\"},{\"ryid\":\"003215\",\"text\":\"任前程[003215]\",\"value\":\"\"},{\"ryid\":\"003412\",\"text\":\"沈宏山[003412]\",\"value\":\"\"},{\"ryid\":\"002678\",\"text\":\"唐健[002678]\",\"value\":\"\"},{\"ryid\":\"003819\",\"text\":\"滕飞[003819]\",\"value\":\"\"},{\"ryid\":\"000786\",\"text\":\"王连群[000786]\",\"value\":\"\"},{\"ryid\":\"002656\",\"text\":\"吴刚[002656]\",\"value\":\"\"},{\"ryid\":\"003519\",\"text\":\"辛念[003519]\",\"value\":\"\"},{\"ryid\":\"003378\",\"text\":\"徐少颖[003378]\",\"value\":\"\"},{\"ryid\":\"002519\",\"text\":\"张孝雨[002519]\",\"value\":\"\"},{\"ryid\":\"002248\",\"text\":\"张在保[002248]\",\"value\":\"\"},{\"ryid\":\"002575\",\"text\":\"张志华[002575]\",\"value\":\"\"},{\"ryid\":\"002219\",\"text\":\"章涛松[002219]\",\"value\":\"\"},{\"ryid\":\"092279\",\"text\":\"王喆鹏[092279]\",\"value\":\"\"},{\"ryid\":\"002895\",\"text\":\"杜子荣[002895]\",\"value\":\"\"},{\"ryid\":\"002797\",\"text\":\"何晓春[002797]\",\"value\":\"\"},{\"ryid\":\"002460\",\"text\":\"周德宏[002460]\",\"value\":\"\"},{\"ryid\":\"003805\",\"text\":\"马涛[003805]\",\"value\":\"\"}]";
       }
 
       //[WebMethod(Description = @"<br />【计划管理-作业表】")]
       //public string Mobile_Jhgl_Zyb_Submit_Ext(int type, string bdbm, string ryid)
       //{
       //    return TDataTable.Dt2Str(JhglFacade.GetJhglZybSubmitExt(type, bdbm, ryid));
       //}
 
       [WebMethod(Description = @"<br />【计划管理-作业表】")]
       public int Mobile_Jhgl_Zyb_Submit(int type, string bdbm, string ryid, string rys, string yj, string wParam, string lParam)
       {
           return 1;
       }
       #endregion
 
       #endregion

    }
}
