
using iml6yu.Result.i18n;
using System;
using System.Text.Json.Serialization;

namespace iml6yu.Result
{
    /// <summary>
    /// 单一数据结果
    /// @author 刘会东
    /// </summary>
    public class DataResult<TData> : EventArgs, IResult
    {

        /// <summary>
        /// 单一数据结果
        /// </summary>
        public DataResult()
        {
        }

        /// <summary>
        /// 单一数据结果
        /// </summary>
        /// <param name="code">状态码</param>
        /// <param name="state">是否成功</param>
        /// <param name="message">消息内容</param>
        /// <param name="error">异常信息</param>
        /// <param name="datas">数据</param>
        public DataResult(int code, bool state, string message, TData datas, Exception error = null)
        {
            Code = code;
            State = state;
            Message = message;
            Error = error;
            Data = datas;
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
        [JsonIgnore]
        public Exception Error { get; set; }

        /// <summary>
        /// 数据
        /// </summary> 
        public TData Data { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static DataResult<TData> Success(TData data)
        {
            return new DataResult<TData>(200, true, lang.Success, data);
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static DataResult<TData> Success(TData data, ResultType result, string message = null)
        {
            return new DataResult<TData>((int)result, true, message ?? "", data);
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataResult<TData> Failed(int code, string message, Exception ex = null, TData data = default(TData))
        {
            return new DataResult<TData>(code, false, message ?? "", data, ex);
        }




        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="result">  </param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataResult<TData> Failed(ResultType result, string message, Exception ex = null, TData data = default(TData))
        {
            return Failed((int)result, message, ex, data);
        }
    }
}