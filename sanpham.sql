-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2021 at 06:42 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sanpham`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `name`, `password`) VALUES
(1, 'admin5', '26A91342190D515231D7238B0C5438E1');

-- --------------------------------------------------------

--
-- Table structure for table `brand`
--

CREATE TABLE `brand` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `image` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`id`, `name`, `image`) VALUES
(1, 'DELL', 'DELL.png'),
(2, 'HP', 'HP.png'),
(3, 'APPLE', 'APPLE.png'),
(4, 'ASUS', 'ASUS.jpg'),
(5, 'MSI', 'MSI.png'),
(6, 'LENOVO', 'LENOVO.png'),
(7, 'GIGABYTE', 'GYGABYTE.jpg'),
(9, 'ACER', 'ACER.png');

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `id` int(11) NOT NULL,
  `id_users` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`id`, `id_users`, `id_product`, `amount`) VALUES
(18, 4, 9, 6);

-- --------------------------------------------------------

--
-- Table structure for table `coment`
--

CREATE TABLE `coment` (
  `id` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `content` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `coment`
--

INSERT INTO `coment` (`id`, `id_product`, `id_user`, `content`) VALUES
(2, 9, 4, 'hay qua'),
(3, 4, 6, 'tri cho haha'),
(4, 7, 4, 'hay');

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `id` int(11) NOT NULL,
  `image` varchar(50) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`id`, `image`, `name`) VALUES
(1, 'event1.jpg', 'sales'),
(3, 'event2.jpg', 'si?u sale');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `time` datetime NOT NULL DEFAULT current_timestamp(),
  `status` int(11) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `city` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(10) NOT NULL,
  `other_note` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `district` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`id`, `id_user`, `time`, `status`, `name`, `address`, `city`, `phone`, `other_note`, `district`) VALUES
(3, 4, '2021-01-01 00:00:00', 2, 'Nguyễn Văn A', '221,Hóc Môn, TPHM', 'AF', '01224356', 'vận chuyển cẩn thận', 'Nguyễn DU'),
(6, 4, '2021-11-09 08:35:18', 1, 'NguyệnThị C', '221,Hóc Môn, TPHM', 'AX', '0123456789', 'vận chuyển cẩn thận', 'Nguyễn DU'),
(12, 4, '2021-11-09 09:08:33', 0, 'Công Văn Kích', '221,Hóc Môn, TPHM', 'AX', '0123456789', 'vận chuyển cẩn thận', 'Nguyễn DU'),
(13, 6, '2021-11-10 09:47:36', 2, 'Té Văn Giếng', '221,Hóc Môn, TPHM', 'AF', '012345690', 'vận chuyển cẩn thận', 'Nguyễn DU');

-- --------------------------------------------------------

--
-- Table structure for table `order_product`
--

CREATE TABLE `order_product` (
  `id` int(11) NOT NULL,
  `id_order` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `id_users` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_product`
--

INSERT INTO `order_product` (`id`, `id_order`, `id_product`, `id_users`, `quantity`, `amount`) VALUES
(1, 3, 4, 4, 8, 8),
(2, 3, 7, 4, 1, 1),
(5, 3, 5, 4, 10, 10),
(6, 3, 5, 4, 10, 10),
(7, 3, 6, 4, 7, 7),
(8, 3, 6, 4, 7, 7),
(12, 6, 9, 4, 9, 9),
(13, 6, 5, 4, 1, 1),
(14, 6, 5, 4, 1, 1),
(18, 13, 9, 6, 16, 16),
(19, 13, 7, 6, 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `name` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `image` varchar(100) NOT NULL,
  `price` int(11) NOT NULL,
  `brand` int(11) NOT NULL,
  `short_desc` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `desc` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `view` int(11) NOT NULL,
  `sold` int(11) NOT NULL,
  `discount_price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `name`, `image`, `price`, `brand`, `short_desc`, `desc`, `view`, `sold`, `discount_price`) VALUES
(4, 'Laptop HP 15s-fq2602TU 4B6D3PA (Core i5-1135G7/ 8GB DDR4 2666MHz/ 256GB M.2 PCIe NVMe/ 15.6 HD/ Win11)', 'laptop2.jpg', 18000000, 2, 'Thiết kế mỏng nhẹ, đơn giản tiện dụng\r\nLaptop HP 15s-fq2602TU 4B6D3PA hướng đến sự đơn giản, tiện lợi nhất cho người dùng với vẻ ngoài thanh lịch và kiểu dáng mỏng nhẹ, vô cùng di động, dễ dàng để bạn mang đi học, đi làm và mang máy di chuyển trong văn phòng. Màu sắc xám bạc đẹp nhẹ nhàng, không bị lỗi thời mang đến vẻ đẹp từ sự đơn giản nhưng cũng rất thời thượng.\r\n\r\nMàn hình viền mỏng sắc nét\r\nHP 15s-fq2602TU 4B6D3PA có màn hình viền  mỏng tạo ra một thiết kế cực kỳ mỏng nhẹ, và tỷ lệ hiển thị hình ảnh trên khung máy lên đến 81%. Laptop HP này cho phép bạn xem nhiều hơn một cách chi tiết, qua đó giúp bạn làm việc hiệu quả hoặc giải trí tốt hơn cho một ngày năng động. Làm việc và giải trí theo cách tốt nhất hiện nay.\r\n\r\nThưởng thức hình ảnh và phim bom tấn với chất lượng hình ảnh và độ nét cao rất chi tiết trong tổng số 1 triệu điểm ảnh.', 'Thiết kế mỏng nhẹ, đơn giản tiện dụng\r\nLaptop HP 15s-fq2602TU 4B6D3PA hướng đến sự đơn giản, tiện lợi nhất cho người dùng với vẻ ngoài thanh lịch và kiểu dáng mỏng nhẹ, vô cùng di động, dễ dàng để bạn mang đi học, đi làm và mang máy di chuyển trong văn phòng. Màu sắc xám bạc đẹp nhẹ nhàng, không bị lỗi thời mang đến vẻ đẹp từ sự đơn giản nhưng cũng rất thời thượng.\r\n\r\nMàn hình viền mỏng sắc nét\r\nHP 15s-fq2602TU 4B6D3PA có màn hình viền  mỏng tạo ra một thiết kế cực kỳ mỏng nhẹ, và tỷ lệ hiển thị hình ảnh trên khung máy lên đến 81%. Laptop HP này cho phép bạn xem nhiều hơn một cách chi tiết, qua đó giúp bạn làm việc hiệu quả hoặc giải trí tốt hơn cho một ngày năng động. Làm việc và giải trí theo cách tốt nhất hiện nay.\r\n\r\nThưởng thức hình ảnh và phim bom tấn với chất lượng hình ảnh và độ nét cao rất chi tiết trong tổng số 1 triệu điểm ảnh.', 20, 8, 17500000),
(5, 'Laptop Dell Gaming G3 15 i7(AMD R3-3250U/ 8GB DDR4/ HDD 1Tb/ 14 FHD/ Win11 + Office2021)', 'laptop1.jpg', 10000000, 1, 'Laptop Dell G3 15 i7 (P89F002BWH) thuộc dòng laptop gaming của Dell có phong cách thiết kế hiện đại, cấu hình mạnh mẽ dựa trên bộ xử lý thế hệ 10 cùng card đồ họa rời NVIDIA GeForce GTX cho các trận game của bạn diễn ra mượt.', 'Laptop Dell G3 15 i7 (P89F002BWH) thuộc dòng laptop gaming của Dell có phong cách thiết kế hiện đại, cấu hình mạnh mẽ dựa trên bộ xử lý thế hệ 10 cùng card đồ họa rời NVIDIA GeForce GTX cho các trận game của bạn diễn ra mượt.', 27, 2, 29000000),
(6, 'Laptop Dell Vostro 3405 P132G002ABL (AMD R3-3250U/ 8GB DDR4/ HDD 1Tb/ 14 FHD/ Win11 + Office2021)', 'laptop3.jpg', 30000000, 1, 'Thiết kế chắc chắn\r\nLaptop Dell Vostro 3405 P132G002ABL được thiết kế với tone màu đen truyền thống, các cạnh xung quanh được thiết kế vát gọn lại sẽ tạo cảm giác thanh thoát hơn, máy có trọng lượng khá nhẹ, chỉ 1.6kg sẽ rất thuận tiện cho người dung trong việc di chuyển. \r\n\r\nHiệu năng đủ dùng\r\nDell Vostro 3405 sử dụng cpu AMD Ryzen (TM) R3 - 3250U  2 nhân 4 luồng, xung nhịp 2.6Ghz up to 3.5 Ghz kết hợp với VGA AMD A PU ; Ram 8GB DDR4 2400Mhz; ổ cứng  1TB 5400 rpm 2.5\" SATA HDD cho hiệu quả xử lý nhanh các tác vụ văn phòng và ứng dụng cơ bản phổ biến. \r\n\r\nBàn phím rộng rãi\r\nBàn phím của máy thiết kế theo kiểu chiclet với các phím rộng và cao hơn, khoảng cách giữa các phím rõ rang, hành trình phím sâu giúp cho việc gõ phím trở nên dễ dàng hơn. \r\n\r\nTouchpad rộng rãi, cho phản ứng nhanh và chính xác với các thao tác vuốt, cuộn, kéo.', 'Thiết kế chắc chắn\r\nLaptop Dell Vostro 3405 P132G002ABL được thiết kế với tone màu đen truyền thống, các cạnh xung quanh được thiết kế vát gọn lại sẽ tạo cảm giác thanh thoát hơn, máy có trọng lượng khá nhẹ, chỉ 1.6kg sẽ rất thuận tiện cho người dung trong việc di chuyển. \r\n\r\nHiệu năng đủ dùng\r\nDell Vostro 3405 sử dụng cpu AMD Ryzen (TM) R3 - 3250U  2 nhân 4 luồng, xung nhịp 2.6Ghz up to 3.5 Ghz kết hợp với VGA AMD A PU ; Ram 8GB DDR4 2400Mhz; ổ cứng  1TB 5400 rpm 2.5\" SATA HDD cho hiệu quả xử lý nhanh các tác vụ văn phòng và ứng dụng cơ bản phổ biến. \r\n\r\nBàn phím rộng rãi\r\nBàn phím của máy thiết kế theo kiểu chiclet với các phím rộng và cao hơn, khoảng cách giữa các phím rõ rang, hành trình phím sâu giúp cho việc gõ phím trở nên dễ dàng hơn. \r\n\r\nTouchpad rộng rãi, cho phản ứng nhanh và chính xác với các thao tác vuốt, cuộn, kéo.', 15, 0, 28999999),
(7, 'Laptop Dell Latitude 3520 70251590', 'laptop4.jpg', 55000000, 1, 'CPU: Intel Core i7-1165G7 (upto 4.70GHz, 12MB)\r\n \r\n\r\nRAM: 8GB(8GBx1) DDR4 3200MHz ( 2 Khe)\r\n \r\n\r\nỔ cứng: 256GB M.2 256GB PCIe NVMe\r\n \r\n\r\nVGA: Đồ họa Intel Iris Xe\r\n \r\n\r\nMàn hình: 15.6 inch FHD (1920 x 1080) WVA Anti-glare 60Hz\r\n \r\n\r\nPin: 3 Cell, 41Whr\r\n \r\n\r\nCân nặng: 1.79kg\r\n \r\n\r\nMàu sắc: Đen\r\n \r\n\r\n \r\n\r\nHệ điều hành: Fedora\r\nGiá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....', 'CPU: Intel Core i7-1165G7 (upto 4.70GHz, 12MB)\r\n \r\n\r\nRAM: 8GB(8GBx1) DDR4 3200MHz ( 2 Khe)\r\n \r\n\r\nỔ cứng: 256GB M.2 256GB PCIe NVMe\r\n \r\n\r\nVGA: Đồ họa Intel Iris Xe\r\n \r\n\r\nMàn hình: 15.6 inch FHD (1920 x 1080) WVA Anti-glare 60Hz\r\n \r\n\r\nPin: 3 Cell, 41Whr\r\n \r\n\r\nCân nặng: 1.79kg\r\n \r\n\r\nMàu sắc: Đen\r\n \r\n\r\n \r\n\r\nHệ điều hành: Fedora\r\nGiá sản phẩm trên Tiki đã bao gồm thuế theo luật hiện hành. Bên cạnh đó, tuỳ vào loại sản phẩm, hình thức và địa chỉ giao hàng mà có thể phát sinh thêm chi phí khác như phí vận chuyển, phụ phí hàng cồng kềnh, thuế nhập khẩu (đối với đơn hàng giao từ nước ngoài có giá trị trên 1 triệu đồng).....', 59, 1, 30000000),
(9, 'Laptop Dell Vostro 5515 K4Y9X1 (AMD R5-5500U/ 8GB DDR4/ 512GB SSD/ 15.6 FHD/ Win10 + Office) ', 'laptop5.jpg', 15000000, 1, 'Hiệu năng mạnh mẽ, xử lý nhanh chóng mọi tác vụ\r\nVới sức mạnh đến từ AMD Ryzen 5 5500U Processor, Laptop Dell Vostro 5515 K4Y9X1 sẽ dễ dàng giải quyết công việc trong chớp mắt bởi xung nhịp được boost lên tối đa 4.0 GHz. Nhờ đó, bạn có thể thực hiện từ các tác vụ văn phòng nhẹ nhàng cho tới các tác vụ nâng cao như Photoshop hay AI.\r\n\r\nRAM 8 GB cho khả năng đa nhiệm tốt, bạn hoàn toàn có thể mở cùng lúc nhiều ứng dụng mà không cần phải lo lắng máy bị chậm. Bạn có thể vừa làm việc với các tác vụ đồ họa vừa mở YouTube nghe nhạc, giúp giảm căng thẳng trong quá trình làm việc.\r\n\r\nỔ cứng SSD 512 GB cho tốc độ phản hồi nhanh chóng gần như ngay lập tức sau khi nhấp chuột giúp bạn làm việc hiệu quả hơn. Ngoài ra, nó còn đem lại cho bạn một không gian lưu trữ thoải mái, tiện lợi khi lưu trữ các tệp thông tin lớn quan trọng.\r\n\r\nThiết kế nhỏ gọn, hiện đại', 'Hiệu năng mạnh mẽ, xử lý nhanh chóng mọi tác vụ\r\nVới sức mạnh đến từ AMD Ryzen 5 5500U Processor, Laptop Dell Vostro 5515 K4Y9X1 sẽ dễ dàng giải quyết công việc trong chớp mắt bởi xung nhịp được boost lên tối đa 4.0 GHz. Nhờ đó, bạn có thể thực hiện từ các tác vụ văn phòng nhẹ nhàng cho tới các tác vụ nâng cao như Photoshop hay AI.\r\n\r\nRAM 8 GB cho khả năng đa nhiệm tốt, bạn hoàn toàn có thể mở cùng lúc nhiều ứng dụng mà không cần phải lo lắng máy bị chậm. Bạn có thể vừa làm việc với các tác vụ đồ họa vừa mở YouTube nghe nhạc, giúp giảm căng thẳng trong quá trình làm việc.\r\n\r\nỔ cứng SSD 512 GB cho tốc độ phản hồi nhanh chóng gần như ngay lập tức sau khi nhấp chuột giúp bạn làm việc hiệu quả hơn. Ngoài ra, nó còn đem lại cho bạn một không gian lưu trữ thoải mái, tiện lợi khi lưu trữ các tệp thông tin lớn quan trọng.', 49, 9, 10000000);

-- --------------------------------------------------------

--
-- Table structure for table `rate`
--

CREATE TABLE `rate` (
  `id` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `stars` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rate`
--

INSERT INTO `rate` (`id`, `id_product`, `id_user`, `stars`) VALUES
(1, 9, 4, 3),
(2, 4, 6, 3),
(3, 7, 4, 3);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`id`, `name`, `password`) VALUES
(1, 'demacia', '7780E06E0C046A50B535BB3AA8EE500A'),
(2, 'haohan1', '846DC81D1A02F2C47CEACA9DA71B460D'),
(3, 'thangtricho', 'FD15FC6AEE985CC4AE2B6CF63DABC743');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `phone_number` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `phone_number`) VALUES
(1, 'admin@gmail.com', '2EF73C15790350844824', '1234'),
(2, 'mann8u@gmail.com', '2EF73C15790350844824', '0123456789'),
(3, 'haohao@gmail.com', '2EF73C15790350844824', '012345'),
(4, 'admin5@gmail.com', '26A91342190D515231D7238B0C5438E1', '12345'),
(5, 'mann7u@gmail.com', '4D844E2E58E14A0B377B276065C86036', '123456789'),
(6, 'tricho@gmail.com', 'FD15FC6AEE985CC4AE2B6CF63DABC743', '0123456789'),
(7, 'esd1fghjk@gmail.com', 'B3C7683768A0E9EC87C2498711A77DE8', '0123456789'),
(8, 'esdfghjk@gmail.com', 'BE5D8631395F25E2CC5C887F003EC192', '0123456123');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_users` (`id_users`),
  ADD KEY `id_product` (`id_product`);

--
-- Indexes for table `coment`
--
ALTER TABLE `coment`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_product` (`id_product`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `order_product`
--
ALTER TABLE `order_product`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_order` (`id_order`),
  ADD KEY `id_product` (`id_product`),
  ADD KEY `id_users` (`id_users`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`),
  ADD KEY `brand` (`brand`);

--
-- Indexes for table `rate`
--
ALTER TABLE `rate`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_product` (`id_product`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `brand`
--
ALTER TABLE `brand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `coment`
--
ALTER TABLE `coment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `order_product`
--
ALTER TABLE `order_product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `rate`
--
ALTER TABLE `rate`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`id_users`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`id_product`) REFERENCES `product` (`id`);

--
-- Constraints for table `coment`
--
ALTER TABLE `coment`
  ADD CONSTRAINT `coment_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `coment_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

--
-- Constraints for table `order_product`
--
ALTER TABLE `order_product`
  ADD CONSTRAINT `order_product_ibfk_1` FOREIGN KEY (`id_order`) REFERENCES `order` (`id`),
  ADD CONSTRAINT `order_product_ibfk_2` FOREIGN KEY (`id_product`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `order_product_ibfk_3` FOREIGN KEY (`id_users`) REFERENCES `users` (`id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`brand`) REFERENCES `brand` (`id`);

--
-- Constraints for table `rate`
--
ALTER TABLE `rate`
  ADD CONSTRAINT `rate_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `rate_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `product` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
