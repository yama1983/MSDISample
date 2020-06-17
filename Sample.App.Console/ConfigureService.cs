using System;
using Microsoft.Extensions.DependencyInjection;
using Sample.Domain;

namespace Sample.App.Console
{
    public class ConfigureService
    {
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection
#if PATTERN_1
                // .AddSingleton<IInteger>(provider => new Integer(1)) // 引数を渡す場合
                .AddSingleton<IInteger, Integer>() // デフォルトコンストラクタ使用
                // .AddSingleton<ISampleService>(provider => new SampleService(provider.GetRequiredService<IInteger>())) // DIから値を取得して初期化
                .AddSingleton<ISampleService, SampleService>() // ↑みたいなことしなくても普通の記述で勝手にDIから参照してくれる。
#endif
#if PATTERN_2
                .AddTransient<IInteger, Integer>()
                .AddTransient<ISampleService, SampleService>()
#endif
#if PATTERN_3
                .AddTransient<IInteger, Integer>()
                .AddSingleton<ISampleService, SampleService>()
#endif
#if PATTERN_4
                .AddSingleton<IInteger, Integer>()
                .AddTransient<ISampleService, SampleService>()
#endif
                ;


            return serviceCollection.BuildServiceProvider();
        }
    }
}
