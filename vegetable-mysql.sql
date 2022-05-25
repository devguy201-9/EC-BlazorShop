DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(255) NOT NULL,
  `email` varchar(255),
  `full_name` varchar(255) NOT NULL,
  `phone_number` varchar(255),
  `address` varchar(255),
  `cmnd` varchar(100),
  `password` varchar(255) NOT NULL,
  `avatar`varchar(255),
  `role_id` int NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(255) NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `products`;
CREATE TABLE `products` (
  `id` int NOT NULL AUTO_INCREMENT,
  `product_code` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text,
  `price` float NOT NULL,
  `quantity` int NOT NULL,
  `images` json NOT NULL,
  `category_id` int NOT NULL,
  `unit_id` int NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `categories`;
CREATE TABLE `categories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `description` text,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `product_ratings`;
CREATE TABLE `product_ratings` (
  `user_id` int NOT NULL,
  `product_id` int NOT NULL,
  `comment` text,
  `point` float DEFAULT '0',
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`,`product_id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `units`;
CREATE TABLE `units` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `desciption` text,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `carts`;
CREATE TABLE `carts` (
  `user_id` int NOT NULL,
  `product_id` int NOT NULL,
  `quantity` int NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`,`product_id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `note` text,
  `total_price` float NOT NULL,
  `state` enum('init','confirmed','processing','completed','cancelled','returned') NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `order_details`;
CREATE TABLE `order_details` (
  `order_id` int NOT NULL,
  `product_id` int NOT NULL,
  `price` float NOT NULL,
  `quantity` int NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`order_id`,`product_id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `distributors`;
CREATE TABLE `distributors` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phone_number` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `shipments`;
CREATE TABLE `shipments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `shipment_code` varchar(255) NOT NULL,
  `distributor_id` int NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

DROP TABLE IF EXISTS `shipment_details`;
CREATE TABLE `shipment_details` (
  `shipment_id` int NOT NULL,
  `product_id` int NOT NULL,
  `purchase_price` float NOT NULL,
  `price` float NOT NULL,
  `quantity_sold` int NOT NULL,
  `current_quantity` int NOT NULL,
  `quantity` int NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`shipment_id`,`product_id`)
) ENGINE=InnoDB;

ALTER TABLE `users` ADD FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`);
ALTER TABLE `products` ADD FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`);
ALTER TABLE `products` ADD FOREIGN KEY (`unit_id`) REFERENCES `units` (`id`);
ALTER TABLE `product_ratings` ADD FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);
ALTER TABLE `product_ratings` ADD FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);
ALTER TABLE `carts` ADD FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);
ALTER TABLE `carts` ADD FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);
ALTER TABLE `orders` ADD FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);
ALTER TABLE `order_details` ADD FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);
ALTER TABLE `order_details` ADD FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`);
ALTER TABLE `shipments` ADD FOREIGN KEY (`distributor_id`) REFERENCES `distributors` (`id`);
ALTER TABLE `shipment_details` ADD FOREIGN KEY (`shipment_id`) REFERENCES `shipments` (`id`);
ALTER TABLE `shipment_details` ADD FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);
