
using System;
using System.Text.Json.Serialization;

namespace iml6yu.Result
{
    /// <summary>
    /// ͨ�ý���ӿ�
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// ״̬��
        ///1XX:Infomational����Ϣ��״̬�룩���յ��������ڴ��� ��
        ///2XX:Success���ɹ�״̬�룩���������������,Ĭ��200��ʾ�ɹ� ��
        ///3XX:Redirection���ض���״̬�룩��Ҫ���и��Ӳ������������ ��
        ///4XX:Client Error���ͻ��˴���״̬�룩�������޷��������� ��
        ///5XX:Server Error������������״̬�룩�����������������
        /// </summary>
        int Code { get; set; }
        /// <summary>
        /// ����״̬
        /// true:�ɹ���
        /// false:ʧ��
        /// </summary>

        bool State { get; set; }

        /// <summary>
        /// �����Ϣ
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// �쳣��Ϣ
        /// </summary>
        [JsonIgnore]
        Exception Error { get; set; }

    }
}