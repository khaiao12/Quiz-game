-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 04, 2024 at 03:45 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `quizgame`
--

-- --------------------------------------------------------

--
-- Table structure for table `questions`
--

CREATE TABLE `questions` (
  `QuestionID` int(11) NOT NULL,
  `QuizID` int(11) DEFAULT NULL,
  `QuestionText` varchar(255) NOT NULL,
  `AnswerA` varchar(100) NOT NULL,
  `AnswerB` varchar(100) NOT NULL,
  `AnswerC` varchar(100) NOT NULL,
  `AnswerD` varchar(100) NOT NULL,
  `CorrectAnswer` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `questions`
--

INSERT INTO `questions` (`QuestionID`, `QuizID`, `QuestionText`, `AnswerA`, `AnswerB`, `AnswerC`, `AnswerD`, `CorrectAnswer`) VALUES
(1, 1, 'Dog nghĩa là gì?', 'Mèo', 'Chó', 'Ngựa', 'Vịt', 'B'),
(2, 1, 'Cat nghĩa là gì?', 'Cá', 'Gà', 'Chó', 'Mèo', 'D'),
(3, 1, 'Elephant nghĩa là gì?', 'Voi', 'Khỉ', 'Hươu', 'Cú', 'A'),
(4, 1, 'Tiger nghĩa là gì?', 'Sư tử', 'Hổ', 'Gấu', 'Cá mập', 'B'),
(5, 1, 'Rabbit nghĩa là gì?', 'Thỏ', 'Chó', 'Mèo', 'Ngựa', 'A'),
(6, 2, 'Apple nghĩa là gì?', 'Cam', 'Quýt', 'Táo', 'Chuối', 'C'),
(7, 2, 'Bread nghĩa là gì?', 'Bánh mì', 'Bánh ngọt', 'Bánh quy', 'Bánh ga-tô', 'A'),
(8, 2, 'Chicken nghĩa là gì?', 'Gà', 'Vịt', 'Heo', 'Bò', 'A'),
(9, 2, 'Fish nghĩa là gì?', 'Cá', 'Mực', 'Tôm', 'Cua', 'A'),
(10, 2, 'Rice nghĩa là gì?', 'Bánh mì', 'Cơm', 'Mì', 'Phở', 'B'),
(11, 3, 'Rain nghĩa là gì?', 'Mưa', 'Nắng', 'Gió', 'Bão', 'A'),
(12, 3, 'Sun nghĩa là gì?', 'Mặt trời', 'Mặt trăng', 'Sao', 'Hành tinh', 'A'),
(13, 3, 'Cloud nghĩa là gì?', 'Mây', 'Khói', 'Sương', 'Gió', 'A'),
(14, 3, 'Snow nghĩa là gì?', 'Tuyết', 'Mưa', 'Gió', 'Bão', 'A'),
(15, 3, 'Wind nghĩa là gì?', 'Gió', 'Nắng', 'Mưa', 'Sương', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `quizzes`
--

CREATE TABLE `quizzes` (
  `QuizID` int(11) NOT NULL,
  `QuizName` varchar(255) NOT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `quizzes`
--

INSERT INTO `quizzes` (`QuizID`, `QuizName`, `CreatedAt`) VALUES
(1, 'Quiz Động Vật', '2024-11-02 08:55:04'),
(2, 'Quiz Thực Phẩm', '2024-11-02 08:55:04'),
(3, 'Quiz Thời Tiết', '2024-11-02 08:55:04');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `CreatedAt`) VALUES
(1, 'Demo', '4321', '2024-11-02 09:06:26'),
(2, 'Demo1', '1212', '2024-11-02 09:06:26'),
(3, 'Demo2', '1111', '2024-11-02 09:06:26'),
(4, 'Demo3', '1234', '2024-11-02 09:06:26'),
(5, 'Phong', '4321', '2024-11-02 09:07:59');

-- --------------------------------------------------------

--
-- Table structure for table `user_quiz_records`
--

CREATE TABLE `user_quiz_records` (
  `RecordID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `QuizID` int(11) DEFAULT NULL,
  `AttemptDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `Score` int(11) DEFAULT NULL,
  `TotalAttempts` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `questions`
--
ALTER TABLE `questions`
  ADD PRIMARY KEY (`QuestionID`),
  ADD KEY `QuizID` (`QuizID`);

--
-- Indexes for table `quizzes`
--
ALTER TABLE `quizzes`
  ADD PRIMARY KEY (`QuizID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `user_quiz_records`
--
ALTER TABLE `user_quiz_records`
  ADD PRIMARY KEY (`RecordID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `QuizID` (`QuizID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `questions`
--
ALTER TABLE `questions`
  MODIFY `QuestionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `quizzes`
--
ALTER TABLE `quizzes`
  MODIFY `QuizID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user_quiz_records`
--
ALTER TABLE `user_quiz_records`
  MODIFY `RecordID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `questions`
--
ALTER TABLE `questions`
  ADD CONSTRAINT `questions_ibfk_1` FOREIGN KEY (`QuizID`) REFERENCES `quizzes` (`QuizID`);

--
-- Constraints for table `user_quiz_records`
--
ALTER TABLE `user_quiz_records`
  ADD CONSTRAINT `user_quiz_records_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `user_quiz_records_ibfk_2` FOREIGN KEY (`QuizID`) REFERENCES `quizzes` (`QuizID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
