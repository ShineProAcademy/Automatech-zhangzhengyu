namespace AutoMatech.DataRepository.Interface;

/// <summary>
/// 抽象数据仓储
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="TKey"></typeparam>
public interface IDataRepository<T, TKey>
{
    /// <summary>
    /// 加载
    /// </summary>
    void Load();

    /// <summary>
    /// 保存
    /// </summary>
    void Save();
    
    /// <summary>
    /// 查找所有
    /// </summary>
    /// <returns></returns>
    IEnumerable<T> GetAll();

    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    bool Add(T model);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    bool Remove(T model);

    /// <summary>
    /// 按主键查找
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    T Get(TKey key);

    /// <summary>
    /// 更新
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    bool Update(T model);
}