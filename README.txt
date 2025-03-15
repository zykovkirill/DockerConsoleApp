Пример показывающий настройку конфигурации через переменные окружения и json файла.

1) Переменные окружения в .dockerfile
2) Переменные окружения в .yml
3) Переменные окружения в .json

Вывод программы:

DockerConsoleApp1 | ------------
DockerConsoleApp1 | 
DockerConsoleApp1 | dockerconsoleapp1-env-yml
DockerConsoleApp1 | ------------
DockerConsoleApp | 2025-03-15T12:38:19.718434935Z ------------
DockerConsoleApp | 2025-03-15T12:38:19.718471258Z dockerconsoleapp-env-yml
DockerConsoleApp | 2025-03-15T12:38:19.718473335Z 
DockerConsoleApp | 2025-03-15T12:38:19.718474533Z ------------
DockerConsoleApp1 | ------------
DockerConsoleApp1 | DockerConsoleApp1-Test1-json
DockerConsoleApp1 | 1
DockerConsoleApp1 | DockerConsoleApp1-Test2-json
DockerConsoleApp1 | 2
DockerConsoleApp1 | ------------
DockerConsoleApp1 | DockerConsoleApp1-Secret-Env-Docker
DockerConsoleApp1 | dockerconsoleapp1-BigSecret-env-yml
DockerConsoleApp1 | DockerConsoleApp1-VeryBigSecret-json
DockerConsoleApp1 | DockerConsoleApp1-test-Env-Docker
DockerConsoleApp1 | ------------
DockerConsoleApp | 2025-03-15T12:38:19.822719021Z ------------
DockerConsoleApp | 2025-03-15T12:38:19.822742742Z DockerConsoleApp-Test1-yml
DockerConsoleApp | 2025-03-15T12:38:19.822744115Z 200
DockerConsoleApp | 2025-03-15T12:38:19.822745181Z DockerConsoleApp-Test2-Docker
DockerConsoleApp | 2025-03-15T12:38:19.822746264Z 2
DockerConsoleApp | 2025-03-15T12:38:19.822747305Z ------------
DockerConsoleApp | 2025-03-15T12:38:19.822748371Z DockerConsoleApp-Secret-Env-Docker
DockerConsoleApp | 2025-03-15T12:38:19.822749434Z dockerconsoleapp-BigSecret-env-yml
DockerConsoleApp | 2025-03-15T12:38:19.822750485Z DockerConsoleApp-VeryBigSecret-json
DockerConsoleApp | 2025-03-15T12:38:19.822751578Z DockerConsoleApp-test-Env-Docker
DockerConsoleApp | 2025-03-15T12:38:19.822753136Z ------------

Продвинутые настройки https://docs.docker.com/compose/how-tos/environment-variables/envvars-precedence/#advanced-example