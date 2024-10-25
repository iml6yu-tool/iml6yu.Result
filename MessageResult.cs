
using iml6yu.Result.i18n;
using System;

namespace iml6yu.Result
{
    /// <summary>
    /// 通用消息结果
    /// @author 刘会东
    /// </summary>
    public class MessageResult : EventArgs, IResult
    {

        /// <summary>
        /// 通用消息结果
        /// </summary>
        public MessageResult()
        {
        }

        /// <summary>
        /// 通用消息结果
        /// </summary>
        /// <param name="code">状态码</param>
        /// <param name="state">是否成功</param>
        /// <param name="message">消息内容</param>
        /// <param name="error"></param>
        public MessageResult(int code, bool state, string message, Exception error = null)
        {
            Code = code;
            State = state;
            Message = message;
            Error = error;
        }

        /// <summary>
        /// 状态码
        ///1XX:Infomational（信息性状态码）接收的请求正在处理 ，
        ///2XX:Success（成功状态码）请求正常处理完毕,默认200表示成功 ，
        ///3XX:Redirection（重定向状态码）需要进行附加操作以完成请求 ，
        ///4XX:Client Error（客户端错误状态码）服务器无法处理请求 ，
        ///5XX:Server Error（服务器错误状态码）服务器处理请求出错
        /// </summary>
        public int Code { get; set; } = 200;
        /// <summary>
        /// 操作状态
        /// true:成功，
        /// false:失败
        /// </summary>

        public bool State { get; set; } = true;

        /// <summary>
        /// 结果消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public Exception Error { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static MessageResult Success()
        {
            return new MessageResult(200, true, lang.Success);
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static MessageResult Success(ResultType result, string message = null)
        {
            return new MessageResult((int)result, true, message ?? typeof(lang).GetProperty("Code" + (int)result, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.GetProperty)?.GetValue(null)?.ToString() ?? "");
        }
        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="code"> 
        /// 状态码
        ///1XX:Infomational（信息性状态码）接收的请求正在处理 ，
        ///2XX:Success（成功状态码）请求正常处理完毕,默认200表示成功 ，
        ///3XX:Redirection（重定向状态码）需要进行附加操作以完成请求 ，
        ///4XX:Client Error（客户端错误状态码）服务器无法处理请求 ，
        ///5XX:Server Error（服务器错误状态码）服务器处理请求出错 
        /// </param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static MessageResult Failed(int code, string message, Exception ex)
        {
            return new MessageResult(code, false, message ?? typeof(lang).GetProperty("Code" + code, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.GetProperty)?.GetValue(null)?.ToString() ?? "", ex);
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="result">  </param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static MessageResult Failed(ResultType result, string message, Exception ex)
        {
            return Failed((int)result, message, ex);
        }
    }
}