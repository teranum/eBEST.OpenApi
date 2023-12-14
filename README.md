# [![NuGet version](https://badge.fury.io/nu/eBEST.OpenApi.png)](https://badge.fury.io/nu/eBEST.OpenApi) eBEST.OpenApi C# Wrapper

eBEST.OpenApi는 eBEST OpenAPI를 C#에서 사용하기 위한 Wrapper입니다.

## 개발환경
Visual Studio 2022, NET8.0

## 사용법

### 1. eBEST.OpenApi nuget 패키지를 참조합니다.
	(InOutBlocks, TR Models 확장 용 사용 시에는 eBEST.OpenApi.Models 패키지를 참조)
### 2. eBEST.OpenApi.OpenApi 클래스를 생성합니다.
### 3. 로그인후 TR을 요청합니다.

	* 일부TR응답 데이터가 매뉴얼과 실제응답이 차이나는 경우가 있습니다. 확인 후 사용하시기 바랍니다.

```csharp
	_client = new eBEST.OpenApi.EBestOpenApi();
	_client.OnConnectEvent += (sender, e) =>
	{
		if (e.Ok)
		{
			// 로그인 성공
		}
		else
		{
			// 로그인 실패
		}
	};

	// 로그인
	_client.ConnectAsync(AccKey, AccSecretKey);

	// TR 요청
	t1102 주식현재가 = new()
	{
		t1102InBlock = new(code),
	};
	_client.GetTRData(주식현재가).Wait();
	if (주식현재가.t1102OutBlock != null)
	{
		ResultText = $"\r\n{주식현재가.t1102OutBlock}";
	}
	
```

![](./Samples/img/run-001.png)

![](./Samples/img/run-002.png)

![](./Samples/img/run-003.png)

![](./Samples/img/run-004.png)
