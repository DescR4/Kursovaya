-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Янв 29 2025 г., 15:18
-- Версия сервера: 5.7.24
-- Версия PHP: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `db`
--

-- --------------------------------------------------------

--
-- Структура таблицы `numbers`
--

CREATE TABLE `numbers` (
  `id` int(11) UNSIGNED NOT NULL,
  `number` int(3) UNSIGNED NOT NULL,
  `description` text NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `numbers`
--

INSERT INTO `numbers` (`id`, `number`, `description`, `status`) VALUES
(1, 0, 'Уникальное сердце', 'доступен'),
(2, 101, 'Связь с пожарной службой', 'доступен'),
(3, 102, 'Связь с полицейским участком', 'доступен'),
(4, 100, 'Связь с президентом', 'доступен'),
(5, 103, 'Связь с больницей', 'доступен'),
(6, 104, 'Связь с ближайшей военной базой', 'доступен'),
(7, 105, 'Технический отдел', 'доступен'),
(8, 666, 'Запрещённый номер', 'занят');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `role` varchar(50) NOT NULL,
  `connected_to` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `pass`, `role`, `connected_to`) VALUES
(1, 'Кузьмин', '', 'admin', NULL),
(2, 'Спирьянов', '', 'admin', NULL),
(3, 'Попов', '100', 'Обычный', NULL),
(4, 'Григорьев', '101', 'Обычный', NULL),
(6, 'Борисов', '241', 'Обычный', ''),
(5, 'Ложкин', '102', 'Обычный', NULL),
(8, 'Горохов', '241', 'Обычный', ''),
(7, 'Самсонов', '200', 'Обычный', NULL);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `numbers`
--
ALTER TABLE `numbers`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`,`number`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `IDUSHNICK` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `numbers`
--
ALTER TABLE `numbers`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
