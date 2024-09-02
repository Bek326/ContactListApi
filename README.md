ContactListApi

ContactListApi — это веб-API для управления списком контактов. Проект реализует CRUD операции для основной сущности "Контакт" и использует Swagger для генерации и отображения документации API.

Структура проекта
Проект разделен на несколько слоев:

API Layer: Обрабатывает входящие HTTP-запросы и возвращает ответы.
Persistence Layer: Работает с базой данных.
Business/Logic Layer: Содержит бизнес-логику приложения.
Domain/Core Layer: Определяет основные сущности и их свойства.
Требования
.NET 8.0 или выше
SQL Server (или другой поддерживаемый провайдер баз данных)
Swagger UI для отображения документации
Установка и запуск
1. Клонирование репозитория
Сначала клонируйте репозиторий:

Копировать код
git clone https://github.com/yourusername/ContactListApi.git
cd ContactListApi
2. Настройка базы данных
Создайте базу данных SQL Server и добавьте строку подключения в файл appsettings.json:

json
Копировать код
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;"
  }
}

3. Установка зависимостей
Установите все необходимые NuGet-пакеты:

Копировать код
dotnet restore

4. Создание миграций и обновление базы данных
Создайте начальную миграцию и примените её к базе данных:

Копировать код
dotnet ef migrations add InitialCreate --project ContactListApi.Persistence --startup-project ContactListApi.API
dotnet ef database update --project ContactListApi.Persistence --startup-project ContactListApi.API

5. Запуск приложения
Запустите приложение:

Копировать код
dotnet run --project ContactListApi.API
6. Доступ к Swagger UI
После запуска приложения вы можете получить доступ к Swagger UI по адресу:

arduino
Копировать код
https://localhost:5284/index.html
где {port} — это порт, на котором запущен ваш сервер. Swagger UI предоставит интерактивную документацию для вашего API.

Структура проекта
ContactListApi.API: Основной проект API.
Контроллеры и конфигурации API.
ContactListApi.Persistence: Слой доступа к данным.
Контекст базы данных и миграции.
ContactListApi.Services: Слой бизнес-логики.
Сервисы для обработки логики приложения.
ContactListApi.Domain: Слой домена.
Определения сущностей и их свойств.
Используемые технологии
ASP.NET Core: Фреймворк для создания веб-приложений.
Entity Framework Core: ORM для работы с базой данных.
Swagger: Инструмент для документирования и тестирования API.
SQL Server: Система управления базами данных.
Дополнительные команды
Сборка проекта:

Копировать код
dotnet build
Запуск тестов:

Копировать код
dotnet test
Очистка проекта:

Копировать код
dotnet clean

Политика поддержки
Если вы столкнулись с проблемами или у вас есть предложения по улучшению, пожалуйста, создайте issue в репозитории.

Лицензия
Этот проект лицензирован под MIT License. См. LICENSE для получения дополнительных сведений.