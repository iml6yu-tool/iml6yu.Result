using System.ComponentModel;

namespace iml6yu.Result
{
    /// <summary>
    /// 类型
    /// </summary>
    public enum ResultType
    {
        ///<summary>
        ///	操作成功，但并没有引起数据变化
        ///</summary>
        Code201 = 201,
        ///<summary>
        ///	操作已接受，等待后台异步处理
        ///</summary>
        Code202 = 202,
        ///<summary>
        ///	错误请求
        ///</summary>
        Code400 = 400,
        ///<summary>
        ///	请求授权失败
        ///</summary>
        Code401 = 401,
        ///<summary>
        ///	请求不允许
        ///</summary>
        Code403 = 403,
        ///<summary>
        ///	没有发现文件
        ///</summary>
        Code404 = 404,
        ///<summary>
        ///	客户端没有在用户指定的的时间内完成请求
        ///</summary>
        Code408 = 408,
        ///<summary>
        ///	请求的资源大于服务器允许的大小
        ///</summary>
        Code413 = 413,
        ///<summary>
        ///	请求资源不支持请求项目格式
        ///</summary>
        Code415 = 415,

        ///<summary>
        ///	服务器不支持请求的函数
        ///</summary>
        Code501 = 501,
        ///<summary>
        ///	服务器暂时不可用，有时是为了防止发生系统过载
        ///</summary>
        Code502 = 502,
        ///<summary>
        ///	服务器过载或暂停维修
        ///</summary>
        Code503 = 503,
        ///<summary>
        ///	关口过载，服务器使用另一个关口或服务来响应用户，等待时间设定值较长
        ///</summary>
        Code504 = 504,
        ///<summary>
        ///	服务器未实现当前功能
        ///</summary>
        Code505 = 505,
        ///<summary>
        ///	失败
        ///</summary>
        Failed = 500,
        ///<summary>
        ///	成功
        ///</summary>
        Success = 200,

         
        ///<summary>
        ///参数错误
        ///</summary>
        ParameterError = 300,
        ///<summary>
        ///数据重复
        ///</summary>
        RepetitiveData = 301,
        ///<summary>
        ///参数验证失败
        ///</summary>
        VerifyFailed = 302,
        ///<summary>
        ///验证码错误
        ///</summary>
        VerifyCodeError = 303,
        ///<summary>
        ///验证码已超时
        ///</summary>
        VerifyCodeTimeOut = 304,
        ///<summary>
        ///系统数据配置异常
        ///</summary>
        SystemConfigError = 550,

        ///<summary>
        ///登录失败
        ///</summary>
        SignError = 410,
        ///<summary>
        ///用户凭证已失效
        ///</summary>
        VerifyTokenFailed = 411,
        ///<summary>
        ///当前账户已存在
        ///</summary>
        AccountExisted = 420,
        ///<summary>
        ///当前数据不存在
        ///</summary>
        NotFind = 405,
        ///<summary>
        ///当前用户信息未审核
        ///</summary>
        AccountNotChecked = 412,
        ///<summary>
        ///当前用户信息已失效
        ///</summary>
        SignInfoDisable = 413,
        ///<summary>
        ///当前账户不存在
        ///</summary>
        AccountNotFind = 414,
        ///<summary>
        ///无权访问此地址
        ///</summary>
        NotAuthrith = 415,

        ///<summary>
        ///服务器未知异常
        ///</summary>
        ServerUnKonwError = 510,
        ///<summary>
        ///网络原因导致结果不正确请重新操作
        ///</summary>
        ServerNetworkError = 600,
        ///<summary>
        ///调起网络其他API的时候发生的异常
        ///</summary>
        ServerDoApiError = 601,
        ///<summary>
        ///接口数据异常
        ///</summary>
        ServerInterfaceError = 602,
        ///<summary>
        ///该功能未实现
        ///</summary>
        NotImplemented = 506
    }
}
