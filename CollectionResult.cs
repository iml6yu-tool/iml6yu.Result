
using iml6yu.Result.i18n;
using System;
using System.Collections.Generic;

namespace iml6yu.Result
{
    /// <summary>
    /// 数据列表结果
    /// @author 刘会东
    /// </summary>
    public class CollectionResult<TData> : EventArgs, IResult where TData : class
    {

        /// <summary>
        /// 数据列表结果
        /// </summary>
        public CollectionResult()
        {
        }

        /// <summary>
        /// 数据列表结果
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <param name="message"></param>
        /// <param name="datas"></param>
        /// <param name="total"></param>
        /// <param name="totalPage"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="error"></param>
        public CollectionResult(int code, bool state, string message, List<TData> datas, int total, int totalPage, int pageIndex, int pageSize, Exception error = null)
        {
            Code = code;
            State = state;
            Message = message;
            Error = error;
            Datas = datas;
            Total = total;
            TotalPage = totalPage;
            PageIndex = pageIndex;
            PageSize = pageSize;
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
        /// 数据
        /// </summary> 
        public List<TData> Datas { get; set; }
        /// <summary>
        /// 总数居量
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage { get; set; }

        /// <summary>
        /// 页索引
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; }



        /// <summary>
        /// 成功
        /// </summary>
        /// <param name="pageindex">入参中的pageindex</param>
        /// <param name="pagesize">入参中的pagesize</param>
        /// <param name="datas">数据</param>
        /// <param name="total">总记录数</param>
        /// <returns></returns>
        public static CollectionResult<TData> Success(int pageindex, int pagesize, List<TData> datas, int total)
        {
            return new CollectionResult<TData>(200, true, lang.Success, datas, total, (int)Math.Ceiling(total * 1.0d / pagesize), pageindex, pagesize);
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static CollectionResult<TData> Success(int pageindex, int pagesize, List<TData> datas, int total, ResultType result, string message = null)
        {
            return new CollectionResult<TData>((int)result, true, message ?? typeof(lang).GetProperty("Code" + (int)result, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.GetProperty)?.GetValue(null)?.ToString() ?? "", datas, total, (int)Math.Ceiling(total * 1.0d / pagesize), pageindex, pagesize);
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static CollectionResult<TData> Failed(int code, string message, Exception ex = null)
        {
            return new CollectionResult<TData>(code, false, message ?? typeof(lang).GetProperty("Code" + code, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.GetProperty)?.GetValue(null)?.ToString() ?? "", null, 0, 0, 0, 0, ex);
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="result">  </param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static CollectionResult<TData> Failed(ResultType result, string message, Exception ex = null)
        {
            return Failed((int)result, message, ex);
        }
    }
}