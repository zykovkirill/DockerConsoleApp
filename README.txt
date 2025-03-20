Пример показывающий настройку конфигурации через переменные окружения и json файла.

1) Переменные окружения в .dockerfile

   DockerConsoleApp:
		InnerTest__TestString=DockerConsoleApp-test-Env-Docker
		InnerTests__1__TestString=DockerConsoleApp-Test2-Docker

   DockerConsoleApp1:
		Secret=DockerConsoleApp1-Secret-Env-Docker
		InnerTest__TestString=DockerConsoleApp1-test-Env-Docker

2) Переменные окружения в .yml

   DockerConsoleApp:
		dockerconsoleapp=dockerconsoleapp-env-yml
		BigSecret=dockerconsoleapp-BigSecret-env-yml
		InnerTests__0__TestInt=200
		InnerTests__0__TestString=DockerConsoleApp-Test1-yml
   DockerConsoleApp1:
		dockerconsoleapp1=dockerconsoleapp1-env-yml
		BigSecret=dockerconsoleapp1-BigSecret-env-yml
3) Переменные окружения в .env

   dockerconsoleappFILE=sql-i-05;Database=coreDB;Integrated Security=true;TrustServerCertificate=True

4) Переменные окружения в .json

   DockerConsoleApp:
		{
		  "Secret": "DockerConsoleApp-Secret-json",
		  "BigSecret": "DockerConsoleApp-BigSecret-json",
		  "VeryBigSecret": "DockerConsoleApp-VeryBigSecret-json",
		  "InnerTest": {
		    "TestInt": 0,
		    "TestString": "DockerConsoleApp-Test-json"
		  },
		  "InnerTests": [
		    {
		      "TestInt": 1,
		      "TestString": "DockerConsoleApp-Test1-json"
		    },
		    {
		      "TestInt": 2,
		      "TestString": "DockerConsoleApp-Test2-json"
		    }
		  ]
		}

   DockerConsoleApp1:
	    {
		  "Secret": "DockerConsoleApp1-Secret-json",
		  "BigSecret": "DockerConsoleApp1-BigSecret-json",
		  "VeryBigSecret": "DockerConsoleApp1-VeryBigSecret-json",
		  "InnerTest": {
		    "TestInt": 0,
		    "TestString": "DockerConsoleApp1-Test-json"
		  },
		  "InnerTests": [
		    {
		      "TestInt": 1,
		      "TestString": "DockerConsoleApp1-Test1-json"
		    },
		    {
		      "TestInt": 2,
		      "TestString": "DockerConsoleApp1-Test2-json"
		    }
		  ]
		}


Вывод программы:

DockerConsoleApp1 | ------------
DockerConsoleApp1 | 
DockerConsoleApp1 | dockerconsoleapp1-env-yml
DockerConsoleApp1 | ------------
DockerConsoleApp1 | ------------
DockerConsoleApp1 | DockerConsoleApp1-Test1-json
DockerConsoleApp1 | 1
DockerConsoleApp1 | DockerConsoleApp1-Test2-json
DockerConsoleApp1 | 2
DockerConsoleApp1 | ------------
DockerConsoleApp1 | DockerConsoleApp1-Secret-Env-Docker
DockerConsoleApp | 2025-03-20T15:09:13.761344030Z ------------
DockerConsoleApp1 | dockerconsoleapp1-BigSecret-env-yml
DockerConsoleApp | 2025-03-20T15:09:13.761397778Z sql-i-01;Database=coreDB;Integrated Security=true;TrustServerCertificate=True
DockerConsoleApp1 | DockerConsoleApp1-VeryBigSecret-json
DockerConsoleApp | 2025-03-20T15:09:13.761400543Z 
DockerConsoleApp | 2025-03-20T15:09:13.761401956Z sql-i-05;Database=coreDB;Integrated Security=true;TrustServerCertificate=True
DockerConsoleApp | 2025-03-20T15:09:13.761403076Z ------------
DockerConsoleApp | 2025-03-20T15:09:13.876149769Z ------------
DockerConsoleApp | 2025-03-20T15:09:13.876204334Z DockerConsoleApp-Test1-yml
DockerConsoleApp | 2025-03-20T15:09:13.876209926Z 200
DockerConsoleApp | 2025-03-20T15:09:13.876212531Z DockerConsoleApp-Test2-Docker
DockerConsoleApp | 2025-03-20T15:09:13.876215109Z 2
DockerConsoleApp | 2025-03-20T15:09:13.876217700Z ------------
DockerConsoleApp1 | DockerConsoleApp1-test-Env-Docker
DockerConsoleApp1 | ------------
DockerConsoleApp | 2025-03-20T15:09:13.876220259Z DockerConsoleApp-Secret-Env-Docker
DockerConsoleApp | 2025-03-20T15:09:13.876222759Z dockerconsoleapp-BigSecret-env-yml
DockerConsoleApp | 2025-03-20T15:09:13.876225171Z DockerConsoleApp-VeryBigSecret-json
DockerConsoleApp | 2025-03-20T15:09:13.876227759Z DockerConsoleApp-test-Env-Docker
DockerConsoleApp | 2025-03-20T15:09:13.876239551Z ------------


Продвинутые настройки https://docs.docker.com/compose/how-tos/environment-variables/envvars-precedence/#advanced-example