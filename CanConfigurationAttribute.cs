using System;

namespace iml6yu.Result
{
    /// <summary>
    /// 能够用于配置的类
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class CanConfigurationAttribute:Attribute
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description { get; set; } 
    }
}
