

namespace EFDemo.DbModels
{
    /// <summary>
    /// 数据库的表结构模型
    /// </summary>
    public class DbTable
    {
        /// <summary>
        ///  数据的主键 [Id] EF 默认的
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
