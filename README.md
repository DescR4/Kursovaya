# **Kursovaya - Мини-АТС**
Курсовая работа выданная в РГРТУ на 5 семестре обучения по ИБ. Суть проекта разработать приложение Мини-АТС. Было усложнено и добавлена БД MySQL.

**Итак, для работы с данной программой нам потребуется:**
1. **Microsoft Visual Studio 2022**
2. **Установленный MySQL**
3. **Среда для поддержания БД на ПК, я лично использовал MAMP - бесплатную версию**
4. **Установить архив + БД**

# 1. **Установка всех необходимых утилит для работы с данным приложением**
### 1. Microsoft Visual Studio
Переходим на официальный сайт Microsoft и находим Visual Studio. [Скачать Visual Studio](https://visualstudio.microsoft.com/ru/vs/community/)
### 2. MySQL
Установим правильную версию для MySQL, переходим на сайт MySQL (дельфинчик белой обводкой на синем фоном). Перейдя на сайт производителя находим Connector/NET. [MySQL Downloads](https://dev.mysql.com/downloads/connector/net/)
Запоминаем путь и переходим для проверки по этому путю, там пытаемся обнаружить файл MySQL.Data.dll. Если есть - всё правильно. Нету - переустанавливаем.
### 3. Среда для базы данных.
Устанавливаем любую среду для БД. Лично я использовал MAMP. [Официальный сайт](https://www.mamp.info/en/downloads/)  (Да, да, огромная зелёная кнопка - не скам)
При установке проверяем всё, что установиться. Версия PRO вам не пригодится.
### **4. Загрузка архива проекта**
- Перейдите в репозиторий на GitHub
- Нажмите **Code** → **Download ZIP**
- Распакуйте архив в удобное место на вашем ПК

## **#2 Подготовка рабочего окружения**
### **1. Visual Studio**
1. Запустите Visual Studio 2022
2. Перейдите в меню **Вид** и включите необходимые панели:
   - **Панель элементов**
   - **Обозреватель решений**
   - **Свойства**
3. В **Обозревателе решений** видим, что у **Зависимости** есть жёлтый знак ошибки - это значит, что он не видит зависимость для MySQL. Нажимаем по "Зависимости" правой кнопкой мыши и нажимаем на "Добавить ссылку на проект". В левой колонке находим "Обзор", переходим туда и видим внизу "Обзор..." нажимаем и в открывшемся окне находим файл MySQL.Data.dll (По стандарту: `C:\Program Files (x86)\MySQL\MySQL Connector NET 9.2`). Проверяем файл появился и есть ли у него галочка. Если есть, то нажимаем "ОК".
### **2. Настройка базы данных MySQL** 
Теперь открываем установленный нами MAMP или иную среду. Запускаем сервер. Разрешаем функции, который Брандмауэр заблокировал - Apache и MySQL (MySQL - работает только с интернетом). Теперь у вас есть кнопка "Open WebStart page" - нажимаем. Находим колону "MySQL" в этой колонке находим `MySQL can be administered with phpMyAdmin.` нажимаем на phpMyAdmin. Слева нажимаем на "Создать БД (Базу данных)" - имя для БД: `db`, кодировка: utf8_general_ci. Сверху находим: "Импорт" - нажимаем и "Выбрать файл" выбираем мой файл и больше ничего не трогаем в кнопках, нажимаем "Вперёд" и получаем БД, которую я заранее подготовил в архиве RAR для вас. Перейдите слева в часть users и тут добавляйте пользователей для работы (Сверху надпись вставить) - id не указывайте, они автоматически создаются. Если захотите добавить номер , которому звонить - нужно будет добавлять в `numbers` + в папки архива images и Sound.
### **3. Запуск проекта**
1. Теперь мы установили всё нам необходимого и можем нажать `Ctrl + F5`
2. Готово! 🎉

# 3 **Описание проекта**
Мини-АТС — это программное приложение, имитирующее работу автоматической телефонной станции с базой данных MySQL. Реализованные возможности:
Регистрация и управление пользователями
Добавление и редактирование телефонных номеров
Взаимодействие через клиент-серверную архитектуру
Интеграция с MySQL для хранения информации

Удачи в работе! 🚀
