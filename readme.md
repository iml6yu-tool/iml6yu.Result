# iml6yu.Result
这是一个统一的返回结果类，用于统一返回结果的格式。		

## MessageResult 消息结果

### 1. 成功返回结果
```C#
	MessageResult.Success();
```
返回结果：
```json
{
  "code": 200,
  "message": "success",
  "state": true
}
```

### 2. 失败返回结果
```C#
	MessageResult.Fail(ResultType.Failed,message,exception);
```	
返回结果：
```json
{
  "code": 500,
  "message": message,
  "state": false,
  "error": exception
}
```

##  DataResult 单一数据结果
用法同MessageResult，只是返回结果多了一个data属性，用于返回单一数据。

##  CollectionResult 集合数据结果
用法同MessageResult
返回结果多了
- data属性，用于返回集合数据。	
- pageindex属性，用于返回当前页码。
- pagesize属性，用于返回每页数据量。
- total属性，用于返回总数据量。