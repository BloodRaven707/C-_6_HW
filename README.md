# Команды для терминала

## С# Создание и запуск приложения

- dotnet new console
- dotnet run

## GIT Создание и выгрузка на сервер GitHub локального репозитория

- git init
- git add .
- git commit -m "Initial commit"
- git remote add origin https://github.com/BloodRaven707/<название_репозитория>.git
- git branch -M main
- git push -u origin main

<br>

# Заметки

## Описание функции C# 

- ``<summary>Описание функции</summary>``
- ``<param name="имя_переменной">Описание аргумента</param>``
- ``<returns>Описание вывода</returns>``

<br>

## Шаблон C# для Program.cs

```
namespace Console_Program
{
    class Project
    {
        /// <summary>Описание функции</summary>
        /// <param name="имя_переменной">Описание аргумента</param>
        /// <returns>Описание вывода</returns>

        private static void Main( string[] args ) {
            // Описание программы
        }
    }
}
```

<br>


## Шаблон C# для .gitignore

```
### Языки программирования
# C#
[Bb][Ii][Nn]/
[Oo][Bb][Jj]/


### Среда разработки
# VS Code
.vscode/

# Microsoft Visual Studio
.vs/
```