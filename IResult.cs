
using System;
using System.Text.Json.Serialization;

namespace iml6yu.Result
{
    /// <summary>
    /// 通用结果接口
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// 状态码
        ///1XX:Infomational（信息性状态码）接收的请求正在处理 ，
        ///2XX:Success（成功状态码）请求正常处理完毕,默认200表示成功 ，
        ///3XX:Redirection（重定向状态码）需要进行附加操作以完成请求 ，
        ///4XX:Client Error（客户端错误状态码）服务器无法处理请求 ，
        ///5XX:Server Error（服务器错误状态码）服务器处理请求出错
        /// </summary>
        int Code { get; set; }
        /// <summary>
        /// 操作状态
        /// true:成功，
        /// false:失败
        /// </summary>

        bool State { get; set; }

        /// <summary>
        /// 结果消息
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [JsonIgnore]
        Exception Error { get; set; }

    }
}